using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Calculator
{
    public class Currency
    {
        public string Currency_name { get; private set; }
        public int Currency_rate { get; private set; }
        public string Currency_code { get; private set; }
        public double Currency_value { get; private set; }

        public Currency(string currency_name, int currency_rate, string currency_code, double currency_value)
        {
            Currency_name = currency_name;
            Currency_rate = currency_rate;
            Currency_code = currency_code;
            Currency_value = currency_value;
        }
    }
}
