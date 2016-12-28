namespace mysql
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
            this.Connect_button = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.backgroundForm1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(12, 12);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(75, 23);
            this.Connect_button.TabIndex = 0;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 80);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(173, 20);
            this.loginBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(13, 61);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(13, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(36, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Hasło";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 148);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(173, 20);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(58, 208);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 23);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Zaloguj się";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // backgroundForm1
            // 
            this.backgroundForm1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundForm1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 256);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.Connect_button);
            this.Name = "Form1";
            this.Text = "MySQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button LogInButton;
        private System.ComponentModel.BackgroundWorker backgroundForm1;
    }
}

