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
    public partial class frmBuns : Form
    {
        public frmBuns()
        {
            InitializeComponent();
            dgvBuns.DataSource = cls.LoadData("Buns_Select");
            dgvTypesBuns.DataSource = cls.LoadData("TypesBuns_Select");
            if (Properties.Settings.Default.TypeCon == 2)
            {
                btnAddBuns.Enabled = false;
                btnAddTypesBuns.Enabled = false;
                btnAlterBuns.Enabled = false;
                btnAlterTypesBuns.Enabled = false;
                btnDeleteBuns.Enabled = false;
                btnDeleteTypesBuns.Enabled = false;
            }
        }

        private void btnAddBuns_Click_1(object sender, EventArgs e)
        {
            frmBun frm = new frmBun(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnAlterBuns_Click(object sender, EventArgs e)
        {
            frmBun frm = new frmBun(Convert.ToInt32(dgvBuns.CurrentRow.Cells[0].Value));
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }
        private void btnDeleteBuns_Click_1(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvBuns.Rows[dgvBuns.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "Buns_Delete";
                    com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.Int));
                    com.Parameters["@bunsId"].Value = idForDelete;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    dgvBuns.DataSource = cls.LoadData("Buns_Select");
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно. Возможно булочное изделие с таким именем уже существует"); }
        
        }

        private void btnAddTypesBuns_Click(object sender, EventArgs e)
        {
            frmTypesBuns frm = new frmTypesBuns(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnAlterTypesBuns_Click(object sender, EventArgs e)
        {
            frmTypesBuns frm = new frmTypesBuns(Convert.ToInt32(dgvTypesBuns.CurrentRow.Cells[0].Value));
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnDeleteTypesBuns_Click(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvTypesBuns.Rows[dgvTypesBuns.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "TypesBuns_Delete";
                    com.Parameters.Add(new SqlParameter("@typesBunsId", SqlDbType.Int));
                    com.Parameters["@typesBunsId"].Value = idForDelete;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    dgvTypesBuns.DataSource = cls.LoadData("TypesBuns_Select");
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно. Возможно такой тип булочного изделия уже существует"); }
        
        }

        private void frmBuns_Activated(object sender, EventArgs e)
        {
            dgvBuns.DataSource = cls.LoadData("Buns_Select");
            dgvTypesBuns.DataSource = cls.LoadData("TypesBuns_Select");
        }

        


        
    }
}
