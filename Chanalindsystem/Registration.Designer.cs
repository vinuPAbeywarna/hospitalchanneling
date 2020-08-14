namespace Chanalindsystem
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsign = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnback = new XanderUI.XUIButton();
            this.btnexit = new XanderUI.XUIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.doccharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.catcombo = new System.Windows.Forms.ComboBox();
            this.docs = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.docs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(226, 347);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(505, 22);
            this.txtid.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(226, 394);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(505, 22);
            this.txtname.TabIndex = 3;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(226, 446);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(505, 22);
            this.txtpw.TabIndex = 4;
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(226, 500);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(505, 22);
            this.txttele.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(226, 557);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(505, 22);
            this.txtemail.TabIndex = 6;
            // 
            // combotype
            // 
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse",
            "Patient"});
            this.combotype.Location = new System.Drawing.Point(226, 195);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(505, 24);
            this.combotype.TabIndex = 7;
            this.combotype.SelectedIndexChanged += new System.EventHandler(this.combotype_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telephone No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // btnsign
            // 
            this.btnsign.BackgroundColor = System.Drawing.Color.White;
            this.btnsign.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnsign.ButtonImage")));
            this.btnsign.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnsign.ButtonText = "Register";
            this.btnsign.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnsign.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnsign.CornerRadius = 5;
            this.btnsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnsign.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsign.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnsign.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnsign.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnsign.Location = new System.Drawing.Point(549, 613);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(195, 50);
            this.btnsign.TabIndex = 14;
            this.btnsign.TextColor = System.Drawing.Color.Black;
            this.btnsign.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(750, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 383);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnback.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnback.ButtonImage")));
            this.btnback.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnback.ButtonText = "Back";
            this.btnback.ClickBackColor = System.Drawing.Color.Black;
            this.btnback.ClickTextColor = System.Drawing.Color.Black;
            this.btnback.CornerRadius = 5;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnback.HoverBackgroundColor = System.Drawing.Color.Black;
            this.btnback.HoverTextColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnback.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnback.Location = new System.Drawing.Point(819, 636);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(169, 50);
            this.btnback.TabIndex = 28;
            this.btnback.TextColor = System.Drawing.Color.Black;
            this.btnback.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
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
            this.btnexit.Location = new System.Drawing.Point(994, 636);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(169, 50);
            this.btnexit.TabIndex = 26;
            this.btnexit.TextColor = System.Drawing.Color.Black;
            this.btnexit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 26);
            this.label7.TabIndex = 30;
            this.label7.Text = "Charge";
            // 
            // doccharge
            // 
            this.doccharge.Location = new System.Drawing.Point(134, 64);
            this.doccharge.Name = "doccharge";
            this.doccharge.Size = new System.Drawing.Size(505, 22);
            this.doccharge.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Catagory";
            // 
            // catcombo
            // 
            this.catcombo.FormattingEnabled = true;
            this.catcombo.Location = new System.Drawing.Point(134, 21);
            this.catcombo.Name = "catcombo";
            this.catcombo.Size = new System.Drawing.Size(505, 24);
            this.catcombo.TabIndex = 31;
            // 
            // docs
            // 
            this.docs.Controls.Add(this.catcombo);
            this.docs.Controls.Add(this.label8);
            this.docs.Controls.Add(this.doccharge);
            this.docs.Controls.Add(this.label7);
            this.docs.Location = new System.Drawing.Point(92, 225);
            this.docs.Name = "docs";
            this.docs.Size = new System.Drawing.Size(652, 100);
            this.docs.TabIndex = 33;
            this.docs.TabStop = false;
            this.docs.Text = "Doctors";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1175, 698);
            this.Controls.Add(this.docs);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combotype);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.docs.ResumeLayout(false);
            this.docs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox combotype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUIButton btnsign;
        private System.Windows.Forms.PictureBox pictureBox2;
        private XanderUI.XUIButton btnback;
        private XanderUI.XUIButton btnexit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doccharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox catcombo;
        private System.Windows.Forms.GroupBox docs;
    }
}