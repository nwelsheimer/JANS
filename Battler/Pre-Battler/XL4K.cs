﻿using System;
using System.IO;
using System.Xml;
using OfficeOpenXml;
using System.Data;
using System.Drawing;
using OfficeOpenXml.Style;
using System.Windows.Forms;
using General;

namespace Pre_Battler
{
    class xl4k
    {
        /// xl4k - A more robust less stable piece of shit - NDW 3/2/2017
        /// 
        /// Rewrite of the old Joe method of using HTML tags create a spreadsheet. This one isn't very modular, at
        /// least not yet. The ep plus dll lets us write xml direct to an xlsx file, which gives tons of flexibility to creating
        /// dynamic excel files.
        /// TODO
        /// Someone needs to come along and figure out a way to design a spreadsheet template and store in the database, then pull
        /// the template a run time, feed data in to it, and generate output.

        public static string getFilePath(int method, string fileName = "")
        {
            /// Simple function for displaying open or save dialog.

            if (method == 1)
            {
                //Method 1, display save fialog
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.FileName = fileName == "" ? "untitled.xlsx" : fileName + ".xlsx"; //if no filename specified use default
                fileDialog.Filter = "Excel (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return fileDialog.FileName;
            }
            else
            {
                //Method 2, display the open file dialog
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Excel (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                fileDialog.RestoreDirectory = true;
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return fileDialog.FileName;
            }
            return "";
        }

        public static bool basicExcelExport(DataTable exportSource, string fileName)
        {
            /// Basic export that will take the results of a query and dump it back as an unformatted xlsx file
            const int startRow = 1;

            if (fileName != "")
            {
                try
                {
                    //more robust, now just relies on a datatable to be handed back and forth
                    //DataTable basicExport = exportSource; 

                    //Delete the old file if it exists
                    if (File.Exists(fileName)) File.Delete(fileName);
                    FileInfo newFile = new FileInfo(fileName);

                    //Some global stuff
                    int totalColumns = exportSource.Columns.Count;
                    Char lastColumn = Global.LetterToNum(totalColumns);

                    // Build the workbook
                    using (ExcelPackage xlPackage = new ExcelPackage(newFile))
                    {
                        // get handle to the existing worksheet
                        ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add("Export");
                        int row = startRow;

                        //output column headings
                        for (int i = 1; i <= totalColumns; i++)
                        {
                            worksheet.Cells[Global.LetterToNum(i) + row.ToString()].Value = exportSource.Columns[i - 1].ColumnName;
                        }
                        row++;

                        // get the data and fill onwards
                        foreach (DataRow dr in exportSource.Rows)
                        {
                            int col = 1;
                            // our query has the columns in the right order, so simply
                            // iterate through the columns
                            for (int i = 0; i < totalColumns; i++)
                            {
                                // do not bother filling cell with blank data (also useful if we have a formula in a cell)
                                worksheet.Cells[row, i + 1].Value = dr[i];
                                col++;
                            }
                            row++;
                        }
                        // save the new spreadsheet
                        xlPackage.Save();
                    }

                    return true;
                }
                catch (Exception x) //Somehting went wrong
                {
                    MessageBox.Show("There was a problem processing the export: " + x);
                    return false;
                }
            }
            return false;
        }

        public static DataTable basicExcelImport(string path, string tabName="", bool hasHeader = true)
        {
            using (var pck = new ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                {
                    pck.Load(stream);
                }

                var ws = pck.Workbook.Worksheets[1];

                DataTable tbl = new DataTable();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
                return tbl;
            }
        }

        public static string GenerateExport(int sessionId, string fileName = "", string fullPath = "")
        {
            const int startRow = 5;

            if (fullPath != "")
            {
                // lets connect to the server for some data first
                DataTable export = new DataTable();
                export = Global.GetData("usp_PB_ExcelExportSummarySKU @sessionId=" + sessionId).Tables[0];

                //Delete the old file if we are overwriting
                string file = fullPath;
                if (File.Exists(file)) File.Delete(file);
                FileInfo newFile = new FileInfo(file);

                //Don't always know how many regions there will be
                int totalColumns = export.Columns.Count;
                
                string lastColumn = totalColumns + 1 <= 26 ? Global.LetterToNum(totalColumns+1).ToString() :
                    "A"+Global.LetterToNum(totalColumns + 1-26).ToString();

                // ok, we can run the real code now
                using (ExcelPackage xlPackage = new ExcelPackage(newFile))
                {
                    // get handle to the existing worksheet
                    ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add("Summary by SKU");
                    ExcelWorksheet storeDetail = xlPackage.Workbook.Worksheets.Add("Store Detail");
                    var namedStyle = xlPackage.Workbook.Styles.CreateNamedStyle("HyperLink");   //This one is language dependent
                    namedStyle.Style.Font.UnderLine = true;
                    namedStyle.Style.Font.Color.SetColor(Color.Blue);

                    //First worksheet, should have named this better... TAB1
                    if (worksheet != null)
                    {
                        int row = startRow;
                        //Create Headers and format them 
                        worksheet.Cells["A1"].Value = "Summary by SKU Report";
                        using (ExcelRange r = worksheet.Cells["A1:"+lastColumn+"1"])
                        {
                            r.Merge = true;
                            r.Style.Font.SetFromFont(new Font("Britannic Bold", 22, FontStyle.Italic));
                            r.Style.Font.Color.SetColor(Color.White);
                            r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                            r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(23, 55, 93));
                        }
                        worksheet.Cells["A2"].Value = "Session: " + fileName;
                        using (ExcelRange r = worksheet.Cells["A2:"+lastColumn+"2"])
                        {
                            r.Merge = true;
                            r.Style.Font.SetFromFont(new Font("Britannic Bold", 18, FontStyle.Italic));
                            r.Style.Font.Color.SetColor(Color.Black);
                            r.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                            r.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                        }

                        worksheet.Cells["A4"].Value = "Site";
                        worksheet.Cells["B4"].Value = "SKU Desc";
                        worksheet.Cells["C4"].Value = "SKU Size";
                        worksheet.Cells["D4"].Value = "SKU Number";
                        string cell = "";
                        for (int i=5; i<=totalColumns; i++)
                        {
                            cell = i <= 26 ? Global.LetterToNum(i).ToString() : "A" + Global.LetterToNum(i-26).ToString();
                            worksheet.Cells[cell + "4"].Value = export.Columns[i-1].ColumnName;
                        }
                        cell = totalColumns + 1 <= 26 ? Global.LetterToNum(totalColumns + 1).ToString() :
                                "A" + Global.LetterToNum(totalColumns + 1 - 26).ToString();
                        worksheet.Cells[cell+"4"].Value = "Total";
                        worksheet.Cells["A4:" + lastColumn + "4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A4:" + lastColumn + "4"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                        worksheet.Cells["A4:" + lastColumn + "4"].Style.Font.Bold = true;


                        // get the data and fill rows 5 onwards
                        foreach (DataRow dr in export.Rows)
                        {
                            int col = 1;
                            // our query has the columns in the right order, so simply
                            // iterate through the columns
                            for (int i = 0; i < totalColumns; i++)
                            {
                                // do not bother filling cell with blank data (also useful if we have a formula in a cell)
                                worksheet.Cells[row, i+1].Value = dr[i];
                                col++;
                            }
                            row++;
                        }
                        
                        worksheet.Cells[startRow, 3, row - 1, totalColumns].Style.Numberformat.Format = "#,##0";
                        worksheet.Cells[startRow, totalColumns+1, row - 1, totalColumns+1].Style.Numberformat.Format = "#,##0";

                        worksheet.Cells[startRow, totalColumns + 1, row - 1, totalColumns + 1].FormulaR1C1 = "=SUM(RC["+(2-totalColumns)+"]:RC[-1])";

                        //Set column width
                        worksheet.Column(2).Width = 48;
                        worksheet.Column(3).Width = 15;
                        worksheet.Column(4).Width = 15;

                        // lets set the header text 
                        worksheet.HeaderFooter.OddHeader.CenteredText = fileName+ " Pre-battle report";
                        // add the page number to the footer plus the total number of pages
                        worksheet.HeaderFooter.OddFooter.RightAlignedText =
                            string.Format("Page {0} of {1}", ExcelHeaderFooter.PageNumber, ExcelHeaderFooter.NumberOfPages);
                        // add the sheet name to the footer
                        worksheet.HeaderFooter.OddFooter.CenteredText = ExcelHeaderFooter.SheetName;
                        // add the file path to the footer
                        worksheet.HeaderFooter.OddFooter.LeftAlignedText = ExcelHeaderFooter.FilePath + ExcelHeaderFooter.FileName;
                    }
                    //Second, create detail tab. Let the shoehorning begin TAB2
                    if (storeDetail != null)
                    {
                        //flush the table, reload
                        export = new DataTable();
                        string query = "usp_PB_ExcelExportDetail @sessionId=" + sessionId;
                        export = Global.GetData(query).Tables[0];

                        //reset globals
                        totalColumns = export.Columns.Count;
                        lastColumn = totalColumns + 1 <= 26 ? Global.LetterToNum(totalColumns + 1).ToString() :
                            "A" + Global.LetterToNum(totalColumns + 1 - 26).ToString();
                        int row = startRow;

                        //Create Headers and format them 
                        storeDetail.Cells["A1"].Value = "Detail by Store Report";
                        using (ExcelRange r = storeDetail.Cells["A1:" + lastColumn + "1"])
                        {
                            r.Merge = true;
                            r.Style.Font.SetFromFont(new Font("Britannic Bold", 22, FontStyle.Italic));
                            r.Style.Font.Color.SetColor(Color.White);
                            r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                            r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(23, 55, 93));
                        }
                        storeDetail.Cells["A2"].Value = "Session: " + fileName;
                        using (ExcelRange r = storeDetail.Cells["A2:" + lastColumn + "2"])
                        {
                            r.Merge = true;
                            r.Style.Font.SetFromFont(new Font("Britannic Bold", 18, FontStyle.Italic));
                            r.Style.Font.Color.SetColor(Color.Black);
                            r.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                            r.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            r.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                        }
                        
                        for (int i = 1; i <= totalColumns; i++)
                        {
                            storeDetail.Cells[Global.LetterToNum(i) + "4"].Value = export.Columns[i - 1].ColumnName;
                        }
                        storeDetail.Cells["A4:" + lastColumn + "4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        storeDetail.Cells["A4:" + lastColumn + "4"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(184, 204, 228));
                        storeDetail.Cells["A4:" + lastColumn + "4"].Style.Font.Bold = true;


                        // get the data and fill rows 5 onwards
                        foreach (DataRow dr in export.Rows)
                        {
                            int col = 1;
                            // our query has the columns in the right order, so simply
                            // iterate through the columns
                            for (int i = 0; i < totalColumns; i++)
                            {
                                // do not bother filling cell with blank data (also useful if we have a formula in a cell)
                                storeDetail.Cells[row, i + 1].Value = dr[i];
                                col++;
                            }
                            row++;
                        }

                        storeDetail.Cells[startRow, 7, row - 1, totalColumns].Style.Numberformat.Format = "#,##0";
                        storeDetail.Cells[startRow, 8, row - 1, 8].Style.Numberformat.Format = "#,##0.0";

                        //Set column width
                        storeDetail.Column(1).Width = 20;
                        storeDetail.Column(2).Width = 12;
                        storeDetail.Column(3).Width = 26;

                        // lets set the header text 
                        storeDetail.HeaderFooter.OddHeader.CenteredText = fileName + " Pre-battle report";
                        // add the page number to the footer plus the total number of pages
                        storeDetail.HeaderFooter.OddFooter.RightAlignedText =
                            string.Format("Page {0} of {1}", ExcelHeaderFooter.PageNumber, ExcelHeaderFooter.NumberOfPages);
                        // add the sheet name to the footer
                        storeDetail.HeaderFooter.OddFooter.CenteredText = ExcelHeaderFooter.SheetName;
                        // add the file path to the footer
                        storeDetail.HeaderFooter.OddFooter.LeftAlignedText = ExcelHeaderFooter.FilePath + ExcelHeaderFooter.FileName;
                    }
                    //Third, if the shoe don't fit, get a bigger hammer TAB3
                    // set some core property values
                    xlPackage.Workbook.Properties.Title = fileName;
                    xlPackage.Workbook.Properties.Subject = fileName + " Pre-battle report";
                    xlPackage.Workbook.Properties.Keywords = fileName + " Pre-battle report";
                    xlPackage.Workbook.Properties.Category = "ExcelPackage";
                    xlPackage.Workbook.Properties.Comments = "Standard output from pre-battler";

                    // save the new spreadsheet
                    xlPackage.Save();
                }
            
                return newFile.FullName;
            } else
            { return "failed"; }
        }
    }
}
