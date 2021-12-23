
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
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.countNUP = new System.Windows.Forms.NumericUpDown();
            this.TypeL = new System.Windows.Forms.Label();
            this.CountL = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.entryB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // entryL
            // 
            this.entryL.AutoSize = true;
            this.entryL.Location = new System.Drawing.Point(26, 44);
            this.entryL.Name = "entryL";
            this.entryL.Size = new System.Drawing.Size(43, 13);
            this.entryL.TabIndex = 0;
            this.entryL.Text = "Entry Id";
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Location = new System.Drawing.Point(76, 44);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(13, 13);
            this.IdL.TabIndex = 1;
            this.IdL.Text = "0";
            this.IdL.Click += new System.EventHandler(this.label2_Click);
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group"});
            this.typeCB.Location = new System.Drawing.Point(78, 67);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(121, 21);
            this.typeCB.TabIndex = 2;
            // 
            // countNUP
            // 
            this.countNUP.Location = new System.Drawing.Point(79, 102);
            this.countNUP.Name = "countNUP";
            this.countNUP.Size = new System.Drawing.Size(120, 20);
            this.countNUP.TabIndex = 3;
            // 
            // TypeL
            // 
            this.TypeL.AutoSize = true;
            this.TypeL.Location = new System.Drawing.Point(26, 75);
            this.TypeL.Name = "TypeL";
            this.TypeL.Size = new System.Drawing.Size(31, 13);
            this.TypeL.TabIndex = 4;
            this.TypeL.Text = "Type";
            // 
            // CountL
            // 
            this.CountL.AutoSize = true;
            this.CountL.Location = new System.Drawing.Point(26, 109);
            this.CountL.Name = "CountL";
            this.CountL.Size = new System.Drawing.Size(35, 13);
            this.CountL.TabIndex = 5;
            this.CountL.Text = "Count";
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(248, 12);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(525, 343);
            this.grid1.TabIndex = 6;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // entryB
            // 
            this.entryB.Location = new System.Drawing.Point(29, 150);
            this.entryB.Name = "entryB";
            this.entryB.Size = new System.Drawing.Size(75, 23);
            this.entryB.TabIndex = 7;
            this.entryB.Text = "Make Entry";
            this.entryB.UseVisualStyleBackColor = true;
            this.entryB.Click += new System.EventHandler(this.entryB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // VisitorEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entryB);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.CountL);
            this.Controls.Add(this.TypeL);
            this.Controls.Add(this.countNUP);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.IdL);
            this.Controls.Add(this.entryL);
            this.Name = "VisitorEntry";
            this.Text = "VisitorEntry";
            ((System.ComponentModel.ISupportInitialize)(this.countNUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entryL;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.NumericUpDown countNUP;
        private System.Windows.Forms.Label TypeL;
        private System.Windows.Forms.Label CountL;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button entryB;
        private System.Windows.Forms.Label label2;
    }
}