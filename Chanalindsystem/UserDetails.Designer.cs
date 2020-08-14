namespace Chanalindsystem
{
    partial class UserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new XanderUI.XUIButton();
            this.btnedit = new XanderUI.XUIButton();
            this.btnadd = new XanderUI.XUIButton();
            this.combotype = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new XanderUI.XUIButton();
            this.txtidserch = new System.Windows.Forms.TextBox();
            this.btnexit = new XanderUI.XUIButton();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnback = new XanderUI.XUIButton();
            this.btnclear = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1175, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.combotype);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttele);
            this.groupBox1.Controls.Add(this.txtpw);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 519);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User\'s Details";
            // 
            // btndelete
            // 
            this.btndelete.BackgroundColor = System.Drawing.Color.White;
            this.btndelete.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btndelete.ButtonImage")));
            this.btndelete.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btndelete.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.CornerRadius = 5;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btndelete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btndelete.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btndelete.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btndelete.Location = new System.Drawing.Point(185, 438);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(118, 42);
            this.btndelete.TabIndex = 47;
            this.btndelete.TextColor = System.Drawing.Color.Black;
            this.btndelete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackgroundColor = System.Drawing.Color.White;
            this.btnedit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnedit.ButtonImage")));
            this.btnedit.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnedit.ButtonText = "Update";
            this.btnedit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnedit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnedit.CornerRadius = 5;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnedit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnedit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnedit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnedit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnedit.Location = new System.Drawing.Point(309, 438);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(118, 42);
            this.btnedit.TabIndex = 46;
            this.btnedit.TextColor = System.Drawing.Color.Black;
            this.btnedit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundColor = System.Drawing.Color.White;
            this.btnadd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnadd.ButtonImage")));
            this.btnadd.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnadd.ButtonText = "Add New";
            this.btnadd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnadd.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.CornerRadius = 5;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnadd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnadd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnadd.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnadd.Location = new System.Drawing.Point(489, 25);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(124, 42);
            this.btnadd.TabIndex = 45;
            this.btnadd.TextColor = System.Drawing.Color.Black;
            this.btnadd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // combotype
            // 
            this.combotype.Enabled = false;
            this.combotype.FormattingEnabled = true;
            this.combotype.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Nurse",
            "Patient"});
            this.combotype.Location = new System.Drawing.Point(171, 65);
            this.combotype.Name = "combotype";
            this.combotype.Size = new System.Drawing.Size(272, 37);
            this.combotype.TabIndex = 44;
            //this.combotype.SelectedIndexChanged += new System.EventHandler(this.combotype_SelectedIndexChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(171, 398);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(272, 34);
            this.txtemail.TabIndex = 43;
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(171, 333);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(272, 34);
            this.txttele.TabIndex = 42;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(171, 265);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(272, 34);
            this.txtpw.TabIndex = 41;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(171, 138);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(272, 34);
            this.txtid.TabIndex = 40;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(171, 202);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(272, 34);
            this.txtname.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Telephone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "User Type";
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundColor = System.Drawing.Color.White;
            this.btnsearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.ButtonImage")));
            this.btnsearch.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnsearch.ButtonText = "Search";
            this.btnsearch.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnsearch.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.CornerRadius = 5;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnsearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnsearch.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnsearch.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnsearch.Location = new System.Drawing.Point(1063, 241);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(90, 28);
            this.btnsearch.TabIndex = 35;
            this.btnsearch.TextColor = System.Drawing.Color.Black;
            this.btnsearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtidserch
            // 
            this.txtidserch.Location = new System.Drawing.Point(843, 212);
            this.txtidserch.Name = "txtidserch";
            this.txtidserch.Size = new System.Drawing.Size(310, 22);
            this.txtidserch.TabIndex = 34;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnexit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnexit.ButtonImage")));
            this.btnexit.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnexit.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnexit.CornerRadius = 5;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnexit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnexit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnexit.Location = new System.Drawing.Point(1021, 640);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(132, 45);
            this.btnexit.TabIndex = 33;
            this.btnexit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnexit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dtgrid
            // 
            this.dtgrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Location = new System.Drawing.Point(658, 285);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.RowHeadersWidth = 51;
            this.dtgrid.RowTemplate.Height = 24;
            this.dtgrid.Size = new System.Drawing.Size(505, 337);
            this.dtgrid.TabIndex = 31;
            this.dtgrid.DataSourceChanged += new System.EventHandler(this.dtgrid_DataSourceChanged);
            this.dtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CellContentClick);
            this.dtgrid.Click += new System.EventHandler(this.dtgrid_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(705, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Number";
            // 
            // btnback
            // 
            this.btnback.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnback.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnback.ButtonImage")));
            this.btnback.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.btnback.ButtonText = "Back";
            this.btnback.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnback.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnback.CornerRadius = 5;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnback.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnback.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnback.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnback.Location = new System.Drawing.Point(882, 640);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(132, 45);
            this.btnback.TabIndex = 36;
            this.btnback.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnback.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackgroundColor = System.Drawing.Color.White;
            this.btnclear.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnclear.ButtonImage")));
            this.btnclear.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnclear.ButtonText = "Clear";
            this.btnclear.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnclear.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnclear.CornerRadius = 5;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnclear.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnclear.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnclear.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnclear.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnclear.Location = new System.Drawing.Point(967, 241);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(90, 28);
            this.btnclear.TabIndex = 37;
            this.btnclear.TextColor = System.Drawing.Color.Black;
            this.btnclear.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 698);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtidserch);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.Load += new System.EventHandler(this.UserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox combotype;
        private XanderUI.XUIButton btndelete;
        private XanderUI.XUIButton btnedit;
        private XanderUI.XUIButton btnadd;
        private XanderUI.XUIButton btnsearch;
        private System.Windows.Forms.TextBox txtidserch;
        private XanderUI.XUIButton btnexit;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIButton btnback;
        private XanderUI.XUIButton btnclear;
    }
}