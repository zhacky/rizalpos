namespace RizalPOS.App.Management
{
    partial class MenuDialog
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
            this.ButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new MetroFramework.Controls.MetroButton();
            this.OK_Button = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProductsButton = new MetroFramework.Controls.MetroButton();
            this.EditSalesButton = new MetroFramework.Controls.MetroButton();
            this.ConfigurationButton = new MetroFramework.Controls.MetroButton();
            this.LogoutButton = new MetroFramework.Controls.MetroButton();
            this.ReportsButton = new MetroFramework.Controls.MetroButton();
            this.CloseCashButton = new MetroFramework.Controls.MetroButton();
            this.LocationsButton = new MetroFramework.Controls.MetroButton();
            this.UsersButton = new MetroFramework.Controls.MetroButton();
            this.RemindersButton = new MetroFramework.Controls.MetroButton();
            this.ButtonLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLayoutPanel
            // 
            this.ButtonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLayoutPanel.ColumnCount = 2;
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayoutPanel.Controls.Add(this.Cancel_Button, 1, 0);
            this.ButtonLayoutPanel.Controls.Add(this.OK_Button, 0, 0);
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(230, 433);
            this.ButtonLayoutPanel.Name = "ButtonLayoutPanel";
            this.ButtonLayoutPanel.RowCount = 1;
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayoutPanel.Size = new System.Drawing.Size(169, 39);
            this.ButtonLayoutPanel.TabIndex = 5;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(89, 8);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 11;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseSelectable = true;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_Button.Location = new System.Drawing.Point(4, 8);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 10;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33343F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33345F));
            this.tableLayoutPanel1.Controls.Add(this.ProductsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditSalesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConfigurationButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LogoutButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReportsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseCashButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LocationsButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UsersButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RemindersButton, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 364);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ProductsButton
            // 
            this.ProductsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductsButton.Location = new System.Drawing.Point(3, 3);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(119, 115);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseSelectable = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // EditSalesButton
            // 
            this.EditSalesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditSalesButton.Location = new System.Drawing.Point(128, 3);
            this.EditSalesButton.Name = "EditSalesButton";
            this.EditSalesButton.Size = new System.Drawing.Size(119, 115);
            this.EditSalesButton.TabIndex = 2;
            this.EditSalesButton.Text = "Edit Sales";
            this.EditSalesButton.UseSelectable = true;
            this.EditSalesButton.Click += new System.EventHandler(this.EditSalesButton_Click);
            // 
            // ConfigurationButton
            // 
            this.ConfigurationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfigurationButton.Location = new System.Drawing.Point(128, 245);
            this.ConfigurationButton.Name = "ConfigurationButton";
            this.ConfigurationButton.Size = new System.Drawing.Size(119, 115);
            this.ConfigurationButton.TabIndex = 8;
            this.ConfigurationButton.Text = "Configuration";
            this.ConfigurationButton.UseSelectable = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutButton.Location = new System.Drawing.Point(253, 245);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(119, 115);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseSelectable = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReportsButton.Location = new System.Drawing.Point(253, 3);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(119, 115);
            this.ReportsButton.TabIndex = 3;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseSelectable = true;
            // 
            // CloseCashButton
            // 
            this.CloseCashButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseCashButton.Location = new System.Drawing.Point(3, 124);
            this.CloseCashButton.Name = "CloseCashButton";
            this.CloseCashButton.Size = new System.Drawing.Size(119, 115);
            this.CloseCashButton.TabIndex = 4;
            this.CloseCashButton.Text = "Close Cash / End Of Day";
            this.CloseCashButton.UseSelectable = true;
            // 
            // LocationsButton
            // 
            this.LocationsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationsButton.Location = new System.Drawing.Point(128, 124);
            this.LocationsButton.Name = "LocationsButton";
            this.LocationsButton.Size = new System.Drawing.Size(119, 115);
            this.LocationsButton.TabIndex = 5;
            this.LocationsButton.Text = "Locations";
            this.LocationsButton.UseSelectable = true;
            // 
            // UsersButton
            // 
            this.UsersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersButton.Location = new System.Drawing.Point(3, 245);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(119, 115);
            this.UsersButton.TabIndex = 7;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseSelectable = true;
            // 
            // RemindersButton
            // 
            this.RemindersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemindersButton.Location = new System.Drawing.Point(253, 124);
            this.RemindersButton.Name = "RemindersButton";
            this.RemindersButton.Size = new System.Drawing.Size(119, 115);
            this.RemindersButton.TabIndex = 6;
            this.RemindersButton.Text = "Reminders";
            this.RemindersButton.UseSelectable = true;
            // 
            // MenuDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(422, 495);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.Movable = false;
            this.Name = "MenuDialog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuDialog_KeyDown);
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton ProductsButton;
        private MetroFramework.Controls.MetroButton EditSalesButton;
        private MetroFramework.Controls.MetroButton ReportsButton;
        private MetroFramework.Controls.MetroButton LocationsButton;
        private MetroFramework.Controls.MetroButton LogoutButton;
        private MetroFramework.Controls.MetroButton ConfigurationButton;
        private MetroFramework.Controls.MetroButton UsersButton;
        private MetroFramework.Controls.MetroButton CloseCashButton;
        private MetroFramework.Controls.MetroButton RemindersButton;
    }
}