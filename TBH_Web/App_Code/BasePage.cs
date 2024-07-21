using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace MB.TheBeerHouse.UI
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            string id = Globals.ThemesSelectorID;
            if (id.Length > 0)
            {
                // if this is a postback caused by the theme selectors dropdownlist,
                // retrieve the selected theme and unse it for the current page request
                if (this.Request.Form["__EVENTTARGET"] == id &&
                    !string.IsNullOrEmpty(this.Request.Form[id]))
                {
                    this.Theme = this.Request.Form[id];
                    this.Session["CurrentTheme"] = this.Theme;
                }
                else
                {
                    if (this.Session["CurrentTheme"] != null)
                        this.Theme = this.Session["CurrentTheme"].ToString();
                }
            }

            base.OnPreInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            // add onfocus and onblur javascripts to all input controls on the forum,
            // so that the active control has a difference appearance
            Helpers.SetInputControlsHighlight(this, "highlight", false);

            base.OnLoad(e);
        }

    }
}
