namespace mysql
{
    partial class AddPaymentForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UserLogin = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.NumericUpDown();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MinuteBox = new System.Windows.Forms.NumericUpDown();
            this.HourBox = new System.Windows.Forms.NumericUpDown();
            this.hLabel = new System.Windows.Forms.Label();
            this.mLabel = new System.Windows.Forms.Label();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(203, 144);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 34);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(11, 144);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 34);
            this.OKButton.TabIndex = 15;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(107, 144);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(90, 34);
            this.ApplyButton.TabIndex = 14;
            this.ApplyButton.Text = "Zastosuj";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Location = new System.Drawing.Point(8, 35);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(104, 13);
            this.UserLogin.TabIndex = 17;
            this.UserLogin.Text = "Login użytkownika:  ";
            this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(14, 64);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(85, 13);
            this.MoneyLabel.TabIndex = 21;
            this.MoneyLabel.Text = "Wartość wpłaty:";
            // 
            // MoneyBox
            // 
            this.MoneyBox.DecimalPlaces = 2;
            this.MoneyBox.Location = new System.Drawing.Point(104, 62);
            this.MoneyBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(143, 20);
            this.MoneyBox.TabIndex = 20;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(30, 92);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(68, 13);
            this.DateLabel.TabIndex = 19;
            this.DateLabel.Text = "Data wpłaty:";
            // 
            // DateBox
            // 
            this.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateBox.Location = new System.Drawing.Point(104, 88);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(143, 20);
            this.DateBox.TabIndex = 18;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(52, 115);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeLabel.TabIndex = 23;
            this.TimeLabel.Text = "Czas:";
            // 
            // MinuteBox
            // 
            this.MinuteBox.Location = new System.Drawing.Point(154, 113);
            this.MinuteBox.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(40, 20);
            this.MinuteBox.TabIndex = 24;
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(91, 113);
            this.HourBox.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(37, 20);
            this.HourBox.TabIndex = 25;
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(134, 115);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(13, 13);
            this.hLabel.TabIndex = 26;
            this.hLabel.Text = "h";
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(200, 115);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(23, 13);
            this.mLabel.TabIndex = 27;
            this.mLabel.Text = "min";
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Location = new System.Drawing.Point(253, 91);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.DateCheckBox.TabIndex = 28;
            this.DateCheckBox.Text = "teraz";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(36, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(62, 13);
            this.IDLabel.TabIndex = 30;
            this.IDLabel.Text = "Wybierz ID:";
            // 
            // IDComboBox
            // 
            this.IDComboBox.FormattingEnabled = true;
            this.IDComboBox.Location = new System.Drawing.Point(104, 6);
            this.IDComboBox.Name = "IDComboBox";
            this.IDComboBox.Size = new System.Drawing.Size(143, 21);
            this.IDComboBox.TabIndex = 29;
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 194);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDComboBox);
            this.Controls.Add(this.DateCheckBox);
            this.Controls.Add(this.mLabel);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ApplyButton);
            this.Name = "AddPaymentForm";
            this.Text = "Dodaj wpłatę";
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label UserLogin;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.NumericUpDown MoneyBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.NumericUpDown MinuteBox;
        private System.Windows.Forms.NumericUpDown HourBox;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ComboBox IDComboBox;
    }
}