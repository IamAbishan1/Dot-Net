
namespace Application_CW1
{
    partial class VisitorExit
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
            this.ExitIdL = new System.Windows.Forms.Label();
            this.exitNUD = new System.Windows.Forms.NumericUpDown();
            this.SearchB = new System.Windows.Forms.Button();
            this.ExitTimeL = new System.Windows.Forms.Label();
            this.EntryTimeL = new System.Windows.Forms.Label();
            this.ExitCountL = new System.Windows.Forms.Label();
            this.ExitTypeL = new System.Windows.Forms.Label();
            this.DurationL = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.exitEntryTimeTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.exitTimeTB = new System.Windows.Forms.TextBox();
            this.exitTypeTB = new System.Windows.Forms.TextBox();
            this.logInB = new System.Windows.Forms.Button();
            this.weekB = new System.Windows.Forms.Button();
            this.userL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmB = new System.Windows.Forms.Button();
            this.exitCountTB = new System.Windows.Forms.TextBox();
            this.exitTitleL = new System.Windows.Forms.Label();
            this.finishB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitNUD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitIdL
            // 
            this.ExitIdL.AutoSize = true;
            this.ExitIdL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitIdL.Location = new System.Drawing.Point(19, 45);
            this.ExitIdL.Name = "ExitIdL";
            this.ExitIdL.Size = new System.Drawing.Size(48, 13);
            this.ExitIdL.TabIndex = 0;
            this.ExitIdL.Text = "User Id";
            // 
            // exitNUD
            // 
            this.exitNUD.Location = new System.Drawing.Point(73, 42);
            this.exitNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.exitNUD.Name = "exitNUD";
            this.exitNUD.Size = new System.Drawing.Size(75, 20);
            this.exitNUD.TabIndex = 2;
            this.exitNUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Lime;
            this.SearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB.Location = new System.Drawing.Point(169, 37);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 30);
            this.SearchB.TabIndex = 3;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitTimeL
            // 
            this.ExitTimeL.AutoSize = true;
            this.ExitTimeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTimeL.Location = new System.Drawing.Point(19, 176);
            this.ExitTimeL.Name = "ExitTimeL";
            this.ExitTimeL.Size = new System.Drawing.Size(59, 13);
            this.ExitTimeL.TabIndex = 4;
            this.ExitTimeL.Text = "Exit Time";
            // 
            // EntryTimeL
            // 
            this.EntryTimeL.AutoSize = true;
            this.EntryTimeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryTimeL.Location = new System.Drawing.Point(19, 141);
            this.EntryTimeL.Name = "EntryTimeL";
            this.EntryTimeL.Size = new System.Drawing.Size(67, 13);
            this.EntryTimeL.TabIndex = 5;
            this.EntryTimeL.Text = "Entry Time";
            // 
            // ExitCountL
            // 
            this.ExitCountL.AutoSize = true;
            this.ExitCountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCountL.Location = new System.Drawing.Point(19, 108);
            this.ExitCountL.Name = "ExitCountL";
            this.ExitCountL.Size = new System.Drawing.Size(40, 13);
            this.ExitCountL.TabIndex = 6;
            this.ExitCountL.Text = "Count";
            // 
            // ExitTypeL
            // 
            this.ExitTypeL.AutoSize = true;
            this.ExitTypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitTypeL.Location = new System.Drawing.Point(19, 75);
            this.ExitTypeL.Name = "ExitTypeL";
            this.ExitTypeL.Size = new System.Drawing.Size(35, 13);
            this.ExitTypeL.TabIndex = 7;
            this.ExitTypeL.Text = "Type";
            // 
            // DurationL
            // 
            this.DurationL.AutoSize = true;
            this.DurationL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationL.Location = new System.Drawing.Point(19, 211);
            this.DurationL.Name = "DurationL";
            this.DurationL.Size = new System.Drawing.Size(55, 13);
            this.DurationL.TabIndex = 8;
            this.DurationL.Text = "Duration";
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceL.Location = new System.Drawing.Point(19, 242);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(36, 13);
            this.PriceL.TabIndex = 9;
            this.PriceL.Text = "Price";
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(19, 279);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // exitEntryTimeTB
            // 
            this.exitEntryTimeTB.Location = new System.Drawing.Point(92, 141);
            this.exitEntryTimeTB.Name = "exitEntryTimeTB";
            this.exitEntryTimeTB.Size = new System.Drawing.Size(130, 20);
            this.exitEntryTimeTB.TabIndex = 12;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(92, 235);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(130, 20);
            this.priceTB.TabIndex = 13;
            // 
            // durationTB
            // 
            this.durationTB.Location = new System.Drawing.Point(92, 204);
            this.durationTB.Name = "durationTB";
            this.durationTB.Size = new System.Drawing.Size(130, 20);
            this.durationTB.TabIndex = 14;
            // 
            // exitTimeTB
            // 
            this.exitTimeTB.Location = new System.Drawing.Point(92, 173);
            this.exitTimeTB.Name = "exitTimeTB";
            this.exitTimeTB.Size = new System.Drawing.Size(130, 20);
            this.exitTimeTB.TabIndex = 15;
            // 
            // exitTypeTB
            // 
            this.exitTypeTB.Location = new System.Drawing.Point(73, 75);
            this.exitTypeTB.Name = "exitTypeTB";
            this.exitTypeTB.Size = new System.Drawing.Size(92, 20);
            this.exitTypeTB.TabIndex = 16;
            // 
            // logInB
            // 
            this.logInB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInB.Location = new System.Drawing.Point(708, 15);
            this.logInB.Name = "logInB";
            this.logInB.Size = new System.Drawing.Size(75, 23);
            this.logInB.TabIndex = 18;
            this.logInB.Text = "Log In";
            this.logInB.UseVisualStyleBackColor = true;
            this.logInB.Click += new System.EventHandler(this.logInB_Click);
            // 
            // weekB
            // 
            this.weekB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekB.Location = new System.Drawing.Point(791, 15);
            this.weekB.Name = "weekB";
            this.weekB.Size = new System.Drawing.Size(97, 23);
            this.weekB.TabIndex = 17;
            this.weekB.Text = "WeekDay";
            this.weekB.UseVisualStyleBackColor = true;
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.Location = new System.Drawing.Point(93, 25);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(51, 15);
            this.userL.TabIndex = 20;
            this.userL.Text = "Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.confirmB);
            this.panel1.Controls.Add(this.exitCountTB);
            this.panel1.Controls.Add(this.exitTitleL);
            this.panel1.Controls.Add(this.ExitIdL);
            this.panel1.Controls.Add(this.exitNUD);
            this.panel1.Controls.Add(this.SearchB);
            this.panel1.Controls.Add(this.ExitTimeL);
            this.panel1.Controls.Add(this.exitTypeTB);
            this.panel1.Controls.Add(this.EntryTimeL);
            this.panel1.Controls.Add(this.exitTimeTB);
            this.panel1.Controls.Add(this.ExitCountL);
            this.panel1.Controls.Add(this.durationTB);
            this.panel1.Controls.Add(this.ExitTypeL);
            this.panel1.Controls.Add(this.priceTB);
            this.panel1.Controls.Add(this.DurationL);
            this.panel1.Controls.Add(this.exitEntryTimeTB);
            this.panel1.Controls.Add(this.PriceL);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(23, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 331);
            this.panel1.TabIndex = 21;
            // 
            // confirmB
            // 
            this.confirmB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmB.Location = new System.Drawing.Point(158, 279);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(119, 23);
            this.confirmB.TabIndex = 19;
            this.confirmB.Text = "Confirm Exit";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // exitCountTB
            // 
            this.exitCountTB.Location = new System.Drawing.Point(73, 105);
            this.exitCountTB.Name = "exitCountTB";
            this.exitCountTB.Size = new System.Drawing.Size(100, 20);
            this.exitCountTB.TabIndex = 18;
            // 
            // exitTitleL
            // 
            this.exitTitleL.AutoSize = true;
            this.exitTitleL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitTitleL.Location = new System.Drawing.Point(130, 12);
            this.exitTitleL.Name = "exitTitleL";
            this.exitTitleL.Size = new System.Drawing.Size(72, 16);
            this.exitTitleL.TabIndex = 17;
            this.exitTitleL.Text = "Exit Form";
            // 
            // finishB
            // 
            this.finishB.BackColor = System.Drawing.Color.Blue;
            this.finishB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishB.ForeColor = System.Drawing.Color.White;
            this.finishB.Location = new System.Drawing.Point(23, 403);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(75, 29);
            this.finishB.TabIndex = 19;
            this.finishB.Text = "Finish";
            this.finishB.UseVisualStyleBackColor = false;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(150, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(544, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "The Amusement Park";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Application_CW1.Properties.Resources.gif;
            this.pictureBox1.Location = new System.Drawing.Point(341, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // userPB
            // 
            this.userPB.Image = global::Application_CW1.Properties.Resources.users;
            this.userPB.Location = new System.Drawing.Point(14, 15);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(73, 34);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPB.TabIndex = 19;
            this.userPB.TabStop = false;
            // 
            // VisitorExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.logInB);
            this.Controls.Add(this.weekB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.Name = "VisitorExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitorExit";
            this.Load += new System.EventHandler(this.VisitorExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitNUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitIdL;
        private System.Windows.Forms.NumericUpDown exitNUD;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label ExitTimeL;
        private System.Windows.Forms.Label EntryTimeL;
        private System.Windows.Forms.Label ExitCountL;
        private System.Windows.Forms.Label ExitTypeL;
        private System.Windows.Forms.Label DurationL;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox exitEntryTimeTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.TextBox exitTimeTB;
        private System.Windows.Forms.TextBox exitTypeTB;
        private System.Windows.Forms.Button logInB;
        private System.Windows.Forms.Button weekB;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitTitleL;
        private System.Windows.Forms.TextBox exitCountTB;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirmB;
    }
}