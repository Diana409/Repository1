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
    public partial class frmPrice : Form
    {
        public frmPrice(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public int Id;
        public SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
        public bool loading;

        private void frmPrice_Load(object sender, EventArgs e)
        {
            cmbTypesBuns.DataSource = cls.LoadData("TypesBuns_Select");
            cmbTypesBuns.DisplayMember = "Тип изделия";
            cmbTypesBuns.ValueMember = "№";
            cmbTypesBuns.SelectedValue = 1;

            cmbBuns.DataSource = cls.LoadCMB("exec Buns_Select null, 1");
            cmbBuns.DisplayMember = "Наименование";
            cmbBuns.ValueMember = "№";

            if (Id > 0)
            {
                label1.Visible = true;
                txtId.Visible = true;
                txtId.Text = Id.ToString();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Price_Select";
                com.Parameters.Add(new SqlParameter("@priceId", SqlDbType.Int));
                com.Parameters["@priceId"].Value = Id;
                string str;
                con.Open();
                SqlDataReader rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    str = rdr.GetValue(rdr.GetOrdinal("Тип изделия")).ToString();
                    cmbTypesBuns.SelectedIndex = cmbTypesBuns.FindString(str);

                    cmbBuns.DataSource = cls.LoadCMB("exec Buns_Select null, " + cmbTypesBuns.SelectedValue);
                    cmbBuns.DisplayMember = "Наименование";
                    cmbBuns.ValueMember = "№";
                    str = rdr.GetValue(rdr.GetOrdinal("Изделие")).ToString();
                    cmbBuns.SelectedIndex = cmbBuns.FindString(str);

                    txtCost.Text = rdr.GetValue(rdr.GetOrdinal("Цена")).ToString();
                    dtpInstall.Value = (DateTime)(rdr.GetValue(rdr.GetOrdinal("Дата установки")));
                }
                con.Close();
            }
            loading = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            if (txtCost.Text != "Введите цену")
            {
                try
                {
                    if (Id >= 0)
                    {
                        com.CommandText = "Price_Update";
                        com.Parameters.Add(new SqlParameter("@priceId", SqlDbType.Int));
                        com.Parameters["@priceId"].Value = Id;
                        com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.NVarChar));
                        com.Parameters["@bunsId"].Value = cmbBuns.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                        com.Parameters["@cost"].Value = (txtCost.Text);
                        com.Parameters.Add(new SqlParameter("@dateInstallationCost", SqlDbType.Date));
                        com.Parameters["@dateInstallationCost"].Value = dtpInstall.Value;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно изменена");
                    }
                    else
                    {
                        com.CommandText = "Price_Insert";
                        com.Parameters.Add(new SqlParameter("@bunsId", SqlDbType.NVarChar));
                        com.Parameters["@bunsId"].Value = cmbBuns.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                        com.Parameters["@cost"].Value = (txtCost.Text);
                        com.Parameters.Add(new SqlParameter("@dateInstallationCost", SqlDbType.Date));
                        com.Parameters["@dateInstallationCost"].Value = dtpInstall.Value;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно изменена");
                    }
                    this.Close();
                }
                catch { MessageBox.Show("Произошла ошибка"); }
            }
            else
                MessageBox.Show("Не должно быть пустых полей");
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

        private void txtCost_Enter(object sender, EventArgs e)
        {
            if (txtCost.Text == "Введите цену")
                txtCost.Clear();
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtCost.Text) < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Цена не может быть отрицательной");
                txtCost.Text = "Введите цену";
            }
        }

    }
}
