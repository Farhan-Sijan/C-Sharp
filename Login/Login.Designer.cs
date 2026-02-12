namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btlogin = new System.Windows.Forms.Button();
            this.btsign = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btspass = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources._998907335dc3f2f66180a6239565dd9b;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btlogin);
            this.panel1.Controls.Add(this.btsign);
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.btlogin, "btlogin");
            this.btlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btlogin.Name = "btlogin";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            this.btlogin.MouseLeave += new System.EventHandler(this.btlogin_MouseLeave);
            this.btlogin.MouseHover += new System.EventHandler(this.btlogin_MouseHover);
            // 
            // btsign
            // 
            this.btsign.BackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.btsign, "btsign");
            this.btsign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsign.Name = "btsign";
            this.btsign.UseVisualStyleBackColor = false;
            this.btsign.Click += new System.EventHandler(this.btsign_Click);
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.btexit, "btexit");
            this.btexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btexit.Name = "btexit";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            this.btexit.MouseLeave += new System.EventHandler(this.btexit_MouseLeave);
            this.btexit.MouseHover += new System.EventHandler(this.btexit_MouseHover);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Login.Properties.Resources._1768921580288;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btspass);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.txtmail);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btspass
            // 
            this.btspass.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btspass, "btspass");
            this.btspass.ForeColor = System.Drawing.Color.Transparent;
            this.btspass.Name = "btspass";
            this.btspass.UseVisualStyleBackColor = false;
            this.btspass.MouseLeave += new System.EventHandler(this.btspass_MouseLeave);
            this.btspass.MouseHover += new System.EventHandler(this.btspass_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtpassword
            // 
            resources.ApplyResources(this.txtpassword, "txtpassword");
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtmail
            // 
            resources.ApplyResources(this.txtmail, "txtmail");
            this.txtmail.Name = "txtmail";
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Name = "label1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btsign;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btspass;
    }
}

