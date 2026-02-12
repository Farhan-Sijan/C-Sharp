namespace Login
{
    partial class S2_Emp3
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtBack = new System.Windows.Forms.Button();
            this.BtMcustomer = new System.Windows.Forms.Button();
            this.BtMorder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMenuid = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1392, 699);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(236, 103);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(903, 593);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MenuID";
            this.Column1.HeaderText = "MenuID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "FoodName";
            this.Column2.HeaderText = "FoodName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "CategoryName";
            this.Column4.HeaderText = "CatagoryName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AvailableQuantity";
            this.Column5.HeaderText = "AvailableQnY";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtBack);
            this.panel1.Controls.Add(this.BtMcustomer);
            this.panel1.Controls.Add(this.BtMorder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 593);
            this.panel1.TabIndex = 1;
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtBack.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtBack.Location = new System.Drawing.Point(60, 467);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(91, 41);
            this.BtBack.TabIndex = 7;
            this.BtBack.Text = "Back";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.button2_Click);
            this.BtBack.MouseLeave += new System.EventHandler(this.BtBack_MouseLeave);
            this.BtBack.MouseHover += new System.EventHandler(this.BtBack_MouseHover);
            // 
            // BtMcustomer
            // 
            this.BtMcustomer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtMcustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMcustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMcustomer.Location = new System.Drawing.Point(9, 190);
            this.BtMcustomer.Name = "BtMcustomer";
            this.BtMcustomer.Size = new System.Drawing.Size(199, 71);
            this.BtMcustomer.TabIndex = 9;
            this.BtMcustomer.Text = "Manage Customer";
            this.BtMcustomer.UseVisualStyleBackColor = false;
            this.BtMcustomer.Click += new System.EventHandler(this.BtMcustomer_Click);
            // 
            // BtMorder
            // 
            this.BtMorder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtMorder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMorder.Location = new System.Drawing.Point(9, 84);
            this.BtMorder.Name = "BtMorder";
            this.BtMorder.Size = new System.Drawing.Size(199, 76);
            this.BtMorder.TabIndex = 6;
            this.BtMorder.Text = "Manage Orders";
            this.BtMorder.UseVisualStyleBackColor = false;
            this.BtMorder.Click += new System.EventHandler(this.BtMorder_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 94);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtSave);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbCatagory);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.txtMenuid);
            this.panel3.Controls.Add(this.txtFood);
            this.panel3.Controls.Add(this.txtprice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1145, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 593);
            this.panel3.TabIndex = 3;
            // 
            // BtSave
            // 
            this.BtSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtSave.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSave.Location = new System.Drawing.Point(82, 504);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(92, 31);
            this.BtSave.TabIndex = 4;
            this.BtSave.Text = "Save ";
            this.BtSave.UseVisualStyleBackColor = false;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            this.BtSave.MouseLeave += new System.EventHandler(this.BtSave_MouseLeave_1);
            this.BtSave.MouseHover += new System.EventHandler(this.BtSave_MouseHover_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(17, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Food Name";
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(18, 435);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(210, 24);
            this.cmbCatagory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(17, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(17, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Catagory";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(17, 356);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(211, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtMenuid
            // 
            this.txtMenuid.Location = new System.Drawing.Point(21, 84);
            this.txtMenuid.Name = "txtMenuid";
            this.txtMenuid.ReadOnly = true;
            this.txtMenuid.Size = new System.Drawing.Size(211, 22);
            this.txtMenuid.TabIndex = 1;
            this.txtMenuid.Text = "AG";
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(17, 179);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(211, 22);
            this.txtFood.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(17, 263);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(211, 22);
            this.txtprice.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.BtRefresh);
            this.panel5.Controls.Add(this.btDelete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(236, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(903, 94);
            this.panel5.TabIndex = 4;
            // 
            // BtRefresh
            // 
            this.BtRefresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtRefresh.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtRefresh.Location = new System.Drawing.Point(60, 37);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(101, 35);
            this.BtRefresh.TabIndex = 5;
            this.BtRefresh.Text = "Refresh";
            this.BtRefresh.UseVisualStyleBackColor = false;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            this.BtRefresh.MouseLeave += new System.EventHandler(this.BtRefresh_MouseLeave_1);
            this.BtRefresh.MouseHover += new System.EventHandler(this.BtRefresh_MouseHover_1);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDelete.Location = new System.Drawing.Point(187, 37);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(98, 32);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            this.btDelete.MouseLeave += new System.EventHandler(this.btDelete_MouseLeave_1);
            this.btDelete.MouseHover += new System.EventHandler(this.btDelete_MouseHover_1);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btNew);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1145, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 94);
            this.panel4.TabIndex = 5;
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btNew.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNew.Location = new System.Drawing.Point(68, 34);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(116, 35);
            this.btNew.TabIndex = 2;
            this.btNew.Text = "+ New ";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            this.btNew.MouseLeave += new System.EventHandler(this.btNew_MouseLeave);
            this.btNew.MouseHover += new System.EventHandler(this.btNew_MouseHover);
            // 
            // S2_Emp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "S2_Emp3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Menu";
            this.Load += new System.EventHandler(this.S2_Emp3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.TextBox txtMenuid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtRefresh;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtMorder;
        private System.Windows.Forms.Button BtMcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}