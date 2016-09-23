namespace RizalPOS.App.Management
{
    partial class UserManagementDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new MetroFramework.Controls.MetroButton();
            this.OK_Button = new MetroFramework.Controls.MetroButton();
            this.UsersGrid = new MetroFramework.Controls.MetroGrid();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RoleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.AddUserButton = new MetroFramework.Controls.MetroButton();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.ButtonLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
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
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(237, 320);
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
            this.Cancel_Button.TabIndex = 6;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseSelectable = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(4, 8);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 5;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // UsersGrid
            // 
            this.UsersGrid.AllowUserToAddRows = false;
            this.UsersGrid.AllowUserToDeleteRows = false;
            this.UsersGrid.AllowUserToResizeColumns = false;
            this.UsersGrid.AllowUserToResizeRows = false;
            this.UsersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UsersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UsersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersGrid.EnableHeadersVisualStyles = false;
            this.UsersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UsersGrid.Location = new System.Drawing.Point(23, 176);
            this.UsersGrid.MultiSelect = false;
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ReadOnly = true;
            this.UsersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGrid.RowHeadersVisible = false;
            this.UsersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UsersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGrid.ShowEditingIcon = false;
            this.UsersGrid.Size = new System.Drawing.Size(383, 138);
            this.UsersGrid.TabIndex = 6;
            this.UsersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGrid_CellContentClick);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(24, 75);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 19);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            // 
            // 
            // 
            this.UsernameTextBox.CustomButton.Image = null;
            this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.UsernameTextBox.CustomButton.Name = "";
            this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBox.CustomButton.TabIndex = 1;
            this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBox.CustomButton.UseSelectable = true;
            this.UsernameTextBox.CustomButton.Visible = false;
            this.UsernameTextBox.Enabled = false;
            this.UsernameTextBox.Lines = new string[0];
            this.UsernameTextBox.Location = new System.Drawing.Point(113, 71);
            this.UsernameTextBox.MaxLength = 32767;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.SelectionLength = 0;
            this.UsernameTextBox.SelectionStart = 0;
            this.UsernameTextBox.ShortcutsEnabled = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(131, 23);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(250, 71);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Edit";
            this.UpdateButton.UseSelectable = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 115);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 19);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Enabled = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(113, 111);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(131, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Enabled = false;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.ItemHeight = 23;
            this.RoleComboBox.Location = new System.Drawing.Point(285, 111);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(121, 29);
            this.RoleComboBox.TabIndex = 3;
            this.RoleComboBox.UseSelectable = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(331, 71);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Add New";
            this.AddUserButton.UseSelectable = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(331, 146);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UserManagementDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(429, 382);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsersGrid);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.Name = "UserManagementDialog";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UserManagementDialog_Load);
            this.ButtonLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
        private MetroFramework.Controls.MetroGrid UsersGrid;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroButton UpdateButton;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroComboBox RoleComboBox;
        private MetroFramework.Controls.MetroButton AddUserButton;
        private MetroFramework.Controls.MetroButton SaveButton;
    }
}