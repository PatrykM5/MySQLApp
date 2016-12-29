namespace mysql
{
    partial class Panel
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
            this.PanelControl = new System.Windows.Forms.TabControl();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.OutUsers = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.ShowUserButton = new System.Windows.Forms.Button();
            this.DelUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.PlacesPage = new System.Windows.Forms.TabPage();
            this.ShowABiPlaceButton = new System.Windows.Forms.Button();
            this.DelPlaceButton = new System.Windows.Forms.Button();
            this.AddPlaceButton = new System.Windows.Forms.Button();
            this.ExtraCostsPage = new System.Windows.Forms.TabPage();
            this.PaymentPage = new System.Windows.Forms.TabPage();
            this.BikesPage = new System.Windows.Forms.TabPage();
            this.BikeListLabel = new System.Windows.Forms.Label();
            this.BikeListBox = new System.Windows.Forms.ListBox();
            this.BikeNrLabel = new System.Windows.Forms.Label();
            this.BikeNrTextBox = new System.Windows.Forms.TextBox();
            this.EditBikeButton = new System.Windows.Forms.Button();
            this.ShowBikeButton = new System.Windows.Forms.Button();
            this.DelBikeButton = new System.Windows.Forms.Button();
            this.AddBikeButton = new System.Windows.Forms.Button();
            this.RentsPage = new System.Windows.Forms.TabPage();
            this.AdminsPage = new System.Windows.Forms.TabPage();
            this.ConStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionOKLabel = new System.Windows.Forms.Label();
            this.ConnectionBrakLabel = new System.Windows.Forms.Label();
            this.backgroundW = new System.ComponentModel.BackgroundWorker();
            this.PanelControl.SuspendLayout();
            this.UsersPage.SuspendLayout();
            this.PlacesPage.SuspendLayout();
            this.BikesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl
            // 
            this.PanelControl.Controls.Add(this.UsersPage);
            this.PanelControl.Controls.Add(this.PlacesPage);
            this.PanelControl.Controls.Add(this.ExtraCostsPage);
            this.PanelControl.Controls.Add(this.PaymentPage);
            this.PanelControl.Controls.Add(this.BikesPage);
            this.PanelControl.Controls.Add(this.RentsPage);
            this.PanelControl.Controls.Add(this.AdminsPage);
            this.PanelControl.Location = new System.Drawing.Point(12, 12);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.SelectedIndex = 0;
            this.PanelControl.Size = new System.Drawing.Size(521, 336);
            this.PanelControl.TabIndex = 0;
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.UserListBox);
            this.UsersPage.Controls.Add(this.EditUserButton);
            this.UsersPage.Controls.Add(this.OutUsers);
            this.UsersPage.Controls.Add(this.UserName);
            this.UsersPage.Controls.Add(this.UserLoginBox);
            this.UsersPage.Controls.Add(this.ShowUserButton);
            this.UsersPage.Controls.Add(this.DelUserButton);
            this.UsersPage.Controls.Add(this.AddUserButton);
            this.UsersPage.Location = new System.Drawing.Point(4, 22);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(513, 310);
            this.UsersPage.TabIndex = 0;
            this.UsersPage.Text = "Użytkownicy";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(275, 109);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(152, 173);
            this.UserListBox.TabIndex = 11;
            this.UserListBox.SelectedIndexChanged += new System.EventHandler(this.UserListBox_SelectedIndexChanged);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(38, 164);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(124, 35);
            this.EditUserButton.TabIndex = 10;
            this.EditUserButton.Text = "Edytuj dane użytkownika";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // OutUsers
            // 
            this.OutUsers.AutoSize = true;
            this.OutUsers.Location = new System.Drawing.Point(272, 93);
            this.OutUsers.Name = "OutUsers";
            this.OutUsers.Size = new System.Drawing.Size(102, 13);
            this.OutUsers.TabIndex = 8;
            this.OutUsers.Text = "Lista użytkowników:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(272, 25);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(155, 13);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Szukaj użytkownika po nazwie:";
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.Location = new System.Drawing.Point(275, 41);
            this.UserLoginBox.Name = "UserLoginBox";
            this.UserLoginBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserLoginBox.Size = new System.Drawing.Size(152, 20);
            this.UserLoginBox.TabIndex = 3;
            this.UserLoginBox.TextChanged += new System.EventHandler(this.UserLoginBox_TextChanged);
            // 
            // ShowUserButton
            // 
            this.ShowUserButton.Location = new System.Drawing.Point(38, 123);
            this.ShowUserButton.Name = "ShowUserButton";
            this.ShowUserButton.Size = new System.Drawing.Size(124, 35);
            this.ShowUserButton.TabIndex = 2;
            this.ShowUserButton.Text = "Wyświetl użytkownika";
            this.ShowUserButton.UseVisualStyleBackColor = true;
            this.ShowUserButton.Click += new System.EventHandler(this.ShowUserButton_Click);
            // 
            // DelUserButton
            // 
            this.DelUserButton.Location = new System.Drawing.Point(38, 82);
            this.DelUserButton.Name = "DelUserButton";
            this.DelUserButton.Size = new System.Drawing.Size(124, 35);
            this.DelUserButton.TabIndex = 1;
            this.DelUserButton.Text = "Usuń użytkownika";
            this.DelUserButton.UseVisualStyleBackColor = true;
            this.DelUserButton.Click += new System.EventHandler(this.DelUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(38, 41);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(124, 35);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Dodaj użytkownika";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // PlacesPage
            // 
            this.PlacesPage.Controls.Add(this.ShowABiPlaceButton);
            this.PlacesPage.Controls.Add(this.DelPlaceButton);
            this.PlacesPage.Controls.Add(this.AddPlaceButton);
            this.PlacesPage.Location = new System.Drawing.Point(4, 22);
            this.PlacesPage.Name = "PlacesPage";
            this.PlacesPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlacesPage.Size = new System.Drawing.Size(513, 310);
            this.PlacesPage.TabIndex = 1;
            this.PlacesPage.Text = "Miejsca";
            this.PlacesPage.UseVisualStyleBackColor = true;
            // 
            // ShowABiPlaceButton
            // 
            this.ShowABiPlaceButton.Location = new System.Drawing.Point(38, 122);
            this.ShowABiPlaceButton.Name = "ShowABiPlaceButton";
            this.ShowABiPlaceButton.Size = new System.Drawing.Size(124, 40);
            this.ShowABiPlaceButton.TabIndex = 2;
            this.ShowABiPlaceButton.Text = "Wypisz rowery z miejsca";
            this.ShowABiPlaceButton.UseVisualStyleBackColor = true;
            // 
            // DelPlaceButton
            // 
            this.DelPlaceButton.Location = new System.Drawing.Point(38, 82);
            this.DelPlaceButton.Name = "DelPlaceButton";
            this.DelPlaceButton.Size = new System.Drawing.Size(124, 34);
            this.DelPlaceButton.TabIndex = 1;
            this.DelPlaceButton.Text = "Usuń miejsce";
            this.DelPlaceButton.UseVisualStyleBackColor = true;
            // 
            // AddPlaceButton
            // 
            this.AddPlaceButton.Location = new System.Drawing.Point(38, 41);
            this.AddPlaceButton.Name = "AddPlaceButton";
            this.AddPlaceButton.Size = new System.Drawing.Size(124, 35);
            this.AddPlaceButton.TabIndex = 0;
            this.AddPlaceButton.Text = "Dodaj miejsce";
            this.AddPlaceButton.UseVisualStyleBackColor = true;
            // 
            // ExtraCostsPage
            // 
            this.ExtraCostsPage.Location = new System.Drawing.Point(4, 22);
            this.ExtraCostsPage.Name = "ExtraCostsPage";
            this.ExtraCostsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExtraCostsPage.Size = new System.Drawing.Size(513, 310);
            this.ExtraCostsPage.TabIndex = 2;
            this.ExtraCostsPage.Text = "Koszty dodatkowe";
            this.ExtraCostsPage.UseVisualStyleBackColor = true;
            // 
            // PaymentPage
            // 
            this.PaymentPage.Location = new System.Drawing.Point(4, 22);
            this.PaymentPage.Name = "PaymentPage";
            this.PaymentPage.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentPage.Size = new System.Drawing.Size(513, 310);
            this.PaymentPage.TabIndex = 3;
            this.PaymentPage.Text = "Wpłaty";
            this.PaymentPage.UseVisualStyleBackColor = true;
            // 
            // BikesPage
            // 
            this.BikesPage.Controls.Add(this.BikeListLabel);
            this.BikesPage.Controls.Add(this.BikeListBox);
            this.BikesPage.Controls.Add(this.BikeNrLabel);
            this.BikesPage.Controls.Add(this.BikeNrTextBox);
            this.BikesPage.Controls.Add(this.EditBikeButton);
            this.BikesPage.Controls.Add(this.ShowBikeButton);
            this.BikesPage.Controls.Add(this.DelBikeButton);
            this.BikesPage.Controls.Add(this.AddBikeButton);
            this.BikesPage.Location = new System.Drawing.Point(4, 22);
            this.BikesPage.Name = "BikesPage";
            this.BikesPage.Padding = new System.Windows.Forms.Padding(3);
            this.BikesPage.Size = new System.Drawing.Size(513, 310);
            this.BikesPage.TabIndex = 4;
            this.BikesPage.Text = "Rowery";
            this.BikesPage.UseVisualStyleBackColor = true;
            // 
            // BikeListLabel
            // 
            this.BikeListLabel.AutoSize = true;
            this.BikeListLabel.Location = new System.Drawing.Point(272, 93);
            this.BikeListLabel.Name = "BikeListLabel";
            this.BikeListLabel.Size = new System.Drawing.Size(75, 13);
            this.BikeListLabel.TabIndex = 8;
            this.BikeListLabel.Text = "Lista rowerów:";
            // 
            // BikeListBox
            // 
            this.BikeListBox.FormattingEnabled = true;
            this.BikeListBox.Location = new System.Drawing.Point(275, 109);
            this.BikeListBox.Name = "BikeListBox";
            this.BikeListBox.Size = new System.Drawing.Size(152, 173);
            this.BikeListBox.TabIndex = 7;
            // 
            // BikeNrLabel
            // 
            this.BikeNrLabel.AutoSize = true;
            this.BikeNrLabel.Location = new System.Drawing.Point(272, 25);
            this.BikeNrLabel.Name = "BikeNrLabel";
            this.BikeNrLabel.Size = new System.Drawing.Size(53, 13);
            this.BikeNrLabel.TabIndex = 6;
            this.BikeNrLabel.Text = "Nr roweru";
            // 
            // BikeNrTextBox
            // 
            this.BikeNrTextBox.Location = new System.Drawing.Point(275, 41);
            this.BikeNrTextBox.Name = "BikeNrTextBox";
            this.BikeNrTextBox.Size = new System.Drawing.Size(152, 20);
            this.BikeNrTextBox.TabIndex = 5;
            this.BikeNrTextBox.TextChanged += new System.EventHandler(this.BikeNrTextBox_TextChanged);
            // 
            // EditBikeButton
            // 
            this.EditBikeButton.Location = new System.Drawing.Point(38, 164);
            this.EditBikeButton.Name = "EditBikeButton";
            this.EditBikeButton.Size = new System.Drawing.Size(124, 35);
            this.EditBikeButton.TabIndex = 3;
            this.EditBikeButton.Text = "Edytuj dane roweru";
            this.EditBikeButton.UseVisualStyleBackColor = true;
            this.EditBikeButton.Click += new System.EventHandler(this.EditBikeButton_Click);
            // 
            // ShowBikeButton
            // 
            this.ShowBikeButton.Location = new System.Drawing.Point(38, 123);
            this.ShowBikeButton.Name = "ShowBikeButton";
            this.ShowBikeButton.Size = new System.Drawing.Size(124, 35);
            this.ShowBikeButton.TabIndex = 2;
            this.ShowBikeButton.Text = "Informacje o rowerze";
            this.ShowBikeButton.UseVisualStyleBackColor = true;
            this.ShowBikeButton.Click += new System.EventHandler(this.ShowBikeButton_Click);
            // 
            // DelBikeButton
            // 
            this.DelBikeButton.Location = new System.Drawing.Point(38, 82);
            this.DelBikeButton.Name = "DelBikeButton";
            this.DelBikeButton.Size = new System.Drawing.Size(124, 35);
            this.DelBikeButton.TabIndex = 1;
            this.DelBikeButton.Text = "Usuń rower";
            this.DelBikeButton.UseVisualStyleBackColor = true;
            this.DelBikeButton.Click += new System.EventHandler(this.DelBikeButton_Click);
            // 
            // AddBikeButton
            // 
            this.AddBikeButton.Location = new System.Drawing.Point(38, 41);
            this.AddBikeButton.Name = "AddBikeButton";
            this.AddBikeButton.Size = new System.Drawing.Size(124, 35);
            this.AddBikeButton.TabIndex = 0;
            this.AddBikeButton.Text = "Dodaj rower";
            this.AddBikeButton.UseVisualStyleBackColor = true;
            this.AddBikeButton.Click += new System.EventHandler(this.AddBikeButton_Click);
            // 
            // RentsPage
            // 
            this.RentsPage.Location = new System.Drawing.Point(4, 22);
            this.RentsPage.Name = "RentsPage";
            this.RentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.RentsPage.Size = new System.Drawing.Size(513, 310);
            this.RentsPage.TabIndex = 5;
            this.RentsPage.Text = "Wypożyczenia";
            this.RentsPage.UseVisualStyleBackColor = true;
            // 
            // AdminsPage
            // 
            this.AdminsPage.Location = new System.Drawing.Point(4, 22);
            this.AdminsPage.Name = "AdminsPage";
            this.AdminsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminsPage.Size = new System.Drawing.Size(513, 310);
            this.AdminsPage.TabIndex = 6;
            this.AdminsPage.Text = "Administratorzy";
            this.AdminsPage.UseVisualStyleBackColor = true;
            // 
            // ConStatusLabel
            // 
            this.ConStatusLabel.AutoSize = true;
            this.ConStatusLabel.Location = new System.Drawing.Point(397, 351);
            this.ConStatusLabel.Name = "ConStatusLabel";
            this.ConStatusLabel.Size = new System.Drawing.Size(88, 13);
            this.ConStatusLabel.TabIndex = 1;
            this.ConStatusLabel.Text = "Stan połączenia:";
            // 
            // ConnectionOKLabel
            // 
            this.ConnectionOKLabel.AutoSize = true;
            this.ConnectionOKLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.ConnectionOKLabel.Location = new System.Drawing.Point(491, 351);
            this.ConnectionOKLabel.Name = "ConnectionOKLabel";
            this.ConnectionOKLabel.Size = new System.Drawing.Size(22, 13);
            this.ConnectionOKLabel.TabIndex = 2;
            this.ConnectionOKLabel.Text = "OK";
            // 
            // ConnectionBrakLabel
            // 
            this.ConnectionBrakLabel.AutoSize = true;
            this.ConnectionBrakLabel.ForeColor = System.Drawing.Color.Red;
            this.ConnectionBrakLabel.Location = new System.Drawing.Point(484, 351);
            this.ConnectionBrakLabel.Name = "ConnectionBrakLabel";
            this.ConnectionBrakLabel.Size = new System.Drawing.Size(29, 13);
            this.ConnectionBrakLabel.TabIndex = 3;
            this.ConnectionBrakLabel.Text = "Brak";
            // 
            // backgroundW
            // 
            this.backgroundW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundW_DoWork);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(538, 369);
            this.Controls.Add(this.ConnectionBrakLabel);
            this.Controls.Add(this.ConnectionOKLabel);
            this.Controls.Add(this.ConStatusLabel);
            this.Controls.Add(this.PanelControl);
            this.Name = "Panel";
            this.Text = "Panel sterowania bazą danych";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_FormClosing);
            this.Load += new System.EventHandler(this.Panel_Load);
            this.Shown += new System.EventHandler(this.Panel_Shown);
            this.PanelControl.ResumeLayout(false);
            this.UsersPage.ResumeLayout(false);
            this.UsersPage.PerformLayout();
            this.PlacesPage.ResumeLayout(false);
            this.BikesPage.ResumeLayout(false);
            this.BikesPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl PanelControl;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.Button DelUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TabPage PlacesPage;
        private System.Windows.Forms.TabPage ExtraCostsPage;
        private System.Windows.Forms.TabPage PaymentPage;
        private System.Windows.Forms.TabPage BikesPage;
        private System.Windows.Forms.TabPage RentsPage;
        private System.Windows.Forms.TabPage AdminsPage;
        private System.Windows.Forms.Button ShowUserButton;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.Label OutUsers;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button ShowBikeButton;
        private System.Windows.Forms.Button DelBikeButton;
        private System.Windows.Forms.Button AddBikeButton;
        private System.Windows.Forms.Button DelPlaceButton;
        private System.Windows.Forms.Button AddPlaceButton;
        private System.Windows.Forms.Button EditBikeButton;
        private System.Windows.Forms.Button ShowABiPlaceButton;
        private System.Windows.Forms.Label BikeNrLabel;
        private System.Windows.Forms.TextBox BikeNrTextBox;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.ListBox BikeListBox;
        private System.Windows.Forms.Label BikeListLabel;
        private System.Windows.Forms.Label ConStatusLabel;
        private System.Windows.Forms.Label ConnectionOKLabel;
        private System.Windows.Forms.Label ConnectionBrakLabel;
        private System.ComponentModel.BackgroundWorker backgroundW;
    }
}