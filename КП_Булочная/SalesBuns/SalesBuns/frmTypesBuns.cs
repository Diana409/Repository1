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
    public partial class frmTypesBuns : Form
    {
        public frmTypesBuns(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public int Id;
        public SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);

        private void frmTypesBuns_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                label1.Visible = true;
                txtId.Visible = true;
                txtId.Text = Id.ToString();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "TypesBuns_Select";
                com.Parameters.Add(new SqlParameter("@typesBunsId", SqlDbType.Int));
                com.Parameters["@typesBunsId"].Value = Id;
                con.Open();
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    txtName.Text = rdr.GetValue(rdr.GetOrdinal("Тип изделия")).ToString();
                }
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            if (txtName.Text != "Введите название")
            {
                try
                {
                    if (Id >= 0)
                    {
                        com.CommandText = "TypesBuns_Update";
                        com.Parameters.Add(new SqlParameter("@typeBunsId", SqlDbType.Int));
                        com.Parameters["@typeBunsId"].Value = Id;
                        com.Parameters.Add(new SqlParameter("@typeBuns", SqlDbType.NVarChar));
                        com.Parameters["@typeBuns"].Value = txtName.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно изменена");
                    }
                    else
                    {
                        com.CommandText = "TypesBuns_Insert";
                        com.Parameters.Add(new SqlParameter("@typeBuns", SqlDbType.NVarChar));
                        com.Parameters["@typeBuns"].Value = txtName.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно добавлена");
                    }
                    this.Close();
                }
                catch { MessageBox.Show("Произошла ошибка"); }
            }
            else
                MessageBox.Show("Не должно быть пустых полей");
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Введите тип")
                txtName.Clear();
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.TextLength != 0)
            {
                for (int i = 0; i < txtName.Text.Length; i++)
                {
                    if ((txtName.Text[i] < 'А') || (txtName.Text[i] > 'я'))
                    {
                        if ((i < txtName.Text.Length - 2 && i > 1) && (txtName.Text[i] == '-' || txtName.Text[i] == ' '))
                        { }
                        else
                        {
                            MessageBox.Show("Тип должен содержать только русские буквы (возможен дефис)");
                            txtName.Text = "Введите тип";
                            break;
                        }
                    }
                }
            }
            else
                txtName.Text = "Введите тип";
        }
    }
}
