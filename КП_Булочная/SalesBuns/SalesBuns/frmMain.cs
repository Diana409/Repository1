using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace SalesBuns
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            if (Properties.Settings.Default.TypeCon == 2)
            tsbutManagers.Visible = false;
            //MessageBox.Show(al[1].ToString());
        }

        private void tsbutManagers_Click(object sender, EventArgs e)
        {
            frmManagers frm = new frmManagers();
            frm.MdiParent = this;
            frm.Show();
        }
            

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsbutClients_Click(object sender, EventArgs e)
        {
            frmClients frm = new frmClients();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbutBuns_Click(object sender, EventArgs e)
        {
            frmBuns frm = new frmBuns();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbutPrice_Click(object sender, EventArgs e)
        {
            frmPrices frm = new frmPrices();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsbutOrders_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
