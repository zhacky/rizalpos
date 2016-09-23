namespace RizalPOS.App.Reports
{
    partial class ReportsMainForm
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
            this.ReportBrowser = new System.Windows.Forms.WebBrowser();
            this.VandalizeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ReportBrowser
            // 
            this.ReportBrowser.Location = new System.Drawing.Point(23, 140);
            this.ReportBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.ReportBrowser.Name = "ReportBrowser";
            this.ReportBrowser.Size = new System.Drawing.Size(654, 311);
            this.ReportBrowser.TabIndex = 0;
            // 
            // VandalizeButton
            // 
            this.VandalizeButton.Location = new System.Drawing.Point(23, 111);
            this.VandalizeButton.Name = "VandalizeButton";
            this.VandalizeButton.Size = new System.Drawing.Size(75, 23);
            this.VandalizeButton.TabIndex = 1;
            this.VandalizeButton.Text = "Vandalize";
            this.VandalizeButton.UseSelectable = true;
            this.VandalizeButton.Click += new System.EventHandler(this.VandalizeButton_Click);
            // 
            // ReportsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 474);
            this.Controls.Add(this.VandalizeButton);
            this.Controls.Add(this.ReportBrowser);
            this.Name = "ReportsMainForm";
            this.ShowIcon = false;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportsMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ReportBrowser;
        private MetroFramework.Controls.MetroButton VandalizeButton;
    }
}