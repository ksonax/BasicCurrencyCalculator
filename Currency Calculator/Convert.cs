using System;


namespace Currency_Calculator
{
    class Convert
    {
        public static string ConvertCurrencies(string baseCurrencyCode, double baseCurrencyAmount, string otherCurrencyCode)
        {
            double baseCurrencyValue = FindCurrencyValue(baseCurrencyCode);
            double otherCurrencyValue = FindCurrencyValue(otherCurrencyCode);
            double baseCurrencyRate = FindCurrencyRate(baseCurrencyCode);
            double otherCurrencyRate = FindCurrencyRate(otherCurrencyCode);
            string result = System.Convert.ToString(Math.Round((((baseCurrencyAmount * baseCurrencyValue) / baseCurrencyRate) / (otherCurrencyValue / otherCurrencyRate)), 2));

            return result;

        }

        private static double FindCurrencyValue(string currencyCode)
        {
            foreach (var i in LoadFromNBP.currency_list)
            {
                if (currencyCode == i.Currency_code)
                    return System.Convert.ToDouble(i.Currency_value);
            }
            return 0;
        }

        private static double FindCurrencyRate(string currencyCode)
        {
            foreach (var i in LoadFromNBP.currency_list)
            {
                if (currencyCode == i.Currency_code)
                    return System.Convert.ToDouble(i.Currency_rate);
            }
            return 0;
        }
    }

}
