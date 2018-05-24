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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
            dgvClients.DataSource = cls.LoadData("Clients_Select");
            if (Properties.Settings.Default.TypeCon == 1)
            {
                btnAdd.Enabled = false;
                btnAlter.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient(Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value));
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id удаляемого клиента в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvClients.Rows[dgvClients.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "Clients_Delete";
                    com.Parameters.Add(new SqlParameter("@clientId", SqlDbType.Int));
                    com.Parameters["@clientId"].Value = idForDelete;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    dgvClients.DataSource = cls.LoadData("Clients_Select");
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно. Попробуйте удалить все заказы этого клиента"); }
        
        }

        private void frmClients_Activated(object sender, EventArgs e)
        {
            dgvClients.DataSource = cls.LoadData("Clients_Select");
        }
    }
}
