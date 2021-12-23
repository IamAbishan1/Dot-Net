
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
            this.ticketRateCB = new System.Windows.Forms.ComboBox();
            this.ticketRateGV = new System.Windows.Forms.DataGridView();
            this.UpdateRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketRateGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketRateCB
            // 
            this.ticketRateCB.FormattingEnabled = true;
            this.ticketRateCB.Items.AddRange(new object[] {
            "WeekDays",
            "WeekEnds"});
            this.ticketRateCB.Location = new System.Drawing.Point(108, 36);
            this.ticketRateCB.Name = "ticketRateCB";
            this.ticketRateCB.Size = new System.Drawing.Size(204, 21);
            this.ticketRateCB.TabIndex = 0;
            // 
            // ticketRateGV
            // 
            this.ticketRateGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketRateGV.Location = new System.Drawing.Point(22, 109);
            this.ticketRateGV.Name = "ticketRateGV";
            this.ticketRateGV.Size = new System.Drawing.Size(641, 238);
            this.ticketRateGV.TabIndex = 1;
            this.ticketRateGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketRateGV_CellContentClick);
            // 
            // UpdateRate
            // 
            this.UpdateRate.Location = new System.Drawing.Point(669, 269);
            this.UpdateRate.Name = "UpdateRate";
            this.UpdateRate.Size = new System.Drawing.Size(103, 23);
            this.UpdateRate.TabIndex = 2;
            this.UpdateRate.Text = "Update Rate";
            this.UpdateRate.UseVisualStyleBackColor = true;
            this.UpdateRate.Click += new System.EventHandler(this.UpdateRate_Click);
            // 
            // TicketRateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateRate);
            this.Controls.Add(this.ticketRateGV);
            this.Controls.Add(this.ticketRateCB);
            this.Name = "TicketRateDisplay";
            this.Text = "TicketRateDisplay";
            this.Load += new System.EventHandler(this.TicketRateDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketRateGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ticketRateCB;
        private System.Windows.Forms.DataGridView ticketRateGV;
        private System.Windows.Forms.Button UpdateRate;
    }
}