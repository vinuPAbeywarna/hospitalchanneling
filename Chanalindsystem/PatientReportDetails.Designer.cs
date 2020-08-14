namespace Chanalindsystem
{
    partial class PatientReportDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientReportDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rpid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.details = new System.Windows.Forms.TextBox();
            this.dnames = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.pids = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnexit = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton5 = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rpid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.xuiButton3);
            this.groupBox1.Controls.Add(this.xuiButton2);
            this.groupBox1.Controls.Add(this.xuiButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.details);
            this.groupBox1.Controls.Add(this.dnames);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.pids);
            this.groupBox1.Controls.Add(this.pname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 522);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient\'s Report Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rpid
            // 
            this.rpid.Location = new System.Drawing.Point(203, 42);
            this.rpid.Name = "rpid";
            this.rpid.Size = new System.Drawing.Size(342, 30);
            this.rpid.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Reporters ID";
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton3.ButtonText = "Delete";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(551, 106);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(93, 54);
            this.xuiButton3.TabIndex = 31;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton2.ButtonImage")));
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton2.ButtonText = "Edit";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton2.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton2.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(551, 42);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(93, 58);
            this.xuiButton2.TabIndex = 30;
            this.xuiButton2.TextColor = System.Drawing.Color.Black;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton1.ButtonText = "Add";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(203, 400);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(342, 56);
            this.xuiButton1.TabIndex = 29;
            this.xuiButton1.TextColor = System.Drawing.Color.Black;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID Number";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(203, 328);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(342, 30);
            this.date.TabIndex = 27;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(203, 186);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(342, 136);
            this.details.TabIndex = 26;
            // 
            // dnames
            // 
            this.dnames.Location = new System.Drawing.Point(203, 364);
            this.dnames.Name = "dnames";
            this.dnames.Size = new System.Drawing.Size(342, 30);
            this.dnames.TabIndex = 20;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(203, 150);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(342, 30);
            this.tel.TabIndex = 19;
            // 
            // pids
            // 
            this.pids.Location = new System.Drawing.Point(203, 114);
            this.pids.Name = "pids";
            this.pids.Size = new System.Drawing.Size(342, 30);
            this.pids.TabIndex = 18;
            this.pids.TextChanged += new System.EventHandler(this.pids_TextChanged);
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(203, 78);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(342, 30);
            this.pname.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Docter Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Report Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Telephone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = " Name";
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(668, 206);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(505, 429);
            this.dg.TabIndex = 3;
            this.dg.Click += new System.EventHandler(this.dg_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnexit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnexit.ButtonImage")));
            this.btnexit.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.btnexit.ButtonText = "Close";
            this.btnexit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnexit.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnexit.CornerRadius = 5;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnexit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnexit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnexit.Location = new System.Drawing.Point(1031, 641);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(132, 45);
            this.btnexit.TabIndex = 28;
            this.btnexit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnexit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Patient ID";
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchbox.Location = new System.Drawing.Point(797, 164);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(165, 30);
            this.searchbox.TabIndex = 29;
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton4.ButtonImage")));
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton4.ButtonText = "Search";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton4.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton4.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(968, 164);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(104, 34);
            this.xuiButton4.TabIndex = 30;
            this.xuiButton4.TextColor = System.Drawing.Color.Black;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.Click += new System.EventHandler(this.xuiButton4_Click);
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton5.ButtonImage")));
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton5.ButtonText = "Clear";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiButton5.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiButton5.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(1078, 164);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(85, 34);
            this.xuiButton5.TabIndex = 31;
            this.xuiButton5.TextColor = System.Drawing.Color.Black;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.Click += new System.EventHandler(this.xuiButton5_Click);
            // 
            // PatientReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 698);
            this.Controls.Add(this.xuiButton5);
            this.Controls.Add(this.xuiButton4);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "PatientReportDetails";
            this.Text = "PatientReportDetails";
            this.Load += new System.EventHandler(this.PatientReportDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg;
        private XanderUI.XUIButton btnexit;
        private System.Windows.Forms.TextBox dnames;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox pids;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton4;
        private XanderUI.XUIButton xuiButton5;
        private System.Windows.Forms.TextBox rpid;
        private System.Windows.Forms.Label label8;
    }
}