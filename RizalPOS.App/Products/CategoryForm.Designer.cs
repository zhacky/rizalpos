namespace RizalPOS.App.Products
{
    partial class CategoryForm
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
            this.CategoryNameLabel = new MetroFramework.Controls.MetroLabel();
            this.CategoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ParentCategoryLabel = new MetroFramework.Controls.MetroLabel();
            this.CategoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new MetroFramework.Controls.MetroButton();
            this.OK_Button = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Location = new System.Drawing.Point(23, 56);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(107, 19);
            this.CategoryNameLabel.TabIndex = 0;
            this.CategoryNameLabel.Text = "Category Name:";
            // 
            // CategoryTextBox
            // 
            // 
            // 
            // 
            this.CategoryTextBox.CustomButton.Image = null;
            this.CategoryTextBox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.CategoryTextBox.CustomButton.Name = "";
            this.CategoryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CategoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CategoryTextBox.CustomButton.TabIndex = 1;
            this.CategoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CategoryTextBox.CustomButton.UseSelectable = true;
            this.CategoryTextBox.CustomButton.Visible = false;
            this.CategoryTextBox.Lines = new string[0];
            this.CategoryTextBox.Location = new System.Drawing.Point(136, 56);
            this.CategoryTextBox.MaxLength = 32767;
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.PasswordChar = '\0';
            this.CategoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CategoryTextBox.SelectedText = "";
            this.CategoryTextBox.SelectionLength = 0;
            this.CategoryTextBox.SelectionStart = 0;
            this.CategoryTextBox.ShortcutsEnabled = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(195, 23);
            this.CategoryTextBox.TabIndex = 1;
            this.CategoryTextBox.UseSelectable = true;
            this.CategoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CategoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ParentCategoryLabel
            // 
            this.ParentCategoryLabel.AutoSize = true;
            this.ParentCategoryLabel.Location = new System.Drawing.Point(22, 85);
            this.ParentCategoryLabel.Name = "ParentCategoryLabel";
            this.ParentCategoryLabel.Size = new System.Drawing.Size(108, 19);
            this.ParentCategoryLabel.TabIndex = 2;
            this.ParentCategoryLabel.Text = "Parent Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.ItemHeight = 23;
            this.CategoryComboBox.Location = new System.Drawing.Point(136, 85);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(195, 29);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.UseSelectable = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 39);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(89, 8);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
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
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // CategoryForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(356, 190);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ParentCategoryLabel);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.CategoryNameLabel);
            this.Name = "CategoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel CategoryNameLabel;
        private MetroFramework.Controls.MetroTextBox CategoryTextBox;
        private MetroFramework.Controls.MetroLabel ParentCategoryLabel;
        private MetroFramework.Controls.MetroComboBox CategoryComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
    }
}