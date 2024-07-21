using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace MB.TheBeerHouse.UI
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Events...
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.IsBodyHtml = false;
                msg.From = new MailAddress(txtEmail.Text, txtName.Text);
                msg.To.Add(new MailAddress(Globals.Settings.ContactForm.MailTo));

                if (!string.IsNullOrEmpty(Globals.Settings.ContactForm.MailCC))
                {
                    msg.To.Add(new MailAddress(Globals.Settings.ContactForm.MailCC));
                }

                msg.Subject = string.Format(Globals.Settings.ContactForm.MailSubject, txtSubject.Text);
                msg.Body = txtBody.Text;

                new SmtpClient().Send(msg);

                //show confirmation message and reset the fields
                lblFeedbackOK.Visible = true;
                lblFeedbackKO.Visible = false;
                txtName.Text = "";
                txtEmail.Text = "";
                txtSubject.Text = "";
                txtBody.Text = "";
            }
            catch (Exception)
            {
                lblFeedbackKO.Visible = true;
                lblFeedbackOK.Visible = false;
            }
        }
        #endregion
    }
}