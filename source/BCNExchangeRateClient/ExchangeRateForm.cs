using System;
using System.Windows.Forms;

namespace BCNExchangeRateClient
{
    public partial class ExchangeRateForm : Form
    {
        public ExchangeRateForm()
        {
            InitializeComponent();
        }

        private void BtnDailyExchangeRate_Click(object sender, EventArgs e)
        {
            using (var form = new DailyExchangeRateForm())
            {
                form.ShowDialog();
            }
        }

        private void BtnMonthlyExchangeRate_Click(object sender, EventArgs e)
        {
            using (var form = new MonthlyExchangeRateForm())
            {
                form.ShowDialog();
            }
        }
    }
}
