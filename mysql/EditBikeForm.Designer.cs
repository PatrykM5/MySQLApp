namespace mysql
{
    partial class EditBikeForm
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
            this.BikeNumLabel = new System.Windows.Forms.Label();
            this.EdBikeNumTBox = new System.Windows.Forms.TextBox();
            this.PlaceBikeLabel = new System.Windows.Forms.Label();
            this.EdBikePlaceCBox = new System.Windows.Forms.ComboBox();
            this.EdBikeUsLoginCBox = new System.Windows.Forms.ComboBox();
            this.LoginUserLabel = new System.Windows.Forms.Label();
            this.RentBikeLabel = new System.Windows.Forms.Label();
            this.RentYesRButton = new System.Windows.Forms.RadioButton();
            this.RentNoRButton = new System.Windows.Forms.RadioButton();
            this.StatusBikeLabel = new System.Windows.Forms.Label();
            this.EditBikeButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.BikeStatusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BikeNumLabel
            // 
            this.BikeNumLabel.AutoSize = true;
            this.BikeNumLabel.Location = new System.Drawing.Point(73, 47);
            this.BikeNumLabel.Name = "BikeNumLabel";
            this.BikeNumLabel.Size = new System.Drawing.Size(41, 13);
            this.BikeNumLabel.TabIndex = 0;
            this.BikeNumLabel.Text = "Numer:";
            // 
            // EdBikeNumTBox
            // 
            this.EdBikeNumTBox.Location = new System.Drawing.Point(120, 44);
            this.EdBikeNumTBox.Name = "EdBikeNumTBox";
            this.EdBikeNumTBox.Size = new System.Drawing.Size(121, 20);
            this.EdBikeNumTBox.TabIndex = 1;
            this.EdBikeNumTBox.TextChanged += new System.EventHandler(this.EdBikeNumTBox_TextChanged);
            // 
            // PlaceBikeLabel
            // 
            this.PlaceBikeLabel.AutoSize = true;
            this.PlaceBikeLabel.Location = new System.Drawing.Point(68, 73);
            this.PlaceBikeLabel.Name = "PlaceBikeLabel";
            this.PlaceBikeLabel.Size = new System.Drawing.Size(46, 13);
            this.PlaceBikeLabel.TabIndex = 2;
            this.PlaceBikeLabel.Text = "Miejsce:";
            // 
            // EdBikePlaceCBox
            // 
            this.EdBikePlaceCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EdBikePlaceCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EdBikePlaceCBox.FormattingEnabled = true;
            this.EdBikePlaceCBox.Location = new System.Drawing.Point(120, 70);
            this.EdBikePlaceCBox.Name = "EdBikePlaceCBox";
            this.EdBikePlaceCBox.Size = new System.Drawing.Size(121, 21);
            this.EdBikePlaceCBox.TabIndex = 4;
            this.EdBikePlaceCBox.SelectedIndexChanged += new System.EventHandler(this.EdBikePlaceCBox_SelectedIndexChanged);
            // 
            // EdBikeUsLoginCBox
            // 
            this.EdBikeUsLoginCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EdBikeUsLoginCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EdBikeUsLoginCBox.FormattingEnabled = true;
            this.EdBikeUsLoginCBox.Location = new System.Drawing.Point(120, 128);
            this.EdBikeUsLoginCBox.Name = "EdBikeUsLoginCBox";
            this.EdBikeUsLoginCBox.Size = new System.Drawing.Size(121, 21);
            this.EdBikeUsLoginCBox.TabIndex = 5;
            this.EdBikeUsLoginCBox.SelectedIndexChanged += new System.EventHandler(this.EdBikeUsLoginCBox_SelectedIndexChanged);
            // 
            // LoginUserLabel
            // 
            this.LoginUserLabel.AutoSize = true;
            this.LoginUserLabel.Location = new System.Drawing.Point(16, 131);
            this.LoginUserLabel.Name = "LoginUserLabel";
            this.LoginUserLabel.Size = new System.Drawing.Size(98, 13);
            this.LoginUserLabel.TabIndex = 6;
            this.LoginUserLabel.Text = "Login użytkownika:";
            // 
            // RentBikeLabel
            // 
            this.RentBikeLabel.AutoSize = true;
            this.RentBikeLabel.Location = new System.Drawing.Point(38, 103);
            this.RentBikeLabel.Name = "RentBikeLabel";
            this.RentBikeLabel.Size = new System.Drawing.Size(76, 13);
            this.RentBikeLabel.TabIndex = 7;
            this.RentBikeLabel.Text = "Wypożyczony:";
            // 
            // RentYesRButton
            // 
            this.RentYesRButton.AutoSize = true;
            this.RentYesRButton.Location = new System.Drawing.Point(120, 101);
            this.RentYesRButton.Name = "RentYesRButton";
            this.RentYesRButton.Size = new System.Drawing.Size(44, 17);
            this.RentYesRButton.TabIndex = 8;
            this.RentYesRButton.TabStop = true;
            this.RentYesRButton.Text = "Tak";
            this.RentYesRButton.UseVisualStyleBackColor = true;
            this.RentYesRButton.CheckedChanged += new System.EventHandler(this.RentYesRButton_CheckedChanged);
            // 
            // RentNoRButton
            // 
            this.RentNoRButton.AutoSize = true;
            this.RentNoRButton.Location = new System.Drawing.Point(170, 101);
            this.RentNoRButton.Name = "RentNoRButton";
            this.RentNoRButton.Size = new System.Drawing.Size(41, 17);
            this.RentNoRButton.TabIndex = 9;
            this.RentNoRButton.TabStop = true;
            this.RentNoRButton.Text = "Nie";
            this.RentNoRButton.UseVisualStyleBackColor = true;
            this.RentNoRButton.CheckedChanged += new System.EventHandler(this.RentNoRButton_CheckedChanged);
            // 
            // StatusBikeLabel
            // 
            this.StatusBikeLabel.AutoSize = true;
            this.StatusBikeLabel.Location = new System.Drawing.Point(82, 158);
            this.StatusBikeLabel.Name = "StatusBikeLabel";
            this.StatusBikeLabel.Size = new System.Drawing.Size(32, 13);
            this.StatusBikeLabel.TabIndex = 10;
            this.StatusBikeLabel.Text = "Stan:";
            // 
            // EditBikeButton
            // 
            this.EditBikeButton.Location = new System.Drawing.Point(98, 215);
            this.EditBikeButton.Name = "EditBikeButton";
            this.EditBikeButton.Size = new System.Drawing.Size(90, 34);
            this.EditBikeButton.TabIndex = 11;
            this.EditBikeButton.Text = "Zastosuj zmiany";
            this.EditBikeButton.UseVisualStyleBackColor = true;
            this.EditBikeButton.Click += new System.EventHandler(this.EditBikeButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(2, 215);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(90, 34);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(194, 215);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 34);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(58, 19);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(56, 13);
            this.IDLabel.TabIndex = 14;
            this.IDLabel.Text = "ID roweru:";
            // 
            // BikeStatusBox
            // 
            this.BikeStatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BikeStatusBox.FormattingEnabled = true;
            this.BikeStatusBox.Items.AddRange(new object[] {
            "Sprawny",
            "Zepsuty",
            "W naprawie"});
            this.BikeStatusBox.Location = new System.Drawing.Point(120, 155);
            this.BikeStatusBox.Name = "BikeStatusBox";
            this.BikeStatusBox.Size = new System.Drawing.Size(121, 21);
            this.BikeStatusBox.TabIndex = 15;
            this.BikeStatusBox.SelectedIndexChanged += new System.EventHandler(this.BikeStatusBox_SelectedIndexChanged);
            // 
            // EditBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.BikeStatusBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EditBikeButton);
            this.Controls.Add(this.StatusBikeLabel);
            this.Controls.Add(this.RentNoRButton);
            this.Controls.Add(this.RentYesRButton);
            this.Controls.Add(this.RentBikeLabel);
            this.Controls.Add(this.LoginUserLabel);
            this.Controls.Add(this.EdBikeUsLoginCBox);
            this.Controls.Add(this.EdBikePlaceCBox);
            this.Controls.Add(this.PlaceBikeLabel);
            this.Controls.Add(this.EdBikeNumTBox);
            this.Controls.Add(this.BikeNumLabel);
            this.Name = "EditBikeForm";
            this.Text = "Edytuj dane roweru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BikeNumLabel;
        private System.Windows.Forms.TextBox EdBikeNumTBox;
        private System.Windows.Forms.Label PlaceBikeLabel;
        private System.Windows.Forms.ComboBox EdBikePlaceCBox;
        private System.Windows.Forms.ComboBox EdBikeUsLoginCBox;
        private System.Windows.Forms.Label LoginUserLabel;
        private System.Windows.Forms.Label RentBikeLabel;
        private System.Windows.Forms.RadioButton RentYesRButton;
        private System.Windows.Forms.RadioButton RentNoRButton;
        private System.Windows.Forms.Label StatusBikeLabel;
        private System.Windows.Forms.Button EditBikeButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ComboBox BikeStatusBox;
    }
}