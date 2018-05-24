namespace SalesBuns
{
    partial class frmBuns
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBuns = new System.Windows.Forms.TabPage();
            this.btnDeleteBuns = new System.Windows.Forms.Button();
            this.btnAlterBuns = new System.Windows.Forms.Button();
            this.btnAddBuns = new System.Windows.Forms.Button();
            this.dgvBuns = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteTypesBuns = new System.Windows.Forms.Button();
            this.btnAlterTypesBuns = new System.Windows.Forms.Button();
            this.btnAddTypesBuns = new System.Windows.Forms.Button();
            this.dgvTypesBuns = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageBuns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuns)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypesBuns)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBuns);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 253);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBuns
            // 
            this.tabPageBuns.Controls.Add(this.btnDeleteBuns);
            this.tabPageBuns.Controls.Add(this.btnAlterBuns);
            this.tabPageBuns.Controls.Add(this.btnAddBuns);
            this.tabPageBuns.Controls.Add(this.dgvBuns);
            this.tabPageBuns.Location = new System.Drawing.Point(4, 25);
            this.tabPageBuns.Name = "tabPageBuns";
            this.tabPageBuns.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuns.Size = new System.Drawing.Size(402, 224);
            this.tabPageBuns.TabIndex = 0;
            this.tabPageBuns.Text = "Изделия";
            this.tabPageBuns.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBuns
            // 
            this.btnDeleteBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteBuns.Location = new System.Drawing.Point(286, 191);
            this.btnDeleteBuns.Name = "btnDeleteBuns";
            this.btnDeleteBuns.Size = new System.Drawing.Size(93, 25);
            this.btnDeleteBuns.TabIndex = 14;
            this.btnDeleteBuns.Text = "Удалить";
            this.btnDeleteBuns.UseVisualStyleBackColor = true;
            this.btnDeleteBuns.Click += new System.EventHandler(this.btnDeleteBuns_Click_1);
            // 
            // btnAlterBuns
            // 
            this.btnAlterBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterBuns.Location = new System.Drawing.Point(187, 191);
            this.btnAlterBuns.Name = "btnAlterBuns";
            this.btnAlterBuns.Size = new System.Drawing.Size(93, 25);
            this.btnAlterBuns.TabIndex = 13;
            this.btnAlterBuns.Text = "Изменить";
            this.btnAlterBuns.UseVisualStyleBackColor = true;
            this.btnAlterBuns.Click += new System.EventHandler(this.btnAlterBuns_Click);
            // 
            // btnAddBuns
            // 
            this.btnAddBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBuns.Location = new System.Drawing.Point(88, 191);
            this.btnAddBuns.Name = "btnAddBuns";
            this.btnAddBuns.Size = new System.Drawing.Size(93, 25);
            this.btnAddBuns.TabIndex = 12;
            this.btnAddBuns.Text = "Добавить";
            this.btnAddBuns.UseVisualStyleBackColor = true;
            this.btnAddBuns.Click += new System.EventHandler(this.btnAddBuns_Click_1);
            // 
            // dgvBuns
            // 
            this.dgvBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuns.Location = new System.Drawing.Point(8, 8);
            this.dgvBuns.Name = "dgvBuns";
            this.dgvBuns.RowTemplate.Height = 24;
            this.dgvBuns.Size = new System.Drawing.Size(386, 177);
            this.dgvBuns.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteTypesBuns);
            this.tabPage2.Controls.Add(this.btnAlterTypesBuns);
            this.tabPage2.Controls.Add(this.btnAddTypesBuns);
            this.tabPage2.Controls.Add(this.dgvTypesBuns);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Типы изделий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTypesBuns
            // 
            this.btnDeleteTypesBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTypesBuns.Location = new System.Drawing.Point(301, 191);
            this.btnDeleteTypesBuns.Name = "btnDeleteTypesBuns";
            this.btnDeleteTypesBuns.Size = new System.Drawing.Size(93, 25);
            this.btnDeleteTypesBuns.TabIndex = 10;
            this.btnDeleteTypesBuns.Text = "Удалить";
            this.btnDeleteTypesBuns.UseVisualStyleBackColor = true;
            this.btnDeleteTypesBuns.Click += new System.EventHandler(this.btnDeleteTypesBuns_Click);
            // 
            // btnAlterTypesBuns
            // 
            this.btnAlterTypesBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterTypesBuns.Location = new System.Drawing.Point(202, 191);
            this.btnAlterTypesBuns.Name = "btnAlterTypesBuns";
            this.btnAlterTypesBuns.Size = new System.Drawing.Size(93, 25);
            this.btnAlterTypesBuns.TabIndex = 9;
            this.btnAlterTypesBuns.Text = "Изменить";
            this.btnAlterTypesBuns.UseVisualStyleBackColor = true;
            this.btnAlterTypesBuns.Click += new System.EventHandler(this.btnAlterTypesBuns_Click);
            // 
            // btnAddTypesBuns
            // 
            this.btnAddTypesBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTypesBuns.Location = new System.Drawing.Point(103, 191);
            this.btnAddTypesBuns.Name = "btnAddTypesBuns";
            this.btnAddTypesBuns.Size = new System.Drawing.Size(93, 25);
            this.btnAddTypesBuns.TabIndex = 8;
            this.btnAddTypesBuns.Text = "Добавить";
            this.btnAddTypesBuns.UseVisualStyleBackColor = true;
            this.btnAddTypesBuns.Click += new System.EventHandler(this.btnAddTypesBuns_Click);
            // 
            // dgvTypesBuns
            // 
            this.dgvTypesBuns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTypesBuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypesBuns.Location = new System.Drawing.Point(38, 8);
            this.dgvTypesBuns.Name = "dgvTypesBuns";
            this.dgvTypesBuns.RowTemplate.Height = 24;
            this.dgvTypesBuns.Size = new System.Drawing.Size(326, 177);
            this.dgvTypesBuns.TabIndex = 7;
            // 
            // frmBuns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 253);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(332, 258);
            this.Name = "frmBuns";
            this.Text = "Булочные изделия";
            this.Activated += new System.EventHandler(this.frmBuns_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBuns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuns)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypesBuns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBuns;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteTypesBuns;
        private System.Windows.Forms.Button btnAlterTypesBuns;
        private System.Windows.Forms.Button btnAddTypesBuns;
        private System.Windows.Forms.DataGridView dgvTypesBuns;
        private System.Windows.Forms.Button btnDeleteBuns;
        private System.Windows.Forms.Button btnAlterBuns;
        private System.Windows.Forms.Button btnAddBuns;
        private System.Windows.Forms.DataGridView dgvBuns;
    }
}