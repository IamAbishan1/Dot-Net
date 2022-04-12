
namespace Application_CW1
{
    partial class VisitorDetail
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
            this.title1 = new System.Windows.Forms.Button();
            this.visitorListGV = new System.Windows.Forms.DataGridView();
            this.searchL = new System.Windows.Forms.Label();
            this.childSearchB = new System.Windows.Forms.Button();
            this.G25searchB = new System.Windows.Forms.Button();
            this.G10searchB = new System.Windows.Forms.Button();
            this.G5searchB = new System.Windows.Forms.Button();
            this.adultSearchB = new System.Windows.Forms.Button();
            this.sortB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sortL = new System.Windows.Forms.Label();
            this.exportB = new System.Windows.Forms.Button();
            this.exportL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitorListGV)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.Blue;
            this.title1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(12, 2);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(876, 48);
            this.title1.TabIndex = 0;
            this.title1.Text = "Visitor Details Here";
            this.title1.UseVisualStyleBackColor = false;
            // 
            // visitorListGV
            // 
            this.visitorListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorListGV.Location = new System.Drawing.Point(169, 56);
            this.visitorListGV.Name = "visitorListGV";
            this.visitorListGV.Size = new System.Drawing.Size(719, 365);
            this.visitorListGV.TabIndex = 1;
            // 
            // searchL
            // 
            this.searchL.AutoSize = true;
            this.searchL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchL.Location = new System.Drawing.Point(12, 85);
            this.searchL.Name = "searchL";
            this.searchL.Size = new System.Drawing.Size(135, 15);
            this.searchL.TabIndex = 2;
            this.searchL.Text = "Filter By Ticket Type";
            // 
            // childSearchB
            // 
            this.childSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childSearchB.Location = new System.Drawing.Point(15, 114);
            this.childSearchB.Name = "childSearchB";
            this.childSearchB.Size = new System.Drawing.Size(109, 23);
            this.childSearchB.TabIndex = 3;
            this.childSearchB.Text = "Child";
            this.childSearchB.UseVisualStyleBackColor = true;
            this.childSearchB.Click += new System.EventHandler(this.childSearchB_Click);
            // 
            // G25searchB
            // 
            this.G25searchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G25searchB.Location = new System.Drawing.Point(15, 230);
            this.G25searchB.Name = "G25searchB";
            this.G25searchB.Size = new System.Drawing.Size(109, 23);
            this.G25searchB.TabIndex = 4;
            this.G25searchB.Text = "Group of 25";
            this.G25searchB.UseVisualStyleBackColor = true;
            this.G25searchB.Click += new System.EventHandler(this.G25searchB_Click);
            // 
            // G10searchB
            // 
            this.G10searchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G10searchB.Location = new System.Drawing.Point(15, 201);
            this.G10searchB.Name = "G10searchB";
            this.G10searchB.Size = new System.Drawing.Size(109, 23);
            this.G10searchB.TabIndex = 5;
            this.G10searchB.Text = "Group of 10";
            this.G10searchB.UseVisualStyleBackColor = true;
            this.G10searchB.Click += new System.EventHandler(this.G10searchB_Click);
            // 
            // G5searchB
            // 
            this.G5searchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5searchB.Location = new System.Drawing.Point(15, 172);
            this.G5searchB.Name = "G5searchB";
            this.G5searchB.Size = new System.Drawing.Size(109, 23);
            this.G5searchB.TabIndex = 6;
            this.G5searchB.Text = "Group of 5";
            this.G5searchB.UseVisualStyleBackColor = true;
            this.G5searchB.Click += new System.EventHandler(this.G5searchB_Click);
            // 
            // adultSearchB
            // 
            this.adultSearchB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultSearchB.Location = new System.Drawing.Point(15, 143);
            this.adultSearchB.Name = "adultSearchB";
            this.adultSearchB.Size = new System.Drawing.Size(109, 23);
            this.adultSearchB.TabIndex = 7;
            this.adultSearchB.Text = "Adult";
            this.adultSearchB.UseVisualStyleBackColor = true;
            this.adultSearchB.Click += new System.EventHandler(this.adultSearchB_Click);
            // 
            // sortB
            // 
            this.sortB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortB.Location = new System.Drawing.Point(12, 299);
            this.sortB.Name = "sortB";
            this.sortB.Size = new System.Drawing.Size(129, 23);
            this.sortB.TabIndex = 8;
            this.sortB.Text = "Price High-Low";
            this.sortB.UseVisualStyleBackColor = true;
            this.sortB.Click += new System.EventHandler(this.sortB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortL
            // 
            this.sortL.AutoSize = true;
            this.sortL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortL.Location = new System.Drawing.Point(12, 274);
            this.sortL.Name = "sortL";
            this.sortL.Size = new System.Drawing.Size(122, 15);
            this.sortL.TabIndex = 10;
            this.sortL.Text = "Sort Data by Price";
            // 
            // exportB
            // 
            this.exportB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportB.Location = new System.Drawing.Point(12, 388);
            this.exportB.Name = "exportB";
            this.exportB.Size = new System.Drawing.Size(109, 23);
            this.exportB.TabIndex = 11;
            this.exportB.Text = "Export";
            this.exportB.UseVisualStyleBackColor = true;
            this.exportB.Click += new System.EventHandler(this.exportB_Click);
            // 
            // exportL
            // 
            this.exportL.AutoSize = true;
            this.exportL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportL.Location = new System.Drawing.Point(9, 364);
            this.exportL.Name = "exportL";
            this.exportL.Size = new System.Drawing.Size(132, 15);
            this.exportL.TabIndex = 12;
            this.exportL.Text = "Export Data to CSV ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Price Low-High";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VisitorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exportL);
            this.Controls.Add(this.exportB);
            this.Controls.Add(this.sortL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortB);
            this.Controls.Add(this.adultSearchB);
            this.Controls.Add(this.G5searchB);
            this.Controls.Add(this.G10searchB);
            this.Controls.Add(this.G25searchB);
            this.Controls.Add(this.childSearchB);
            this.Controls.Add(this.searchL);
            this.Controls.Add(this.visitorListGV);
            this.Controls.Add(this.title1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "VisitorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitorDetail";
            this.Load += new System.EventHandler(this.VisitorDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitorListGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button title1;
        private System.Windows.Forms.DataGridView visitorListGV;
        private System.Windows.Forms.Label searchL;
        private System.Windows.Forms.Button childSearchB;
        private System.Windows.Forms.Button G25searchB;
        private System.Windows.Forms.Button G10searchB;
        private System.Windows.Forms.Button G5searchB;
        private System.Windows.Forms.Button adultSearchB;
        private System.Windows.Forms.Button sortB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sortL;
        private System.Windows.Forms.Button exportB;
        private System.Windows.Forms.Label exportL;
        private System.Windows.Forms.Button button2;
    }
}