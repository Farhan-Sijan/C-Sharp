namespace Login
{
    partial class S1_Emp1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtMcustomer = new System.Windows.Forms.Button();
            this.Btlogout = new System.Windows.Forms.Button();
            this.BtMmenu = new System.Windows.Forms.Button();
            this.BtMorder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 725F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1277, 725);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BackgroundImage = global::Login.Properties.Resources._1768921233910;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(253, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 719);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._1768921580288;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtMcustomer);
            this.panel1.Controls.Add(this.Btlogout);
            this.panel1.Controls.Add(this.BtMmenu);
            this.panel1.Controls.Add(this.BtMorder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 719);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtMcustomer
            // 
            this.BtMcustomer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtMcustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMcustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMcustomer.Location = new System.Drawing.Point(22, 313);
            this.BtMcustomer.Name = "BtMcustomer";
            this.BtMcustomer.Size = new System.Drawing.Size(197, 62);
            this.BtMcustomer.TabIndex = 8;
            this.BtMcustomer.Text = "Manage Customer";
            this.BtMcustomer.UseVisualStyleBackColor = false;
            this.BtMcustomer.Click += new System.EventHandler(this.BtMOitem_Click);
            this.BtMcustomer.MouseLeave += new System.EventHandler(this.BtMcustomer_MouseLeave);
            this.BtMcustomer.MouseHover += new System.EventHandler(this.BtMcustomer_MouseHover);
            // 
            // Btlogout
            // 
            this.Btlogout.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btlogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btlogout.Location = new System.Drawing.Point(71, 626);
            this.Btlogout.Name = "Btlogout";
            this.Btlogout.Size = new System.Drawing.Size(90, 38);
            this.Btlogout.TabIndex = 6;
            this.Btlogout.Text = "Logout";
            this.Btlogout.UseVisualStyleBackColor = false;
            this.Btlogout.Click += new System.EventHandler(this.Btlogout_Click);
            this.Btlogout.MouseLeave += new System.EventHandler(this.Btlogout_MouseLeave);
            this.Btlogout.MouseHover += new System.EventHandler(this.Btlogout_MouseHover);
            // 
            // BtMmenu
            // 
            this.BtMmenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtMmenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMmenu.Location = new System.Drawing.Point(22, 211);
            this.BtMmenu.Name = "BtMmenu";
            this.BtMmenu.Size = new System.Drawing.Size(197, 64);
            this.BtMmenu.TabIndex = 7;
            this.BtMmenu.Text = "Manage Menu";
            this.BtMmenu.UseVisualStyleBackColor = false;
            this.BtMmenu.Click += new System.EventHandler(this.BtMmenu_Click);
            this.BtMmenu.MouseLeave += new System.EventHandler(this.BtMmenu_MouseLeave);
            this.BtMmenu.MouseHover += new System.EventHandler(this.BtMmenu_MouseHover);
            // 
            // BtMorder
            // 
            this.BtMorder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtMorder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtMorder.Location = new System.Drawing.Point(22, 111);
            this.BtMorder.Name = "BtMorder";
            this.BtMorder.Size = new System.Drawing.Size(197, 66);
            this.BtMorder.TabIndex = 5;
            this.BtMorder.Text = "Manage orders";
            this.BtMorder.UseVisualStyleBackColor = false;
            this.BtMorder.Click += new System.EventHandler(this.BtMorder_Click);
            this.BtMorder.MouseLeave += new System.EventHandler(this.BtMorder_MouseLeave);
            this.BtMorder.MouseHover += new System.EventHandler(this.BtMorder_MouseHover);
            // 
            // S1_Emp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 725);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "S1_Emp1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtMcustomer;
        private System.Windows.Forms.Button Btlogout;
        private System.Windows.Forms.Button BtMorder;
        private System.Windows.Forms.Button BtMmenu;
    }
}