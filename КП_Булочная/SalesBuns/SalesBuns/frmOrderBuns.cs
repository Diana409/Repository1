using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace SalesBuns
{
    public partial class frmOrderBuns : Form
    {
        public frmOrderBuns(int id, DataGridViewRow dgvrow, bool isU)
        {
            InitializeComponent();
            IdO = id;
            row = dgvrow;
            isUpdate = isU;
        }

        public int IdO;
        public SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
        public bool loading, isUpdate;
        public DataGridViewRow row;
        
        private void frmOrderBuns_Load(object sender, EventArgs e)
        {
            cmbTypesBuns.DataSource = cls.LoadData("TypesBuns_Select");
            cmbTypesBuns.DisplayMember = "Тип изделия";
            cmbTypesBuns.ValueMember = "№";
            cmbTypesBuns.SelectedValue = 1;

            cmbBuns.DataSource = cls.LoadCMB("exec Buns_Select null, 1");
            cmbBuns.DisplayMember = "Наименование";
            cmbBuns.ValueMember = "№";
            
            priceText();
            if (isUpdate)
            {
                label1.Visible = true;
                txtId.Visible = true;
                txtId.Text = row.Cells[0].Value.ToString();
                cmbTypesBuns.SelectedIndex = cmbTypesBuns.FindString(row.Cells[1].Value.ToString());
                cmbBuns.DataSource = cls.LoadCMB("exec Buns_Select null, " + cmbTypesBuns.SelectedValue);
                cmbBuns.DisplayMember = "Наименование";
                cmbBuns.ValueMember = "№";
                cmbBuns.SelectedIndex = cmbBuns.FindString(row.Cells[2].Value.ToString());
                txtPrice.Text = row.Cells[3].Value.ToString();
                txtQuantity.Text = row.Cells[4].Value.ToString();
            }
            loading = true;
        }

        private void cmbTypesBuns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                cmbBuns.DataSource = cls.LoadCMB("exec Buns_Select null, " + cmbTypesBuns.SelectedValue);
                cmbBuns.DisplayMember = "Наименование";
                cmbBuns.ValueMember = "№";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQuantity.MaskCompleted)
            {
                int idor = IdO; //id заказа
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                //try
                //{
                con.Open();
                if (isUpdate)
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "OrdersBuns_Update";
                    com.Parameters.Add(new SqlParameter("@ordersBunsId", SqlDbType.Int));
                    com.Parameters["@ordersBunsId"].Value = Convert.ToInt32(txtId.Text);
                    com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.Int));
                    com.Parameters["@bunsId"].Value = cmbBuns.SelectedValue;
                    com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                    com.Parameters["@ordersId"].Value = idor;
                    com.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int));
                    com.Parameters["@quantity"].Value = Convert.ToInt32(txtQuantity.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно изменена");
                }
                else
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "OrdersBuns_Insert";
                    com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.Int));
                    com.Parameters["@bunsId"].Value = cmbBuns.SelectedValue;
                    com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                    com.Parameters["@ordersId"].Value = idor;
                    com.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int));
                    com.Parameters["@quantity"].Value = Convert.ToInt32(txtQuantity.Text);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно добавлена");
                }
                con.Close();
                this.Close();
                //}
                //catch { MessageBox.Show("Произошла ошибка"); }
                this.Close();
            }
            else MessageBox.Show("Не должно быть пустых полей");
        }

        public void priceText()
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Цена FROM dbo.PriceBuns WHERE id_buns=" + cmbBuns.SelectedValue;
            con.Open();
            txtPrice.Text = Convert.ToString(com.ExecuteScalar());
            con.Close();
        }

        private void cmbBuns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loading)
                priceText();
        }
        
    }
}
