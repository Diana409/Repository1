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
    public partial class frmClient : Form
    {
        public frmClient(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public int Id;
        public SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);

        private void frmClient_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                label1.Visible = true;
                txtId.Visible = true;
                txtId.Text = Id.ToString();

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Clients_Select";
                com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.Int));
                com.Parameters["@clientsId"].Value = Id;
                con.Open();
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    txtSurname.Text = rdr.GetValue(rdr.GetOrdinal("Фамилия")).ToString();
                    txtName.Text = rdr.GetValue(rdr.GetOrdinal("Имя")).ToString();
                    txtPatronymic.Text = rdr.GetValue(rdr.GetOrdinal("Отчество")).ToString();
                    mtxtPhone.Text = rdr.GetValue(rdr.GetOrdinal("Телефон")).ToString();
                }
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            if (txtSurname.Text != "Введите фамилию" && txtName.Text != "Введите имя" && txtPatronymic.Text != "Введите отчество")
            {
                try
                {
                    if (Id >= 0)
                    {
                        com.CommandText = "Clients_Update";
                        com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.Int));
                        com.Parameters["@clientsId"].Value = Id;
                        com.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar));
                        com.Parameters["@surname"].Value = txtSurname.Text;
                        com.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                        com.Parameters["@name"].Value = txtName.Text;
                        com.Parameters.Add(new SqlParameter("@patronymic", SqlDbType.NVarChar));
                        com.Parameters["@patronymic"].Value = txtPatronymic.Text;
                        com.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar));
                        com.Parameters["@phone"].Value = mtxtPhone.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно изменена");
                    }
                    else
                    {
                        com.CommandText = "Clients_Insert";
                        com.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar));
                        com.Parameters["@surname"].Value = txtSurname.Text;
                        com.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar));
                        com.Parameters["@name"].Value = txtName.Text;
                        com.Parameters.Add(new SqlParameter("@patronymic", SqlDbType.NVarChar));
                        com.Parameters["@patronymic"].Value = txtPatronymic.Text;
                        com.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar));
                        com.Parameters["@phone"].Value = mtxtPhone.Text;
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

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (txtSurname.TextLength != 0)
            {
                for (int i = 0; i < txtSurname.Text.Length; i++)
                {
                    if ((txtSurname.Text[i] < 'А') || (txtSurname.Text[i] > 'я'))
                    {
                        if (i < txtSurname.Text.Length - 2 && i > 1 && txtSurname.Text[i] == '-')
                        { }
                        else
                        {
                            MessageBox.Show("Фамилия должна содержать только русские буквы (возможен дефис)");
                            txtSurname.Text = "Введите фамилию";
                            break;
                        }
                    }
                }
            }
            else
                txtSurname.Text = "Введите фамилию";
        }
        private void txtSurname_Enter(object sender, EventArgs e)
        {
            if (txtSurname.Text == "Введите фамилию")
                txtSurname.Clear();
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
                            MessageBox.Show("Имя должно содержать только русские буквы (возможен дефис)");
                            txtName.Text = "Введите имя";
                            break;
                        }
                    }
                }
            }
            else
                txtName.Text = "Введите имя";
        }
        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Введите имя")
                txtName.Clear();
        }

        private void txtPatronymic_Leave(object sender, EventArgs e)
        {
            if (txtPatronymic.TextLength != 0)
            {
                for (int i = 0; i < txtPatronymic.Text.Length; i++)
                {
                    if ((txtPatronymic.Text[i] < 'А') || (txtPatronymic.Text[i] > 'я'))
                    {
                        if (i < txtPatronymic.Text.Length - 2 && i > 1 && txtPatronymic.Text[i] == '-')
                        { }
                        else
                        {
                            MessageBox.Show("Отчество должно содержать только русские буквы (возможен дефис)");
                            txtPatronymic.Text = "Введите отчество";
                            break;
                        }
                    }
                }
            }
            else
                txtPatronymic.Text = "Введите отчество";
        }
        private void txtPatronymic_Enter(object sender, EventArgs e)
        {
            if (txtPatronymic.Text == "Введите отчество")
                txtPatronymic.Clear();
        }
    }
}
