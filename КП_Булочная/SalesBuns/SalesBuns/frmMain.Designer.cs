namespace SalesBuns
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbutOrders = new System.Windows.Forms.ToolStripButton();
            this.tsbutClients = new System.Windows.Forms.ToolStripButton();
            this.tsbutPrice = new System.Windows.Forms.ToolStripButton();
            this.tsbutBuns = new System.Windows.Forms.ToolStripButton();
            this.tsbutManagers = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbutOrders,
            this.tsbutClients,
            this.tsbutPrice,
            this.tsbutBuns,
            this.tsbutManagers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbutOrders
            // 
            this.tsbutOrders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutOrders.Image = ((System.Drawing.Image)(resources.GetObject("tsbutOrders.Image")));
            this.tsbutOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutOrders.Name = "tsbutOrders";
            this.tsbutOrders.Size = new System.Drawing.Size(62, 24);
            this.tsbutOrders.Text = "Заказы";
            this.tsbutOrders.Click += new System.EventHandler(this.tsbutOrders_Click);
            // 
            // tsbutClients
            // 
            this.tsbutClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutClients.Image = ((System.Drawing.Image)(resources.GetObject("tsbutClients.Image")));
            this.tsbutClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutClients.Name = "tsbutClients";
            this.tsbutClients.Size = new System.Drawing.Size(73, 24);
            this.tsbutClients.Text = "Клиенты";
            this.tsbutClients.Click += new System.EventHandler(this.tsbutClients_Click);
            // 
            // tsbutPrice
            // 
            this.tsbutPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutPrice.Image = ((System.Drawing.Image)(resources.GetObject("tsbutPrice.Image")));
            this.tsbutPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutPrice.Name = "tsbutPrice";
            this.tsbutPrice.Size = new System.Drawing.Size(52, 24);
            this.tsbutPrice.Text = "Цены";
            this.tsbutPrice.Click += new System.EventHandler(this.tsbutPrice_Click);
            // 
            // tsbutBuns
            // 
            this.tsbutBuns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutBuns.Image = ((System.Drawing.Image)(resources.GetObject("tsbutBuns.Image")));
            this.tsbutBuns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutBuns.Name = "tsbutBuns";
            this.tsbutBuns.Size = new System.Drawing.Size(72, 24);
            this.tsbutBuns.Text = "Изделия";
            this.tsbutBuns.Click += new System.EventHandler(this.tsbutBuns_Click);
            // 
            // tsbutManagers
            // 
            this.tsbutManagers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbutManagers.Image = ((System.Drawing.Image)(resources.GetObject("tsbutManagers.Image")));
            this.tsbutManagers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbutManagers.Name = "tsbutManagers";
            this.tsbutManagers.Size = new System.Drawing.Size(98, 24);
            this.tsbutManagers.Text = "Менеджеры";
            this.tsbutManagers.Click += new System.EventHandler(this.tsbutManagers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 542);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(384, 279);
            this.Name = "frmMain";
            this.Text = "Продажа выпечки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbutOrders;
        private System.Windows.Forms.ToolStripButton tsbutClients;
        private System.Windows.Forms.ToolStripButton tsbutManagers;
        private System.Windows.Forms.ToolStripButton tsbutPrice;
        private System.Windows.Forms.ToolStripButton tsbutBuns;
    }
}