namespace Chanalindsystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnlogin = new XanderUI.XUIButton();
            this.btnsign = new XanderUI.XUIButton();
            this.btnexit = new XanderUI.XUIButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackgroundColor = System.Drawing.Color.White;
            this.btnlogin.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.ButtonImage")));
            this.btnlogin.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.ClickBackColor = System.Drawing.Color.White;
            this.btnlogin.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnlogin.CornerRadius = 16;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnlogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnlogin.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnlogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnlogin.Location = new System.Drawing.Point(153, 197);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(240, 50);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.TextColor = System.Drawing.Color.Black;
            this.btnlogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnsign
            // 
            this.btnsign.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsign.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnsign.ButtonImage")));
            this.btnsign.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnsign.ButtonText = "Register";
            this.btnsign.ClickBackColor = System.Drawing.Color.Black;
            this.btnsign.ClickTextColor = System.Drawing.Color.Black;
            this.btnsign.CornerRadius = 5;
            this.btnsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsign.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnsign.HoverTextColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsign.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnsign.Location = new System.Drawing.Point(955, 549);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(195, 50);
            this.btnsign.TabIndex = 1;
            this.btnsign.TextColor = System.Drawing.Color.Black;
            this.btnsign.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnexit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnexit.ButtonImage")));
            this.btnexit.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.ClickBackColor = System.Drawing.Color.Black;
            this.btnexit.ClickTextColor = System.Drawing.Color.Black;
            this.btnexit.CornerRadius = 5;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnexit.HoverTextColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnexit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnexit.Location = new System.Drawing.Point(955, 623);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(195, 48);
            this.btnexit.TabIndex = 2;
            this.btnexit.TextColor = System.Drawing.Color.Black;
            this.btnexit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtname.Location = new System.Drawing.Point(153, 100);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(240, 38);
            this.txtname.TabIndex = 3;
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtpw.Location = new System.Drawing.Point(153, 153);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(240, 38);
            this.txtpw.TabIndex = 4;
            this.txtpw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(843, 728);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 67);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtpw);
            this.groupBox1.Location = new System.Drawing.Point(746, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 262);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1175, 708);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Login | Health Shield";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btnlogin;
        private XanderUI.XUIButton btnsign;
        private XanderUI.XUIButton btnexit;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

