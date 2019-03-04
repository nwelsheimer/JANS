using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Nursery_Production_Software.sysForms
{
  public partial class frmRFIDRead : Form
  {
    XmlDocument readerDoc = new XmlDocument();
    CookieContainer cookie = new CookieContainer();
    HttpWebRequest readerRequest;
    HttpWebResponse readerResponse;
    
    public frmRFIDRead()
    {
      InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      if (timer1.Enabled)
      {
        timer1.Enabled = false;
        txtTimerInt.Enabled = true;
        txtURL.Enabled = true;
        btnStart.Text = "Start Timer";
        lblOutput.Text = "Not running...";
      } else
      {
        timer1.Interval = Convert.ToInt32(txtTimerInt.Text)*1000;
        timer1.Enabled = true;
        txtTimerInt.Enabled = false;
        txtURL.Enabled = false;
        btnStart.Text = "Stop Timer";
        lblOutput.Text = "Running...";
        queryReader(true);
      }
    }

    private void queryReader(bool newSession)
    {
      readerDoc.RemoveAll();
      string url = "";
      string txtout = "";

      if (newSession)
        url = txtURL.Text;
      else
        url = txtURL2.Text;

      readerRequest = (HttpWebRequest)WebRequest.Create(url);
      readerRequest.CookieContainer = cookie;
      readerResponse = (HttpWebResponse)readerRequest.GetResponse();

      Stream datastream = readerResponse.GetResponseStream();
      //StreamReader reader = new StreamReader(datastream);

      //string xml = reader.ReadToEnd();

      readerDoc.Load(readerResponse.GetResponseStream());

      XmlNodeList nodeList = readerDoc.SelectNodes("/update-events/update-event");
      foreach (XmlNode n in nodeList)
      {
        txtout = "";
        foreach (XmlNode n2 in n.ChildNodes)
        {
          txtout = txtout + " - " + n2.InnerText;
        }
        lbxOutput.Items.Add(txtout);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      queryReader(false);
    }
  }
}
