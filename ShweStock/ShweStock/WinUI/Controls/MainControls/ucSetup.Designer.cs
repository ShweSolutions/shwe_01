namespace ShweStock
{
    partial class ucSetup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnUserMgr = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserMgr)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnUserMgr);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(244, 740);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnUserMgr
            // 
            this.btnUserMgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserMgr.DirtyPaletteCounter = 864;
            this.btnUserMgr.Location = new System.Drawing.Point(13, 11);
            this.btnUserMgr.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btnUserMgr.Name = "btnUserMgr";
            this.btnUserMgr.OverrideDefault.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnUserMgr.OverrideDefault.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUserMgr.OverrideFocus.Back.Color1 = System.Drawing.Color.Khaki;
            this.btnUserMgr.OverrideFocus.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUserMgr.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnUserMgr.Size = new System.Drawing.Size(225, 43);
            this.btnUserMgr.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btnUserMgr.StateCommon.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btnUserMgr.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btnUserMgr.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMgr.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnUserMgr.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnUserMgr.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMgr.StateNormal.Back.Color1 = System.Drawing.Color.Coral;
            this.btnUserMgr.StateNormal.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnUserMgr.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnUserMgr.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnUserMgr.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnUserMgr.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btnUserMgr.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btnUserMgr.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnUserMgr.TabIndex = 34;
            this.btnUserMgr.Text = "User Management";
            this.btnUserMgr.Values.ExtraText = "";
            this.btnUserMgr.Values.Image = null;
            this.btnUserMgr.Values.ImageStates.ImageCheckedNormal = null;
            this.btnUserMgr.Values.ImageStates.ImageCheckedPressed = null;
            this.btnUserMgr.Values.ImageStates.ImageCheckedTracking = null;
            this.btnUserMgr.Values.Text = "User Management";
            this.btnUserMgr.Click += new System.EventHandler(this.btnUserMgr_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Thistle;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(244, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(756, 740);
            this.pnlMain.TabIndex = 1;
            // 
            // ucSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ucSetup";
            this.Size = new System.Drawing.Size(1000, 740);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnUserMgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUserMgr;
        private System.Windows.Forms.Panel pnlMain;
    }
}
