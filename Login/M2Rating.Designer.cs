namespace Login
{
    partial class M2Rating
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
            this.label1 = new System.Windows.Forms.Label();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.cmbOid = new System.Windows.Forms.ComboBox();
            this.btRating = new System.Windows.Forms.Button();
            this.btMail = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.dgvCusid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRstar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRating = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 642);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btRefresh);
            this.panel1.Controls.Add(this.btNew);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rating";
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRefresh.Location = new System.Drawing.Point(431, 6);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(118, 32);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btNew.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNew.Location = new System.Drawing.Point(166, 7);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(95, 32);
            this.btNew.TabIndex = 6;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelete.Location = new System.Drawing.Point(292, 7);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(105, 32);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(943, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 44);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btSave);
            this.panel4.Controls.Add(this.cmbOid);
            this.panel4.Controls.Add(this.btRating);
            this.panel4.Controls.Add(this.btMail);
            this.panel4.Controls.Add(this.txtMail);
            this.panel4.Controls.Add(this.dgvCusid);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtRstar);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.rtxtComment);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtCid);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtRid);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(943, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 586);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSave.Location = new System.Drawing.Point(27, 521);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(90, 32);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cmbOid
            // 
            this.cmbOid.BackColor = System.Drawing.Color.Ivory;
            this.cmbOid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOid.FormattingEnabled = true;
            this.cmbOid.Location = new System.Drawing.Point(13, 294);
            this.cmbOid.Name = "cmbOid";
            this.cmbOid.Size = new System.Drawing.Size(258, 24);
            this.cmbOid.TabIndex = 25;
            // 
            // btRating
            // 
            this.btRating.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btRating.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRating.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRating.Location = new System.Drawing.Point(194, 74);
            this.btRating.Name = "btRating";
            this.btRating.Size = new System.Drawing.Size(78, 50);
            this.btRating.TabIndex = 24;
            this.btRating.Text = "Show Rating";
            this.btRating.UseVisualStyleBackColor = false;
            this.btRating.Click += new System.EventHandler(this.btRating_Click);
            // 
            // btMail
            // 
            this.btMail.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btMail.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMail.Location = new System.Drawing.Point(207, 8);
            this.btMail.Name = "btMail";
            this.btMail.Size = new System.Drawing.Size(75, 23);
            this.btMail.TabIndex = 23;
            this.btMail.Text = "Click";
            this.btMail.UseVisualStyleBackColor = false;
            this.btMail.Click += new System.EventHandler(this.btMail_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Ivory;
            this.txtMail.Location = new System.Drawing.Point(76, 9);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 22);
            this.txtMail.TabIndex = 22;
            // 
            // dgvCusid
            // 
            this.dgvCusid.AllowUserToAddRows = false;
            this.dgvCusid.AllowUserToDeleteRows = false;
            this.dgvCusid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvCusid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvCusid.Location = new System.Drawing.Point(3, 46);
            this.dgvCusid.Name = "dgvCusid";
            this.dgvCusid.ReadOnly = true;
            this.dgvCusid.RowHeadersWidth = 51;
            this.dgvCusid.RowTemplate.Height = 24;
            this.dgvCusid.Size = new System.Drawing.Size(185, 88);
            this.dgvCusid.TabIndex = 21;
            this.dgvCusid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusid_CellClick);
            this.dgvCusid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCusid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MistyRose;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email:";
            // 
            // txtRstar
            // 
            this.txtRstar.BackColor = System.Drawing.Color.Ivory;
            this.txtRstar.Location = new System.Drawing.Point(14, 356);
            this.txtRstar.Name = "txtRstar";
            this.txtRstar.Size = new System.Drawing.Size(265, 22);
            this.txtRstar.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(7, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rating Satrs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(10, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Order ID:";
            // 
            // rtxtComment
            // 
            this.rtxtComment.BackColor = System.Drawing.Color.Ivory;
            this.rtxtComment.Location = new System.Drawing.Point(14, 415);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(265, 69);
            this.rtxtComment.TabIndex = 14;
            this.rtxtComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(7, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Comment:";
            // 
            // txtCid
            // 
            this.txtCid.BackColor = System.Drawing.Color.Ivory;
            this.txtCid.Location = new System.Drawing.Point(14, 234);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(261, 22);
            this.txtCid.TabIndex = 12;
            this.txtCid.Text = "Auto Fill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer ID:";
            // 
            // txtRid
            // 
            this.txtRid.BackColor = System.Drawing.Color.Ivory;
            this.txtRid.Location = new System.Drawing.Point(13, 171);
            this.txtRid.Name = "txtRid";
            this.txtRid.Size = new System.Drawing.Size(261, 22);
            this.txtRid.TabIndex = 10;
            this.txtRid.Text = "Auto Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rating ID:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(194, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvRating);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 586);
            this.panel2.TabIndex = 4;
            // 
            // dgvRating
            // 
            this.dgvRating.AllowUserToAddRows = false;
            this.dgvRating.AllowUserToDeleteRows = false;
            this.dgvRating.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRating.Location = new System.Drawing.Point(0, 0);
            this.dgvRating.Name = "dgvRating";
            this.dgvRating.ReadOnly = true;
            this.dgvRating.RowHeadersWidth = 51;
            this.dgvRating.RowTemplate.Height = 24;
            this.dgvRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRating.Size = new System.Drawing.Size(934, 586);
            this.dgvRating.TabIndex = 0;
            this.dgvRating.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRating_CellClick_1);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RatingID";
            this.Column2.HeaderText = "Rating ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CustomerID";
            this.Column3.HeaderText = "Customer ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "OrderID";
            this.Column4.HeaderText = "Order ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RatingStars";
            this.Column5.HeaderText = "Rating Stars";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Comment";
            this.Column6.HeaderText = "Comment";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // M2Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "M2Rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvCusid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRstar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btRating;
        private System.Windows.Forms.Button btMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRating;
        private System.Windows.Forms.ComboBox cmbOid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}