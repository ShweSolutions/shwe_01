namespace ShweStock
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.btnSupplier = new DevComponents.DotNetBar.ButtonX();
            this.btnCustomer = new DevComponents.DotNetBar.ButtonX();
            this.btnSystemsetting = new DevComponents.DotNetBar.ButtonX();
            this.btnUser = new DevComponents.DotNetBar.ButtonX();
            this.btnUnit = new DevComponents.DotNetBar.ButtonX();
            this.btnStock = new DevComponents.DotNetBar.ButtonX();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.btnReturnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnSaleOrder = new DevComponents.DotNetBar.ButtonX();
            this.btnSale = new DevComponents.DotNetBar.ButtonX();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.btnReturnOut = new DevComponents.DotNetBar.ButtonX();
            this.btnPurchaseOrder = new DevComponents.DotNetBar.ButtonX();
            this.btnPurchase = new DevComponents.DotNetBar.ButtonX();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbtSale = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbtPurchase = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbtSetup = new DevComponents.DotNetBar.RibbonTabItem();
            this.rbtReport = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 108);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1008, 623);
            this.pnlMain.TabIndex = 3;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel4);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rbtSale,
            this.rbtPurchase,
            this.rbtSetup,
            this.rbtReport});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(1008, 108);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 2;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Controls.Add(this.btnSupplier);
            this.ribbonPanel3.Controls.Add(this.btnCustomer);
            this.ribbonPanel3.Controls.Add(this.btnSystemsetting);
            this.ribbonPanel3.Controls.Add(this.btnUser);
            this.ribbonPanel3.Controls.Add(this.btnUnit);
            this.ribbonPanel3.Controls.Add(this.btnStock);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1008, 81);
            this.ribbonPanel3.TabIndex = 3;
            // 
            // btnSupplier
            // 
            this.btnSupplier.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSupplier.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Location = new System.Drawing.Point(403, 12);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(111, 53);
            this.btnSupplier.TabIndex = 11;
            this.btnSupplier.Text = "Supplier";
            // 
            // btnCustomer
            // 
            this.btnCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCustomer.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(268, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(110, 56);
            this.btnCustomer.TabIndex = 10;
            this.btnCustomer.Text = "Customer";
            // 
            // btnSystemsetting
            // 
            this.btnSystemsetting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSystemsetting.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnSystemsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemsetting.Image")));
            this.btnSystemsetting.Location = new System.Drawing.Point(730, 12);
            this.btnSystemsetting.Name = "btnSystemsetting";
            this.btnSystemsetting.Size = new System.Drawing.Size(135, 59);
            this.btnSystemsetting.TabIndex = 9;
            this.btnSystemsetting.Text = "System Setting";
            // 
            // btnUser
            // 
            this.btnUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUser.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(542, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(160, 59);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "User Management";
            this.btnUser.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUnit.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.Location = new System.Drawing.Point(147, 12);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(102, 56);
            this.btnUnit.TabIndex = 1;
            this.btnUnit.Text = "Unit";
            // 
            // btnStock
            // 
            this.btnStock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStock.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(12, 12);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(111, 56);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Stock";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.btnReturnIn);
            this.ribbonPanel1.Controls.Add(this.btnSaleOrder);
            this.ribbonPanel1.Controls.Add(this.btnSale);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1008, 81);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // btnReturnIn
            // 
            this.btnReturnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReturnIn.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnReturnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnIn.Location = new System.Drawing.Point(256, 16);
            this.btnReturnIn.Name = "btnReturnIn";
            this.btnReturnIn.Size = new System.Drawing.Size(97, 49);
            this.btnReturnIn.TabIndex = 2;
            this.btnReturnIn.Text = "Return In";
            // 
            // btnSaleOrder
            // 
            this.btnSaleOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaleOrder.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnSaleOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleOrder.Location = new System.Drawing.Point(135, 16);
            this.btnSaleOrder.Name = "btnSaleOrder";
            this.btnSaleOrder.Size = new System.Drawing.Size(93, 49);
            this.btnSaleOrder.TabIndex = 1;
            this.btnSaleOrder.Text = "Sale Order";
            // 
            // btnSale
            // 
            this.btnSale.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSale.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(8, 16);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(105, 49);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "Sale";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.btnReturnOut);
            this.ribbonPanel2.Controls.Add(this.btnPurchaseOrder);
            this.ribbonPanel2.Controls.Add(this.btnPurchase);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1008, 81);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // btnReturnOut
            // 
            this.btnReturnOut.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReturnOut.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnReturnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnOut.Location = new System.Drawing.Point(264, 12);
            this.btnReturnOut.Name = "btnReturnOut";
            this.btnReturnOut.Size = new System.Drawing.Size(106, 59);
            this.btnReturnOut.TabIndex = 2;
            this.btnReturnOut.Text = "Return Out";
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPurchaseOrder.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseOrder.Location = new System.Drawing.Point(138, 12);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Size = new System.Drawing.Size(111, 59);
            this.btnPurchaseOrder.TabIndex = 1;
            this.btnPurchaseOrder.Text = "Purchase Order";
            // 
            // btnPurchase
            // 
            this.btnPurchase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPurchase.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(12, 12);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(114, 59);
            this.btnPurchase.TabIndex = 0;
            this.btnPurchase.Text = "Purchase";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(1008, 81);
            this.ribbonPanel4.TabIndex = 4;
            this.ribbonPanel4.Visible = false;
            // 
            // rbtSale
            // 
            this.rbtSale.Name = "rbtSale";
            this.rbtSale.Panel = this.ribbonPanel1;
            this.rbtSale.Text = "Sale";
            // 
            // rbtPurchase
            // 
            this.rbtPurchase.Name = "rbtPurchase";
            this.rbtPurchase.Panel = this.ribbonPanel2;
            this.rbtPurchase.Text = "Purchase";
            // 
            // rbtSetup
            // 
            this.rbtSetup.Checked = true;
            this.rbtSetup.Name = "rbtSetup";
            this.rbtSetup.Panel = this.ribbonPanel3;
            this.rbtSetup.Text = "Setup";
            // 
            // rbtReport
            // 
            this.rbtReport.Name = "rbtReport";
            this.rbtReport.Panel = this.ribbonPanel4;
            this.rbtReport.Text = "Report";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 731);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.ButtonX btnSupplier;
        private DevComponents.DotNetBar.ButtonX btnCustomer;
        private DevComponents.DotNetBar.ButtonX btnSystemsetting;
        private DevComponents.DotNetBar.ButtonX btnUser;
        private DevComponents.DotNetBar.ButtonX btnUnit;
        private DevComponents.DotNetBar.ButtonX btnStock;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ButtonX btnReturnOut;
        private DevComponents.DotNetBar.ButtonX btnPurchaseOrder;
        private DevComponents.DotNetBar.ButtonX btnPurchase;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.ButtonX btnReturnIn;
        private DevComponents.DotNetBar.ButtonX btnSaleOrder;
        private DevComponents.DotNetBar.ButtonX btnSale;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonTabItem rbtSale;
        private DevComponents.DotNetBar.RibbonTabItem rbtPurchase;
        private DevComponents.DotNetBar.RibbonTabItem rbtSetup;
        private DevComponents.DotNetBar.RibbonTabItem rbtReport;
    }
}