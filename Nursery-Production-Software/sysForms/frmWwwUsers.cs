using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBSio.etc.sp;
using NBSio.etc.dbobj;

namespace Nursery_Production_Software.sysForms
{
  public partial class frmWwwUsers : DevExpress.XtraEditors.XtraForm
  {
    wwwUserObj wwwUser = new wwwUserObj();
    wwwUserSP wwwSP = new wwwUserSP();

    public frmWwwUsers()
    {
      InitializeComponent();
    }

    

    private void frmWwwUsers_Load(object sender, EventArgs e)
    {
      grdWwwUsers.DataSource = wwwSP.ViewAllUsers();
    }
  }
}
