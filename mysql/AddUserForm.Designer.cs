namespace mysql
{
    partial class AddUserForm
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
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.UserPassBox = new System.Windows.Forms.TextBox();
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.MinimumLabel = new System.Windows.Forms.Label();
            this.OptionalLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserSurnameBox = new System.Windows.Forms.TextBox();
            this.UserMailBox = new System.Windows.Forms.TextBox();
            this.UserSurnameLabel = new System.Windows.Forms.Label();
            this.UserMailLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.Location = new System.Drawing.Point(109, 40);
            this.UserLoginBox.Name = "UserLoginBox";
            this.UserLoginBox.Size = new System.Drawing.Size(159, 20);
            this.UserLoginBox.TabIndex = 0;
            // 
            // UserPassBox
            // 
            this.UserPassBox.Location = new System.Drawing.Point(109, 66);
            this.UserPassBox.Name = "UserPassBox";
            this.UserPassBox.Size = new System.Drawing.Size(159, 20);
            this.UserPassBox.TabIndex = 1;
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.AutoSize = true;
            this.UserLoginLabel.Location = new System.Drawing.Point(67, 43);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(36, 13);
            this.UserLoginLabel.TabIndex = 2;
            this.UserLoginLabel.Text = "Login:";
            this.UserLoginLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.UserLoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(64, 69);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(39, 13);
            this.UserPasswordLabel.TabIndex = 3;
            this.UserPasswordLabel.Text = "Hasło:";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(109, 250);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(90, 34);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Zastosuj";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // MinimumLabel
            // 
            this.MinimumLabel.AutoSize = true;
            this.MinimumLabel.Location = new System.Drawing.Point(12, 19);
            this.MinimumLabel.Name = "MinimumLabel";
            this.MinimumLabel.Size = new System.Drawing.Size(91, 13);
            this.MinimumLabel.TabIndex = 5;
            this.MinimumLabel.Text = "Wymagane dane:";
            // 
            // OptionalLabel
            // 
            this.OptionalLabel.AutoSize = true;
            this.OptionalLabel.Location = new System.Drawing.Point(12, 175);
            this.OptionalLabel.Name = "OptionalLabel";
            this.OptionalLabel.Size = new System.Drawing.Size(91, 13);
            this.OptionalLabel.TabIndex = 6;
            this.OptionalLabel.Text = "Dane opcjonalne:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(74, 95);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(29, 13);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "Imię:";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(109, 92);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(159, 20);
            this.UserNameBox.TabIndex = 8;
            // 
            // UserSurnameBox
            // 
            this.UserSurnameBox.Location = new System.Drawing.Point(109, 119);
            this.UserSurnameBox.Name = "UserSurnameBox";
            this.UserSurnameBox.Size = new System.Drawing.Size(159, 20);
            this.UserSurnameBox.TabIndex = 9;
            // 
            // UserMailBox
            // 
            this.UserMailBox.Location = new System.Drawing.Point(109, 146);
            this.UserMailBox.Name = "UserMailBox";
            this.UserMailBox.Size = new System.Drawing.Size(159, 20);
            this.UserMailBox.TabIndex = 10;
            // 
            // UserSurnameLabel
            // 
            this.UserSurnameLabel.AutoSize = true;
            this.UserSurnameLabel.Location = new System.Drawing.Point(47, 122);
            this.UserSurnameLabel.Name = "UserSurnameLabel";
            this.UserSurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.UserSurnameLabel.TabIndex = 11;
            this.UserSurnameLabel.Text = "Nazwisko:";
            // 
            // UserMailLabel
            // 
            this.UserMailLabel.AutoSize = true;
            this.UserMailLabel.Location = new System.Drawing.Point(66, 149);
            this.UserMailLabel.Name = "UserMailLabel";
            this.UserMailLabel.Size = new System.Drawing.Size(37, 13);
            this.UserMailLabel.TabIndex = 12;
            this.UserMailLabel.Text = "e-mail:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 250);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 34);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(205, 250);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 34);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 296);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.UserMailLabel);
            this.Controls.Add(this.UserSurnameLabel);
            this.Controls.Add(this.UserMailBox);
            this.Controls.Add(this.UserSurnameBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.OptionalLabel);
            this.Controls.Add(this.MinimumLabel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserLoginLabel);
            this.Controls.Add(this.UserPassBox);
            this.Controls.Add(this.UserLoginBox);
            this.Name = "AddUserForm";
            this.Text = "Dodawanie użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.TextBox UserPassBox;
        private System.Windows.Forms.Label UserLoginLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label MinimumLabel;
        private System.Windows.Forms.Label OptionalLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox UserSurnameBox;
        private System.Windows.Forms.TextBox UserMailBox;
        private System.Windows.Forms.Label UserSurnameLabel;
        private System.Windows.Forms.Label UserMailLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}