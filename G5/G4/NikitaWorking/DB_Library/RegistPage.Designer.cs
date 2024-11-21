
namespace DB_Library
{
    partial class RegistPage
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
            this.NameBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBar = new System.Windows.Forms.TextBox();
            this.PasswordBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegButt2 = new System.Windows.Forms.Button();
            this.BackButt = new System.Windows.Forms.Button();
            this.RoleBar = new System.Windows.Forms.TextBox();
            this.RoleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBar
            // 
            this.NameBar.Location = new System.Drawing.Point(328, 86);
            this.NameBar.Name = "NameBar";
            this.NameBar.Size = new System.Drawing.Size(146, 20);
            this.NameBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // LoginBar
            // 
            this.LoginBar.Location = new System.Drawing.Point(328, 125);
            this.LoginBar.Name = "LoginBar";
            this.LoginBar.Size = new System.Drawing.Size(146, 20);
            this.LoginBar.TabIndex = 4;
            // 
            // PasswordBar
            // 
            this.PasswordBar.Location = new System.Drawing.Point(328, 164);
            this.PasswordBar.Name = "PasswordBar";
            this.PasswordBar.Size = new System.Drawing.Size(146, 20);
            this.PasswordBar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // RegButt2
            // 
            this.RegButt2.Location = new System.Drawing.Point(328, 190);
            this.RegButt2.Name = "RegButt2";
            this.RegButt2.Size = new System.Drawing.Size(146, 23);
            this.RegButt2.TabIndex = 10;
            this.RegButt2.Text = "Registration";
            this.RegButt2.UseVisualStyleBackColor = true;
            this.RegButt2.Click += new System.EventHandler(this.RegButt2_Click);
            // 
            // BackButt
            // 
            this.BackButt.Location = new System.Drawing.Point(328, 219);
            this.BackButt.Name = "BackButt";
            this.BackButt.Size = new System.Drawing.Size(146, 23);
            this.BackButt.TabIndex = 11;
            this.BackButt.Text = "Back";
            this.BackButt.UseVisualStyleBackColor = true;
            this.BackButt.Click += new System.EventHandler(this.BackButt_Click);
            // 
            // RoleBar
            // 
            this.RoleBar.Location = new System.Drawing.Point(328, 47);
            this.RoleBar.Name = "RoleBar";
            this.RoleBar.Size = new System.Drawing.Size(146, 20);
            this.RoleBar.TabIndex = 12;
            // 
            // RoleText
            // 
            this.RoleText.AutoSize = true;
            this.RoleText.Location = new System.Drawing.Point(328, 28);
            this.RoleText.Name = "RoleText";
            this.RoleText.Size = new System.Drawing.Size(29, 13);
            this.RoleText.TabIndex = 13;
            this.RoleText.Text = "Role";
            // 
            // RegistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleText);
            this.Controls.Add(this.RoleBar);
            this.Controls.Add(this.BackButt);
            this.Controls.Add(this.RegButt2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBar);
            this.Controls.Add(this.LoginBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBar);
            this.Name = "RegistPage";
            this.Text = "Regist Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginBar;
        private System.Windows.Forms.TextBox PasswordBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegButt2;
        private System.Windows.Forms.Button BackButt;
        private System.Windows.Forms.TextBox RoleBar;
        private System.Windows.Forms.Label RoleText;
    }
}