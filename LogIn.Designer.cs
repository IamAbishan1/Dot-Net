
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
            this.LoginB = new System.Windows.Forms.Button();
            this.SkipB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UPCheckL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.UserL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginB
            // 
            this.LoginB.Location = new System.Drawing.Point(329, 254);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(138, 23);
            this.LoginB.TabIndex = 17;
            this.LoginB.Text = "Login (Admin)";
            this.LoginB.UseVisualStyleBackColor = true;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // SkipB
            // 
            this.SkipB.Location = new System.Drawing.Point(330, 294);
            this.SkipB.Name = "SkipB";
            this.SkipB.Size = new System.Drawing.Size(138, 23);
            this.SkipB.TabIndex = 16;
            this.SkipB.Text = "Skip (User)";
            this.SkipB.UseVisualStyleBackColor = true;
            this.SkipB.Click += new System.EventHandler(this.SkipB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // UPCheckL
            // 
            this.UPCheckL.AutoSize = true;
            this.UPCheckL.ForeColor = System.Drawing.Color.DarkRed;
            this.UPCheckL.Location = new System.Drawing.Point(326, 233);
            this.UPCheckL.Name = "UPCheckL";
            this.UPCheckL.Size = new System.Drawing.Size(149, 13);
            this.UPCheckL.TabIndex = 13;
            this.UPCheckL.Text = "Username/Password not valid";
            this.UPCheckL.Visible = false;
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Location = new System.Drawing.Point(330, 184);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(53, 13);
            this.PasswordL.TabIndex = 12;
            this.PasswordL.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(329, 204);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 11;
            this.PasswordTB.UseSystemPasswordChar = true;
            // 
            // UserTB
            // 
            this.UserTB.Location = new System.Drawing.Point(330, 156);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(100, 20);
            this.UserTB.TabIndex = 10;
            // 
            // UserL
            // 
            this.UserL.AutoSize = true;
            this.UserL.Location = new System.Drawing.Point(326, 134);
            this.UserL.Name = "UserL";
            this.UserL.Size = new System.Drawing.Size(55, 13);
            this.UserL.TabIndex = 9;
            this.UserL.Text = "Username";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginB);
            this.Controls.Add(this.SkipB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UPCheckL);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserTB);
            this.Controls.Add(this.UserL);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

