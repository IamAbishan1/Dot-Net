
namespace Application_CW1
{
    partial class TicketRateDisplay
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
            this.ticketRateGV = new System.Windows.Forms.DataGridView();
            this.UpdateRate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userL = new System.Windows.Forms.Label();
            this.logInB = new System.Windows.Forms.Button();
            this.weekB = new System.Windows.Forms.Button();
            this.ticketRateTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.finishB = new System.Windows.Forms.Button();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketRateGV)).BeginInit();
            this.ticketRateTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketRateGV
            // 
            this.ticketRateGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketRateGV.Location = new System.Drawing.Point(92, 125);
            this.ticketRateGV.Name = "ticketRateGV";
            this.ticketRateGV.Size = new System.Drawing.Size(685, 262);
            this.ticketRateGV.TabIndex = 1;
            this.ticketRateGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketRateGV_CellContentClick);
            // 
            // UpdateRate
            // 
            this.UpdateRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRate.Location = new System.Drawing.Point(676, 402);
            this.UpdateRate.Name = "UpdateRate";
            this.UpdateRate.Size = new System.Drawing.Size(103, 23);
            this.UpdateRate.TabIndex = 2;
            this.UpdateRate.Text = "Update Rate";
            this.UpdateRate.UseVisualStyleBackColor = true;
            this.UpdateRate.Click += new System.EventHandler(this.UpdateRate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(146, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(544, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "The Amusement Park";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.Location = new System.Drawing.Point(89, 28);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(51, 15);
            this.userL.TabIndex = 27;
            this.userL.Text = "Staff";
            // 
            // logInB
            // 
            this.logInB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInB.Location = new System.Drawing.Point(702, 18);
            this.logInB.Name = "logInB";
            this.logInB.Size = new System.Drawing.Size(75, 23);
            this.logInB.TabIndex = 25;
            this.logInB.Text = "Log In";
            this.logInB.UseVisualStyleBackColor = true;
            this.logInB.Click += new System.EventHandler(this.logInB_Click);
            // 
            // weekB
            // 
            this.weekB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekB.Location = new System.Drawing.Point(786, 18);
            this.weekB.Name = "weekB";
            this.weekB.Size = new System.Drawing.Size(97, 23);
            this.weekB.TabIndex = 24;
            this.weekB.Text = "WeekDay";
            this.weekB.UseVisualStyleBackColor = true;
            // 
            // ticketRateTitle
            // 
            this.ticketRateTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ticketRateTitle.Controls.Add(this.label1);
            this.ticketRateTitle.Location = new System.Drawing.Point(12, 72);
            this.ticketRateTitle.Name = "ticketRateTitle";
            this.ticketRateTitle.Size = new System.Drawing.Size(860, 47);
            this.ticketRateTitle.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(315, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ticket Rate For Today";
            // 
            // finishB
            // 
            this.finishB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishB.Location = new System.Drawing.Point(92, 402);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(103, 23);
            this.finishB.TabIndex = 30;
            this.finishB.Text = "Finish";
            this.finishB.UseVisualStyleBackColor = true;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // userPB
            // 
            this.userPB.Image = global::Application_CW1.Properties.Resources.users;
            this.userPB.Location = new System.Drawing.Point(10, 18);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(73, 34);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPB.TabIndex = 26;
            this.userPB.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(501, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "View Weekend Rate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(245, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "View Weekday Rate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TicketRateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.ticketRateTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.logInB);
            this.Controls.Add(this.weekB);
            this.Controls.Add(this.UpdateRate);
            this.Controls.Add(this.ticketRateGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.Name = "TicketRateDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketRateDisplay";
            this.Load += new System.EventHandler(this.TicketRateDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketRateGV)).EndInit();
            this.ticketRateTitle.ResumeLayout(false);
            this.ticketRateTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ticketRateGV;
        private System.Windows.Forms.Button UpdateRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Button logInB;
        private System.Windows.Forms.Button weekB;
        private System.Windows.Forms.Panel ticketRateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}