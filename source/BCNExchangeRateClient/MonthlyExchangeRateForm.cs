using BCNExchangeRateClient.ExchangeRateService;
using BCNExchangeRateClient.Model;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BCNExchangeRateClient
{
    public partial class MonthlyExchangeRateForm : Form
    {
        public MonthlyExchangeRateForm()
        {
            InitializeComponent();
        }

        private async void MonthlyExchangeRateForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                var year = DateTime.Today.AddYears((i * -1)).Year;
                cmbYear.Items.Add(year);
            }

            cmbYear.SelectedIndex = 0;
            cmbMonth.SelectedIndex = DateTime.Today.Month - 1;

            cmbMonth.SelectedIndexChanged += CmbMonth_SelectedIndexChanged;
            cmbYear.SelectedIndexChanged += CmbYear_SelectedIndexChanged;

            await GetData();
        }

        private async Task GetData()
        {
            using (var client = new Tipo_Cambio_BCNSoapClient())
            {
                int.TryParse(cmbYear.Text, out int year);

                var results = await client.RecuperaTC_MesAsync(year, cmbMonth.SelectedIndex + 1);

                var serializer = new XmlSerializer(typeof(ExchangeRateResult));

                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(results.Body.RecuperaTC_MesResult.ToString())))
                {
                    var result = serializer.Deserialize(stream) as ExchangeRateResult;

                    var bindingList = new BindingList<ExchangeRate>(result?.ExchangeRates);

                    dtgExchageRate.DataSource = bindingList
                        .OrderBy(x => x.Day)
                        .ToList();
                }
            }
        }

        private async void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                await GetData();
            }
        }

        private async void CmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValidateDate())
            {
                await GetData();
            }
        }

        private bool ValidateDate()
        {
            int.TryParse(cmbYear.Text, out int year);

            bool result = new DateTime(year, cmbMonth.SelectedIndex + 1, 1) < DateTime.Now;

            if (!result)
            {
                MessageBox.Show("Aún no hay registros para ese mes");
            }

            return result;
        }
    }
}
