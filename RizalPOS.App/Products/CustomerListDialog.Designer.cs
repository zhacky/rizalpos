namespace RizalPOS.App.Products
{
    partial class CustomerListDialog
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
            this.ButtonLayoutPanel.SuspendLayout();
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
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseSelectable = true;
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
            // 
            // CustomerListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.Name = "CustomerListDialog";
            this.Text = "Dialog";
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonLayoutPanel;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
    }
}