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
    public partial class frmPrices : Form
    {
        public frmPrices()
        {
            InitializeComponent();
            dgvPrices.DataSource = cls.LoadData("Price_Select");
            
            if (Properties.Settings.Default.TypeCon == 2)
            {
                btnAdd.Enabled = false;
                btnAlter.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPrice frm = new frmPrice(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmPrice frm = new frmPrice(Convert.ToInt32(dgvPrices.CurrentRow.Cells[0].Value));
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id удаляемого менеджера в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvPrices.Rows[dgvPrices.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "Price_Delete";
                    com.Parameters.Add(new SqlParameter("@priceId", SqlDbType.Int));
                    com.Parameters["@priceId"].Value = idForDelete;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    dgvPrices.DataSource = cls.LoadData("Price_Select");
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно. Попробуйте удалить все заказы этого менеджера"); }
        }

        private void frmPrices_Activated(object sender, EventArgs e)
        {
            dgvPrices.DataSource = cls.LoadData("Price_Select");
        }
    }
}
