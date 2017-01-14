namespace mysql
{
    partial class EditUserForm
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
            this.EditUserDataButton = new System.Windows.Forms.Button();
            this.EdUserLoginTBox = new System.Windows.Forms.TextBox();
            this.EdUserPassTBox = new System.Windows.Forms.TextBox();
            this.EdUserFinancialTBox = new System.Windows.Forms.TextBox();
            this.EdUserStatusCBox = new System.Windows.Forms.ComboBox();
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.UserPassLabel = new System.Windows.Forms.Label();
            this.UserFinancialLabel = new System.Windows.Forms.Label();
            this.UserStatusLabel = new System.Windows.Forms.Label();
            this.EdUserMailTBox = new System.Windows.Forms.TextBox();
            this.UserMailLabel = new System.Windows.Forms.Label();
            this.EdUserNameTBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.EdUserSurnameTBox = new System.Windows.Forms.TextBox();
            this.UserSurnameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditUserDataButton
            // 
            this.EditUserDataButton.Location = new System.Drawing.Point(108, 277);
            this.EditUserDataButton.Name = "EditUserDataButton";
            this.EditUserDataButton.Size = new System.Drawing.Size(90, 34);
            this.EditUserDataButton.TabIndex = 5;
            this.EditUserDataButton.Text = "Zastosuj zmiany";
            this.EditUserDataButton.UseVisualStyleBackColor = true;
            this.EditUserDataButton.Click += new System.EventHandler(this.EditUserDataButton_Click);
            // 
            // EdUserLoginTBox
            // 
            this.EdUserLoginTBox.Location = new System.Drawing.Point(108, 51);
            this.EdUserLoginTBox.Name = "EdUserLoginTBox";
            this.EdUserLoginTBox.Size = new System.Drawing.Size(160, 20);
            this.EdUserLoginTBox.TabIndex = 6;
            this.EdUserLoginTBox.TextChanged += new System.EventHandler(this.EdUserLoginTBox_TextChanged);
            // 
            // EdUserPassTBox
            // 
            this.EdUserPassTBox.Location = new System.Drawing.Point(108, 77);
            this.EdUserPassTBox.Name = "EdUserPassTBox";
            this.EdUserPassTBox.Size = new System.Drawing.Size(160, 20);
            this.EdUserPassTBox.TabIndex = 7;
            this.EdUserPassTBox.TextChanged += new System.EventHandler(this.EdUserPassTBox_TextChanged);
            // 
            // EdUserFinancialTBox
            // 
            this.EdUserFinancialTBox.Location = new System.Drawing.Point(108, 104);
            this.EdUserFinancialTBox.Name = "EdUserFinancialTBox";
            this.EdUserFinancialTBox.Size = new System.Drawing.Size(160, 20);
            this.EdUserFinancialTBox.TabIndex = 8;
            this.EdUserFinancialTBox.TextChanged += new System.EventHandler(this.EdUserFinancialTBox_TextChanged);
            // 
            // EdUserStatusCBox
            // 
            this.EdUserStatusCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EdUserStatusCBox.FormattingEnabled = true;
            this.EdUserStatusCBox.Items.AddRange(new object[] {
            "Aktywny",
            "Nieaktywny",
            "Zablokowany"});
            this.EdUserStatusCBox.Location = new System.Drawing.Point(108, 133);
            this.EdUserStatusCBox.Name = "EdUserStatusCBox";
            this.EdUserStatusCBox.Size = new System.Drawing.Size(160, 21);
            this.EdUserStatusCBox.TabIndex = 10;
            this.EdUserStatusCBox.SelectedIndexChanged += new System.EventHandler(this.EdUserStatusCBox_SelectedIndexChanged);
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.AutoSize = true;
            this.UserLoginLabel.Location = new System.Drawing.Point(66, 54);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(36, 13);
            this.UserLoginLabel.TabIndex = 12;
            this.UserLoginLabel.Text = "Login:";
            // 
            // UserPassLabel
            // 
            this.UserPassLabel.AutoSize = true;
            this.UserPassLabel.Location = new System.Drawing.Point(63, 80);
            this.UserPassLabel.Name = "UserPassLabel";
            this.UserPassLabel.Size = new System.Drawing.Size(39, 13);
            this.UserPassLabel.TabIndex = 13;
            this.UserPassLabel.Text = "Hasło:";
            // 
            // UserFinancialLabel
            // 
            this.UserFinancialLabel.AutoSize = true;
            this.UserFinancialLabel.Location = new System.Drawing.Point(40, 107);
            this.UserFinancialLabel.Name = "UserFinancialLabel";
            this.UserFinancialLabel.Size = new System.Drawing.Size(62, 13);
            this.UserFinancialLabel.TabIndex = 14;
            this.UserFinancialLabel.Text = "Stan konta:";
            // 
            // UserStatusLabel
            // 
            this.UserStatusLabel.AutoSize = true;
            this.UserStatusLabel.Location = new System.Drawing.Point(62, 136);
            this.UserStatusLabel.Name = "UserStatusLabel";
            this.UserStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.UserStatusLabel.TabIndex = 15;
            this.UserStatusLabel.Text = "Status:";
            // 
            // EdUserMailTBox
            // 
            this.EdUserMailTBox.Location = new System.Drawing.Point(108, 161);
            this.EdUserMailTBox.Name = "EdUserMailTBox";
            this.EdUserMailTBox.Size = new System.Drawing.Size(160, 20);
            this.EdUserMailTBox.TabIndex = 16;
            this.EdUserMailTBox.TextChanged += new System.EventHandler(this.EdUserMailTBox_TextChanged);
            // 
            // UserMailLabel
            // 
            this.UserMailLabel.AutoSize = true;
            this.UserMailLabel.Location = new System.Drawing.Point(67, 164);
            this.UserMailLabel.Name = "UserMailLabel";
            this.UserMailLabel.Size = new System.Drawing.Size(37, 13);
            this.UserMailLabel.TabIndex = 17;
            this.UserMailLabel.Text = "e-mail:";
            // 
            // EdUserNameTBox
            // 
            this.EdUserNameTBox.Location = new System.Drawing.Point(108, 188);
            this.EdUserNameTBox.Name = "EdUserNameTBox";
            this.EdUserNameTBox.Size = new System.Drawing.Size(160, 20);
            this.EdUserNameTBox.TabIndex = 18;
            this.EdUserNameTBox.TextChanged += new System.EventHandler(this.EdUserNameTBox_TextChanged);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(73, 191);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(29, 13);
            this.UserNameLabel.TabIndex = 19;
            this.UserNameLabel.Text = "Imię:";
            // 
            // EdUserSurnameTBox
            // 
            this.EdUserSurnameTBox.Location = new System.Drawing.Point(108, 215);
            this.EdUserSurnameTBox.Name = "EdUserSurnameTBox";
            this.EdUserSurnameTBox.Size = new System.Drawing.Size(160, 20);
            this.EdUserSurnameTBox.TabIndex = 20;
            this.EdUserSurnameTBox.TextChanged += new System.EventHandler(this.EdUserSurnameTBox_TextChanged);
            // 
            // UserSurnameLabel
            // 
            this.UserSurnameLabel.AutoSize = true;
            this.UserSurnameLabel.Location = new System.Drawing.Point(46, 218);
            this.UserSurnameLabel.Name = "UserSurnameLabel";
            this.UserSurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.UserSurnameLabel.TabIndex = 21;
            this.UserSurnameLabel.Text = "Nazwisko:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 277);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 34);
            this.OKButton.TabIndex = 22;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(204, 277);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 34);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(21, 26);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(83, 13);
            this.IDLabel.TabIndex = 24;
            this.IDLabel.Text = "ID użytkownika:";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 323);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.UserSurnameLabel);
            this.Controls.Add(this.EdUserSurnameTBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.EdUserNameTBox);
            this.Controls.Add(this.UserMailLabel);
            this.Controls.Add(this.EdUserMailTBox);
            this.Controls.Add(this.UserStatusLabel);
            this.Controls.Add(this.UserFinancialLabel);
            this.Controls.Add(this.UserPassLabel);
            this.Controls.Add(this.UserLoginLabel);
            this.Controls.Add(this.EdUserStatusCBox);
            this.Controls.Add(this.EdUserFinancialTBox);
            this.Controls.Add(this.EdUserPassTBox);
            this.Controls.Add(this.EdUserLoginTBox);
            this.Controls.Add(this.EditUserDataButton);
            this.Name = "EditUserForm";
            this.Text = "Edytuj dane użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditUserDataButton;
        private System.Windows.Forms.TextBox EdUserLoginTBox;
        private System.Windows.Forms.TextBox EdUserPassTBox;
        private System.Windows.Forms.TextBox EdUserFinancialTBox;
        private System.Windows.Forms.ComboBox EdUserStatusCBox;
        private System.Windows.Forms.Label UserLoginLabel;
        private System.Windows.Forms.Label UserPassLabel;
        private System.Windows.Forms.Label UserFinancialLabel;
        private System.Windows.Forms.Label UserStatusLabel;
        private System.Windows.Forms.TextBox EdUserMailTBox;
        private System.Windows.Forms.Label UserMailLabel;
        private System.Windows.Forms.TextBox EdUserNameTBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox EdUserSurnameTBox;
        private System.Windows.Forms.Label UserSurnameLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label IDLabel;
    }
}