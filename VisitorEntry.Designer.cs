
namespace Application_CW1
{
    partial class VisitorEntry
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
            this.entryL = new System.Windows.Forms.Label();
            this.IdL = new System.Windows.Forms.Label();
            this.visitorTypeCB = new System.Windows.Forms.ComboBox();
            this.countNUP = new System.Windows.Forms.NumericUpDown();
            this.TypeL = new System.Windows.Forms.Label();
            this.CountL = new System.Windows.Forms.Label();
            this.visitorListGrid = new System.Windows.Forms.DataGridView();
            this.entryB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeInL = new System.Windows.Forms.Label();
            this.timeInTB = new System.Windows.Forms.TextBox();
            this.visitorListL = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.userL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title1L = new System.Windows.Forms.Label();
            this.logInB = new System.Windows.Forms.Button();
            this.weekB = new System.Windows.Forms.Button();
            this.userPB = new System.Windows.Forms.PictureBox();
            this.titleB = new System.Windows.Forms.Button();
            this.serializationB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            this.SuspendLayout();
            // 
            // entryL
            // 
            this.entryL.AutoSize = true;
            this.entryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryL.Location = new System.Drawing.Point(13, 56);
            this.entryL.Name = "entryL";
            this.entryL.Size = new System.Drawing.Size(51, 13);
            this.entryL.TabIndex = 0;
            this.entryL.Text = "Entry Id";
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdL.Location = new System.Drawing.Point(76, 56);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(14, 13);
            this.IdL.TabIndex = 1;
            this.IdL.Text = "0";
            //this.IdL.Click += new System.EventHandler(this.label2_Click);
            // 
            // visitorTypeCB
            // 
            this.visitorTypeCB.FormattingEnabled = true;
            this.visitorTypeCB.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group of 5",
            "Group of 10",
            "Group of 25"});
            this.visitorTypeCB.Location = new System.Drawing.Point(74, 79);
            this.visitorTypeCB.Name = "visitorTypeCB";
            this.visitorTypeCB.Size = new System.Drawing.Size(152, 21);
            this.visitorTypeCB.TabIndex = 2;
            // 
            // countNUP
            // 
            this.countNUP.Location = new System.Drawing.Point(75, 114);
            this.countNUP.Name = "countNUP";
            this.countNUP.Size = new System.Drawing.Size(152, 20);
            this.countNUP.TabIndex = 3;
            // 
            // TypeL
            // 
            this.TypeL.AutoSize = true;
            this.TypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeL.Location = new System.Drawing.Point(13, 87);
            this.TypeL.Name = "TypeL";
            this.TypeL.Size = new System.Drawing.Size(35, 13);
            this.TypeL.TabIndex = 4;
            this.TypeL.Text = "Type";
            // 
            // CountL
            // 
            this.CountL.AutoSize = true;
            this.CountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountL.Location = new System.Drawing.Point(13, 121);
            this.CountL.Name = "CountL";
            this.CountL.Size = new System.Drawing.Size(40, 13);
            this.CountL.TabIndex = 5;
            this.CountL.Text = "Count";
            // 
            // visitorListGrid
            // 
            this.visitorListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorListGrid.Location = new System.Drawing.Point(272, 49);
            this.visitorListGrid.Name = "visitorListGrid";
            this.visitorListGrid.Size = new System.Drawing.Size(616, 423);
            this.visitorListGrid.TabIndex = 6;
            this.visitorListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // entryB
            // 
            this.entryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryB.Location = new System.Drawing.Point(16, 190);
            this.entryB.Name = "entryB";
            this.entryB.Size = new System.Drawing.Size(105, 26);
            this.entryB.TabIndex = 7;
            this.entryB.Text = "Make Entry";
            this.entryB.UseVisualStyleBackColor = true;
            this.entryB.Click += new System.EventHandler(this.entryB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            //this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // timeInL
            // 
            this.timeInL.AutoSize = true;
            this.timeInL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInL.Location = new System.Drawing.Point(13, 154);
            this.timeInL.Name = "timeInL";
            this.timeInL.Size = new System.Drawing.Size(45, 13);
            this.timeInL.TabIndex = 10;
            this.timeInL.Text = "TimeIn";
            // 
            // timeInTB
            // 
            this.timeInTB.Location = new System.Drawing.Point(75, 151);
            this.timeInTB.Name = "timeInTB";
            this.timeInTB.Size = new System.Drawing.Size(151, 20);
            this.timeInTB.TabIndex = 11;
           // this.timeInTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // visitorListL
            // 
            this.visitorListL.AutoSize = true;
            this.visitorListL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.visitorListL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorListL.Location = new System.Drawing.Point(518, 21);
            this.visitorListL.Name = "visitorListL";
            this.visitorListL.Size = new System.Drawing.Size(95, 15);
            this.visitorListL.TabIndex = 12;
            this.visitorListL.Text = "Visitor List";
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.MediumBlue;
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.Location = new System.Drawing.Point(12, 379);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(84, 25);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userL.Location = new System.Drawing.Point(101, 19);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(51, 15);
            this.userL.TabIndex = 15;
            this.userL.Text = "Staff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.title1L);
            this.panel1.Controls.Add(this.countNUP);
            this.panel1.Controls.Add(this.entryL);
            this.panel1.Controls.Add(this.IdL);
            this.panel1.Controls.Add(this.visitorTypeCB);
            this.panel1.Controls.Add(this.TypeL);
            this.panel1.Controls.Add(this.timeInTB);
            this.panel1.Controls.Add(this.entryB);
            this.panel1.Controls.Add(this.CountL);
            this.panel1.Controls.Add(this.timeInL);
            this.panel1.Location = new System.Drawing.Point(13, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 244);
            this.panel1.TabIndex = 0;
          //  this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // title1L
            // 
            this.title1L.AutoSize = true;
            this.title1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1L.Location = new System.Drawing.Point(72, 15);
            this.title1L.Name = "title1L";
            this.title1L.Size = new System.Drawing.Size(82, 16);
            this.title1L.TabIndex = 12;
            this.title1L.Text = "Entry Form";
            // 
            // logInB
            // 
            this.logInB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInB.Location = new System.Drawing.Point(701, 18);
            this.logInB.Name = "logInB";
            this.logInB.Size = new System.Drawing.Size(75, 23);
            this.logInB.TabIndex = 15;
            this.logInB.Text = "Log In";
            this.logInB.UseVisualStyleBackColor = true;
            this.logInB.Click += new System.EventHandler(this.logInB_Click);
            // 
            // weekB
            // 
            this.weekB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekB.Location = new System.Drawing.Point(789, 17);
            this.weekB.Name = "weekB";
            this.weekB.Size = new System.Drawing.Size(98, 23);
            this.weekB.TabIndex = 14;
            this.weekB.Text = "WeekDay";
            this.weekB.UseVisualStyleBackColor = true;
            this.weekB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // userPB
            // 
            this.userPB.Image = global::Application_CW1.Properties.Resources.users;
            this.userPB.Location = new System.Drawing.Point(15, 7);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(73, 34);
            this.userPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPB.TabIndex = 14;
            this.userPB.TabStop = false;
            //this.userPB.Click += new System.EventHandler(this.userPB_Click);
            // 
            // titleB
            // 
            this.titleB.BackColor = System.Drawing.SystemColors.Control;
            this.titleB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleB.Location = new System.Drawing.Point(162, 3);
            this.titleB.Name = "titleB";
            this.titleB.Size = new System.Drawing.Size(336, 40);
            this.titleB.TabIndex = 24;
            this.titleB.Text = "The Amusement Park";
            this.titleB.UseVisualStyleBackColor = false;
           // this.titleB.Click += new System.EventHandler(this.titleB_Click);
            // 
            // serializationB
            // 
            this.serializationB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serializationB.Location = new System.Drawing.Point(13, 302);
            this.serializationB.Name = "serializationB";
            this.serializationB.Size = new System.Drawing.Size(152, 26);
            this.serializationB.TabIndex = 14;
            this.serializationB.Text = "Save Serialization";
            this.serializationB.UseVisualStyleBackColor = true;
            this.serializationB.Click += new System.EventHandler(this.serializationB_Click);
            // 
            // VisitorEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.serializationB);
            this.Controls.Add(this.titleB);
            this.Controls.Add(this.logInB);
            this.Controls.Add(this.weekB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.userPB);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.visitorListL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitorListGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "VisitorEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finish";
            this.Load += new System.EventHandler(this.VisitorEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entryL;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.ComboBox visitorTypeCB;
        private System.Windows.Forms.NumericUpDown countNUP;
        private System.Windows.Forms.Label TypeL;
        private System.Windows.Forms.Label CountL;
        private System.Windows.Forms.DataGridView visitorListGrid;
        private System.Windows.Forms.Button entryB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeInL;
        private System.Windows.Forms.TextBox timeInTB;
        private System.Windows.Forms.Label visitorListL;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.PictureBox userPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title1L;
        private System.Windows.Forms.Button logInB;
        private System.Windows.Forms.Button weekB;
        private System.Windows.Forms.Button titleB;
        private System.Windows.Forms.Button serializationB;
    }
}