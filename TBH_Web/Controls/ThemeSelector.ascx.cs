using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MB.TheBeerHouse.UI;
using MB.TheBeerHouse;

public partial class Controls_ThemeSelector : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Globals.ThemesSelectorID.Length == 0)
        {
            Globals.ThemesSelectorID = ddlThemes.UniqueID;
        }

        ddlThemes.DataSource = Helpers.GetThemes();
        ddlThemes.DataBind();

        ddlThemes.SelectedValue = this.Page.Theme;
    }
}

