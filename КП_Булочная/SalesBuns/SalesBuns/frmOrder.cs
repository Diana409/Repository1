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
    public partial class frmOrder : Form
    {
        public frmOrder(int id)
        {
            InitializeComponent();
            Id = id;
        }
        int Id;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
        string str;

        private void frmOrder_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT id_managers As [№] FROM  dbo.Managers WHERE manager_login='" + Properties.Settings.Default.login+"'";
            SqlDataReader sdr; 

            cmbManager.DropDownStyle = ComboBoxStyle.DropDown;
            cmbManager.DataSource = cls.LoadCMB("SELECT id_managers As [№], manager_surname + ' ' + manager_name + ' ' + manager_patronymic AS ФИОм FROM  dbo.Managers");
            cmbManager.DisplayMember = "ФИОм";
            cmbManager.ValueMember = "№";
            con.Open();
            cmbManager.SelectedValue = com.ExecuteScalar();
            con.Close();

            cmbClient.DataSource = cls.LoadCMB("SELECT id_clients As [№], client_surname + ' ' + client_name + ' ' + client_patronymic AS ФИОк FROM  dbo.Clients");
            cmbClient.DisplayMember = "ФИОк";
            cmbClient.ValueMember = "№";
            cmbClient.SelectedValue = 1;
            
            if (Id > 0)
            {
                label1.Visible = true;
                txtId.Visible = true;
                txtId.Text = Id.ToString();

                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Orders_Select";
                com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                com.Parameters["@ordersId"].Value = Id;
                con.Open();
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    str = sdr.GetValue(sdr.GetOrdinal("ФИО менеджера")).ToString();
                    cmbManager.SelectedIndex = cmbManager.FindString(str);

                    str = sdr.GetValue(sdr.GetOrdinal("ФИОклиента")).ToString();
                    cmbClient.SelectedValue = cmbClient.FindString(str);
                    dtpOrder.Value = (DateTime)(sdr.GetValue(sdr.GetOrdinal("дата заказа")));
                    dtpDelivery.Value = (DateTime)(sdr.GetValue(sdr.GetOrdinal("дата сдачи")));
                    txtPrice.Text = sdr.GetValue(sdr.GetOrdinal("Стоимость")).ToString();
                    
                    if (txtPrice.Text == "" || txtPrice.Text == null)
                        txtPrice.Text = "0";

                    cbDone.Checked = (bool)sdr.GetValue(sdr.GetOrdinal("Выполнено"));

                    if (dgvOrdersBuns.ColumnCount != 0)
                    {
                        dgvOrdersBuns.Columns.Clear();
                        dgvOrdersBuns.DataSource = cls.LoadCMB("EXEC OrdersBuns_Select " + Id);
                    }
                }
                con.Close();
            }
        }


        private void btnAddOrdersBuns_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            if (Id > 0)
            {
                com.CommandText = "Orders_Update";
                com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                com.Parameters["@ordersId"].Value = Id;
                
                com.Parameters.Add(new SqlParameter("@managersId", SqlDbType.NVarChar));
                com.Parameters["@managersId"].Value = cmbManager.SelectedValue;
                com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.NVarChar));
                com.Parameters["@clientsId"].Value = cmbClient.SelectedValue;
                com.Parameters.Add(new SqlParameter("@orderDate", SqlDbType.Date));
                com.Parameters["@orderDate"].Value = dtpOrder.Value;
                com.Parameters.Add("@cost", SqlDbType.Money);
                com.Parameters["@cost"].SqlValue = null;
                com.Parameters.Add(new SqlParameter("@done", SqlDbType.Bit));
                com.Parameters["@done"].Value = cbDone.Checked;
                com.Parameters.Add(new SqlParameter("@deliveryTime", SqlDbType.Date));
                com.Parameters["@deliveryTime"].Value = dtpDelivery.Value;

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                frmOrderBuns frm;
                frm = new frmOrderBuns(Id, null, false);
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
            else
            {
                com.CommandText = "Orders_Insert";
                com.Parameters.Add(new SqlParameter("@managersId", SqlDbType.Int));
                com.Parameters["@managersId"].Value = cmbManager.SelectedValue;
                com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.Int));
                com.Parameters["@clientsId"].Value = cmbClient.SelectedValue;
                com.Parameters.Add(new SqlParameter("@orderDate", SqlDbType.Date));
                com.Parameters["@orderDate"].Value = dtpOrder.Value;
                com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                com.Parameters["@cost"].Value = null;
                com.Parameters.Add(new SqlParameter("@done", SqlDbType.Bit));
                com.Parameters["@done"].Value = cbDone.Checked;
                com.Parameters.Add(new SqlParameter("@deliveryTime", SqlDbType.Date));
                com.Parameters["@deliveryTime"].Value = dtpDelivery.Value;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT MAX(id_orders) FROM dbo.Orders";
                con.Open();
                Id = (int)com.ExecuteScalar();
                con.Close();

                frmOrderBuns frm;
                frm = new frmOrderBuns(Id, null, false);
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
        }
        private void frmOrder_Activated(object sender, EventArgs e)
        {
            dgvOrdersBuns.DataSource = null;
            dgvOrdersBuns.Rows.Clear();
            dgvOrdersBuns.Columns.Clear();
            dgvOrdersBuns.DataSource = cls.LoadCMB("EXEC OrdersBuns_Select " + Id+", null");
            if( dgvOrdersBuns.RowCount>0)
                dgvOrdersBuns.Columns[0].Visible = false;
            

            cmbClient.DataSource = cls.LoadCMB("SELECT id_clients As [№], client_surname + ' ' + client_name + ' ' + client_patronymic AS ФИОк FROM  dbo.Clients");
            cmbClient.DisplayMember = "ФИОк";
            cmbClient.ValueMember = "№";
            if (str != null)
                cmbClient.SelectedIndex = cmbClient.FindString(str);
            else
                cmbClient.SelectedValue = 1;

        }

        private void btnOrdersBunsAlter_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            if (Id > 0)
            {
                com.CommandText = "Orders_Update";
                com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                com.Parameters["@ordersId"].Value = Id;
                com.Parameters.Add(new SqlParameter("@managersId", SqlDbType.NVarChar));
                com.Parameters["@managersId"].Value = cmbManager.SelectedValue;
                com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.NVarChar));
                com.Parameters["@clientsId"].Value = cmbClient.SelectedValue;
                com.Parameters.Add(new SqlParameter("@orderDate", SqlDbType.Date));
                com.Parameters["@orderDate"].Value = dtpOrder.Value;
                com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                com.Parameters["@cost"].Value = null;
                com.Parameters.Add(new SqlParameter("@done", SqlDbType.Bit));
                com.Parameters["@done"].Value = cbDone.Checked;
                com.Parameters.Add(new SqlParameter("@deliveryTime", SqlDbType.Date));
                com.Parameters["@deliveryTime"].Value = dtpDelivery.Value;

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                frmOrderBuns frm;
                frm = new frmOrderBuns(Id, dgvOrdersBuns.SelectedRows[0], true);
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
            else
            {
                com.CommandText = "Orders_Insert";
                com.Parameters.Add(new SqlParameter("@managersId", SqlDbType.NVarChar));
                com.Parameters["@managersId"].Value = cmbManager.SelectedValue;
                com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.NVarChar));
                com.Parameters["@clientsId"].Value = cmbClient.SelectedValue;
                com.Parameters.Add(new SqlParameter("@orderDate", SqlDbType.Date));
                com.Parameters["@orderDate"].Value = dtpOrder.Value;
                com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                com.Parameters["@cost"].Value = null;
                com.Parameters.Add(new SqlParameter("@done", SqlDbType.Bit));
                com.Parameters["@done"].Value = cbDone.Checked;
                com.Parameters.Add(new SqlParameter("@deliveryTime", SqlDbType.Date));
                com.Parameters["@deliveryTime"].Value = dtpDelivery.Value;
                
                con.Open();
                int insertId = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                frmOrderBuns frm;
                frm = new frmOrderBuns(Id, dgvOrdersBuns.SelectedRows[0], true);
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
        }

        private void btnDeleteOrdersBuns_Click(object sender, EventArgs e)
        {
            try
            {
                //при frmManagers_Activated выбирается 1 строка, поэтому запоминаем id удаляемого менеджера в переменную idForDelete
                int idForDelete = Convert.ToInt32(dgvOrdersBuns.Rows[dgvOrdersBuns.CurrentCell.RowIndex].Cells[0].Value);
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.ConString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "OrdersBuns_Delete";
                    com.Parameters.Add(new SqlParameter("@orderBunsId", SqlDbType.Int));
                    com.Parameters["@orderBunsId"].Value = idForDelete;
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    dgvOrdersBuns.DataSource = cls.LoadCMB("EXEC OrdersBuns_Select " + Id);
                }
            }
            catch { MessageBox.Show("Попытка удаления завершилась неудачно."); }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient(-1);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Double Sum = 0;
            for (int i = 0; i < dgvOrdersBuns.RowCount; i++)
            {
                 Sum= Sum+(Convert.ToDouble(dgvOrdersBuns.Rows[i].Cells[3].Value) * Convert.ToDouble(dgvOrdersBuns.Rows[i].Cells[4].Value));
            }
            txtPrice.Text=String.Format("{0:0.00}", Sum);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            if (dgvOrdersBuns.RowCount > 0)
            {
                try
                {
                    if (Id >= 0)
                    {
                        com.CommandText = "Orders_Update";
                        com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                        com.Parameters["@ordersId"].Value = Id;
                        com.Parameters.Add(new SqlParameter("@managersId", SqlDbType.NVarChar));
                        com.Parameters["@managersId"].Value = cmbManager.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.NVarChar));
                        com.Parameters["@clientsId"].Value = cmbClient.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@orderDate", SqlDbType.Date));
                        com.Parameters["@orderDate"].Value = dtpOrder.Value;
                        com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                        com.Parameters["@cost"].Value = null;
                        com.Parameters.Add(new SqlParameter("@done", SqlDbType.Bit));
                        com.Parameters["@done"].Value = cbDone.Checked;
                        com.Parameters.Add(new SqlParameter("@deliveryTime", SqlDbType.Date));
                        com.Parameters["@deliveryTime"].Value = dtpDelivery.Value;

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Запись успешно изменена");
                    }
                    else
                    {
                        com.CommandText = "Orders_Update";
                        com.Parameters.Add(new SqlParameter("@ordersId", SqlDbType.Int));
                        com.Parameters["@ordersId"].Value = Id;
                        com.Parameters.Add(new SqlParameter("@managersId", SqlDbType.NVarChar));
                        com.Parameters["@managersId"].Value = cmbManager.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@clientsId", SqlDbType.NVarChar));
                        com.Parameters["@clientsId"].Value = cmbClient.SelectedValue;
                        com.Parameters.Add(new SqlParameter("@orderDate", SqlDbType.Date));
                        com.Parameters["@orderDate"].Value = dtpOrder.Value;
                        com.Parameters.Add(new SqlParameter("@cost", SqlDbType.Money));
                        com.Parameters["@cost"].Value = null;
                        com.Parameters.Add(new SqlParameter("@done", SqlDbType.Bit));
                        com.Parameters["@done"].Value = cbDone.Checked;
                        com.Parameters.Add(new SqlParameter("@deliveryTime", SqlDbType.Date));
                        com.Parameters["@deliveryTime"].Value = dtpDelivery.Value;

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
    }
}
