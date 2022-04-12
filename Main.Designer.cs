
namespace Application_CW1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DateTimeL = new System.Windows.Forms.Label();
            this.entryL = new System.Windows.Forms.Label();
            this.visitorPanel = new System.Windows.Forms.Panel();
            this.entryPB = new System.Windows.Forms.PictureBox();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitL = new System.Windows.Forms.Label();
            this.ratePanel = new System.Windows.Forms.Panel();
            this.ratePB = new System.Windows.Forms.PictureBox();
            this.rateL = new System.Windows.Forms.Label();
            this.userL = new System.Windows.Forms.Label();
            this.exitB = new System.Windows.Forms.Button();
            this.aboutB = new System.Windows.Forms.Button();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.logInB = new System.Windows.Forms.Button();
            this.reportP = new System.Windows.Forms.Panel();
            this.reportPB = new System.Windows.Forms.PictureBox();
            this.reportL = new System.Windows.Forms.Label();
            this.DayL = new System.Windows.Forms.Label();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.visitorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryPB)).BeginInit();
            this.exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ratePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratePB)).BeginInit();
            this.reportP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DateTimeL
            // 
            this.DateTimeL.AutoSize = true;
            this.DateTimeL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeL.Location = new System.Drawing.Point(404, 13);
            this.DateTimeL.Name = "DateTimeL";
            this.DateTimeL.Size = new System.Drawing.Size(0, 15);
            this.DateTimeL.TabIndex = 4;
            // 
            // entryL
            // 
            this.entryL.AutoSize = true;
            this.entryL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.entryL.Location = new System.Drawing.Point(14, 4);
            this.entryL.Name = "entryL";
            this.entryL.Size = new System.Drawing.Size(134, 18);
            this.entryL.TabIndex = 5;
            this.entryL.Text = "Visitor Entry Form";
            this.entryL.Click += new System.EventHandler(this.label1_Click);
            // 
            // visitorPanel
            // 
            this.visitorPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.visitorPanel.Controls.Add(this.entryPB);
            this.visitorPanel.Controls.Add(this.entryL);
            this.visitorPanel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorPanel.Location = new System.Drawing.Point(701, 52);
            this.visitorPanel.Name = "visitorPanel";
            this.visitorPanel.Size = new System.Drawing.Size(167, 102);
            this.visitorPanel.TabIndex = 6;
            //this.visitorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.visitorPanel_Paint);
            // 
            // entryPB
            // 
            this.entryPB.Image = ((System.Drawing.Image)(resources.GetObject("entryPB.Image")));
            this.entryPB.Location = new System.Drawing.Point(48, 25);
            this.entryPB.Name = "entryPB";
            this.entryPB.Size = new System.Drawing.Size(65, 61);
            this.entryPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.entryPB.TabIndex = 7;
            this.entryPB.TabStop = false;
            this.entryPB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exitPanel
            // 
            this.exitPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitPanel.Controls.Add(this.pictureBox1);
            this.exitPanel.Controls.Add(this.exitL);
            this.exitPanel.Location = new System.Drawing.Point(701, 156);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(166, 121);
            this.exitPanel.TabIndex = 8;
           // this.exitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.exitPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // exitL
            // 
            this.exitL.AutoSize = true;
            this.exitL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitL.Location = new System.Drawing.Point(19, 9);
            this.exitL.Name = "exitL";
            this.exitL.Size = new System.Drawing.Size(135, 19);
            this.exitL.TabIndex = 5;
            this.exitL.Text = "Visitor Exit Form";
            this.exitL.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ratePanel
            // 
            this.ratePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ratePanel.Controls.Add(this.ratePB);
            this.ratePanel.Controls.Add(this.rateL);
            this.ratePanel.Location = new System.Drawing.Point(703, 281);
            this.ratePanel.Name = "ratePanel";
            this.ratePanel.Size = new System.Drawing.Size(164, 102);
            this.ratePanel.TabIndex = 9;
            this.ratePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ratePanel_Paint);
            // 
            // ratePB
            // 
            this.ratePB.Image = ((System.Drawing.Image)(resources.GetObject("ratePB.Image")));
            this.ratePB.Location = new System.Drawing.Point(46, 32);
            this.ratePB.Name = "ratePB";
            this.ratePB.Size = new System.Drawing.Size(73, 60);
            this.ratePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ratePB.TabIndex = 8;
            this.ratePB.TabStop = false;
            this.ratePB.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rateL
            // 
            this.rateL.AutoSize = true;
            this.rateL.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateL.ForeColor = System.Drawing.SystemColors.Control;
            this.rateL.Location = new System.Drawing.Point(17, 6);
            this.rateL.Name = "rateL";
            this.rateL.Size = new System.Drawing.Size(133, 23);
            this.rateL.TabIndex = 5;
            this.rateL.Text = "Veiw Ticket Rate";
            this.rateL.Click += new System.EventHandler(this.rateL_Click);
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.Location = new System.Drawing.Point(91, 18);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(44, 19);
            this.userL.TabIndex = 11;
            this.userL.Text = "Staff";
            //this.userL.Click += new System.EventHandler(this.userL_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.exitB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitB.Location = new System.Drawing.Point(789, 8);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(80, 32);
            this.exitB.TabIndex = 12;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // aboutB
            // 
            this.aboutB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.aboutB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutB.Location = new System.Drawing.Point(703, 8);
            this.aboutB.Name = "aboutB";
            this.aboutB.Size = new System.Drawing.Size(80, 32);
            this.aboutB.TabIndex = 13;
            this.aboutB.Text = "About";
            this.aboutB.UseVisualStyleBackColor = false;
            //this.aboutB.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Location = new System.Drawing.Point(228, 18);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(44, 19);
            this.DateTimeLabel.TabIndex = 14;
            this.DateTimeLabel.Text = "Date";
            //this.DateTimeLabel.Click += new System.EventHandler(this.DateTimeLabel_Click);
            // 
            // logInB
            // 
            this.logInB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.logInB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logInB.Location = new System.Drawing.Point(601, 8);
            this.logInB.Name = "logInB";
            this.logInB.Size = new System.Drawing.Size(96, 34);
            this.logInB.TabIndex = 15;
            this.logInB.Text = "Log In";
            this.logInB.UseVisualStyleBackColor = false;
            this.logInB.Click += new System.EventHandler(this.logInB_Click);
            // 
            // reportP
            // 
            this.reportP.BackColor = System.Drawing.Color.RoyalBlue;
            this.reportP.Controls.Add(this.reportPB);
            this.reportP.Controls.Add(this.reportL);
            this.reportP.Location = new System.Drawing.Point(703, 388);
            this.reportP.Name = "reportP";
            this.reportP.Size = new System.Drawing.Size(164, 110);
            this.reportP.TabIndex = 10;
            //this.reportP.Paint += new System.Windows.Forms.PaintEventHandler(this.reportP_Paint);
            // 
            // reportPB
            // 
            this.reportPB.Image = global::Application_CW1.Properties.Resources.report___Copy;
            this.reportPB.Location = new System.Drawing.Point(48, 31);
            this.reportPB.Name = "reportPB";
            this.reportPB.Size = new System.Drawing.Size(64, 69);
            this.reportPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportPB.TabIndex = 8;
            this.reportPB.TabStop = false;
            this.reportPB.Click += new System.EventHandler(this.reportPB_Click);
            // 
            // reportL
            // 
            this.reportL.AutoSize = true;
            this.reportL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportL.Location = new System.Drawing.Point(12, 9);
            this.reportL.Name = "reportL";
            this.reportL.Size = new System.Drawing.Size(134, 19);
            this.reportL.TabIndex = 5;
            this.reportL.Text = "Generate Report";
            this.reportL.Click += new System.EventHandler(this.reportL_Click);
            // 
            // DayL
            // 
            this.DayL.AutoSize = true;
            this.DayL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayL.Location = new System.Drawing.Point(474, 21);
            this.DayL.Name = "DayL";
            this.DayL.Size = new System.Drawing.Size(39, 19);
            this.DayL.TabIndex = 16;
            this.DayL.Text = "Day";
            // 
            // userPB
            // 
            this.userPB.Image = global::Application_CW1.Properties.Resources.users;
            this.userPB.Location = new System.Drawing.Point(12, 8);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(73, 34);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPB.TabIndex = 10;
            this.userPB.TabStop = false;
            //this.userPB.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // logoPB
            // 
            this.logoPB.Image = global::Application_CW1.Properties.Resources.backPic;
            this.logoPB.Location = new System.Drawing.Point(12, 67);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(674, 431);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 9;
            this.logoPB.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.DayL);
            this.Controls.Add(this.reportP);
            this.Controls.Add(this.logInB);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.aboutB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.ratePanel);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.exitPanel);
            this.Controls.Add(this.visitorPanel);
            this.Controls.Add(this.DateTimeL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.visitorPanel.ResumeLayout(false);
            this.visitorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryPB)).EndInit();
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ratePanel.ResumeLayout(false);
            this.ratePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratePB)).EndInit();
            this.reportP.ResumeLayout(false);
            this.reportP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DateTimeL;
        private System.Windows.Forms.Label entryL;
        private System.Windows.Forms.Panel visitorPanel;
        private System.Windows.Forms.PictureBox entryPB;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Label exitL;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Panel ratePanel;
        private System.Windows.Forms.Label rateL;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button aboutB;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.PictureBox ratePB;
        private System.Windows.Forms.Button logInB;
        private System.Windows.Forms.Panel reportP;
        private System.Windows.Forms.PictureBox reportPB;
        private System.Windows.Forms.Label reportL;
        private System.Windows.Forms.Label DayL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}