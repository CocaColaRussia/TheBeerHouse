using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Caching;
using System.IO;
using System.Collections;
using System.Collections.Specialized;

namespace MB.TheBeerHouse
{
    public static class Helpers
    {
        /// <summary>
        /// Returns an array with the names of all local themes
        /// </summary>

        public static string[] GetThemes()
        {
            if (HttpContext.Current.Cache["SiteThemes"] != null)
            {
                return (string[])HttpContext.Current.Cache["SiteThemes"];
            }
            else
            {
                string themesDirPath = HttpContext.Current.Server.MapPath("~/App_Themes");
                // get the array of themes folders under /app_themes
                string[] themes = Directory.GetDirectories(themesDirPath);
                for (int i = 0; i <= themes.Length - 1; i++)
                    themes[i] = Path.GetFileName(themes[i]);
                // cache the array with a dependency to the folder
                CacheDependency dep = new CacheDependency(themesDirPath);
                HttpContext.Current.Cache.Insert("SiteThemes", themes, dep);
                return themes;
            }
        }

        /// <summary>
        /// Adds the onfocus and onblur attributes to all input controls found in the specified parent,
        /// to change their apperance with the control has the focus
        /// </summary>
        public static void SetInputControlsHighlight(Control container, string className, bool onlyTextBoxes)
        {
            foreach (Control ctl in container.Controls)
            {
                if ((onlyTextBoxes && ctl is TextBox) || ctl is TextBox || ctl is DropDownList ||
                    ctl is ListBox || ctl is CheckBox || ctl is RadioButton ||
                    ctl is RadioButtonList || ctl is CheckBoxList)
                {
                    WebControl wctl = ctl as WebControl;
                    wctl.Attributes.Add("onfocus", string.Format("this.className = '{0}';", className));
                    wctl.Attributes.Add("onblur", "this.className = '';");
                }
                else
                {
                    if (ctl.Controls.Count > 0)
                        SetInputControlsHighlight(ctl, className, onlyTextBoxes);
                }
            }
        }

    }
}