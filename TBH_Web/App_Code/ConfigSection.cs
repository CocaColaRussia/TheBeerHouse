using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace MB.TheBeerHouse
{
    /// <summary>
    /// Summary description for ConfigSection
    /// </summary>
    public class TheBeerHouseSection : ConfigurationSection
    {
        [ConfigurationProperty("defaultConnectionStringName", DefaultValue = "LocalSqlServer")]
        public string DefaultConnectionStringName
        {
            get { return (string)base["defaultConnectionStringName"]; }
            set { base["connectionStdefaultConnectionStringNameringName"] = value; }
        }

        [ConfigurationProperty("defaultCacheDuration", DefaultValue = "600")]
        public int DefaultCacheDuration
        {
            get { return (int)base["defaultCacheDuration"]; }
            set { base["defaultCacheDuration"] = value; }
        }

        [ConfigurationProperty("contactForm", IsRequired = true)]
        public ContactFormElement ContactForm
        {
            get { return (ContactFormElement)base["contactForm"]; }
        }
    }

    public class ContactFormElement : ConfigurationElement
    {
        [ConfigurationProperty("mailSubject",
            DefaultValue = "Mail from TheBeerHouse: {0}")]
        public string MailSubject
        {
            get { return (string)base["mailSubject"]; }
            set { base["mailSubject"] = value; }
        }

        [ConfigurationProperty("mailTo", IsRequired = true)]
        public string MailTo
        {
            get { return (string)base["mailTo"]; }
            set { base["mailTo"] = value; }
        }

        [ConfigurationProperty("mailCC")]
        public string MailCC
        {
            get { return (string)base["mailCC"]; }
            set { base["mailCC"] = value; }
        }
    }

}