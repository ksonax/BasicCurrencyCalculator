using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Currency_Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            bool isDouble = false;
            double outputValue = 0;
            isDouble = double.TryParse(baseCurrencyValue.Text, out outputValue);

            if ((String.IsNullOrEmpty(baseCurrencyValue.Text)) || String.IsNullOrEmpty(baseCurrencyCode.Text) || String.IsNullOrEmpty(otherCurrencyCode.Text))
            {
                MessageBox.Show("You need to add base currency value and wanted currencies!!!");
            }
            if (!isDouble)
            {
                MessageBox.Show("Base Currency Value must be a number!!!");
            }
            else
            {
                otherCurrencyValue.Text = Convert.ConvertCurrencies(baseCurrencyCode.Text, System.Convert.ToDouble(baseCurrencyValue.Text), otherCurrencyCode.Text);
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            LoadFromNBP.LoadCurrencies();
            AddCurrencyCodeToCombobox();
        }

        private void AddCurrencyCodeToCombobox()
        {
            currencyIDText1.Text = "Currency Code";
            foreach (var i in LoadFromNBP.currency_list)
            {
                baseCurrencyCode.Items.Add(i.Currency_code);
                otherCurrencyCode.Items.Add(i.Currency_code);
            }
        }
    }
}
