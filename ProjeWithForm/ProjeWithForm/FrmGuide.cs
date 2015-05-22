using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjeWithForm
{
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();
        }

        #region headerPanel
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (e.Button == MouseButtons.Left)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        int mouseX;
        int mouseY;
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
        #endregion

        private void btFrmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
