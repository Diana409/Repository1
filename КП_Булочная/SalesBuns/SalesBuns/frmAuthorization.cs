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
using System.Data.Sql;
using System.Data.Common;

namespace SalesBuns
{
    public partial class frmAuthorization : Form
    {
        public frmAuthorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.ConStringAuthor + "USER ID=" + txtLogin.Text + ";PASSWORD=" + txtPassword.Text + ";";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT p.NAME ,m.NAME FROM sys.database_role_members rmm JOIN sys.database_principals p ON rmm.role_principal_id = p.principal_id JOIN sys.database_principals m ON rmm.member_principal_id = m.principal_id";
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "Director")
                    Properties.Settings.Default.TypeCon = 1;
                if (cmd.ExecuteScalar().ToString() == "Manager")
                    Properties.Settings.Default.TypeCon = 2;

                cmd.CommandText = "SELECT m.NAME ,p.NAME FROM sys.database_role_members rmm JOIN sys.database_principals p ON rmm.role_principal_id = p.principal_id JOIN sys.database_principals m ON rmm.member_principal_id = m.principal_id";
                Properties.Settings.Default.login = cmd.ExecuteScalar().ToString();

                con.Close();
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            catch
            {
                MessageBox.Show("Неверно введен логин или пароль");
            }

        }
    }
}
