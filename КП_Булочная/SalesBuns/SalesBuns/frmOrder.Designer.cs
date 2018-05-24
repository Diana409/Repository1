namespace SalesBuns
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrdersBuns = new System.Windows.Forms.DataGridView();
            this.typeBuns_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buns_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnOrdersBunsAlter = new System.Windows.Forms.Button();
            this.btnAddOrdersBuns = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteOrdersBuns = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersBuns)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDone
            // 
            this.cbDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(18, 394);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(105, 21);
            this.cbDone.TabIndex = 54;
            this.cbDone.Text = "Выполнено";
            this.cbDone.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(183, 357);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(79, 22);
            this.txtPrice.TabIndex = 53;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Дата заказа";
            // 
            // dgvOrdersBuns
            // 
            this.dgvOrdersBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdersBuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersBuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeBuns_name,
            this.buns_name,
            this.price,
            this.quantity});
            this.dgvOrdersBuns.Location = new System.Drawing.Point(18, 201);
            this.dgvOrdersBuns.Name = "dgvOrdersBuns";
            this.dgvOrdersBuns.RowTemplate.Height = 24;
            this.dgvOrdersBuns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersBuns.Size = new System.Drawing.Size(519, 139);
            this.dgvOrdersBuns.TabIndex = 51;
            // 
            // typeBuns_name
            // 
            this.typeBuns_name.HeaderText = "Тип изделия";
            this.typeBuns_name.Name = "typeBuns_name";
            this.typeBuns_name.ReadOnly = true;
            this.typeBuns_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeBuns_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.typeBuns_name.Width = 120;
            // 
            // buns_name
            // 
            this.buns_name.HeaderText = "Изделие";
            this.buns_name.Name = "buns_name";
            this.buns_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.buns_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.buns_name.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Количество";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cmbClient
            // 
            this.cmbClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(146, 90);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(305, 24);
            this.cmbClient.TabIndex = 49;
            // 
            // cmbManager
            // 
            this.cmbManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Location = new System.Drawing.Point(146, 59);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(391, 22);
            this.cmbManager.TabIndex = 48;
            // 
            // btnPrice
            // 
            this.btnPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrice.Location = new System.Drawing.Point(17, 357);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(160, 22);
            this.btnPrice.TabIndex = 46;
            this.btnPrice.Text = "Посчитать стоимость";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddClient.Location = new System.Drawing.Point(457, 89);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(80, 23);
            this.btnAddClient.TabIndex = 47;
            this.btnAddClient.Text = "Добавить";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnOrdersBunsAlter
            // 
            this.btnOrdersBunsAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdersBunsAlter.Location = new System.Drawing.Point(366, 354);
            this.btnOrdersBunsAlter.Name = "btnOrdersBunsAlter";
            this.btnOrdersBunsAlter.Size = new System.Drawing.Size(84, 25);
            this.btnOrdersBunsAlter.TabIndex = 56;
            this.btnOrdersBunsAlter.Text = "Изменить";
            this.btnOrdersBunsAlter.UseVisualStyleBackColor = true;
            this.btnOrdersBunsAlter.Click += new System.EventHandler(this.btnOrdersBunsAlter_Click);
            // 
            // btnAddOrdersBuns
            // 
            this.btnAddOrdersBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrdersBuns.Location = new System.Drawing.Point(283, 354);
            this.btnAddOrdersBuns.Name = "btnAddOrdersBuns";
            this.btnAddOrdersBuns.Size = new System.Drawing.Size(80, 25);
            this.btnAddOrdersBuns.TabIndex = 58;
            this.btnAddOrdersBuns.Text = "Добавить";
            this.btnAddOrdersBuns.UseVisualStyleBackColor = true;
            this.btnAddOrdersBuns.Click += new System.EventHandler(this.btnAddOrdersBuns_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(444, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 25);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Записать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDelivery.Location = new System.Drawing.Point(146, 148);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(210, 22);
            this.dtpDelivery.TabIndex = 55;
            this.dtpDelivery.Value = new System.DateTime(2016, 11, 23, 0, 0, 0, 0);
            // 
            // dtpOrder
            // 
            this.dtpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrder.Location = new System.Drawing.Point(146, 120);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(210, 22);
            this.dtpOrder.TabIndex = 50;
            this.dtpOrder.Value = new System.DateTime(2016, 11, 23, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Дата сдачи";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Менеджер";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(43, 24);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(114, 22);
            this.txtId.TabIndex = 44;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "№";
            this.label1.Visible = false;
            // 
            // btnDeleteOrdersBuns
            // 
            this.btnDeleteOrdersBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrdersBuns.Location = new System.Drawing.Point(453, 354);
            this.btnDeleteOrdersBuns.Name = "btnDeleteOrdersBuns";
            this.btnDeleteOrdersBuns.Size = new System.Drawing.Size(84, 25);
            this.btnDeleteOrdersBuns.TabIndex = 56;
            this.btnDeleteOrdersBuns.Text = "Удалить";
            this.btnDeleteOrdersBuns.UseVisualStyleBackColor = true;
            this.btnDeleteOrdersBuns.Click += new System.EventHandler(this.btnDeleteOrdersBuns_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 459);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrdersBuns);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmbManager);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnDeleteOrdersBuns);
            this.Controls.Add(this.btnOrdersBunsAlter);
            this.Controls.Add(this.btnAddOrdersBuns);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDelivery);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(503, 372);
            this.Name = "frmOrder";
            this.Text = "Заказ";
            this.Activated += new System.EventHandler(this.frmOrder_Activated);
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersBuns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrdersBuns;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeBuns_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn buns_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnOrdersBunsAlter;
        private System.Windows.Forms.Button btnAddOrdersBuns;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteOrdersBuns;


    }
}