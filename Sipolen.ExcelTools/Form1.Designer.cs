namespace Sipolen.ExcelTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectSourceExcel = new System.Windows.Forms.Button();
            this.lbSourceExcelPath = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbCountryTemplate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBeginMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkPath = new System.Windows.Forms.TextBox();
            this.btnSetWorkPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbEuropeSite = new System.Windows.Forms.RadioButton();
            this.rbAmericaSite = new System.Windows.Forms.RadioButton();
            this.lbCurrencyUnit = new System.Windows.Forms.Label();
            this.lbCurrencyExchangeRate = new System.Windows.Forms.Label();
            this.btnSureConturyTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectSourceExcel
            // 
            this.btnSelectSourceExcel.Location = new System.Drawing.Point(50, 82);
            this.btnSelectSourceExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectSourceExcel.Name = "btnSelectSourceExcel";
            this.btnSelectSourceExcel.Size = new System.Drawing.Size(148, 34);
            this.btnSelectSourceExcel.TabIndex = 0;
            this.btnSelectSourceExcel.Text = "选择平台导出表";
            this.btnSelectSourceExcel.UseVisualStyleBackColor = true;
            this.btnSelectSourceExcel.Click += new System.EventHandler(this.btnSelectSourceExcel_Click);
            // 
            // lbSourceExcelPath
            // 
            this.lbSourceExcelPath.AutoSize = true;
            this.lbSourceExcelPath.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbSourceExcelPath.Location = new System.Drawing.Point(246, 90);
            this.lbSourceExcelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSourceExcelPath.Name = "lbSourceExcelPath";
            this.lbSourceExcelPath.Size = new System.Drawing.Size(0, 18);
            this.lbSourceExcelPath.TabIndex = 1;
            this.lbSourceExcelPath.Tag = "";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(436, 153);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(118, 26);
            this.cbCountry.TabIndex = 2;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // cbCountryTemplate
            // 
            this.cbCountryTemplate.FormattingEnabled = true;
            this.cbCountryTemplate.Location = new System.Drawing.Point(664, 153);
            this.cbCountryTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCountryTemplate.Name = "cbCountryTemplate";
            this.cbCountryTemplate.Size = new System.Drawing.Size(180, 26);
            this.cbCountryTemplate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(342, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "选择国家";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(574, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Tag = "";
            this.label3.Text = "选择模板";
            // 
            // btnBeginMove
            // 
            this.btnBeginMove.Location = new System.Drawing.Point(50, 406);
            this.btnBeginMove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeginMove.Name = "btnBeginMove";
            this.btnBeginMove.Size = new System.Drawing.Size(112, 34);
            this.btnBeginMove.TabIndex = 6;
            this.btnBeginMove.Text = "开始移表";
            this.btnBeginMove.UseVisualStyleBackColor = true;
            this.btnBeginMove.Click += new System.EventHandler(this.btnBeginMove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(46, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "我的工作目录 -->";
            // 
            // txtWorkPath
            // 
            this.txtWorkPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtWorkPath.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtWorkPath.Location = new System.Drawing.Point(249, 26);
            this.txtWorkPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkPath.Name = "txtWorkPath";
            this.txtWorkPath.Size = new System.Drawing.Size(478, 28);
            this.txtWorkPath.TabIndex = 8;
            this.txtWorkPath.Text = "D:\\work\\excel";
            // 
            // btnSetWorkPath
            // 
            this.btnSetWorkPath.Location = new System.Drawing.Point(892, 26);
            this.btnSetWorkPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetWorkPath.Name = "btnSetWorkPath";
            this.btnSetWorkPath.Size = new System.Drawing.Size(112, 34);
            this.btnSetWorkPath.TabIndex = 9;
            this.btnSetWorkPath.Text = "设置工作目录";
            this.btnSetWorkPath.UseVisualStyleBackColor = true;
            this.btnSetWorkPath.Click += new System.EventHandler(this.btnSetWorkPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(46, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Tag = "";
            this.label5.Text = "选择站点";
            // 
            // rbEuropeSite
            // 
            this.rbEuropeSite.AutoSize = true;
            this.rbEuropeSite.Checked = true;
            this.rbEuropeSite.Location = new System.Drawing.Point(135, 156);
            this.rbEuropeSite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEuropeSite.Name = "rbEuropeSite";
            this.rbEuropeSite.Size = new System.Drawing.Size(87, 22);
            this.rbEuropeSite.TabIndex = 11;
            this.rbEuropeSite.TabStop = true;
            this.rbEuropeSite.Tag = "Europe";
            this.rbEuropeSite.Text = "欧洲站";
            this.rbEuropeSite.UseVisualStyleBackColor = true;
            this.rbEuropeSite.CheckedChanged += new System.EventHandler(this.rbEuropeSite_CheckedChanged);
            // 
            // rbAmericaSite
            // 
            this.rbAmericaSite.AutoSize = true;
            this.rbAmericaSite.Location = new System.Drawing.Point(232, 156);
            this.rbAmericaSite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAmericaSite.Name = "rbAmericaSite";
            this.rbAmericaSite.Size = new System.Drawing.Size(87, 22);
            this.rbAmericaSite.TabIndex = 12;
            this.rbAmericaSite.Tag = "America";
            this.rbAmericaSite.Text = "美洲站";
            this.rbAmericaSite.UseVisualStyleBackColor = true;
            // 
            // lbCurrencyUnit
            // 
            this.lbCurrencyUnit.AutoSize = true;
            this.lbCurrencyUnit.ForeColor = System.Drawing.Color.Blue;
            this.lbCurrencyUnit.Location = new System.Drawing.Point(860, 118);
            this.lbCurrencyUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrencyUnit.Name = "lbCurrencyUnit";
            this.lbCurrencyUnit.Size = new System.Drawing.Size(98, 18);
            this.lbCurrencyUnit.TabIndex = 13;
            this.lbCurrencyUnit.Tag = "";
            this.lbCurrencyUnit.Text = "货币单位：";
            // 
            // lbCurrencyExchangeRate
            // 
            this.lbCurrencyExchangeRate.AutoSize = true;
            this.lbCurrencyExchangeRate.ForeColor = System.Drawing.Color.Blue;
            this.lbCurrencyExchangeRate.Location = new System.Drawing.Point(860, 159);
            this.lbCurrencyExchangeRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrencyExchangeRate.Name = "lbCurrencyExchangeRate";
            this.lbCurrencyExchangeRate.Size = new System.Drawing.Size(98, 18);
            this.lbCurrencyExchangeRate.TabIndex = 14;
            this.lbCurrencyExchangeRate.Tag = "";
            this.lbCurrencyExchangeRate.Text = "货币汇率：";
            // 
            // btnSureConturyTemplate
            // 
            this.btnSureConturyTemplate.Location = new System.Drawing.Point(50, 202);
            this.btnSureConturyTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSureConturyTemplate.Name = "btnSureConturyTemplate";
            this.btnSureConturyTemplate.Size = new System.Drawing.Size(156, 34);
            this.btnSureConturyTemplate.TabIndex = 15;
            this.btnSureConturyTemplate.Text = "确定国家及模板";
            this.btnSureConturyTemplate.UseVisualStyleBackColor = true;
            this.btnSureConturyTemplate.Click += new System.EventHandler(this.btnSureConturyTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 714);
            this.Controls.Add(this.btnSureConturyTemplate);
            this.Controls.Add(this.lbCurrencyExchangeRate);
            this.Controls.Add(this.lbCurrencyUnit);
            this.Controls.Add(this.rbAmericaSite);
            this.Controls.Add(this.rbEuropeSite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSetWorkPath);
            this.Controls.Add(this.txtWorkPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBeginMove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCountryTemplate);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbSourceExcelPath);
            this.Controls.Add(this.btnSelectSourceExcel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourceExcel;
        private System.Windows.Forms.Label lbSourceExcelPath;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCountryTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBeginMove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkPath;
        private System.Windows.Forms.Button btnSetWorkPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbEuropeSite;
        private System.Windows.Forms.RadioButton rbAmericaSite;
        private System.Windows.Forms.Label lbCurrencyUnit;
        private System.Windows.Forms.Label lbCurrencyExchangeRate;
        private System.Windows.Forms.Button btnSureConturyTemplate;
    }
}

