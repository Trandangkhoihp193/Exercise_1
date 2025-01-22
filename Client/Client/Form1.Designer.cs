namespace Client
{
    partial class Form1
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
            this.lb_CountryCode = new System.Windows.Forms.Label();
            this.lb_CityName = new System.Windows.Forms.Label();
            this.txb_CountryCode = new System.Windows.Forms.TextBox();
            this.txb_CityName = new System.Windows.Forms.TextBox();
            this.getAllCountry = new System.Windows.Forms.Button();
            this.getCountrybyCode = new System.Windows.Forms.Button();
            this.getCityByName = new System.Windows.Forms.Button();
            this.getAllCityFromCountry = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btn_getLangs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CountryCode
            // 
            this.lb_CountryCode.AutoSize = true;
            this.lb_CountryCode.Location = new System.Drawing.Point(89, 80);
            this.lb_CountryCode.Name = "lb_CountryCode";
            this.lb_CountryCode.Size = new System.Drawing.Size(106, 20);
            this.lb_CountryCode.TabIndex = 0;
            this.lb_CountryCode.Text = "Country Code";
            // 
            // lb_CityName
            // 
            this.lb_CityName.AutoSize = true;
            this.lb_CityName.Location = new System.Drawing.Point(89, 139);
            this.lb_CityName.Name = "lb_CityName";
            this.lb_CityName.Size = new System.Drawing.Size(81, 20);
            this.lb_CityName.TabIndex = 1;
            this.lb_CityName.Text = "City Name";
            // 
            // txb_CountryCode
            // 
            this.txb_CountryCode.Location = new System.Drawing.Point(268, 80);
            this.txb_CountryCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_CountryCode.Name = "txb_CountryCode";
            this.txb_CountryCode.Size = new System.Drawing.Size(112, 26);
            this.txb_CountryCode.TabIndex = 2;
            // 
            // txb_CityName
            // 
            this.txb_CityName.Location = new System.Drawing.Point(268, 131);
            this.txb_CityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_CityName.Name = "txb_CityName";
            this.txb_CityName.Size = new System.Drawing.Size(112, 26);
            this.txb_CityName.TabIndex = 3;
            // 
            // getAllCountry
            // 
            this.getAllCountry.Location = new System.Drawing.Point(429, 71);
            this.getAllCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getAllCountry.Name = "getAllCountry";
            this.getAllCountry.Size = new System.Drawing.Size(190, 29);
            this.getAllCountry.TabIndex = 5;
            this.getAllCountry.Text = "getAllCountry";
            this.getAllCountry.UseVisualStyleBackColor = true;
            this.getAllCountry.Click += new System.EventHandler(this.button1_Click);
            // 
            // getCountrybyCode
            // 
            this.getCountrybyCode.Location = new System.Drawing.Point(429, 128);
            this.getCountrybyCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getCountrybyCode.Name = "getCountrybyCode";
            this.getCountrybyCode.Size = new System.Drawing.Size(181, 29);
            this.getCountrybyCode.TabIndex = 6;
            this.getCountrybyCode.Text = "getCountrybyCode";
            this.getCountrybyCode.UseVisualStyleBackColor = true;
            this.getCountrybyCode.Click += new System.EventHandler(this.getCountrybyCode_Click);
            // 
            // getCityByName
            // 
            this.getCityByName.Location = new System.Drawing.Point(675, 71);
            this.getCityByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getCityByName.Name = "getCityByName";
            this.getCityByName.Size = new System.Drawing.Size(190, 29);
            this.getCityByName.TabIndex = 7;
            this.getCityByName.Text = "getCityByName";
            this.getCityByName.UseVisualStyleBackColor = true;
            this.getCityByName.Click += new System.EventHandler(this.getCityByName_Click);
            // 
            // getAllCityFromCountry
            // 
            this.getAllCityFromCountry.Location = new System.Drawing.Point(675, 130);
            this.getAllCityFromCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getAllCityFromCountry.Name = "getAllCityFromCountry";
            this.getAllCityFromCountry.Size = new System.Drawing.Size(190, 52);
            this.getAllCityFromCountry.TabIndex = 8;
            this.getAllCityFromCountry.Text = "getAllCityFromCountry";
            this.getAllCityFromCountry.UseVisualStyleBackColor = true;
            this.getAllCityFromCountry.Click += new System.EventHandler(this.getAllCityFromCountry_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(82, 280);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(755, 244);
            this.dgvResults.TabIndex = 10;
            // 
            // btn_getLangs
            // 
            this.btn_getLangs.AutoEllipsis = true;
            this.btn_getLangs.Location = new System.Drawing.Point(675, 211);
            this.btn_getLangs.Name = "btn_getLangs";
            this.btn_getLangs.Size = new System.Drawing.Size(190, 36);
            this.btn_getLangs.TabIndex = 11;
            this.btn_getLangs.Text = "getLanguage";
            this.btn_getLangs.UseVisualStyleBackColor = true;
            this.btn_getLangs.Click += new System.EventHandler(this.btn_getLangs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btn_getLangs);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.getAllCityFromCountry);
            this.Controls.Add(this.getCityByName);
            this.Controls.Add(this.getCountrybyCode);
            this.Controls.Add(this.getAllCountry);
            this.Controls.Add(this.txb_CityName);
            this.Controls.Add(this.txb_CountryCode);
            this.Controls.Add(this.lb_CityName);
            this.Controls.Add(this.lb_CountryCode);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CountryCode;
        private System.Windows.Forms.Label lb_CityName;
        private System.Windows.Forms.TextBox txb_CountryCode;
        private System.Windows.Forms.TextBox txb_CityName;
        private System.Windows.Forms.Button getAllCountry;
        private System.Windows.Forms.Button getCountrybyCode;
        private System.Windows.Forms.Button getCityByName;
        private System.Windows.Forms.Button getAllCityFromCountry;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btn_getLangs;
    }
}
