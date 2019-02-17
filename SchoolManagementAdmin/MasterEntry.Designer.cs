namespace SATHOSA_ICS
{
    partial class frmMasterEntry
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOptionsMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblBusinessYear = new System.Windows.Forms.Label();
            this.cmbAcademicYear = new System.Windows.Forms.ComboBox();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.pnlRightOptions = new System.Windows.Forms.Panel();
            this.pnlRightMain = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.RightOptions = new System.Windows.Forms.Timer(this.components);
            this.Options = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlOptionsMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            this.pnlRightOptions.SuspendLayout();
            this.pnlRightMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "VISITORS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlOptionsMain
            // 
            this.pnlOptionsMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlOptionsMain.Controls.Add(this.panel3);
            this.pnlOptionsMain.Controls.Add(this.panel2);
            this.pnlOptionsMain.Controls.Add(this.panel1);
            this.pnlOptionsMain.Location = new System.Drawing.Point(3, 3);
            this.pnlOptionsMain.Name = "pnlOptionsMain";
            this.pnlOptionsMain.Size = new System.Drawing.Size(601, 86);
            this.pnlOptionsMain.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(430, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 73);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "COMPLAINTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(220, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 73);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "APPOINTMENTS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.Black;
            this.pnlOptions.Controls.Add(this.lblBusinessYear);
            this.pnlOptions.Controls.Add(this.cmbAcademicYear);
            this.pnlOptions.Controls.Add(this.pnlOptionsMain);
            this.pnlOptions.Controls.Add(this.pbHide);
            this.pnlOptions.ForeColor = System.Drawing.Color.Black;
            this.pnlOptions.Location = new System.Drawing.Point(0, 548);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(1021, 89);
            this.pnlOptions.TabIndex = 17;
            this.pnlOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOptions_Paint);
            // 
            // lblBusinessYear
            // 
            this.lblBusinessYear.AutoSize = true;
            this.lblBusinessYear.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessYear.ForeColor = System.Drawing.Color.White;
            this.lblBusinessYear.Location = new System.Drawing.Point(795, 11);
            this.lblBusinessYear.Name = "lblBusinessYear";
            this.lblBusinessYear.Size = new System.Drawing.Size(92, 19);
            this.lblBusinessYear.TabIndex = 17;
            this.lblBusinessYear.Text = "Business Year";
            this.lblBusinessYear.Click += new System.EventHandler(this.lblAcademicYear_Click);
            // 
            // cmbAcademicYear
            // 
            this.cmbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcademicYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcademicYear.FormattingEnabled = true;
            this.cmbAcademicYear.Location = new System.Drawing.Point(896, 8);
            this.cmbAcademicYear.Name = "cmbAcademicYear";
            this.cmbAcademicYear.Size = new System.Drawing.Size(84, 25);
            this.cmbAcademicYear.TabIndex = 16;
            this.cmbAcademicYear.Text = "2014-2015";
            // 
            // pbHide
            // 
            this.pbHide.BackgroundImage = global::SATHOSA_ICS.Properties.Resources.appbar_arrow_down;
            this.pbHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbHide.Location = new System.Drawing.Point(980, -3);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(40, 40);
            this.pbHide.TabIndex = 9;
            this.pbHide.TabStop = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // pnlRightOptions
            // 
            this.pnlRightOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlRightOptions.Controls.Add(this.pnlRightMain);
            this.pnlRightOptions.Location = new System.Drawing.Point(1026, -43);
            this.pnlRightOptions.Name = "pnlRightOptions";
            this.pnlRightOptions.Size = new System.Drawing.Size(77, 644);
            this.pnlRightOptions.TabIndex = 18;
            // 
            // pnlRightMain
            // 
            this.pnlRightMain.Controls.Add(this.pbExit);
            this.pnlRightMain.Controls.Add(this.pbHome);
            this.pnlRightMain.Controls.Add(this.pbLogout);
            this.pnlRightMain.Location = new System.Drawing.Point(3, 52);
            this.pnlRightMain.Name = "pnlRightMain";
            this.pnlRightMain.Size = new System.Drawing.Size(70, 396);
            this.pnlRightMain.TabIndex = 1;
            // 
            // pbExit
            // 
            this.pbExit.Image = global::SATHOSA_ICS.Properties.Resources.appbar_power;
            this.pbExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbExit.Location = new System.Drawing.Point(-3, 320);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(76, 76);
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbHome
            // 
            this.pbHome.Image = global::SATHOSA_ICS.Properties.Resources.appbar_home;
            this.pbHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbHome.Location = new System.Drawing.Point(-3, 160);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(76, 76);
            this.pbHome.TabIndex = 4;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::SATHOSA_ICS.Properties.Resources.appbar_lock;
            this.pbLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLogout.Location = new System.Drawing.Point(-3, 0);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(76, 76);
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            // 
            // RightOptions
            // 
            this.RightOptions.Interval = 1;
            this.RightOptions.Tick += new System.EventHandler(this.RightOptions_Tick);
            // 
            // Options
            // 
            this.Options.Interval = 1;
            this.Options.Tick += new System.EventHandler(this.Options_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.lblMainTitle);
            this.pnlMain.ForeColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 648);
            this.pnlMain.TabIndex = 16;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(12, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(157, 30);
            this.lblMainTitle.TabIndex = 3;
            this.lblMainTitle.Text = "SALES INVOICE";
            // 
            // frmMasterEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 648);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlRightOptions);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMasterEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlOptionsMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            this.pnlRightOptions.ResumeLayout(false);
            this.pnlRightMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOptionsMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlRightOptions;
        private System.Windows.Forms.Panel pnlRightMain;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Timer RightOptions;
        private System.Windows.Forms.Timer Options;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblBusinessYear;
        private System.Windows.Forms.ComboBox cmbAcademicYear;
    }
}