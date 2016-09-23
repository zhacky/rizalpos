﻿namespace RizalPOS.App.Sales
{
    partial class ReturnChangeForm
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
            this.ButtonsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new MetroFramework.Controls.MetroButton();
            this.Cancel_Button = new MetroFramework.Controls.MetroButton();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsLayoutPanel
            // 
            this.ButtonsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsLayoutPanel.ColumnCount = 2;
            this.ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayoutPanel.Controls.Add(this.OK_Button, 0, 0);
            this.ButtonsLayoutPanel.Controls.Add(this.Cancel_Button, 1, 0);
            this.ButtonsLayoutPanel.Location = new System.Drawing.Point(169, 170);
            this.ButtonsLayoutPanel.Name = "ButtonsLayoutPanel";
            this.ButtonsLayoutPanel.RowCount = 1;
            this.ButtonsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsLayoutPanel.Size = new System.Drawing.Size(192, 42);
            this.ButtonsLayoutPanel.TabIndex = 1;
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(10, 9);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "&OK";
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(106, 9);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "&Cancel";
            this.Cancel_Button.UseSelectable = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeTextBox.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTextBox.Location = new System.Drawing.Point(75, 63);
            this.ChangeTextBox.MaximumSize = new System.Drawing.Size(0, 93);
            this.ChangeTextBox.MinimumSize = new System.Drawing.Size(286, 93);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(286, 93);
            this.ChangeTextBox.TabIndex = 2;
            // 
            // ReturnChangeForm
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(384, 235);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.ButtonsLayoutPanel);
            this.Name = "ReturnChangeForm";
            this.Text = "Change";
            this.Load += new System.EventHandler(this.ReturnChangeForm_Load);
            this.ButtonsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonsLayoutPanel;
        private MetroFramework.Controls.MetroButton OK_Button;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private System.Windows.Forms.TextBox ChangeTextBox;
    }
}