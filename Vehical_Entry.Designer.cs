namespace Army_Vechical_Entry
{
    partial class Vehical_Entry
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_VNUMBER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_driver_CNIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_driver_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_No_of_P = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PNAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PCNIC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_VNUMBER
            // 
            this.txt_VNUMBER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_VNUMBER.Location = new System.Drawing.Point(105, 41);
            this.txt_VNUMBER.Name = "txt_VNUMBER";
            this.txt_VNUMBER.Size = new System.Drawing.Size(100, 20);
            this.txt_VNUMBER.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehical Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehical Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Driver CNIC";
            // 
            // txt_driver_CNIC
            // 
            this.txt_driver_CNIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_driver_CNIC.Location = new System.Drawing.Point(295, 79);
            this.txt_driver_CNIC.MaxLength = 13;
            this.txt_driver_CNIC.Name = "txt_driver_CNIC";
            this.txt_driver_CNIC.Size = new System.Drawing.Size(100, 20);
            this.txt_driver_CNIC.TabIndex = 3;
            this.txt_driver_CNIC.Leave += new System.EventHandler(this.txt_driver_CNIC_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Driver Name";
            // 
            // txt_driver_name
            // 
            this.txt_driver_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_driver_name.Location = new System.Drawing.Point(105, 79);
            this.txt_driver_name.Name = "txt_driver_name";
            this.txt_driver_name.Size = new System.Drawing.Size(100, 20);
            this.txt_driver_name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "No of Passengers";
            // 
            // txt_No_of_P
            // 
            this.txt_No_of_P.Location = new System.Drawing.Point(105, 123);
            this.txt_No_of_P.Name = "txt_No_of_P";
            this.txt_No_of_P.ReadOnly = true;
            this.txt_No_of_P.Size = new System.Drawing.Size(100, 20);
            this.txt_No_of_P.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // txt_PNAME
            // 
            this.txt_PNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PNAME.Location = new System.Drawing.Point(76, 47);
            this.txt_PNAME.Name = "txt_PNAME";
            this.txt_PNAME.Size = new System.Drawing.Size(100, 20);
            this.txt_PNAME.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CNIC";
            // 
            // txt_PCNIC
            // 
            this.txt_PCNIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PCNIC.Location = new System.Drawing.Point(266, 50);
            this.txt_PCNIC.MaxLength = 13;
            this.txt_PCNIC.Name = "txt_PCNIC";
            this.txt_PCNIC.Size = new System.Drawing.Size(100, 20);
            this.txt_PCNIC.TabIndex = 1;
            this.txt_PCNIC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PCNIC_KeyDown);
            this.txt_PCNIC.Leave += new System.EventHandler(this.txt_PCNIC_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_PNAME);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_PCNIC);
            this.groupBox1.Location = new System.Drawing.Point(28, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passengers Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txt_VNUMBER);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_No_of_P);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_driver_name);
            this.groupBox2.Controls.Add(this.txt_driver_CNIC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(28, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 182);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehical Information";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(492, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(267, 368);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Passengers Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Passangers CNIC";
            this.columnHeader3.Width = 150;
            // 
            // Vehical_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 498);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Vehical_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Vehical_Entry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_VNUMBER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_driver_CNIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_driver_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_No_of_P;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PNAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PCNIC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivercnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofpDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}