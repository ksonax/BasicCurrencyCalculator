using System.Collections.Generic;
using System.Xml;

namespace Currency_Calculator
{
    class LoadFromNBP
    {
        public static List<Currency> currency_list = new List<Currency>();

        //Load current currency rates from NBP
        public static void LoadCurrencies()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("https://www.nbp.pl/kursy/xml/lasta.xml");
            XmlNodeList nodes;
            XmlNode root = doc.DocumentElement;
            nodes = root.SelectNodes("descendant::pozycja");

            foreach (XmlNode node in nodes)
            {
                string currency_name = System.Convert.ToString(node["nazwa_waluty"].InnerText);
                int currency_rate = int.Parse(node["przelicznik"].InnerText);
                string currency_code = System.Convert.ToString(node["kod_waluty"].InnerText);
                double currency_value = double.Parse(node["kurs_sredni"].InnerText);

                Currency currency = new Currency(currency_name, currency_rate, currency_code, currency_value);
                currency_list.Add(currency);
            }

        }
    }
}
