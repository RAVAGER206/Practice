
namespace DB_Library
{
    partial class LoginPage
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
            this.LogButt = new System.Windows.Forms.Button();
            this.RegButt = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogButt
            // 
            this.LogButt.Location = new System.Drawing.Point(359, 208);
            this.LogButt.Name = "LogButt";
            this.LogButt.Size = new System.Drawing.Size(75, 23);
            this.LogButt.TabIndex = 0;
            this.LogButt.Text = "Login";
            this.LogButt.UseVisualStyleBackColor = true;
            this.LogButt.Click += new System.EventHandler(this.LogButt_Click);
            // 
            // RegButt
            // 
            this.RegButt.Location = new System.Drawing.Point(359, 237);
            this.RegButt.Name = "RegButt";
            this.RegButt.Size = new System.Drawing.Size(75, 23);
            this.RegButt.TabIndex = 1;
            this.RegButt.Text = "Registration";
            this.RegButt.UseVisualStyleBackColor = true;
            this.RegButt.Click += new System.EventHandler(this.RegButt_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(348, 143);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(100, 20);
            this.LogTextBox.TabIndex = 2;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(348, 182);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(100, 20);
            this.PassTextBox.TabIndex = 3;
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Location = new System.Drawing.Point(345, 127);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(33, 13);
            this.LoginText.TabIndex = 4;
            this.LoginText.Text = "Login";
            // 
            // PassText
            // 
            this.PassText.AutoSize = true;
            this.PassText.Location = new System.Drawing.Point(345, 166);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(53, 13);
            this.PassText.TabIndex = 5;
            this.PassText.Text = "Password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.RegButt);
            this.Controls.Add(this.LogButt);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogButt;
        private System.Windows.Forms.Button RegButt;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.Label PassText;
    }
}