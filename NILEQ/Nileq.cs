using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using NILEQ.UM.UI;
using NILEQ.UM.COMMON;

namespace NILEQ
{
    public partial class Nileq : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private NILEQ.UM.COMMON.StudentManagement.StudentApplication _apply;
        private NILEQ.UM.UI.Authentication.Login _login;

        public Nileq()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BringFormToFront(Form oForm)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.WindowState = FormWindowState.Normal;

            oForm.BringToFront();
            oForm.WindowState = FormWindowState.Maximized;
            Application.DoEvents();
        }

        private void ShowForm(Form oForm)
        {
            try
            {
                oForm.MdiParent = this;

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.WindowState = FormWindowState.Normal;

                oForm.Show();
                oForm.WindowState = FormWindowState.Maximized;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loginButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_login == null || _login.IsDisposed)
                {
                    _login = new NILEQ.UM.UI.Authentication.Login();
                    ShowForm(_login);
                }
                else
                {
                    BringFormToFront(_login);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
