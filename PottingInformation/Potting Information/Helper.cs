﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using General;

namespace Potting_Information
{
    class Helper
    {
        public static string Zebra_105SL_3x3_PottingWorkOrder(DataRow rd, string[] Locations)
        {
            string desc1 = rd["Description"].ToString();
            string PrintCommand = @"
                ^XA
                ^FO40,20^GB570,60,2^FS
                ^FO90,35^ADN,36,24^FDPotting Work Order^FS"+

                "^FO40,100^ADN,36,10^FDTrans Wk:^FS"+
                "^FO180,100^ADN,36,10^FD" + rd["TransWeek"] + "^FS" +
                "^FO290,100^ADN,36,10^FDRdy Wk:^FS"+
                "^FO430,100^ADN,36,10^FD" + rd["Ready"] + "^FS" +
                "^FO40,140^ADN,36,10^FDLot ID:^FS"+
                "^FO130,140^ADN,36,10^FD" + rd["LotID"] + "^FS" +
                "^FO290,140^ADN,36,10^FDCalc Rdy Wk:^FS"+
                "^FO500,140^ADN,36,10^FD" + rd["CalculatedReady"] + "^FS" +

                "^FO40,180^ADN,28,12^FB550,2,,^FD" + desc1 + "^FS" +

                "^FO40,245^ADN,28,12^FD" + rd["Size"] + "^FS" +

                "^FO40,280^ADN,20,12^FDPer Pot^FS"+
                "^FO40,300^GB81,0^FS"+
                "^FO45,310^ADN,28,16^FD" + rd["QtyPerPot"] + "^FS" +

                "^FO140,280^ADN,20,12^FDPot Space^FS"+
                "^FO140,300^GB110,0^FS"+
                "^FO160,310^ADN,28,16^FD" + rd["SpaceFactor"] + "^FS" +

                "^FO290,280^ADN,20,12^FDFlats^FS"+
                "^FO290,300^GB55,0^FS"+
                "^FO295,310^ADN,28,16^FD" + rd["FlatsRemaining"] + "^FS" +

                "^FO420,280^ADN,26,12^FDQuantity^FS"+
                "^FO420,300^GB120,0^FS"+
                "^FO440,320^ADN,36,16^FD" + rd["UnitsRemaining"] + "^FS" +

                "^FO40,355^GB570,142^FS"+
                "^FO50,365^ADN,28,12^FD" + rd["FromSize"] + "^FS" +
                "^FO60,420^ADN,24,16^FD" + Locations[0] + "^FS"+
                "^FO60,440^ADN,24,16^FD" + Locations[1] + "^FS" +
                "^FO60,460^ADN,24,16^FD" + Locations[2] + "^FS" +
                "^FO60,480^ADN,24,16^FD" + Locations[3] + "^FS" +

                "^FO60,500^BY2^B3N,N,80,Y,N^FD" + rd["LotID"] + "^FS" +
                "^XZ";

            return PrintCommand;
        }

        //bama label 3.5x2.5 for Zebra EPL
        public static string Zebra_2844_35x25_PottingWorkOrder(DataRow rd, string[] Locations)
        {
            string desc1 = rd["Description"].ToString();
            string PrintCommand = "\r\n" +
                "N\r\n" +
                "LO640,20,5,65\r\n" +
                "LO70,20,575,5\r\n" +
                "LO70,20,5,65\r\n" +
                "LO70,85,575,5\r\n" +
                "A110,35,0,3,2,2,N,\"Potting Work Order\"\r\n" +

                "A70,100,0,3,1,1,N,\"Trans Wk:\"\r\n" +
                "A210,100,0,3,1,1,N,\"" + rd["TransWeek"] + "\"\r\n" +
                "A320,100,0,3,1,1,N,\"Rdy Wk:\"\r\n" +
                "A460,100,0,3,1,1,N,\"" + rd["Ready"] + "\"\r\n" +
                "A70,120,0,3,1,1,N,\"Lot ID:\"\r\n" +
                "A160,120,0,3,1,1,N,\"" + rd["LotID"] + "\"\r\n" +
                "A320,120,0,3,1,1,N,\"Calc Rdy Wk:\"\r\n" +
                "A530,120,0,3,1,1,N,\"" + rd["CalculatedReady"] + "\"\r\n" +

                "A70,150,0,4,1,2,N,\"" + desc1 + "\"\r\n" +

                "A70,200,0,4,1,2,N,\"" + rd["Size"] + "\"\r\n" +

                "A40,250,0,3,1,1,N,\"Per Pot:\"\r\n" +
                "A155,250,0,4,1,1,N,\"" + rd["QtyPerPot"] + "\"\r\n" +

                "A180,250,0,3,1,1,N,\"Spacing:\"\r\n" +
                "A295,250,0,4,1,1,N,\"" + rd["SpaceFactor"] + "\"\r\n" +

                "A350,250,0,3,1,1,N,\"Flats:\"\r\n" +
                "A430,250,0,4,1,1,N,\"" + rd["FlatsRemaining"] + "\"\r\n" +

                "A495,250,0,3,1,1,N,\"Qty:\"\r\n" +
                "A555,250,0,4,1,1,N,\"" + rd["UnitsRemaining"] + "\"\r\n" +

                "LO640,280,5,100\r\n" +
                "LO70,280,575,5\r\n" +
                "LO70,280,5,100\r\n" +
                "LO70,380,575,5\r\n" +
                "A80,290,0,3,1,1,N,\"" + rd["FromSize"] + "\"\r\n" +
                //"A400,290,0,3,1,1,N,\"" + Locations[0] + "\"\r\n" +
                //"A400,313,0,3,1,1,N,\"" + Locations[1] + "\"\r\n" +
                //"A400,336,0,3,1,1,N,\"" + Locations[2] + "\"\r\n" +
                //"A400,360,0,3,1,1,N,\"" + Locations[3] + "\"\r\n" +
                "A45,400,0,3,2,3,N,\"Vendor:______________\"\r\n" +
                //"B60,400,0,3,3,7,70,B,\"" + rd["LotID"] + "\"\r\n" +
                "P1\r\n";

            return PrintCommand;
        }

