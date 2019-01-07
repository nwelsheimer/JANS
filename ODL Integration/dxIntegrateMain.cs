using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NBSio.etc.sp;
using NBSio.etc.dbobj;

namespace ODL_Integration
{
  public partial class dxIntegrateMain : DevExpress.XtraEditors.XtraForm
  {
    logOrdSP orderSP = new logOrdSP();

    public dxIntegrateMain()
    {
      InitializeComponent();
    }

    private void dxIntegrateMain_Load(object sender, EventArgs e)
    {
      grdOrderSelect.DataSource = orderSP.ViewAvailableOrders();
      gvOrderSelect.BestFitColumns();

      txtNextLoad.Text = orderSP.GetNextLoadNum();
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      //Get the selected order numbers
      string orderIds = "";
      foreach (int i in gvOrderSelect.GetSelectedRows())
      {
        orderIds += gvOrderSelect.GetRowCellValue(i, "orderId") + ",";
      }

      //todo Spreadsheet has to be built here
      //get file name to save the spreadsheet
      string filename = NBSio.xl4k.getFilePath(1, DateTime.Now.ToString("MM-dd-yyyy"));

      DataSet odlFile = new DataSet();
      //blank stoporder table
      DataTable stopOrder = new DataTable();
      stopOrder.TableName = "Stop-Order";
      stopOrder.Columns.Add("vehicle-id");
      stopOrder.Columns.Add("id");
      stopOrder.Columns.Add("stop-id");
      stopOrder.Columns.Add("id1");
      odlFile.Tables.Add(stopOrder);

      //export orders to the stops table
      DataTable stops = orderSP.ExportStopDetails(orderIds);
      stops.TableName = "Stops";
      odlFile.Tables.Add(stops);

      //vehicle config export
      DataTable vehicleTypes = orderSP.ExportFleetDetails();
      vehicleTypes.TableName = "VehicleTypes";
      odlFile.Tables.Add(vehicleTypes);

      if (NBSio.xl4k.basicExcelExport(odlFile, filename))
        MessageBox.Show("Export Complete");
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      string filename = NBSio.xl4k.getFilePath(2);

      DataTable dt = NBSio.xl4k.basicExcelImport(filename, "Exported-Stop-Details", true);
      if (dt.Rows.Count>0)
      {
        string orderIds = "";
        foreach (DataRow dr in dt.Rows)
        {
          orderIds += dr["stop-id"].ToString() + "|" + dr["travel-km"].ToString() + "|" + dr["stop-number"].ToString() + "|" + dr["vehicle-id"].ToString() + ",";
        }

        MessageBox.Show(orderSP.ImportStopDetail(orderIds));
      }
    }
  }
}