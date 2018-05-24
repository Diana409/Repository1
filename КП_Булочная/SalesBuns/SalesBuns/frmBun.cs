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
    public partial class frmBun : Form
    {
        public frmBun(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public int Id;
        public SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);

        private void frmBun_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = cls.LoadData("TypesBuns_Select");
            cmbType.DisplayMember = "Тип изделия";
            cmbType.ValueMember = "№";
            if (Id > 0)
            {
                label1.Visible = true;
                txtId.Visible = true;
                txtId.Text = Id.ToString();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Buns_Select";
                com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.Int));
                com.Parameters["@bunsId"].Value = Id;
                string str;
                con.Open();
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    txtName.Text = rdr.GetValue(rdr.GetOrdinal("Наименование")).ToString();
                    str = rdr.GetValue(rdr.GetOrdinal("Тип изделия")).ToString();
                    cmbType.SelectedIndex = cmbType.FindString(str);
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
                        com.CommandText = "Buns_Update";
                        com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.Int));
                        com.Parameters["@bunsId"].Value = Id;
                        com.Parameters.Add(new SqlParameter("@typeBunsId", SqlDbType.NVarChar));
                        com.Parameters["@typeBunsId"].Value = cmbType.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                        com.Parameters["@name"].Value = txtName.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно изменена");
                    }
                    else
                    {
                        com.CommandText = "Buns_Insert";
                        com.Parameters.Add(new SqlParameter("@typeBunsId", SqlDbType.NVarChar));
                        com.Parameters["@typeBunsId"].Value = cmbType.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                        com.Parameters["@name"].Value = txtName.Text;
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
            if (txtName.Text == "Введите название")
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
                            MessageBox.Show("Название должно содержать только русские буквы (возможен дефис)");
                            txtName.Text = "Введите название";
                            break;
                        }
                    }
                }
            }
            else
                txtName.Text = "Введите название";
        }
    }
}
