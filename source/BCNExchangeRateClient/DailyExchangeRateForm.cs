using BCNExchangeRateClient.ExchangeRateService;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCNExchangeRateClient
{
    public partial class DailyExchangeRateForm : Form
    {
        public DailyExchangeRateForm()
        {
            InitializeComponent();
        }

        private async void DailyExchangeRate_Load(object sender, EventArgs e)
        {
            monthCalendar.MinDate = new DateTime(DateTime.Now.AddYears(-8).Year, 01, 01);
            monthCalendar.MaxDate = DateTime.Now;

            await GetData();
        }

        private async Task GetData()
        {
            using (var client = new Tipo_Cambio_BCNSoapClient())
            {
                var result = await client.RecuperaTC_DiaAsync
                    (
                        monthCalendar.SelectionStart.Year,
                        monthCalendar.SelectionStart.Month,
                        monthCalendar.SelectionStart.Day
                    );

                lblExchangeRate.Text = result.ToString();
            }
        }

        private async void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            await GetData();
        }
    }
}
