
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Uname = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.BackColor = System.Drawing.SystemColors.Highlight;
            this.Uname.ForeColor = System.Drawing.Color.Snow;
            this.Uname.Location = new System.Drawing.Point(54, 57);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(79, 17);
            this.Uname.TabIndex = 0;
            this.Uname.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(226, 54);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(173, 22);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Zensar";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(250, 197);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(143, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(54, 115);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 17);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter_1);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter_1);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Uname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

