
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.Entry = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTimeL = new System.Windows.Forms.Label();
            this.ticketRateOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTicketRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTicketRateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.ticketRateOpen});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // MenuOpen
            // 
            this.MenuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Entry,
            this.exitToolStripMenuItem});
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(48, 20);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Entry
            // 
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(180, 22);
            this.Entry.Text = "Entry";
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DateTimeL
            // 
            this.DateTimeL.AutoSize = true;
            this.DateTimeL.Location = new System.Drawing.Point(513, 10);
            this.DateTimeL.Name = "DateTimeL";
            this.DateTimeL.Size = new System.Drawing.Size(30, 13);
            this.DateTimeL.TabIndex = 4;
            this.DateTimeL.Text = "Date";
            // 
            // ticketRateOpen
            // 
            this.ticketRateOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTicketRateToolStripMenuItem,
            this.updateTicketRateMenu});
            this.ticketRateOpen.Name = "ticketRateOpen";
            this.ticketRateOpen.Size = new System.Drawing.Size(76, 20);
            this.ticketRateOpen.Text = "Ticket Rate";
            this.ticketRateOpen.Click += new System.EventHandler(this.ticketRateToolStripMenuItem_Click);
            // 
            // viewTicketRateToolStripMenuItem
            // 
            this.viewTicketRateToolStripMenuItem.Name = "viewTicketRateToolStripMenuItem";
            this.viewTicketRateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewTicketRateToolStripMenuItem.Text = "View Ticket Rate";
            this.viewTicketRateToolStripMenuItem.Click += new System.EventHandler(this.viewTicketRateToolStripMenuItem_Click);
            // 
            // updateTicketRateMenu
            // 
            this.updateTicketRateMenu.Name = "updateTicketRateMenu";
            this.updateTicketRateMenu.Size = new System.Drawing.Size(180, 22);
            this.updateTicketRateMenu.Text = "Update Ticket Rate";
            this.updateTicketRateMenu.Click += new System.EventHandler(this.updateTicketRateToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateTimeL);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.Label DateTimeL;
        private System.Windows.Forms.ToolStripMenuItem Entry;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketRateOpen;
        private System.Windows.Forms.ToolStripMenuItem viewTicketRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTicketRateMenu;
    }
}