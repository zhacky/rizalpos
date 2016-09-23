namespace RizalPOS.App.Management
{
    partial class LoginDialog
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
            this.LoginPanel = new MetroFramework.Controls.MetroPanel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ButtonLayoutPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
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
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(230, 199);
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
            this.Cancel_Button.TabIndex = 4;
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
            this.OK_Button.TabIndex = 3;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.PasswordTextBox);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.UsernameTextBox);
            this.LoginPanel.HorizontalScrollbarBarColor = true;
            this.LoginPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LoginPanel.HorizontalScrollbarSize = 10;
            this.LoginPanel.Location = new System.Drawing.Point(61, 44);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(311, 133);
            this.LoginPanel.TabIndex = 6;
            this.LoginPanel.VerticalScrollbarBarColor = true;
            this.LoginPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LoginPanel.VerticalScrollbarSize = 10;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(39, 76);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 19);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(108, 76);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(173, 28);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(34, 29);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 19);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            // 
            // 
            // 
            this.UsernameTextBox.CustomButton.Image = null;
            this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.UsernameTextBox.CustomButton.Name = "";
            this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBox.CustomButton.TabIndex = 1;
            this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBox.CustomButton.UseSelectable = true;
            this.UsernameTextBox.CustomButton.Visible = false;
            this.UsernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.UsernameTextBox.Lines = new string[0];
            this.UsernameTextBox.Location = new System.Drawing.Point(108, 29);
            this.UsernameTextBox.MaxLength = 32767;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.SelectionLength = 0;
            this.UsernameTextBox.SelectionStart = 0;
            this.UsernameTextBox.ShortcutsEnabled = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(173, 28);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.ControlBox = false;
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.Name = "LoginDialog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.LoginDialog_Load);
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
        private MetroFramework.Controls.MetroPanel LoginPanel;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
    }
}