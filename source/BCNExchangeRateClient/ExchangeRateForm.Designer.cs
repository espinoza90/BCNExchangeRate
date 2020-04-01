namespace BCNExchangeRateClient
{
    partial class ExchangeRateForm
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
            this.btnDailyExchangeRate = new System.Windows.Forms.Button();
            this.btnMonthlyExchangeRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDailyExchangeRate
            // 
            this.btnDailyExchangeRate.Location = new System.Drawing.Point(95, 35);
            this.btnDailyExchangeRate.Name = "btnDailyExchangeRate";
            this.btnDailyExchangeRate.Size = new System.Drawing.Size(169, 66);
            this.btnDailyExchangeRate.TabIndex = 0;
            this.btnDailyExchangeRate.Text = "Tasa de cambio por día";
            this.btnDailyExchangeRate.UseVisualStyleBackColor = true;
            this.btnDailyExchangeRate.Click += new System.EventHandler(this.BtnDailyExchangeRate_Click);
            // 
            // btnMonthlyExchangeRate
            // 
            this.btnMonthlyExchangeRate.Location = new System.Drawing.Point(95, 124);
            this.btnMonthlyExchangeRate.Name = "btnMonthlyExchangeRate";
            this.btnMonthlyExchangeRate.Size = new System.Drawing.Size(169, 66);
            this.btnMonthlyExchangeRate.TabIndex = 1;
            this.btnMonthlyExchangeRate.Text = "Tasa de cambio por mes";
            this.btnMonthlyExchangeRate.UseVisualStyleBackColor = true;
            this.btnMonthlyExchangeRate.Click += new System.EventHandler(this.BtnMonthlyExchangeRate_Click);
            // 
            // ExchangeRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 229);
            this.Controls.Add(this.btnMonthlyExchangeRate);
            this.Controls.Add(this.btnDailyExchangeRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExchangeRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente de tasa de cambio BCN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDailyExchangeRate;
        private System.Windows.Forms.Button btnMonthlyExchangeRate;
    }
}

