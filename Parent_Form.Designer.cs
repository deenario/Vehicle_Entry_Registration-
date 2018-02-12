namespace Army_Vechical_Entry
{
    partial class Parent_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicalEntryOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripSheetPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripSheetVehicalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripSheetVehicalsSpecificDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripSheetVouchersGeneratedByOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vouchersGeneratedOnThisLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripSheetCompanionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicalTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.adminControlsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.vehicalEntryOnlyToolStripMenuItem,
            this.passengerEntryToolStripMenuItem,
            this.personEntryToolStripMenuItem});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newEntryToolStripMenuItem.Text = "New Receipt";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // vehicalEntryOnlyToolStripMenuItem
            // 
            this.vehicalEntryOnlyToolStripMenuItem.Name = "vehicalEntryOnlyToolStripMenuItem";
            this.vehicalEntryOnlyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.vehicalEntryOnlyToolStripMenuItem.Text = "Vehical Entry";
            this.vehicalEntryOnlyToolStripMenuItem.Click += new System.EventHandler(this.vehicalEntryOnlyToolStripMenuItem_Click);
            // 
            // passengerEntryToolStripMenuItem
            // 
            this.passengerEntryToolStripMenuItem.Name = "passengerEntryToolStripMenuItem";
            this.passengerEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.passengerEntryToolStripMenuItem.Text = "Passenger Entry";
            this.passengerEntryToolStripMenuItem.Click += new System.EventHandler(this.passengerEntryToolStripMenuItem_Click);
            // 
            // personEntryToolStripMenuItem
            // 
            this.personEntryToolStripMenuItem.Name = "personEntryToolStripMenuItem";
            this.personEntryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.personEntryToolStripMenuItem.Text = "Person Entry";
            this.personEntryToolStripMenuItem.Click += new System.EventHandler(this.personEntryToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personSearchToolStripMenuItem,
            this.tripSheetPassengersToolStripMenuItem,
            this.tripSheetVehicalsToolStripMenuItem,
            this.tripSheetVehicalsSpecificDateToolStripMenuItem,
            this.tripSheetVouchersGeneratedByOPToolStripMenuItem,
            this.vouchersGeneratedOnThisLocationToolStripMenuItem,
            this.tripSheetCompanionsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // personSearchToolStripMenuItem
            // 
            this.personSearchToolStripMenuItem.Name = "personSearchToolStripMenuItem";
            this.personSearchToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.personSearchToolStripMenuItem.Text = "Person Search";
            this.personSearchToolStripMenuItem.Click += new System.EventHandler(this.personSearchToolStripMenuItem_Click);
            // 
            // tripSheetPassengersToolStripMenuItem
            // 
            this.tripSheetPassengersToolStripMenuItem.Name = "tripSheetPassengersToolStripMenuItem";
            this.tripSheetPassengersToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.tripSheetPassengersToolStripMenuItem.Text = "Trip Sheet Passengers";
            this.tripSheetPassengersToolStripMenuItem.Click += new System.EventHandler(this.tripSheetPassengersToolStripMenuItem_Click);
            // 
            // tripSheetVehicalsToolStripMenuItem
            // 
            this.tripSheetVehicalsToolStripMenuItem.Name = "tripSheetVehicalsToolStripMenuItem";
            this.tripSheetVehicalsToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.tripSheetVehicalsToolStripMenuItem.Text = "Trip Sheet Vehicals";
            this.tripSheetVehicalsToolStripMenuItem.Click += new System.EventHandler(this.tripSheetVehicalsToolStripMenuItem_Click);
            // 
            // tripSheetVehicalsSpecificDateToolStripMenuItem
            // 
            this.tripSheetVehicalsSpecificDateToolStripMenuItem.Name = "tripSheetVehicalsSpecificDateToolStripMenuItem";
            this.tripSheetVehicalsSpecificDateToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.tripSheetVehicalsSpecificDateToolStripMenuItem.Text = "Trip Sheet Vehicals Specific Date";
            this.tripSheetVehicalsSpecificDateToolStripMenuItem.Click += new System.EventHandler(this.tripSheetVehicalsSpecificDateToolStripMenuItem_Click);
            // 
            // tripSheetVouchersGeneratedByOPToolStripMenuItem
            // 
            this.tripSheetVouchersGeneratedByOPToolStripMenuItem.Name = "tripSheetVouchersGeneratedByOPToolStripMenuItem";
            this.tripSheetVouchersGeneratedByOPToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.tripSheetVouchersGeneratedByOPToolStripMenuItem.Text = "Trip Sheet Vouchers Generated By OP";
            this.tripSheetVouchersGeneratedByOPToolStripMenuItem.Click += new System.EventHandler(this.tripSheetVouchersGeneratedByOPToolStripMenuItem_Click);
            // 
            // vouchersGeneratedOnThisLocationToolStripMenuItem
            // 
            this.vouchersGeneratedOnThisLocationToolStripMenuItem.Name = "vouchersGeneratedOnThisLocationToolStripMenuItem";
            this.vouchersGeneratedOnThisLocationToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.vouchersGeneratedOnThisLocationToolStripMenuItem.Text = "Vouchers Generated On This Location";
            this.vouchersGeneratedOnThisLocationToolStripMenuItem.Click += new System.EventHandler(this.vouchersGeneratedOnThisLocationToolStripMenuItem_Click);
            // 
            // tripSheetCompanionsToolStripMenuItem
            // 
            this.tripSheetCompanionsToolStripMenuItem.Name = "tripSheetCompanionsToolStripMenuItem";
            this.tripSheetCompanionsToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.tripSheetCompanionsToolStripMenuItem.Text = "Trip Sheet Companions";
            this.tripSheetCompanionsToolStripMenuItem.Click += new System.EventHandler(this.tripSheetCompanionsToolStripMenuItem_Click);
            // 
            // adminControlsToolStripMenuItem
            // 
            this.adminControlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewAccountsToolStripMenuItem});
            this.adminControlsToolStripMenuItem.Name = "adminControlsToolStripMenuItem";
            this.adminControlsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adminControlsToolStripMenuItem.Text = "Admin Controls";
            // 
            // createNewAccountsToolStripMenuItem
            // 
            this.createNewAccountsToolStripMenuItem.Name = "createNewAccountsToolStripMenuItem";
            this.createNewAccountsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createNewAccountsToolStripMenuItem.Text = "Create New Accounts";
            this.createNewAccountsToolStripMenuItem.Click += new System.EventHandler(this.createNewAccountsToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConnectionToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.vehicalTypeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // databaseConnectionToolStripMenuItem
            // 
            this.databaseConnectionToolStripMenuItem.Name = "databaseConnectionToolStripMenuItem";
            this.databaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.databaseConnectionToolStripMenuItem.Text = "Database Connection";
            this.databaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.databaseConnectionToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // vehicalTypeToolStripMenuItem
            // 
            this.vehicalTypeToolStripMenuItem.Name = "vehicalTypeToolStripMenuItem";
            this.vehicalTypeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.vehicalTypeToolStripMenuItem.Text = "Vehical Type";
            this.vehicalTypeToolStripMenuItem.Click += new System.EventHandler(this.vehicalTypeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "LOGIN ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(157, 122);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(225, 20);
            this.txtbox_password.TabIndex = 8;
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(157, 95);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(225, 20);
            this.txtbox_username.TabIndex = 7;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(413, 84);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(154, 75);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbox_username);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbox_password);
            this.groupBox1.Location = new System.Drawing.Point(17, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 211);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG IN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Welcome: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "______";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(777, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "_________";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Counter:";
            // 
            // Parent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 448);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Parent Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Parent_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicalEntryOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengerEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripSheetPassengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripSheetVehicalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripSheetVehicalsSpecificDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripSheetVouchersGeneratedByOPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vouchersGeneratedOnThisLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAccountsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicalTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripSheetCompanionsToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}