        public static string Zebra_105SL_3x3_PottingFieldLabel(DataRow rd, int PrintQty)
        {
            string desc1 = rd["Description"].ToString();
            string productid;

            productid = rd["ToProductID"].ToString().Substring(0, rd["ToProductID"].ToString().Length - 5);

            string PrintCommand = @"
                    ^XA

                    ^FO60,20^A0N,130,80^FB550,1,0,C^FD"+productid+"^FS"+
                    "^FO15,120^ADN,54,40^FD...........................................^FS"+

                    "^FO40,180^A0N,36,50^FB550,4,,^FD" + desc1 + "^FS" +

                    "^FO40,300^A0N,36,36^FD" + rd["Size"] + "^FS" +
                    "^FO15,310^ADN,54,40^FD...........................................^FS"+

                    "^FO40,365^A0N,38,38^FDLot ID:" + rd["LotID"] + "^FS" +
                    "^FO40,435^A0N,38,38^FDDate:____/____/_____^FS"+
                    "^FO40,500^A0N,38,38^FDLocation:___________^FS"+

                    "^FO450,365^A0N,42,42^FDReady^FS"+
                    "^FO460,405^A0N,42,42^FD" + rd["Ready"] + "^FS" +
                    "^FO450,470^A0N,28,28^FDCalc Ready^FS"+
                    "^FO480,495^A0N,28,28^FD" + rd["CalculatedReady"] + "^FS" +

                    "^FO40,560^A0N,38,38^FDPer Pot:"+rd["QtyPerPot"]+"^FS"+
                    "^FO200,560^A0N,38,38^FDSpace:" + rd["SpaceFactor"] + "^FS" +
                    //07142015 (NDW) - Removed total quantity per Steve
                    //"^FO400,560^A0N,38,38^FDQty:" + rd["UnitsPlanned"] + "^FS" +
                    "^PQ"+PrintQty+
                    "^XZ";
            return PrintCommand;
        }

        public static string Zebra_2844_35x25_PottingFieldLabel(DataRow rd, int PrintQty)
        {
            string desc1 = rd["Description"].ToString();
            desc1 = desc1.Substring(0, 21);
            int breakpoint = desc1.LastIndexOf(' ');
            desc1 = desc1.Substring(0, breakpoint);

            string desc2 = rd["Description"].ToString();
            desc2 = desc2.Substring(breakpoint+1);
            string productid;

            productid = rd["ToProductID"].ToString().Substring(0, rd["ToProductID"].ToString().Length - 5);

            string PrintCommand = "\r\n" +
                    "N\r\n" +

                    "A210,5,0,2,2,1,N,\"" + productid + "\"\r\n" +
                    "A40,30,0,4,2,2,N,\"" + desc1 + "\"\r\n" +
                    "A40,90,0,4,2,2,N,\"" + desc2 + "\"\r\n" +
                    "A40,145,0,4,1,2,N,\"" + rd["Size"] + "\"\r\n" +
                    "A50,190,0,3,2,2,N,\"--------------------\"\r\n" +

                    "A45,220,0,1,2,2,N,\"Lot ID: " + rd["LotID"] + "\"\r\n" +
                    "A420,220,0,1,2,2,N,\"Per Pot: " + rd["QtyPerPot"] + "\"\r\n" +

                    "A45,265,0,3,2,3,N,\"Date:____/____/_____\"\r\n" +
                    "A45,360,0,3,2,3,N,\"Location:___________\"\r\n" +

                    //"A15,380,0,3,2,3,N,\"Ready:" + rd["Ready"] + "\"\r\n" +
                    //"A345,380,0,3,2,3,N,\"Space:" + rd["SpaceFactor"] + "\"\r\n" +

                    "A45,450,0,1,2,2,N,\"Calc Ready: " + rd["CalculatedReady"] + "\"\r\n" +

                    "P" + PrintQty + "\r\n\r\n";
            return PrintCommand;
        }


        public static void Test_Print(string PrinterName, string Command)
        {
            string PrintCommand = @"
                   ^XA
                ^FO90,35^ADN,336,124^FD$$$^FS
                    ^XZ";
            if (Command != "")
            {
                PrintCommand = Command;
            }
            RawPrinterHelper.SendStringToPrinter(PrinterName, PrintCommand);
        }

        public static DataSet PottingDetailData(StringBuilder lotids)
        {
            string PottingDetailSQL;

            PottingDetailSQL = "usp_PI_SelectPottingDetail @lotIDs='" + lotids.ToString() + "'";

            return Global.GetData(PottingDetailSQL);
        }
    }
}
