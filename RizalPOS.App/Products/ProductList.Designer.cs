namespace RizalPOS.App.Products
{
    partial class ProductList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductsGridView = new MetroFramework.Controls.MetroGrid();
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductNameLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductBarcodeLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductBarcodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UnitPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.UnitPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UnitCostLabel = new MetroFramework.Controls.MetroLabel();
            this.UnitCostTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MarginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MarginLabel = new MetroFramework.Controls.MetroLabel();
            this.PercentMarginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PercentLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductToolTip = new MetroFramework.Components.MetroToolTip();
            this.AddingRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.EditingRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.AddProductButton = new MetroFramework.Controls.MetroButton();
            this.CategoryLabel = new MetroFramework.Controls.MetroLabel();
            this.EditCategoryButton = new MetroFramework.Controls.MetroButton();
            this.CategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowUserToOrderColumns = true;
            this.ProductsGridView.AllowUserToResizeColumns = false;
            this.ProductsGridView.AllowUserToResizeRows = false;
            this.ProductsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ProductsGridView.EnableHeadersVisualStyles = false;
            this.ProductsGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductsGridView.Location = new System.Drawing.Point(12, 281);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ProductsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGridView.Size = new System.Drawing.Size(634, 176);
            this.ProductsGridView.StandardTab = true;
            this.ProductsGridView.TabIndex = 10;
            this.ProductsGridView.TabStop = false;
            this.ProductsGridView.Visible = false;
            this.ProductsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellClick);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(491, 252);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(155, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save Changes";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.SearchTextBox.CustomButton.Image = null;
            this.SearchTextBox.CustomButton.Location = new System.Drawing.Point(343, 2);
            this.SearchTextBox.CustomButton.Name = "";
            this.SearchTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.SearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTextBox.CustomButton.TabIndex = 1;
            this.SearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTextBox.CustomButton.UseSelectable = true;
            this.SearchTextBox.CustomButton.Visible = false;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.Location = new System.Drawing.Point(124, 254);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.Size = new System.Drawing.Size(361, 20);
            this.SearchTextBox.TabIndex = 8;
            this.SearchTextBox.TabStop = false;
            this.SearchTextBox.UseSelectable = true;
            this.SearchTextBox.Visible = false;
            this.SearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(124, 232);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(81, 19);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Search Filter";
            this.SearchLabel.Visible = false;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(23, 91);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(95, 19);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Product Name";
            this.ProductToolTip.SetToolTip(this.ProductNameLabel, "Complete Product Description including size or volume");
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ProductNameTextBox.CustomButton.Image = null;
            this.ProductNameTextBox.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.ProductNameTextBox.CustomButton.Name = "";
            this.ProductNameTextBox.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.ProductNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductNameTextBox.CustomButton.TabIndex = 1;
            this.ProductNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductNameTextBox.CustomButton.UseSelectable = true;
            this.ProductNameTextBox.CustomButton.Visible = false;
            this.ProductNameTextBox.Lines = new string[0];
            this.ProductNameTextBox.Location = new System.Drawing.Point(124, 91);
            this.ProductNameTextBox.MaxLength = 32767;
            this.ProductNameTextBox.Multiline = true;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.PasswordChar = '\0';
            this.ProductNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductNameTextBox.SelectedText = "";
            this.ProductNameTextBox.SelectionLength = 0;
            this.ProductNameTextBox.SelectionStart = 0;
            this.ProductNameTextBox.ShortcutsEnabled = true;
            this.ProductNameTextBox.Size = new System.Drawing.Size(172, 69);
            this.ProductNameTextBox.TabIndex = 1;
            this.ProductNameTextBox.UseSelectable = true;
            this.ProductNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductBarcodeLabel
            // 
            this.ProductBarcodeLabel.AutoSize = true;
            this.ProductBarcodeLabel.Location = new System.Drawing.Point(10, 166);
            this.ProductBarcodeLabel.Name = "ProductBarcodeLabel";
            this.ProductBarcodeLabel.Size = new System.Drawing.Size(108, 19);
            this.ProductBarcodeLabel.TabIndex = 6;
            this.ProductBarcodeLabel.Text = "Product Barcode";
            this.ProductToolTip.SetToolTip(this.ProductBarcodeLabel, "Item barcode or any distinct code");
            // 
            // ProductBarcodeTextBox
            // 
            // 
            // 
            // 
            this.ProductBarcodeTextBox.CustomButton.Image = null;
            this.ProductBarcodeTextBox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.ProductBarcodeTextBox.CustomButton.Name = "";
            this.ProductBarcodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ProductBarcodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductBarcodeTextBox.CustomButton.TabIndex = 1;
            this.ProductBarcodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductBarcodeTextBox.CustomButton.UseSelectable = true;
            this.ProductBarcodeTextBox.CustomButton.Visible = false;
            this.ProductBarcodeTextBox.Lines = new string[0];
            this.ProductBarcodeTextBox.Location = new System.Drawing.Point(124, 166);
            this.ProductBarcodeTextBox.MaxLength = 32767;
            this.ProductBarcodeTextBox.Name = "ProductBarcodeTextBox";
            this.ProductBarcodeTextBox.PasswordChar = '\0';
            this.ProductBarcodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductBarcodeTextBox.SelectedText = "";
            this.ProductBarcodeTextBox.SelectionLength = 0;
            this.ProductBarcodeTextBox.SelectionStart = 0;
            this.ProductBarcodeTextBox.ShortcutsEnabled = true;
            this.ProductBarcodeTextBox.Size = new System.Drawing.Size(172, 23);
            this.ProductBarcodeTextBox.TabIndex = 2;
            this.ProductBarcodeTextBox.UseSelectable = true;
            this.ProductBarcodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductBarcodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Location = new System.Drawing.Point(310, 91);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(65, 19);
            this.UnitPriceLabel.TabIndex = 8;
            this.UnitPriceLabel.Text = "Unit Price";
            this.ProductToolTip.SetToolTip(this.UnitPriceLabel, "Price when selling (Php)");
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.UnitPriceTextBox.CustomButton.Image = null;
            this.UnitPriceTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.UnitPriceTextBox.CustomButton.Name = "";
            this.UnitPriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UnitPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UnitPriceTextBox.CustomButton.TabIndex = 1;
            this.UnitPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UnitPriceTextBox.CustomButton.UseSelectable = true;
            this.UnitPriceTextBox.CustomButton.Visible = false;
            this.UnitPriceTextBox.Lines = new string[0];
            this.UnitPriceTextBox.Location = new System.Drawing.Point(384, 91);
            this.UnitPriceTextBox.MaxLength = 32767;
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.PasswordChar = '\0';
            this.UnitPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UnitPriceTextBox.SelectedText = "";
            this.UnitPriceTextBox.SelectionLength = 0;
            this.UnitPriceTextBox.SelectionStart = 0;
            this.UnitPriceTextBox.ShortcutsEnabled = true;
            this.UnitPriceTextBox.Size = new System.Drawing.Size(75, 23);
            this.UnitPriceTextBox.TabIndex = 3;
            this.UnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UnitPriceTextBox.UseSelectable = true;
            this.UnitPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UnitPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UnitCostLabel
            // 
            this.UnitCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitCostLabel.AutoSize = true;
            this.UnitCostLabel.Location = new System.Drawing.Point(313, 122);
            this.UnitCostLabel.Name = "UnitCostLabel";
            this.UnitCostLabel.Size = new System.Drawing.Size(62, 19);
            this.UnitCostLabel.TabIndex = 8;
            this.UnitCostLabel.Text = "Unit Cost";
            this.ProductToolTip.SetToolTip(this.UnitCostLabel, "Cost when acquiring (Php)");
            // 
            // UnitCostTextBox
            // 
            this.UnitCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.UnitCostTextBox.CustomButton.Image = null;
            this.UnitCostTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.UnitCostTextBox.CustomButton.Name = "";
            this.UnitCostTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UnitCostTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UnitCostTextBox.CustomButton.TabIndex = 1;
            this.UnitCostTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UnitCostTextBox.CustomButton.UseSelectable = true;
            this.UnitCostTextBox.CustomButton.Visible = false;
            this.UnitCostTextBox.Lines = new string[0];
            this.UnitCostTextBox.Location = new System.Drawing.Point(384, 122);
            this.UnitCostTextBox.MaxLength = 32767;
            this.UnitCostTextBox.Name = "UnitCostTextBox";
            this.UnitCostTextBox.PasswordChar = '\0';
            this.UnitCostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UnitCostTextBox.SelectedText = "";
            this.UnitCostTextBox.SelectionLength = 0;
            this.UnitCostTextBox.SelectionStart = 0;
            this.UnitCostTextBox.ShortcutsEnabled = true;
            this.UnitCostTextBox.Size = new System.Drawing.Size(75, 23);
            this.UnitCostTextBox.TabIndex = 4;
            this.UnitCostTextBox.TabStop = false;
            this.UnitCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UnitCostTextBox.UseSelectable = true;
            this.UnitCostTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UnitCostTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MarginTextBox
            // 
            this.MarginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.MarginTextBox.CustomButton.Image = null;
            this.MarginTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.MarginTextBox.CustomButton.Name = "";
            this.MarginTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MarginTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MarginTextBox.CustomButton.TabIndex = 1;
            this.MarginTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MarginTextBox.CustomButton.UseSelectable = true;
            this.MarginTextBox.CustomButton.Visible = false;
            this.MarginTextBox.Lines = new string[0];
            this.MarginTextBox.Location = new System.Drawing.Point(546, 91);
            this.MarginTextBox.MaxLength = 32767;
            this.MarginTextBox.Name = "MarginTextBox";
            this.MarginTextBox.PasswordChar = '\0';
            this.MarginTextBox.ReadOnly = true;
            this.MarginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MarginTextBox.SelectedText = "";
            this.MarginTextBox.SelectionLength = 0;
            this.MarginTextBox.SelectionStart = 0;
            this.MarginTextBox.ShortcutsEnabled = true;
            this.MarginTextBox.Size = new System.Drawing.Size(75, 23);
            this.MarginTextBox.TabIndex = 5;
            this.MarginTextBox.TabStop = false;
            this.MarginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MarginTextBox.UseSelectable = true;
            this.MarginTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MarginTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MarginLabel
            // 
            this.MarginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarginLabel.AutoSize = true;
            this.MarginLabel.Location = new System.Drawing.Point(473, 91);
            this.MarginLabel.Name = "MarginLabel";
            this.MarginLabel.Size = new System.Drawing.Size(51, 19);
            this.MarginLabel.TabIndex = 11;
            this.MarginLabel.Text = "Margin";
            this.ProductToolTip.SetToolTip(this.MarginLabel, "Product and Cost Difference (Php)");
            // 
            // PercentMarginTextBox
            // 
            this.PercentMarginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.PercentMarginTextBox.CustomButton.Image = null;
            this.PercentMarginTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.PercentMarginTextBox.CustomButton.Name = "";
            this.PercentMarginTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PercentMarginTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PercentMarginTextBox.CustomButton.TabIndex = 1;
            this.PercentMarginTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PercentMarginTextBox.CustomButton.UseSelectable = true;
            this.PercentMarginTextBox.CustomButton.Visible = false;
            this.PercentMarginTextBox.Lines = new string[0];
            this.PercentMarginTextBox.Location = new System.Drawing.Point(546, 122);
            this.PercentMarginTextBox.MaxLength = 32767;
            this.PercentMarginTextBox.Name = "PercentMarginTextBox";
            this.PercentMarginTextBox.PasswordChar = '\0';
            this.PercentMarginTextBox.ReadOnly = true;
            this.PercentMarginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PercentMarginTextBox.SelectedText = "";
            this.PercentMarginTextBox.SelectionLength = 0;
            this.PercentMarginTextBox.SelectionStart = 0;
            this.PercentMarginTextBox.ShortcutsEnabled = true;
            this.PercentMarginTextBox.Size = new System.Drawing.Size(75, 23);
            this.PercentMarginTextBox.TabIndex = 6;
            this.PercentMarginTextBox.TabStop = false;
            this.PercentMarginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PercentMarginTextBox.UseSelectable = true;
            this.PercentMarginTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PercentMarginTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PercentMarginTextBox.TextChanged += new System.EventHandler(this.PercentMarginTextBox_TextChanged);
            // 
            // PercentLabel
            // 
            this.PercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(473, 122);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(66, 19);
            this.PercentLabel.TabIndex = 11;
            this.PercentLabel.Text = "% Margin";
            this.ProductToolTip.SetToolTip(this.PercentLabel, "Profit Margin in (%)");
            // 
            // ProductToolTip
            // 
            this.ProductToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductToolTip.StyleManager = null;
            this.ProductToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // AddingRadioButton
            // 
            this.AddingRadioButton.AutoSize = true;
            this.AddingRadioButton.Checked = true;
            this.AddingRadioButton.Location = new System.Drawing.Point(251, 31);
            this.AddingRadioButton.Name = "AddingRadioButton";
            this.AddingRadioButton.Size = new System.Drawing.Size(62, 15);
            this.AddingRadioButton.TabIndex = 1;
            this.AddingRadioButton.TabStop = true;
            this.AddingRadioButton.Text = "Adding";
            this.AddingRadioButton.UseSelectable = true;
            this.AddingRadioButton.Visible = false;
            this.AddingRadioButton.CheckedChanged += new System.EventHandler(this.AddingRadioButton_CheckedChanged);
            // 
            // EditingRadioButton
            // 
            this.EditingRadioButton.AutoSize = true;
            this.EditingRadioButton.Location = new System.Drawing.Point(319, 31);
            this.EditingRadioButton.Name = "EditingRadioButton";
            this.EditingRadioButton.Size = new System.Drawing.Size(142, 15);
            this.EditingRadioButton.TabIndex = 1;
            this.EditingRadioButton.Text = "Display List / Updating";
            this.EditingRadioButton.UseSelectable = true;
            this.EditingRadioButton.CheckedChanged += new System.EventHandler(this.EditingRadioButton_CheckedChanged);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductButton.Location = new System.Drawing.Point(473, 166);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(148, 56);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "Add This Product";
            this.AddProductButton.UseSelectable = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(54, 197);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(64, 19);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category";
            // 
            // EditCategoryButton
            // 
            this.EditCategoryButton.Location = new System.Drawing.Point(302, 193);
            this.EditCategoryButton.Name = "EditCategoryButton";
            this.EditCategoryButton.Size = new System.Drawing.Size(36, 29);
            this.EditCategoryButton.TabIndex = 3;
            this.EditCategoryButton.TabStop = false;
            this.EditCategoryButton.Text = "+";
            this.EditCategoryButton.UseSelectable = true;
            this.EditCategoryButton.Click += new System.EventHandler(this.EditCategoryButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.ItemHeight = 23;
            this.CategoryComboBox.Location = new System.Drawing.Point(124, 193);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(172, 29);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.UseSelectable = true;
            // 
            // ProductList
            // 
            this.AcceptButton = this.AddProductButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 469);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.EditCategoryButton);
            this.Controls.Add(this.EditingRadioButton);
            this.Controls.Add(this.AddingRadioButton);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.MarginLabel);
            this.Controls.Add(this.PercentMarginTextBox);
            this.Controls.Add(this.MarginTextBox);
            this.Controls.Add(this.UnitCostTextBox);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.UnitCostLabel);
            this.Controls.Add(this.UnitPriceLabel);
            this.Controls.Add(this.ProductBarcodeTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ProductBarcodeLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductsGridView);
            this.Name = "ProductList";
            this.Text = "Product List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductList_FormClosing);
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid ProductsGridView;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private MetroFramework.Controls.MetroLabel SearchLabel;
        private MetroFramework.Controls.MetroLabel ProductNameLabel;
        private MetroFramework.Controls.MetroTextBox ProductNameTextBox;
        private MetroFramework.Controls.MetroLabel ProductBarcodeLabel;
        private MetroFramework.Controls.MetroTextBox ProductBarcodeTextBox;
        private MetroFramework.Controls.MetroLabel UnitPriceLabel;
        private MetroFramework.Controls.MetroTextBox UnitPriceTextBox;
        private MetroFramework.Controls.MetroLabel UnitCostLabel;
        private MetroFramework.Controls.MetroTextBox UnitCostTextBox;
        private MetroFramework.Controls.MetroTextBox MarginTextBox;
        private MetroFramework.Controls.MetroLabel MarginLabel;
        private MetroFramework.Controls.MetroTextBox PercentMarginTextBox;
        private MetroFramework.Controls.MetroLabel PercentLabel;
        private MetroFramework.Components.MetroToolTip ProductToolTip;
        private MetroFramework.Controls.MetroRadioButton AddingRadioButton;
        private MetroFramework.Controls.MetroButton AddProductButton;
        private MetroFramework.Controls.MetroLabel CategoryLabel;
        private MetroFramework.Controls.MetroButton EditCategoryButton;
        private MetroFramework.Controls.MetroComboBox CategoryComboBox;
        private MetroFramework.Controls.MetroRadioButton EditingRadioButton;
    }
}