using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace SalesBuns
{
    public partial class frmManagers : Form
    {
        public frmManagers()
        {
            InitializeComponent();
            dgvManagers.DataSource = cls.LoadData("Managers_Select");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmManager frm = new frmManager(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            frmManager frm = new frmManager(Convert.ToInt32(dgvManagers.CurrentRow.Cells[0].Value));
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id удаляемого менеджера в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvManagers.Rows[dgvManagers.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "Managers_Delete";
                    com.Parameters.Add(new SqlParameter("@managerId", SqlDbType.Int));
                    com.Parameters["@managerId"].Value = idForDelete;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    dgvManagers.DataSource = cls.LoadData("Managers_Select");
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно. Попробуйте удалить все заказы этого менеджера"); }
        }

        private void frmManagers_Activated(object sender, EventArgs e)
        {
            dgvManagers.DataSource = cls.LoadData("Managers_Select");
        }
    }
}
