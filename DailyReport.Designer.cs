
namespace Application_CW1
{
    partial class DailyReport
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
            this.dailyReportGrid = new System.Windows.Forms.DataGridView();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.exitB = new System.Windows.Forms.Button();
            this.dailyReportTitleB = new System.Windows.Forms.Button();
            this.datePickL = new System.Windows.Forms.Label();
            this.finishB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listPanel = new System.Windows.Forms.Panel();
            this.totalBillL = new System.Windows.Forms.Label();
            this.G5BillL = new System.Windows.Forms.Label();
            this.adultBillL = new System.Windows.Forms.Label();
            this.G10BillL = new System.Windows.Forms.Label();
            this.G25BillL = new System.Windows.Forms.Label();
            this.childBillL = new System.Windows.Forms.Label();
            this.totalCountL = new System.Windows.Forms.Label();
            this.childCountL = new System.Windows.Forms.Label();
            this.adultCountL = new System.Windows.Forms.Label();
            this.G5CountL = new System.Windows.Forms.Label();
            this.G10CountL = new System.Windows.Forms.Label();
            this.G25CountL = new System.Windows.Forms.Label();
            this.totalL = new System.Windows.Forms.Label();
            this.tktChildL = new System.Windows.Forms.Label();
            this.tkAdultL = new System.Windows.Forms.Label();
            this.G5L = new System.Windows.Forms.Label();
            this.G10 = new System.Windows.Forms.Label();
            this.G25L = new System.Windows.Forms.Label();
            this.countL = new System.Windows.Forms.Label();
            this.billL = new System.Windows.Forms.Label();
            this.tktTypeL = new System.Windows.Forms.Label();
            this.dateL = new System.Windows.Forms.Label();
            this.todayTime = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sortHTL = new System.Windows.Forms.Button();
            this.sortLTHP = new System.Windows.Forms.Button();
            this.sortLTHC = new System.Windows.Forms.Button();
            this.sortHTLC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).BeginInit();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailyReportGrid
            // 
            this.dailyReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyReportGrid.Location = new System.Drawing.Point(12, 116);
            this.dailyReportGrid.Name = "dailyReportGrid";
            this.dailyReportGrid.Size = new System.Drawing.Size(619, 341);
            this.dailyReportGrid.TabIndex = 0;
            // 
            // pickDate
            // 
            this.pickDate.Location = new System.Drawing.Point(105, 77);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(218, 20);
            this.pickDate.TabIndex = 1;
            this.pickDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // exitB
            // 
            this.exitB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.Location = new System.Drawing.Point(802, 12);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 30);
            this.exitB.TabIndex = 2;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // dailyReportTitleB
            // 
            this.dailyReportTitleB.BackColor = System.Drawing.Color.Blue;
            this.dailyReportTitleB.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyReportTitleB.ForeColor = System.Drawing.Color.White;
            this.dailyReportTitleB.Location = new System.Drawing.Point(12, 6);
            this.dailyReportTitleB.Name = "dailyReportTitleB";
            this.dailyReportTitleB.Size = new System.Drawing.Size(757, 42);
            this.dailyReportTitleB.TabIndex = 3;
            this.dailyReportTitleB.Text = "Daily Report Here";
            this.dailyReportTitleB.UseVisualStyleBackColor = false;
            // 
            // datePickL
            // 
            this.datePickL.AutoSize = true;
            this.datePickL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickL.Location = new System.Drawing.Point(17, 79);
            this.datePickL.Name = "datePickL";
            this.datePickL.Size = new System.Drawing.Size(84, 15);
            this.datePickL.TabIndex = 4;
            this.datePickL.Text = "Pick A Date:";
            // 
            // finishB
            // 
            this.finishB.BackColor = System.Drawing.Color.Red;
            this.finishB.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishB.Location = new System.Drawing.Point(654, 457);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(116, 33);
            this.finishB.TabIndex = 5;
            this.finishB.Text = "Finish";
            this.finishB.UseVisualStyleBackColor = false;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listPanel
            // 
            this.listPanel.Controls.Add(this.totalBillL);
            this.listPanel.Controls.Add(this.G5BillL);
            this.listPanel.Controls.Add(this.adultBillL);
            this.listPanel.Controls.Add(this.G10BillL);
            this.listPanel.Controls.Add(this.G25BillL);
            this.listPanel.Controls.Add(this.childBillL);
            this.listPanel.Controls.Add(this.totalCountL);
            this.listPanel.Controls.Add(this.childCountL);
            this.listPanel.Controls.Add(this.adultCountL);
            this.listPanel.Controls.Add(this.G5CountL);
            this.listPanel.Controls.Add(this.G10CountL);
            this.listPanel.Controls.Add(this.G25CountL);
            this.listPanel.Controls.Add(this.totalL);
            this.listPanel.Controls.Add(this.tktChildL);
            this.listPanel.Controls.Add(this.tkAdultL);
            this.listPanel.Controls.Add(this.G5L);
            this.listPanel.Controls.Add(this.G10);
            this.listPanel.Controls.Add(this.G25L);
            this.listPanel.Controls.Add(this.countL);
            this.listPanel.Controls.Add(this.billL);
            this.listPanel.Controls.Add(this.tktTypeL);
            this.listPanel.Location = new System.Drawing.Point(637, 116);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(251, 204);
            this.listPanel.TabIndex = 7;
            // 
            // totalBillL
            // 
            this.totalBillL.AutoSize = true;
            this.totalBillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBillL.Location = new System.Drawing.Point(187, 165);
            this.totalBillL.Name = "totalBillL";
            this.totalBillL.Size = new System.Drawing.Size(27, 15);
            this.totalBillL.TabIndex = 28;
            this.totalBillL.Text = "n/a";
            // 
            // G5BillL
            // 
            this.G5BillL.AutoSize = true;
            this.G5BillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5BillL.Location = new System.Drawing.Point(187, 91);
            this.G5BillL.Name = "G5BillL";
            this.G5BillL.Size = new System.Drawing.Size(27, 15);
            this.G5BillL.TabIndex = 27;
            this.G5BillL.Text = "n/a";
            // 
            // adultBillL
            // 
            this.adultBillL.AutoSize = true;
            this.adultBillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultBillL.Location = new System.Drawing.Point(187, 66);
            this.adultBillL.Name = "adultBillL";
            this.adultBillL.Size = new System.Drawing.Size(27, 15);
            this.adultBillL.TabIndex = 26;
            this.adultBillL.Text = "n/a";
            // 
            // G10BillL
            // 
            this.G10BillL.AutoSize = true;
            this.G10BillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G10BillL.Location = new System.Drawing.Point(187, 115);
            this.G10BillL.Name = "G10BillL";
            this.G10BillL.Size = new System.Drawing.Size(27, 15);
            this.G10BillL.TabIndex = 25;
            this.G10BillL.Text = "n/a";
            // 
            // G25BillL
            // 
            this.G25BillL.AutoSize = true;
            this.G25BillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G25BillL.Location = new System.Drawing.Point(187, 139);
            this.G25BillL.Name = "G25BillL";
            this.G25BillL.Size = new System.Drawing.Size(27, 15);
            this.G25BillL.TabIndex = 24;
            this.G25BillL.Text = "n/a";
            // 
            // childBillL
            // 
            this.childBillL.AutoSize = true;
            this.childBillL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childBillL.Location = new System.Drawing.Point(187, 42);
            this.childBillL.Name = "childBillL";
            this.childBillL.Size = new System.Drawing.Size(27, 15);
            this.childBillL.TabIndex = 23;
            this.childBillL.Text = "n/a";
            // 
            // totalCountL
            // 
            this.totalCountL.AutoSize = true;
            this.totalCountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCountL.Location = new System.Drawing.Point(107, 165);
            this.totalCountL.Name = "totalCountL";
            this.totalCountL.Size = new System.Drawing.Size(27, 15);
            this.totalCountL.TabIndex = 22;
            this.totalCountL.Text = "n/a";
            // 
            // childCountL
            // 
            this.childCountL.AutoSize = true;
            this.childCountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childCountL.Location = new System.Drawing.Point(105, 42);
            this.childCountL.Name = "childCountL";
            this.childCountL.Size = new System.Drawing.Size(27, 15);
            this.childCountL.TabIndex = 21;
            this.childCountL.Text = "n/a";
            // 
            // adultCountL
            // 
            this.adultCountL.AutoSize = true;
            this.adultCountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultCountL.Location = new System.Drawing.Point(107, 64);
            this.adultCountL.Name = "adultCountL";
            this.adultCountL.Size = new System.Drawing.Size(27, 15);
            this.adultCountL.TabIndex = 20;
            this.adultCountL.Text = "n/a";
            // 
            // G5CountL
            // 
            this.G5CountL.AutoSize = true;
            this.G5CountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5CountL.Location = new System.Drawing.Point(107, 91);
            this.G5CountL.Name = "G5CountL";
            this.G5CountL.Size = new System.Drawing.Size(27, 15);
            this.G5CountL.TabIndex = 19;
            this.G5CountL.Text = "n/a";
            // 
            // G10CountL
            // 
            this.G10CountL.AutoSize = true;
            this.G10CountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G10CountL.Location = new System.Drawing.Point(107, 115);
            this.G10CountL.Name = "G10CountL";
            this.G10CountL.Size = new System.Drawing.Size(27, 15);
            this.G10CountL.TabIndex = 18;
            this.G10CountL.Text = "n/a";
            // 
            // G25CountL
            // 
            this.G25CountL.AutoSize = true;
            this.G25CountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G25CountL.Location = new System.Drawing.Point(107, 139);
            this.G25CountL.Name = "G25CountL";
            this.G25CountL.Size = new System.Drawing.Size(27, 15);
            this.G25CountL.TabIndex = 17;
            this.G25CountL.Text = "n/a";
            // 
            // totalL
            // 
            this.totalL.AutoSize = true;
            this.totalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalL.Location = new System.Drawing.Point(7, 165);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(39, 15);
            this.totalL.TabIndex = 16;
            this.totalL.Text = "Total";
            // 
            // tktChildL
            // 
            this.tktChildL.AutoSize = true;
            this.tktChildL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tktChildL.Location = new System.Drawing.Point(6, 42);
            this.tktChildL.Name = "tktChildL";
            this.tktChildL.Size = new System.Drawing.Size(40, 15);
            this.tktChildL.TabIndex = 15;
            this.tktChildL.Text = "Child";
            // 
            // tkAdultL
            // 
            this.tkAdultL.AutoSize = true;
            this.tkAdultL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tkAdultL.Location = new System.Drawing.Point(7, 66);
            this.tkAdultL.Name = "tkAdultL";
            this.tkAdultL.Size = new System.Drawing.Size(39, 15);
            this.tkAdultL.TabIndex = 14;
            this.tkAdultL.Text = "Adult";
            // 
            // G5L
            // 
            this.G5L.AutoSize = true;
            this.G5L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G5L.Location = new System.Drawing.Point(7, 91);
            this.G5L.Name = "G5L";
            this.G5L.Size = new System.Drawing.Size(74, 15);
            this.G5L.TabIndex = 13;
            this.G5L.Text = "Group of 5";
            // 
            // G10
            // 
            this.G10.AutoSize = true;
            this.G10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G10.Location = new System.Drawing.Point(7, 115);
            this.G10.Name = "G10";
            this.G10.Size = new System.Drawing.Size(82, 15);
            this.G10.TabIndex = 12;
            this.G10.Text = "Group of 10";
            // 
            // G25L
            // 
            this.G25L.AutoSize = true;
            this.G25L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G25L.Location = new System.Drawing.Point(7, 139);
            this.G25L.Name = "G25L";
            this.G25L.Size = new System.Drawing.Size(82, 15);
            this.G25L.TabIndex = 11;
            this.G25L.Text = "Group of 25";
            // 
            // countL
            // 
            this.countL.AutoSize = true;
            this.countL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countL.Location = new System.Drawing.Point(90, 11);
            this.countL.Name = "countL";
            this.countL.Size = new System.Drawing.Size(88, 15);
            this.countL.TabIndex = 10;
            this.countL.Text = "Visitor Count";
            // 
            // billL
            // 
            this.billL.AutoSize = true;
            this.billL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billL.Location = new System.Drawing.Point(187, 11);
            this.billL.Name = "billL";
            this.billL.Size = new System.Drawing.Size(28, 15);
            this.billL.TabIndex = 9;
            this.billL.Text = "Bill";
            // 
            // tktTypeL
            // 
            this.tktTypeL.AutoSize = true;
            this.tktTypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tktTypeL.Location = new System.Drawing.Point(6, 10);
            this.tktTypeL.Name = "tktTypeL";
            this.tktTypeL.Size = new System.Drawing.Size(79, 15);
            this.tktTypeL.TabIndex = 8;
            this.tktTypeL.Text = "Ticket Type";
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateL.Location = new System.Drawing.Point(744, 81);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(35, 15);
            this.dateL.TabIndex = 8;
            this.dateL.Text = "date";
            this.dateL.Click += new System.EventHandler(this.dateL_Click);
            // 
            // todayTime
            // 
            this.todayTime.Enabled = true;
            this.todayTime.Tick += new System.EventHandler(this.todayTime_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(605, 79);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(87, 15);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date Today :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sort By Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sort By Count";
            // 
            // sortHTL
            // 
            this.sortHTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortHTL.Location = new System.Drawing.Point(651, 358);
            this.sortHTL.Name = "sortHTL";
            this.sortHTL.Size = new System.Drawing.Size(87, 23);
            this.sortHTL.TabIndex = 12;
            this.sortHTL.Text = "High To Low";
            this.sortHTL.UseVisualStyleBackColor = true;
            this.sortHTL.Click += new System.EventHandler(this.sortHTL_Click);
            // 
            // sortLTHP
            // 
            this.sortLTHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLTHP.Location = new System.Drawing.Point(759, 358);
            this.sortLTHP.Name = "sortLTHP";
            this.sortLTHP.Size = new System.Drawing.Size(87, 23);
            this.sortLTHP.TabIndex = 13;
            this.sortLTHP.Text = "Low To High";
            this.sortLTHP.UseVisualStyleBackColor = true;
            this.sortLTHP.Click += new System.EventHandler(this.sortLTHP_Click);
            // 
            // sortLTHC
            // 
            this.sortLTHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLTHC.Location = new System.Drawing.Point(759, 420);
            this.sortLTHC.Name = "sortLTHC";
            this.sortLTHC.Size = new System.Drawing.Size(87, 23);
            this.sortLTHC.TabIndex = 14;
            this.sortLTHC.Text = "Low To High";
            this.sortLTHC.UseVisualStyleBackColor = true;
            this.sortLTHC.Click += new System.EventHandler(this.sortLTHC_Click);
            // 
            // sortHTLC
            // 
            this.sortHTLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortHTLC.Location = new System.Drawing.Point(651, 420);
            this.sortHTLC.Name = "sortHTLC";
            this.sortHTLC.Size = new System.Drawing.Size(87, 23);
            this.sortHTLC.TabIndex = 15;
            this.sortHTLC.Text = "High To Low";
            this.sortHTLC.UseVisualStyleBackColor = true;
            this.sortHTLC.Click += new System.EventHandler(this.sortHTLC_Click);
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.sortHTLC);
            this.Controls.Add(this.sortLTHC);
            this.Controls.Add(this.sortLTHP);
            this.Controls.Add(this.sortHTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateL);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.datePickL);
            this.Controls.Add(this.dailyReportTitleB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.dailyReportGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.Name = "DailyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyReport";
            this.Load += new System.EventHandler(this.DailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyReportGrid)).EndInit();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailyReportGrid;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button dailyReportTitleB;
        private System.Windows.Forms.Label datePickL;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Label totalBillL;
        private System.Windows.Forms.Label G5BillL;
        private System.Windows.Forms.Label adultBillL;
        private System.Windows.Forms.Label G10BillL;
        private System.Windows.Forms.Label G25BillL;
        private System.Windows.Forms.Label childBillL;
        private System.Windows.Forms.Label totalCountL;
        private System.Windows.Forms.Label childCountL;
        private System.Windows.Forms.Label adultCountL;
        private System.Windows.Forms.Label G5CountL;
        private System.Windows.Forms.Label G10CountL;
        private System.Windows.Forms.Label G25CountL;
        private System.Windows.Forms.Label totalL;
        private System.Windows.Forms.Label tktChildL;
        private System.Windows.Forms.Label tkAdultL;
        private System.Windows.Forms.Label G5L;
        private System.Windows.Forms.Label G10;
        private System.Windows.Forms.Label G25L;
        private System.Windows.Forms.Label countL;
        private System.Windows.Forms.Label billL;
        private System.Windows.Forms.Label tktTypeL;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Timer todayTime;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortHTL;
        private System.Windows.Forms.Button sortLTHP;
        private System.Windows.Forms.Button sortLTHC;
        private System.Windows.Forms.Button sortHTLC;
    }
}