﻿namespace Sipolen.ExcelTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.txtEANCountryCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEANFactoryCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEANProductCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtShippingWeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDeliveryTimeMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDeliveryTimeMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSourceExcel
            // 
            this.btnSelectSourceExcel.Location = new System.Drawing.Point(33, 55);
            this.btnSelectSourceExcel.Name = "btnSelectSourceExcel";
            this.btnSelectSourceExcel.Size = new System.Drawing.Size(99, 23);
            this.btnSelectSourceExcel.TabIndex = 0;
            this.btnSelectSourceExcel.Text = "选择平台导出表";
            this.btnSelectSourceExcel.UseVisualStyleBackColor = true;
            this.btnSelectSourceExcel.Click += new System.EventHandler(this.btnSelectSourceExcel_Click);
            // 
            // lbSourceExcelPath
            // 
            this.lbSourceExcelPath.AutoSize = true;
            this.lbSourceExcelPath.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbSourceExcelPath.Location = new System.Drawing.Point(164, 60);
            this.lbSourceExcelPath.Name = "lbSourceExcelPath";
            this.lbSourceExcelPath.Size = new System.Drawing.Size(0, 12);
            this.lbSourceExcelPath.TabIndex = 1;
            this.lbSourceExcelPath.Tag = "";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(291, 102);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(80, 20);
            this.cbCountry.TabIndex = 2;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // cbCountryTemplate
            // 
            this.cbCountryTemplate.FormattingEnabled = true;
            this.cbCountryTemplate.Location = new System.Drawing.Point(443, 102);
            this.cbCountryTemplate.Name = "cbCountryTemplate";
            this.cbCountryTemplate.Size = new System.Drawing.Size(121, 20);
            this.cbCountryTemplate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(228, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Tag = "";
            this.label2.Text = "选择国家";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(383, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Tag = "";
            this.label3.Text = "选择模板";
            // 
            // btnBeginMove
            // 
            this.btnBeginMove.Location = new System.Drawing.Point(33, 396);
            this.btnBeginMove.Name = "btnBeginMove";
            this.btnBeginMove.Size = new System.Drawing.Size(75, 23);
            this.btnBeginMove.TabIndex = 6;
            this.btnBeginMove.Text = "开始移表";
            this.btnBeginMove.UseVisualStyleBackColor = true;
            this.btnBeginMove.Click += new System.EventHandler(this.btnBeginMove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(31, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 7;
            this.label4.Tag = "";
            this.label4.Text = "我的工作目录 -->";
            // 
            // txtWorkPath
            // 
            this.txtWorkPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtWorkPath.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtWorkPath.Location = new System.Drawing.Point(166, 17);
            this.txtWorkPath.Name = "txtWorkPath";
            this.txtWorkPath.Size = new System.Drawing.Size(320, 21);
            this.txtWorkPath.TabIndex = 8;
            this.txtWorkPath.Text = "D:\\work\\excel";
            // 
            // btnSetWorkPath
            // 
            this.btnSetWorkPath.Location = new System.Drawing.Point(595, 17);
            this.btnSetWorkPath.Name = "btnSetWorkPath";
            this.btnSetWorkPath.Size = new System.Drawing.Size(75, 23);
            this.btnSetWorkPath.TabIndex = 9;
            this.btnSetWorkPath.Text = "设置工作目录";
            this.btnSetWorkPath.UseVisualStyleBackColor = true;
            this.btnSetWorkPath.Click += new System.EventHandler(this.btnSetWorkPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(31, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Tag = "";
            this.label5.Text = "选择站点";
            // 
            // rbEuropeSite
            // 
            this.rbEuropeSite.AutoSize = true;
            this.rbEuropeSite.Checked = true;
            this.rbEuropeSite.Location = new System.Drawing.Point(90, 104);
            this.rbEuropeSite.Name = "rbEuropeSite";
            this.rbEuropeSite.Size = new System.Drawing.Size(59, 16);
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
            this.rbAmericaSite.Location = new System.Drawing.Point(155, 104);
            this.rbAmericaSite.Name = "rbAmericaSite";
            this.rbAmericaSite.Size = new System.Drawing.Size(59, 16);
            this.rbAmericaSite.TabIndex = 12;
            this.rbAmericaSite.Tag = "America";
            this.rbAmericaSite.Text = "美洲站";
            this.rbAmericaSite.UseVisualStyleBackColor = true;
            // 
            // lbCurrencyUnit
            // 
            this.lbCurrencyUnit.AutoSize = true;
            this.lbCurrencyUnit.ForeColor = System.Drawing.Color.Blue;
            this.lbCurrencyUnit.Location = new System.Drawing.Point(573, 79);
            this.lbCurrencyUnit.Name = "lbCurrencyUnit";
            this.lbCurrencyUnit.Size = new System.Drawing.Size(65, 12);
            this.lbCurrencyUnit.TabIndex = 13;
            this.lbCurrencyUnit.Tag = "";
            this.lbCurrencyUnit.Text = "货币单位：";
            // 
            // lbCurrencyExchangeRate
            // 
            this.lbCurrencyExchangeRate.AutoSize = true;
            this.lbCurrencyExchangeRate.ForeColor = System.Drawing.Color.Blue;
            this.lbCurrencyExchangeRate.Location = new System.Drawing.Point(573, 106);
            this.lbCurrencyExchangeRate.Name = "lbCurrencyExchangeRate";
            this.lbCurrencyExchangeRate.Size = new System.Drawing.Size(65, 12);
            this.lbCurrencyExchangeRate.TabIndex = 14;
            this.lbCurrencyExchangeRate.Tag = "";
            this.lbCurrencyExchangeRate.Text = "货币汇率：";
            // 
            // btnSureConturyTemplate
            // 
            this.btnSureConturyTemplate.Location = new System.Drawing.Point(33, 135);
            this.btnSureConturyTemplate.Name = "btnSureConturyTemplate";
            this.btnSureConturyTemplate.Size = new System.Drawing.Size(104, 23);
            this.btnSureConturyTemplate.TabIndex = 15;
            this.btnSureConturyTemplate.Text = "确定国家及模板";
            this.btnSureConturyTemplate.UseVisualStyleBackColor = true;
            this.btnSureConturyTemplate.Click += new System.EventHandler(this.btnSureConturyTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Tag = "";
            this.label1.Text = "品牌名";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(66, 31);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(93, 21);
            this.txtBrandName.TabIndex = 17;
            this.txtBrandName.Text = "sinldo";
            // 
            // txtEANCountryCode
            // 
            this.txtEANCountryCode.Location = new System.Drawing.Point(64, 33);
            this.txtEANCountryCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEANCountryCode.Name = "txtEANCountryCode";
            this.txtEANCountryCode.Size = new System.Drawing.Size(41, 21);
            this.txtEANCountryCode.TabIndex = 19;
            this.txtEANCountryCode.Text = "485";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 18;
            this.label6.Tag = "";
            this.label6.Text = "EAN13位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Tag = "";
            this.label7.Text = "国家代码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(115, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 22;
            this.label8.Tag = "";
            this.label8.Text = "厂商代码";
            // 
            // txtEANFactoryCode
            // 
            this.txtEANFactoryCode.Location = new System.Drawing.Point(169, 33);
            this.txtEANFactoryCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEANFactoryCode.Name = "txtEANFactoryCode";
            this.txtEANFactoryCode.Size = new System.Drawing.Size(65, 21);
            this.txtEANFactoryCode.TabIndex = 21;
            this.txtEANFactoryCode.Text = "3222";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(238, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 24;
            this.label9.Tag = "";
            this.label9.Text = "商品代码";
            // 
            // txtEANProductCode
            // 
            this.txtEANProductCode.Location = new System.Drawing.Point(294, 31);
            this.txtEANProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEANProductCode.Name = "txtEANProductCode";
            this.txtEANProductCode.Size = new System.Drawing.Size(87, 21);
            this.txtEANProductCode.TabIndex = 23;
            this.txtEANProductCode.Text = "32221";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtEANCountryCode);
            this.panel1.Controls.Add(this.txtEANProductCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEANFactoryCode);
            this.panel1.Location = new System.Drawing.Point(33, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 69);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.txtBrandName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(463, 179);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 69);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtShippingWeight);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtDeliveryTimeMin);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtDeliveryTimeMax);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(33, 259);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 56);
            this.panel3.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(366, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 26;
            this.label15.Tag = "";
            this.label15.Text = "KG";
            // 
            // txtShippingWeight
            // 
            this.txtShippingWeight.Location = new System.Drawing.Point(328, 18);
            this.txtShippingWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtShippingWeight.Name = "txtShippingWeight";
            this.txtShippingWeight.Size = new System.Drawing.Size(35, 21);
            this.txtShippingWeight.TabIndex = 25;
            this.txtShippingWeight.Text = "0.5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(270, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 24;
            this.label14.Tag = "";
            this.label14.Text = "商品重量";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(232, 18);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(35, 21);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.Text = "30";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(174, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 22;
            this.label13.Tag = "";
            this.label13.Text = "库存数量";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(151, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 21;
            this.label12.Tag = "";
            this.label12.Text = "天";
            // 
            // txtDeliveryTimeMin
            // 
            this.txtDeliveryTimeMin.Location = new System.Drawing.Point(65, 18);
            this.txtDeliveryTimeMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryTimeMin.Name = "txtDeliveryTimeMin";
            this.txtDeliveryTimeMin.Size = new System.Drawing.Size(35, 21);
            this.txtDeliveryTimeMin.TabIndex = 20;
            this.txtDeliveryTimeMin.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(98, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 19;
            this.label11.Tag = "";
            this.label11.Text = "-";
            // 
            // txtDeliveryTimeMax
            // 
            this.txtDeliveryTimeMax.Location = new System.Drawing.Point(111, 18);
            this.txtDeliveryTimeMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryTimeMax.Name = "txtDeliveryTimeMax";
            this.txtDeliveryTimeMax.Size = new System.Drawing.Size(35, 21);
            this.txtDeliveryTimeMax.TabIndex = 18;
            this.txtDeliveryTimeMax.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(5, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 16;
            this.label10.Tag = "";
            this.label10.Text = "到货时长";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(449, 396);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "开启新窗口";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 476);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.TextBox txtEANCountryCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEANFactoryCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEANProductCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDeliveryTimeMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDeliveryTimeMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtShippingWeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpen;
    }
}

