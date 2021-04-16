
namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.logining = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.login);
            this.flowLayoutPanel1.Controls.Add(this.pass);
            this.flowLayoutPanel1.Controls.Add(this.logining);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(181, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 104);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.login.Location = new System.Drawing.Point(3, 3);
            this.login.Name = "login";
            this.login.PlaceholderText = "Логин";
            this.login.Size = new System.Drawing.Size(408, 23);
            this.login.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pass.Location = new System.Drawing.Point(3, 32);
            this.pass.Name = "pass";
            this.pass.PlaceholderText = "Пароль";
            this.pass.Size = new System.Drawing.Size(408, 23);
            this.pass.TabIndex = 2;
            // 
            // logining
            // 
            this.logining.Location = new System.Drawing.Point(3, 61);
            this.logining.Name = "logining";
            this.logining.Size = new System.Drawing.Size(408, 36);
            this.logining.TabIndex = 1;
            this.logining.Text = "Войти";
            this.logining.UseVisualStyleBackColor = true;
            this.logining.Click += new System.EventHandler(this.logining_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button logining;
    }
}

