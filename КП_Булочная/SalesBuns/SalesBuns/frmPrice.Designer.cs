namespace SalesBuns
{
    partial class frmPrice
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpInstall = new System.Windows.Forms.DateTimePicker();
            this.cmbTypesBuns = new System.Windows.Forms.ComboBox();
            this.cmbBuns = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата установки";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Изделие";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Вид изделия";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(40, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(85, 22);
            this.txtId.TabIndex = 10;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "№";
            this.label1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(215, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Записать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpInstall
            // 
            this.dtpInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInstall.Location = new System.Drawing.Point(138, 132);
            this.dtpInstall.Name = "dtpInstall";
            this.dtpInstall.Size = new System.Drawing.Size(170, 22);
            this.dtpInstall.TabIndex = 4;
            this.dtpInstall.Value = new System.DateTime(2016, 11, 22, 0, 0, 0, 0);
            // 
            // cmbTypesBuns
            // 
            this.cmbTypesBuns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypesBuns.FormattingEnabled = true;
            this.cmbTypesBuns.Location = new System.Drawing.Point(138, 44);
            this.cmbTypesBuns.Name = "cmbTypesBuns";
            this.cmbTypesBuns.Size = new System.Drawing.Size(170, 24);
            this.cmbTypesBuns.TabIndex = 1;
            this.cmbTypesBuns.SelectedIndexChanged += new System.EventHandler(this.cmbTypesBuns_SelectedIndexChanged);
            // 
            // cmbBuns
            // 
            this.cmbBuns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuns.FormattingEnabled = true;
            this.cmbBuns.Location = new System.Drawing.Point(138, 74);
            this.cmbBuns.Name = "cmbBuns";
            this.cmbBuns.Size = new System.Drawing.Size(170, 24);
            this.cmbBuns.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.Location = new System.Drawing.Point(138, 104);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(170, 22);
            this.txtCost.TabIndex = 3;
            this.txtCost.Text = "Введите цену";
            this.txtCost.Enter += new System.EventHandler(this.txtCost_Enter);
            this.txtCost.Leave += new System.EventHandler(this.txtCost_Leave);
            // 
            // frmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 211);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.cmbBuns);
            this.Controls.Add(this.cmbTypesBuns);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpInstall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(348, 256);
            this.Name = "frmPrice";
            this.Text = "Цена";
            this.Load += new System.EventHandler(this.frmPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpInstall;
        private System.Windows.Forms.ComboBox cmbTypesBuns;
        private System.Windows.Forms.ComboBox cmbBuns;
        private System.Windows.Forms.TextBox txtCost;
    }
}