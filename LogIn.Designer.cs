
namespace Application_CW1
{
    partial class LogIn
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
            this.LoginB = new System.Windows.Forms.Button();
            this.SkipB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UPCheckL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.UserL = new System.Windows.Forms.Label();
            this.logInPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dayL = new System.Windows.Forms.Label();
            this.dateL = new System.Windows.Forms.Label();
            this.exitB = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logInPB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginB.Location = new System.Drawing.Point(37, 238);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(138, 30);
            this.LoginB.TabIndex = 17;
            this.LoginB.Text = "Login (Admin)";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // SkipB
            // 
            this.SkipB.BackColor = System.Drawing.Color.Blue;
            this.SkipB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkipB.Location = new System.Drawing.Point(38, 277);
            this.SkipB.Name = "SkipB";
            this.SkipB.Size = new System.Drawing.Size(138, 30);
            this.SkipB.TabIndex = 16;
            this.SkipB.Text = "Skip (User)";
            this.SkipB.UseVisualStyleBackColor = false;
            this.SkipB.Click += new System.EventHandler(this.SkipB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // UPCheckL
            // 
            this.UPCheckL.AutoSize = true;
            this.UPCheckL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPCheckL.ForeColor = System.Drawing.Color.DarkRed;
            this.UPCheckL.Location = new System.Drawing.Point(7, 210);
            this.UPCheckL.Name = "UPCheckL";
            this.UPCheckL.Size = new System.Drawing.Size(215, 16);
            this.UPCheckL.TabIndex = 13;
            this.UPCheckL.Text = "Username/Password not valid";
            this.UPCheckL.Visible = false;
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(42, 159);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(81, 15);
            this.PasswordL.TabIndex = 12;
            this.PasswordL.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(37, 180);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(156, 20);
            this.PasswordTB.TabIndex = 11;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // UserTB
            // 
            this.UserTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTB.Location = new System.Drawing.Point(38, 130);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(155, 20);
            this.UserTB.TabIndex = 10;
            this.UserTB.TextChanged += new System.EventHandler(this.UserTB_TextChanged);
            // 
            // UserL
            // 
            this.UserL.AutoSize = true;
            this.UserL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserL.Location = new System.Drawing.Point(44, 107);
            this.UserL.Name = "UserL";
            this.UserL.Size = new System.Drawing.Size(82, 15);
            this.UserL.TabIndex = 9;
            this.UserL.Text = "Username";
            // 
            // logInPB
            // 
            this.logInPB.Image = global::Application_CW1.Properties.Resources.login;
            this.logInPB.Location = new System.Drawing.Point(249, 53);
            this.logInPB.Name = "logInPB";
            this.logInPB.Size = new System.Drawing.Size(646, 443);
            this.logInPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logInPB.TabIndex = 18;
            this.logInPB.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Fill the form below";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PasswordTB);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UserL);
            this.panel1.Controls.Add(this.UserTB);
            this.panel1.Controls.Add(this.LoginB);
            this.panel1.Controls.Add(this.PasswordL);
            this.panel1.Controls.Add(this.SkipB);
            this.panel1.Controls.Add(this.UPCheckL);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 355);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dayL);
            this.panel2.Controls.Add(this.dateL);
            this.panel2.Controls.Add(this.exitB);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 46);
            this.panel2.TabIndex = 22;
            // 
            // dayL
            // 
            this.dayL.AutoSize = true;
            this.dayL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayL.Location = new System.Drawing.Point(22, 16);
            this.dayL.Name = "dayL";
            this.dayL.Size = new System.Drawing.Size(36, 15);
            this.dayL.TabIndex = 22;
            this.dayL.Text = "day";
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateL.Location = new System.Drawing.Point(113, 16);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(45, 15);
            this.dateL.TabIndex = 21;
            this.dateL.Text = "date";
            this.dateL.Click += new System.EventHandler(this.dateL_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Red;
            this.exitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.Location = new System.Drawing.Point(796, 7);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(88, 30);
            this.exitB.TabIndex = 21;
            this.exitB.Text = "Close";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logInPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.Button SkipB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UPCheckL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.Label UserL;
        private System.Windows.Forms.PictureBox logInPB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Label dateL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dayL;
    }
}

