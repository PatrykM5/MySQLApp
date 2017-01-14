namespace mysql
{
    partial class AddECostForm
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
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.YesRButton = new System.Windows.Forms.RadioButton();
            this.NoRButton = new System.Windows.Forms.RadioButton();
            this.MoneyBox = new System.Windows.Forms.NumericUpDown();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.PaidLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDComboBox = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ToPayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(124, 117);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(143, 20);
            this.DateBox.TabIndex = 0;
            this.DateBox.ValueChanged += new System.EventHandler(this.DateBox_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(51, 117);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(67, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Data kosztu:";
            // 
            // YesRButton
            // 
            this.YesRButton.AutoSize = true;
            this.YesRButton.Location = new System.Drawing.Point(124, 143);
            this.YesRButton.Name = "YesRButton";
            this.YesRButton.Size = new System.Drawing.Size(44, 17);
            this.YesRButton.TabIndex = 2;
            this.YesRButton.TabStop = true;
            this.YesRButton.Text = "Tak";
            this.YesRButton.UseVisualStyleBackColor = true;
            this.YesRButton.CheckedChanged += new System.EventHandler(this.YesRButton_CheckedChanged);
            // 
            // NoRButton
            // 
            this.NoRButton.AutoSize = true;
            this.NoRButton.Location = new System.Drawing.Point(174, 143);
            this.NoRButton.Name = "NoRButton";
            this.NoRButton.Size = new System.Drawing.Size(41, 17);
            this.NoRButton.TabIndex = 3;
            this.NoRButton.TabStop = true;
            this.NoRButton.Text = "Nie";
            this.NoRButton.UseVisualStyleBackColor = true;
            this.NoRButton.CheckedChanged += new System.EventHandler(this.NoRButton_CheckedChanged);
            // 
            // MoneyBox
            // 
            this.MoneyBox.DecimalPlaces = 2;
            this.MoneyBox.Location = new System.Drawing.Point(124, 91);
            this.MoneyBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(143, 20);
            this.MoneyBox.TabIndex = 4;
            this.MoneyBox.ValueChanged += new System.EventHandler(this.MoneyBox_ValueChanged);
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(34, 93);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(84, 13);
            this.MoneyLabel.TabIndex = 5;
            this.MoneyLabel.Text = "Wartość kosztu:";
            // 
            // PaidLabel
            // 
            this.PaidLabel.AutoSize = true;
            this.PaidLabel.Location = new System.Drawing.Point(55, 145);
            this.PaidLabel.Name = "PaidLabel";
            this.PaidLabel.Size = new System.Drawing.Size(63, 13);
            this.PaidLabel.TabIndex = 6;
            this.PaidLabel.Text = "Zapłacone:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(124, 39);
            this.DescriptionBox.MaxLength = 255;
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(143, 46);
            this.DescriptionBox.TabIndex = 7;
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(53, 42);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(65, 13);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Opis kosztu:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(11, 199);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 34);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(107, 199);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(90, 34);
            this.ApplyButton.TabIndex = 10;
            this.ApplyButton.Text = "Zastosuj";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(203, 199);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 34);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDComboBox
            // 
            this.IDComboBox.FormattingEnabled = true;
            this.IDComboBox.Location = new System.Drawing.Point(124, 12);
            this.IDComboBox.Name = "IDComboBox";
            this.IDComboBox.Size = new System.Drawing.Size(143, 21);
            this.IDComboBox.TabIndex = 12;
            this.IDComboBox.SelectedIndexChanged += new System.EventHandler(this.IDComboBox_SelectedIndexChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(56, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(62, 13);
            this.IDLabel.TabIndex = 13;
            this.IDLabel.Text = "Wybierz ID:";
            // 
            // ToPayLabel
            // 
            this.ToPayLabel.AutoSize = true;
            this.ToPayLabel.Location = new System.Drawing.Point(27, 174);
            this.ToPayLabel.Name = "ToPayLabel";
            this.ToPayLabel.Size = new System.Drawing.Size(170, 13);
            this.ToPayLabel.TabIndex = 14;
            this.ToPayLabel.Text = "Do zapłacenia przez użytkownika:";
            // 
            // AddECostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 245);
            this.Controls.Add(this.ToPayLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IDComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.PaidLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.NoRButton);
            this.Controls.Add(this.YesRButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateBox);
            this.Name = "AddECostForm";
            this.Text = "Dodawanie kosztów dodatkowych";
            this.Load += new System.EventHandler(this.AddECostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoneyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.RadioButton YesRButton;
        private System.Windows.Forms.RadioButton NoRButton;
        private System.Windows.Forms.NumericUpDown MoneyBox;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label PaidLabel;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox IDComboBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label ToPayLabel;
    }
}