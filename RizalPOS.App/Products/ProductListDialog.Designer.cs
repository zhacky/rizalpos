namespace RizalPOS.App.Products
{
    partial class ProductListDialog
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
            this.ProductsGrid = new MetroFramework.Controls.MetroGrid();
            this.SearchProductTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuantityLabel = new MetroFramework.Controls.MetroLabel();
            this.MatchCaseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ButtonLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
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
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(540, 396);
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
            this.OK_Button.Location = new System.Drawing.Point(4, 8);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToAddRows = false;
            this.ProductsGrid.AllowUserToDeleteRows = false;
            this.ProductsGrid.AllowUserToResizeColumns = false;
            this.ProductsGrid.AllowUserToResizeRows = false;
            this.ProductsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductsGrid.EnableHeadersVisualStyles = false;
            this.ProductsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductsGrid.Location = new System.Drawing.Point(23, 92);
            this.ProductsGrid.MinimumSize = new System.Drawing.Size(376, 298);
            this.ProductsGrid.MultiSelect = false;
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.ReadOnly = true;
            this.ProductsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsGrid.RowHeadersVisible = false;
            this.ProductsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGrid.Size = new System.Drawing.Size(686, 298);
            this.ProductsGrid.TabIndex = 6;
            this.ProductsGrid.TabStop = false;
            this.ProductsGrid.DoubleClick += new System.EventHandler(this.ProductsGrid_DoubleClick);
            this.ProductsGrid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductsSelection_KeyUp);
            // 
            // SearchProductTextBox
            // 
            this.SearchProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SearchProductTextBox.CustomButton.Image = null;
            this.SearchProductTextBox.CustomButton.Location = new System.Drawing.Point(504, 1);
            this.SearchProductTextBox.CustomButton.Name = "";
            this.SearchProductTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchProductTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchProductTextBox.CustomButton.TabIndex = 1;
            this.SearchProductTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchProductTextBox.CustomButton.UseSelectable = true;
            this.SearchProductTextBox.CustomButton.Visible = false;
            this.SearchProductTextBox.Lines = new string[0];
            this.SearchProductTextBox.Location = new System.Drawing.Point(23, 63);
            this.SearchProductTextBox.MaxLength = 32767;
            this.SearchProductTextBox.Name = "SearchProductTextBox";
            this.SearchProductTextBox.PasswordChar = '\0';
            this.SearchProductTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchProductTextBox.SelectedText = "";
            this.SearchProductTextBox.SelectionLength = 0;
            this.SearchProductTextBox.SelectionStart = 0;
            this.SearchProductTextBox.ShortcutsEnabled = true;
            this.SearchProductTextBox.Size = new System.Drawing.Size(526, 23);
            this.SearchProductTextBox.TabIndex = 7;
            this.SearchProductTextBox.UseSelectable = true;
            this.SearchProductTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchProductTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchProductTextBox.TextChanged += new System.EventHandler(this.SearchProductTextBox_TextChanged);
            this.SearchProductTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductsSelection_KeyUp);
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[] {
        "1"};
            this.QuantityTextBox.Location = new System.Drawing.Point(645, 63);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(64, 23);
            this.QuantityTextBox.TabIndex = 9;
            this.QuantityTextBox.Text = "1";
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            this.QuantityTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductsSelection_KeyUp);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(581, 63);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(58, 19);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "Quantity";
            // 
            // MatchCaseCheckBox
            // 
            this.MatchCaseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchCaseCheckBox.AutoSize = true;
            this.MatchCaseCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MatchCaseCheckBox.Location = new System.Drawing.Point(466, 42);
            this.MatchCaseCheckBox.Name = "MatchCaseCheckBox";
            this.MatchCaseCheckBox.Size = new System.Drawing.Size(83, 15);
            this.MatchCaseCheckBox.TabIndex = 11;
            this.MatchCaseCheckBox.Text = "Match case";
            this.MatchCaseCheckBox.UseSelectable = true;
            // 
            // ProductListDialog
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(732, 458);
            this.ControlBox = false;
            this.Controls.Add(this.MatchCaseCheckBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.SearchProductTextBox);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(422, 458);
            this.Name = "ProductListDialog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search Item";
            this.Load += new System.EventHandler(this.ProductListDialog_Load);
            this.ButtonLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
        private MetroFramework.Controls.MetroGrid ProductsGrid;
        private MetroFramework.Controls.MetroTextBox SearchProductTextBox;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroLabel QuantityLabel;
        private MetroFramework.Controls.MetroCheckBox MatchCaseCheckBox;
    }
}