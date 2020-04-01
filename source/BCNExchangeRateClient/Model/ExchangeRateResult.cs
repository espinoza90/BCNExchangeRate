using System.Collections.Generic;
using System.Xml.Serialization;

namespace BCNExchangeRateClient.Model
{
    [XmlRoot(ElementName = "Detalle_TC")]
    public class ExchangeRateResult
    {
        [XmlElement(ElementName = "Tc")]
        public List<ExchangeRate> ExchangeRates { get; set; }
    }

    [XmlRoot(ElementName = "Tc")]
    public class ExchangeRate
    {
        [XmlElement(ElementName = "Fecha")]
        public string Date { get; set; }
        [XmlElement(ElementName = "Valor")]
        public decimal Value { get; set; }
        [XmlElement(ElementName = "Ano")]
        public int Year { get; set; }
        [XmlElement(ElementName = "Mes")]
        public int Month { get; set; }
        [XmlElement(ElementName = "Dia")]
        public int Day { get; set; }
    }
}
