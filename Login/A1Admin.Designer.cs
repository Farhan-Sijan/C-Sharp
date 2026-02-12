namespace Login
{
    partial class A1Admin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refreshbt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvgEMP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ADMINbutton1 = new System.Windows.Forms.Button();
            this.CAtEGORYbutton3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Savebt = new System.Windows.Forms.Button();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textRole = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEMP = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Deletebt = new System.Windows.Forms.Button();
            this.Newbt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEMP)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1469, 708);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Refreshbt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 114);
            this.panel1.TabIndex = 0;
            // 
            // Refreshbt
            // 
            this.Refreshbt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Refreshbt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refreshbt.Location = new System.Drawing.Point(50, 65);
            this.Refreshbt.Name = "Refreshbt";
            this.Refreshbt.Size = new System.Drawing.Size(97, 27);
            this.Refreshbt.TabIndex = 11;
            this.Refreshbt.Text = "Refresh";
            this.Refreshbt.UseVisualStyleBackColor = false;
            this.Refreshbt.Click += new System.EventHandler(this.Refreshbt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dvgEMP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 582);
            this.panel2.TabIndex = 1;
            // 
            // dvgEMP
            // 
            this.dvgEMP.AllowUserToAddRows = false;
            this.dvgEMP.AllowUserToDeleteRows = false;
            this.dvgEMP.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dvgEMP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dvgEMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgEMP.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dvgEMP.Location = new System.Drawing.Point(0, 0);
            this.dvgEMP.Name = "dvgEMP";
            this.dvgEMP.ReadOnly = true;
            this.dvgEMP.RowHeadersWidth = 51;
            this.dvgEMP.RowTemplate.Height = 24;
            this.dvgEMP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEMP.Size = new System.Drawing.Size(991, 580);
            this.dvgEMP.TabIndex = 0;
            this.dvgEMP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEMP_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "EmpID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "Contact no.";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UserType";
            this.Column5.HeaderText = "Role";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Salary";
            this.Column6.HeaderText = "Salary";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ADMINbutton1);
            this.panel3.Controls.Add(this.CAtEGORYbutton3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 582);
            this.panel3.TabIndex = 2;
            // 
            // ADMINbutton1
            // 
            this.ADMINbutton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ADMINbutton1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADMINbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ADMINbutton1.Location = new System.Drawing.Point(21, 164);
            this.ADMINbutton1.Name = "ADMINbutton1";
            this.ADMINbutton1.Size = new System.Drawing.Size(148, 40);
            this.ADMINbutton1.TabIndex = 6;
            this.ADMINbutton1.Text = "Home";
            this.ADMINbutton1.UseVisualStyleBackColor = false;
            this.ADMINbutton1.Click += new System.EventHandler(this.HOMEbutton1_Click);
            // 
            // CAtEGORYbutton3
            // 
            this.CAtEGORYbutton3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CAtEGORYbutton3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAtEGORYbutton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CAtEGORYbutton3.Location = new System.Drawing.Point(21, 235);
            this.CAtEGORYbutton3.Name = "CAtEGORYbutton3";
            this.CAtEGORYbutton3.Size = new System.Drawing.Size(148, 67);
            this.CAtEGORYbutton3.TabIndex = 8;
            this.CAtEGORYbutton3.Text = "Category Informations";
            this.CAtEGORYbutton3.UseVisualStyleBackColor = false;
            this.CAtEGORYbutton3.Click += new System.EventHandler(this.CAtEGORYbutton3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(203, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(993, 114);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(353, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Informations";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.Savebt);
            this.panel6.Controls.Add(this.textSalary);
            this.panel6.Controls.Add(this.textRole);
            this.panel6.Controls.Add(this.textEmail);
            this.panel6.Controls.Add(this.textContact);
            this.panel6.Controls.Add(this.textName);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textEMP);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1202, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 582);
            this.panel6.TabIndex = 5;
            // 
            // Savebt
            // 
            this.Savebt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Savebt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Savebt.Location = new System.Drawing.Point(85, 515);
            this.Savebt.Name = "Savebt";
            this.Savebt.Size = new System.Drawing.Size(97, 27);
            this.Savebt.TabIndex = 14;
            this.Savebt.Text = "Save";
            this.Savebt.UseVisualStyleBackColor = false;
            this.Savebt.Click += new System.EventHandler(this.Savebt_Click);
            this.Savebt.MouseLeave += new System.EventHandler(this.Savebt_MouseLeave);
            this.Savebt.MouseHover += new System.EventHandler(this.Savebt_MouseHover);
            // 
            // textSalary
            // 
            this.textSalary.BackColor = System.Drawing.Color.Ivory;
            this.textSalary.Location = new System.Drawing.Point(23, 466);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(218, 22);
            this.textSalary.TabIndex = 11;
            // 
            // textRole
            // 
            this.textRole.BackColor = System.Drawing.Color.Ivory;
            this.textRole.Location = new System.Drawing.Point(23, 379);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(218, 22);
            this.textRole.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Ivory;
            this.textEmail.Location = new System.Drawing.Point(23, 295);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(218, 22);
            this.textEmail.TabIndex = 9;
            // 
            // textContact
            // 
            this.textContact.BackColor = System.Drawing.Color.Ivory;
            this.textContact.Location = new System.Drawing.Point(23, 205);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(218, 22);
            this.textContact.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Ivory;
            this.textName.Location = new System.Drawing.Point(23, 120);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(218, 22);
            this.textName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MistyRose;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(19, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(19, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(19, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact no.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp ID:";
            // 
            // textEMP
            // 
            this.textEMP.BackColor = System.Drawing.Color.Ivory;
            this.textEMP.Location = new System.Drawing.Point(23, 38);
            this.textEMP.Name = "textEMP";
            this.textEMP.ReadOnly = true;
            this.textEMP.Size = new System.Drawing.Size(218, 22);
            this.textEMP.TabIndex = 0;
            this.textEMP.Text = "Auto Generated";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Deletebt);
            this.panel5.Controls.Add(this.Newbt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1202, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 114);
            this.panel5.TabIndex = 6;
            // 
            // Deletebt
            // 
            this.Deletebt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Deletebt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deletebt.Location = new System.Drawing.Point(144, 65);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(97, 27);
            this.Deletebt.TabIndex = 12;
            this.Deletebt.Text = "Delete";
            this.Deletebt.UseVisualStyleBackColor = false;
            this.Deletebt.Click += new System.EventHandler(this.Deletebt_Click);
            // 
            // Newbt
            // 
            this.Newbt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Newbt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Newbt.Location = new System.Drawing.Point(23, 65);
            this.Newbt.Name = "Newbt";
            this.Newbt.Size = new System.Drawing.Size(97, 27);
            this.Newbt.TabIndex = 13;
            this.Newbt.Text = "New";
            this.Newbt.UseVisualStyleBackColor = false;
            this.Newbt.Click += new System.EventHandler(this.Newbt_Click);
            // 
            // A1Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 708);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "A1Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.Load += new System.EventHandler(this.A1Admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEMP)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CAtEGORYbutton3;
        private System.Windows.Forms.Button ADMINbutton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dvgEMP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Refreshbt;
        private System.Windows.Forms.Button Newbt;
        private System.Windows.Forms.Button Deletebt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEMP;
        private System.Windows.Forms.Button Savebt;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}