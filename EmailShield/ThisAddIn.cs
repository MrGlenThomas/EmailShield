using Office = Microsoft.Office.Core;

namespace EmailShield
{
    using System;
    using System.Windows.Forms;

    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            Application.ItemSend += Application_ItemSend;
        }

        void Application_ItemSend(object Item, ref bool Cancel)
        {
            var passwordForm = new PasswordForm();

            if (passwordForm.ShowDialog() == DialogResult.OK)
            {
                if (passwordForm.Password == "lensman")
                {
                    return;
                }

                MessageBox.Show("Incorrect password!");
            }

            Cancel = true;
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += this.ThisAddIn_Startup;
            this.Shutdown += this.ThisAddIn_Shutdown;
        }
        
        #endregion
    }
}
