namespace RizalPOS.App.Customers
{
    partial class CustomerDialog
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
            this.CustomersGrid = new MetroFramework.Controls.MetroGrid();
            this.SearchCustomerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CustomerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.CustomerNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CustomerCodeLabel = new MetroFramework.Controls.MetroLabel();
            this.CustomerCodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.GenerateCodeButton = new MetroFramework.Controls.MetroButton();
            this.AddCustomerButton = new MetroFramework.Controls.MetroButton();
            this.DeleteCustomerButton = new MetroFramework.Controls.MetroButton();
            this.ButtonLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
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
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(493, 394);
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
            this.Cancel_Button.TabIndex = 1;
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
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.AllowUserToAddRows = false;
            this.CustomersGrid.AllowUserToDeleteRows = false;
            this.CustomersGrid.AllowUserToResizeColumns = false;
            this.CustomersGrid.AllowUserToResizeRows = false;
            this.CustomersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CustomersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomersGrid.EnableHeadersVisualStyles = false;
            this.CustomersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustomersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomersGrid.Location = new System.Drawing.Point(23, 102);
            this.CustomersGrid.MultiSelect = false;
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.ReadOnly = true;
            this.CustomersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersGrid.RowHeadersVisible = false;
            this.CustomersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomersGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGrid.Size = new System.Drawing.Size(451, 331);
            this.CustomersGrid.TabIndex = 6;
            this.CustomersGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomersGrid_KeyUp);
            // 
            // SearchCustomerTextBox
            // 
            // 
            // 
            // 
            this.SearchCustomerTextBox.CustomButton.Image = null;
            this.SearchCustomerTextBox.CustomButton.Location = new System.Drawing.Point(429, 1);
            this.SearchCustomerTextBox.CustomButton.Name = "";
            this.SearchCustomerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchCustomerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchCustomerTextBox.CustomButton.TabIndex = 1;
            this.SearchCustomerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchCustomerTextBox.CustomButton.UseSelectable = true;
            this.SearchCustomerTextBox.CustomButton.Visible = false;
            this.SearchCustomerTextBox.Lines = new string[0];
            this.SearchCustomerTextBox.Location = new System.Drawing.Point(23, 73);
            this.SearchCustomerTextBox.MaxLength = 32767;
            this.SearchCustomerTextBox.Name = "SearchCustomerTextBox";
            this.SearchCustomerTextBox.PasswordChar = '\0';
            this.SearchCustomerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchCustomerTextBox.SelectedText = "";
            this.SearchCustomerTextBox.SelectionLength = 0;
            this.SearchCustomerTextBox.SelectionStart = 0;
            this.SearchCustomerTextBox.ShortcutsEnabled = true;
            this.SearchCustomerTextBox.Size = new System.Drawing.Size(451, 23);
            this.SearchCustomerTextBox.TabIndex = 7;
            this.SearchCustomerTextBox.UseSelectable = true;
            this.SearchCustomerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchCustomerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchCustomerTextBox.TextChanged += new System.EventHandler(this.SearchCustomerTextBox_TextChanged);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(493, 179);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(106, 19);
            this.CustomerNameLabel.TabIndex = 8;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CustomerNameTextBox.CustomButton.Image = null;
            this.CustomerNameTextBox.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.CustomerNameTextBox.CustomButton.Name = "";
            this.CustomerNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerNameTextBox.CustomButton.TabIndex = 1;
            this.CustomerNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerNameTextBox.CustomButton.UseSelectable = true;
            this.CustomerNameTextBox.CustomButton.Visible = false;
            this.CustomerNameTextBox.Lines = new string[0];
            this.CustomerNameTextBox.Location = new System.Drawing.Point(493, 201);
            this.CustomerNameTextBox.MaxLength = 32767;
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.PasswordChar = '\0';
            this.CustomerNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerNameTextBox.SelectedText = "";
            this.CustomerNameTextBox.SelectionLength = 0;
            this.CustomerNameTextBox.SelectionStart = 0;
            this.CustomerNameTextBox.ShortcutsEnabled = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.CustomerNameTextBox.TabIndex = 9;
            this.CustomerNameTextBox.UseSelectable = true;
            this.CustomerNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustomerCodeLabel
            // 
            this.CustomerCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerCodeLabel.AutoSize = true;
            this.CustomerCodeLabel.Location = new System.Drawing.Point(493, 249);
            this.CustomerCodeLabel.Name = "CustomerCodeLabel";
            this.CustomerCodeLabel.Size = new System.Drawing.Size(102, 19);
            this.CustomerCodeLabel.TabIndex = 8;
            this.CustomerCodeLabel.Text = "Customer Code";
            // 
            // CustomerCodeTextBox
            // 
            this.CustomerCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CustomerCodeTextBox.CustomButton.Image = null;
            this.CustomerCodeTextBox.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.CustomerCodeTextBox.CustomButton.Name = "";
            this.CustomerCodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerCodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerCodeTextBox.CustomButton.TabIndex = 1;
            this.CustomerCodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerCodeTextBox.CustomButton.UseSelectable = true;
            this.CustomerCodeTextBox.CustomButton.Visible = false;
            this.CustomerCodeTextBox.Lines = new string[0];
            this.CustomerCodeTextBox.Location = new System.Drawing.Point(493, 271);
            this.CustomerCodeTextBox.MaxLength = 32767;
            this.CustomerCodeTextBox.Name = "CustomerCodeTextBox";
            this.CustomerCodeTextBox.PasswordChar = '\0';
            this.CustomerCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerCodeTextBox.SelectedText = "";
            this.CustomerCodeTextBox.SelectionLength = 0;
            this.CustomerCodeTextBox.SelectionStart = 0;
            this.CustomerCodeTextBox.ShortcutsEnabled = true;
            this.CustomerCodeTextBox.Size = new System.Drawing.Size(91, 23);
            this.CustomerCodeTextBox.TabIndex = 9;
            this.CustomerCodeTextBox.UseSelectable = true;
            this.CustomerCodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerCodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GenerateCodeButton
            // 
            this.GenerateCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateCodeButton.Location = new System.Drawing.Point(590, 271);
            this.GenerateCodeButton.Name = "GenerateCodeButton";
            this.GenerateCodeButton.Size = new System.Drawing.Size(72, 23);
            this.GenerateCodeButton.TabIndex = 10;
            this.GenerateCodeButton.Text = "Generate";
            this.GenerateCodeButton.UseSelectable = true;
            this.GenerateCodeButton.Click += new System.EventHandler(this.GenerateCodeButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerButton.Location = new System.Drawing.Point(493, 300);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(169, 57);
            this.AddCustomerButton.TabIndex = 11;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseSelectable = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCustomerButton.Location = new System.Drawing.Point(493, 102);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(169, 23);
            this.DeleteCustomerButton.TabIndex = 12;
            this.DeleteCustomerButton.Text = "Delete Selected Customer";
            this.DeleteCustomerButton.UseSelectable = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // CustomerDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(685, 456);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.GenerateCodeButton);
            this.Controls.Add(this.CustomerCodeTextBox);
            this.Controls.Add(this.CustomerCodeLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.SearchCustomerTextBox);
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(422, 456);
            this.Name = "CustomerDialog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerDialog_Load);
            this.ButtonLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
        private MetroFramework.Controls.MetroGrid CustomersGrid;
        private MetroFramework.Controls.MetroTextBox SearchCustomerTextBox;
        private MetroFramework.Controls.MetroLabel CustomerNameLabel;
        private MetroFramework.Controls.MetroTextBox CustomerNameTextBox;
        private MetroFramework.Controls.MetroLabel CustomerCodeLabel;
        private MetroFramework.Controls.MetroTextBox CustomerCodeTextBox;
        private MetroFramework.Controls.MetroButton GenerateCodeButton;
        private MetroFramework.Controls.MetroButton AddCustomerButton;
        private MetroFramework.Controls.MetroButton DeleteCustomerButton;
    }
}