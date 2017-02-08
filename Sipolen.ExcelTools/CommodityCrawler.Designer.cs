namespace Sipolen.ExcelTools
{
    partial class CommodityCrawler
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnBeginCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 40);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(459, 55);
            this.txtUrl.TabIndex = 0;
            // 
            // btnBeginCheck
            // 
            this.btnBeginCheck.Location = new System.Drawing.Point(12, 120);
            this.btnBeginCheck.Name = "btnBeginCheck";
            this.btnBeginCheck.Size = new System.Drawing.Size(75, 23);
            this.btnBeginCheck.TabIndex = 1;
            this.btnBeginCheck.Text = "test";
            this.btnBeginCheck.UseVisualStyleBackColor = true;
            this.btnBeginCheck.Click += new System.EventHandler(this.btnBeginCheck_Click);
            // 
            // CommodityCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 291);
            this.Controls.Add(this.btnBeginCheck);
            this.Controls.Add(this.txtUrl);
            this.Name = "CommodityCrawler";
            this.Text = "CommodityCrawler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnBeginCheck;
    }
}