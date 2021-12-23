
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
            this.exitCountNUD = new System.Windows.Forms.NumericUpDown();
            this.exitNUD = new System.Windows.Forms.NumericUpDown();
            this.SearchB = new System.Windows.Forms.Button();
            this.ExitTimeL = new System.Windows.Forms.Label();
            this.EntryTimeL = new System.Windows.Forms.Label();
            this.ExitCountL = new System.Windows.Forms.Label();
            this.ExitTypeL = new System.Windows.Forms.Label();
            this.DurationL = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.exitC = new System.Windows.Forms.ComboBox();
            this.exitEntryTimeTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.exitTimeTB = new System.Windows.Forms.TextBox();
            this.exitCB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitIdL
            // 
            this.ExitIdL.AutoSize = true;
            this.ExitIdL.Location = new System.Drawing.Point(52, 43);
            this.ExitIdL.Name = "ExitIdL";
            this.ExitIdL.Size = new System.Drawing.Size(16, 13);
            this.ExitIdL.TabIndex = 0;
            this.ExitIdL.Text = "Id";
            // 
            // exitCountNUD
            // 
            this.exitCountNUD.Location = new System.Drawing.Point(90, 99);
            this.exitCountNUD.Name = "exitCountNUD";
            this.exitCountNUD.Size = new System.Drawing.Size(120, 20);
            this.exitCountNUD.TabIndex = 1;
            // 
            // exitNUD
            // 
            this.exitNUD.Location = new System.Drawing.Point(90, 36);
            this.exitNUD.Name = "exitNUD";
            this.exitNUD.Size = new System.Drawing.Size(120, 20);
            this.exitNUD.TabIndex = 2;
            this.exitNUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // SearchB
            // 
            this.SearchB.Location = new System.Drawing.Point(250, 36);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 23);
            this.SearchB.TabIndex = 3;
            this.SearchB.Text = "Search";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitTimeL
            // 
            this.ExitTimeL.AutoSize = true;
            this.ExitTimeL.Location = new System.Drawing.Point(52, 174);
            this.ExitTimeL.Name = "ExitTimeL";
            this.ExitTimeL.Size = new System.Drawing.Size(50, 13);
            this.ExitTimeL.TabIndex = 4;
            this.ExitTimeL.Text = "Exit Time";
            // 
            // EntryTimeL
            // 
            this.EntryTimeL.AutoSize = true;
            this.EntryTimeL.Location = new System.Drawing.Point(52, 139);
            this.EntryTimeL.Name = "EntryTimeL";
            this.EntryTimeL.Size = new System.Drawing.Size(57, 13);
            this.EntryTimeL.TabIndex = 5;
            this.EntryTimeL.Text = "Entry Time";
            // 
            // ExitCountL
            // 
            this.ExitCountL.AutoSize = true;
            this.ExitCountL.Location = new System.Drawing.Point(52, 106);
            this.ExitCountL.Name = "ExitCountL";
            this.ExitCountL.Size = new System.Drawing.Size(35, 13);
            this.ExitCountL.TabIndex = 6;
            this.ExitCountL.Text = "Count";
            // 
            // ExitTypeL
            // 
            this.ExitTypeL.AutoSize = true;
            this.ExitTypeL.Location = new System.Drawing.Point(52, 73);
            this.ExitTypeL.Name = "ExitTypeL";
            this.ExitTypeL.Size = new System.Drawing.Size(31, 13);
            this.ExitTypeL.TabIndex = 7;
            this.ExitTypeL.Text = "Type";
            // 
            // DurationL
            // 
            this.DurationL.AutoSize = true;
            this.DurationL.Location = new System.Drawing.Point(52, 209);
            this.DurationL.Name = "DurationL";
            this.DurationL.Size = new System.Drawing.Size(47, 13);
            this.DurationL.TabIndex = 8;
            this.DurationL.Text = "Duration";
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Location = new System.Drawing.Point(52, 240);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(31, 13);
            this.PriceL.TabIndex = 9;
            this.PriceL.Text = "Price";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(52, 277);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // exitC
            // 
            this.exitC.FormattingEnabled = true;
            this.exitC.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group"});
            this.exitC.Location = new System.Drawing.Point(250, 106);
            this.exitC.Name = "exitC";
            this.exitC.Size = new System.Drawing.Size(121, 21);
            this.exitC.TabIndex = 11;
            this.exitC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // exitEntryTimeTB
            // 
            this.exitEntryTimeTB.Location = new System.Drawing.Point(115, 139);
            this.exitEntryTimeTB.Name = "exitEntryTimeTB";
            this.exitEntryTimeTB.Size = new System.Drawing.Size(100, 20);
            this.exitEntryTimeTB.TabIndex = 12;
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(115, 232);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 13;
            this.priceTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // durationTB
            // 
            this.durationTB.Location = new System.Drawing.Point(115, 206);
            this.durationTB.Name = "durationTB";
            this.durationTB.Size = new System.Drawing.Size(100, 20);
            this.durationTB.TabIndex = 14;
            // 
            // exitTimeTB
            // 
            this.exitTimeTB.Location = new System.Drawing.Point(115, 174);
            this.exitTimeTB.Name = "exitTimeTB";
            this.exitTimeTB.Size = new System.Drawing.Size(100, 20);
            this.exitTimeTB.TabIndex = 15;
            // 
            // exitCB
            // 
            this.exitCB.Location = new System.Drawing.Point(90, 70);
            this.exitCB.Name = "exitCB";
            this.exitCB.Size = new System.Drawing.Size(100, 20);
            this.exitCB.TabIndex = 16;
            // 
            // VisitorExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitCB);
            this.Controls.Add(this.exitTimeTB);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.exitEntryTimeTB);
            this.Controls.Add(this.exitC);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PriceL);
            this.Controls.Add(this.DurationL);
            this.Controls.Add(this.ExitTypeL);
            this.Controls.Add(this.ExitCountL);
            this.Controls.Add(this.EntryTimeL);
            this.Controls.Add(this.ExitTimeL);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.exitNUD);
            this.Controls.Add(this.exitCountNUD);
            this.Controls.Add(this.ExitIdL);
            this.Name = "VisitorExit";
            this.Text = "VisitorExit";
            this.Load += new System.EventHandler(this.VisitorExit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitIdL;
        private System.Windows.Forms.NumericUpDown exitCountNUD;
        private System.Windows.Forms.NumericUpDown exitNUD;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Label ExitTimeL;
        private System.Windows.Forms.Label EntryTimeL;
        private System.Windows.Forms.Label ExitCountL;
        private System.Windows.Forms.Label ExitTypeL;
        private System.Windows.Forms.Label DurationL;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox exitC;
        private System.Windows.Forms.TextBox exitEntryTimeTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.TextBox exitTimeTB;
        private System.Windows.Forms.TextBox exitCB;
    }
}