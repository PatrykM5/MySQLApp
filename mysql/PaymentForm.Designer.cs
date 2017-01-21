namespace mysql
{
    partial class PaymentForm
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
            this.DataBox = new System.Windows.Forms.DataGridView();
            this.FromDateBox = new System.Windows.Forms.DateTimePicker();
            this.ToDateForm = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBox
            // 
            this.DataBox.AllowUserToOrderColumns = true;
            this.DataBox.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBox.Location = new System.Drawing.Point(12, 91);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(378, 193);
            this.DataBox.TabIndex = 0;
            // 
            // FromDateBox
            // 
            this.FromDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateBox.Location = new System.Drawing.Point(41, 65);
            this.FromDateBox.Name = "FromDateBox";
            this.FromDateBox.Size = new System.Drawing.Size(92, 20);
            this.FromDateBox.TabIndex = 1;
            this.FromDateBox.ValueChanged += new System.EventHandler(this.FromDateBox_ValueChanged);
            // 
            // ToDateForm
            // 
            this.ToDateForm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateForm.Location = new System.Drawing.Point(168, 65);
            this.ToDateForm.Name = "ToDateForm";
            this.ToDateForm.Size = new System.Drawing.Size(92, 20);
            this.ToDateForm.TabIndex = 2;
            this.ToDateForm.ValueChanged += new System.EventHandler(this.ToDateForm_ValueChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(12, 68);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(24, 13);
            this.FromLabel.TabIndex = 3;
            this.FromLabel.Text = "Od:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(139, 68);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(24, 13);
            this.ToLabel.TabIndex = 4;
            this.ToLabel.Text = "Do:";
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Location = new System.Drawing.Point(12, 35);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(104, 13);
            this.UserLogin.TabIndex = 18;
            this.UserLogin.Text = "Login użytkownika:  ";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(248, 293);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 34);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(152, 293);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(90, 34);
            this.ApplyButton.TabIndex = 20;
            this.ApplyButton.Text = "Zastosuj";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(56, 293);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 34);
            this.OKButton.TabIndex = 19;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 339);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ToDateForm);
            this.Controls.Add(this.FromDateBox);
            this.Controls.Add(this.DataBox);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataBox;
        private System.Windows.Forms.DateTimePicker FromDateBox;
        private System.Windows.Forms.DateTimePicker ToDateForm;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label UserLogin;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button OKButton;
    }
}