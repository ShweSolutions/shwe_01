namespace ShweStock
{
    partial class ucUserMgrSetup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserMgrSetup));
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.cbbUserRole = new MTGCComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Rest = new DevComponents.DotNetBar.ButtonX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl_Remark = new System.Windows.Forms.Label();
            this.lbl_BedTypeName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxUserList = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.gbxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbxUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUser
            // 
            this.gbxUser.BackColor = System.Drawing.Color.Thistle;
            this.gbxUser.Controls.Add(this.cbbUserRole);
            this.gbxUser.Controls.Add(this.label1);
            this.gbxUser.Controls.Add(this.btn_Rest);
            this.gbxUser.Controls.Add(this.btn_Save);
            this.gbxUser.Controls.Add(this.txtPassword);
            this.gbxUser.Controls.Add(this.lbl_Remark);
            this.gbxUser.Controls.Add(this.lbl_BedTypeName);
            this.gbxUser.Controls.Add(this.txtUserName);
            this.gbxUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxUser.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUser.Location = new System.Drawing.Point(0, 0);
            this.gbxUser.Name = "gbxUser";
            this.gbxUser.Size = new System.Drawing.Size(1008, 302);
            this.gbxUser.TabIndex = 10;
            this.gbxUser.TabStop = false;
            this.gbxUser.Text = "User Information";
            // 
            // cbbUserRole
            // 
            this.cbbUserRole.ArrowBoxColor = System.Drawing.Color.Plum;
            this.cbbUserRole.ArrowColor = System.Drawing.Color.Black;
            this.cbbUserRole.BackColor = System.Drawing.Color.Thistle;
            this.cbbUserRole.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbbUserRole.BindedControl")));
            this.cbbUserRole.BorderStyle = MTGCComboBox.TipiBordi.FlatXP;
            this.cbbUserRole.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbbUserRole.ColumnNum = 1;
            this.cbbUserRole.ColumnWidth = "121";
            this.cbbUserRole.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbbUserRole.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbbUserRole.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbbUserRole.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbbUserRole.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbbUserRole.DisplayMember = "Text";
            this.cbbUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbUserRole.DropDownArrowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(169)))), ((int)(((byte)(223)))));
            this.cbbUserRole.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbbUserRole.DropDownForeColor = System.Drawing.Color.Black;
            this.cbbUserRole.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbbUserRole.DropDownWidth = 140;
            this.cbbUserRole.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUserRole.GridLineColor = System.Drawing.Color.LightGray;
            this.cbbUserRole.GridLineHorizontal = false;
            this.cbbUserRole.GridLineVertical = false;
            this.cbbUserRole.HighlightBorderColor = System.Drawing.Color.Blue;
            this.cbbUserRole.HighlightBorderOnMouseEvents = true;
            this.cbbUserRole.ItemHeight = 20;
            this.cbbUserRole.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbbUserRole.Location = new System.Drawing.Point(135, 143);
            this.cbbUserRole.ManagingFastMouseMoving = true;
            this.cbbUserRole.ManagingFastMouseMovingInterval = 30;
            this.cbbUserRole.Name = "cbbUserRole";
            this.cbbUserRole.NormalBorderColor = System.Drawing.Color.Black;
            this.cbbUserRole.SelectedItem = null;
            this.cbbUserRole.SelectedValue = null;
            this.cbbUserRole.Size = new System.Drawing.Size(218, 26);
            this.cbbUserRole.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 496;
            this.label1.Text = "User Role";
            // 
            // btn_Rest
            // 
            this.btn_Rest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Rest.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btn_Rest.Image = global::ShweStock.Properties.Resources.delete;
            this.btn_Rest.Location = new System.Drawing.Point(235, 203);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(75, 43);
            this.btn_Rest.TabIndex = 4;
            this.btn_Rest.Text = "Reset";
            this.btn_Rest.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_Rest.Click += new System.EventHandler(this.btn_Rest_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btn_Save.Image = global::ShweStock.Properties.Resources.Save;
            this.btn_Save.Location = new System.Drawing.Point(135, 203);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(80, 43);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 91);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(218, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // lbl_Remark
            // 
            this.lbl_Remark.AutoSize = true;
            this.lbl_Remark.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remark.Location = new System.Drawing.Point(60, 94);
            this.lbl_Remark.Name = "lbl_Remark";
            this.lbl_Remark.Size = new System.Drawing.Size(60, 20);
            this.lbl_Remark.TabIndex = 495;
            this.lbl_Remark.Text = "Password";
            // 
            // lbl_BedTypeName
            // 
            this.lbl_BedTypeName.AutoSize = true;
            this.lbl_BedTypeName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BedTypeName.Location = new System.Drawing.Point(61, 43);
            this.lbl_BedTypeName.Name = "lbl_BedTypeName";
            this.lbl_BedTypeName.Size = new System.Drawing.Size(68, 20);
            this.lbl_BedTypeName.TabIndex = 493;
            this.lbl_BedTypeName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(135, 36);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(218, 27);
            this.txtUserName.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbxUserList
            // 
            this.gbxUserList.Controls.Add(this.dgvUser);
            this.gbxUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUserList.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUserList.Location = new System.Drawing.Point(0, 302);
            this.gbxUserList.Name = "gbxUserList";
            this.gbxUserList.Size = new System.Drawing.Size(1008, 321);
            this.gbxUserList.TabIndex = 559;
            this.gbxUserList.TabStop = false;
            this.gbxUserList.Text = "User List";
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(3, 21);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(1002, 297);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellDoubleClick);
            // 
            // ucUserMgrSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.gbxUserList);
            this.Controls.Add(this.gbxUser);
            this.Name = "ucUserMgrSetup";
            this.Size = new System.Drawing.Size(1008, 623);
            this.gbxUser.ResumeLayout(false);
            this.gbxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbxUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUser;
        private MTGCComboBox cbbUserRole;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btn_Rest;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl_Remark;
        private System.Windows.Forms.Label lbl_BedTypeName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbxUserList;
        private System.Windows.Forms.DataGridView dgvUser;
    }
}
