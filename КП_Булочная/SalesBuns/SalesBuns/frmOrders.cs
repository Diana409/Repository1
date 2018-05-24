using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalesBuns
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            dgvOrders.DataSource = cls.LoadData("Orders_Select");
            if (Properties.Settings.Default.TypeCon == 1)
            {
                btnAdd.Enabled = false;
                btnAlter.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder(Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value));
            frm.MdiParent = this.ParentForm;
            
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id удаляемого менеджера в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvOrders.Rows[dgvOrders.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cls.LoadCMB("exec OrdersBuns_Delete null, " + idForDelete);
                    cls.LoadCMB("exec Orders_Delete " + idForDelete);
                    dgvOrders.DataSource = cls.LoadData("Orders_Select");
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно."); }
        }

        private void frmOrders_Activated(object sender, EventArgs e)
        {
            dgvOrders.DataSource = cls.LoadData("Orders_Select");
        }
    }
}
