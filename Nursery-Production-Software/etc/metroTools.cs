using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using Microsoft.Win32;
using General;

namespace Nursery_Production_Software.etc
{
    public static class metroTools
    {
        public static MetroFramework.Components.MetroStyleManager setStyles()
        {
            RegistryKey jans = Global.get_reg_key("JANS", true);
            int style = 0;
            int theme = 0;
            MetroFramework.Components.MetroStyleManager sm = new MetroFramework.Components.MetroStyleManager();

            style = jans.GetValue("metroStyle") == null ? 0 : Convert.ToInt16(jans.GetValue("metroStyle"));
            theme = jans.GetValue("metroTheme") == null ? 0 : Convert.ToInt16(jans.GetValue("metroTheme"));

            sm.Style = (MetroFramework.MetroColorStyle)style;
            sm.Theme = (MetroFramework.MetroThemeStyle)theme;
            return sm;
        }
    }
}
