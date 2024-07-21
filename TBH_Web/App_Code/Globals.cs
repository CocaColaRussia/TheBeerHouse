using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace MB.TheBeerHouse
{
    /// <summary>
    /// Summary description for Globals
    /// </summary>
    public static class Globals
    {
        public static string ThemesSelectorID = "";

        public readonly static TheBeerHouseSection Settings =
       (TheBeerHouseSection)WebConfigurationManager.GetSection("theBeerHouse");
    }
}
