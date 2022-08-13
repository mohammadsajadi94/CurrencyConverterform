using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterform
{
    public class CurrencyConverter:ICurrencyConverter
    {
        private static readonly object lockobject = new object();
        private CurrencyConverter()
        {
            
        }
        private static ICurrencyConverter convert = null;

        public static ICurrencyConverter GetInstance
        {
            get
            {
                lock (lockobject)
                {
                    if (convert == null)
                    {
                        convert = new CurrencyConverter();
                    }
                    return convert;
                }
            }
        }
        public void ClearConfiguration()
        {
            convert = null;
        }
        IEnumerable<Tuple<string, string, double>> rates = null;
        public void UpdateConfiguration(IEnumerable<Tuple<string, string, double>> conversionRates)
        {
            rates = conversionRates;
        }
        double resualtamount = 0;

        double ICurrencyConverter.Convert(string fromCurrency, string toCurrency, double amount)
        {
            switch (fromCurrency)
            {
                case "USD":
                    switch (toCurrency)
                    {
                        case "CAD":
                            resualtamount = amount * Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First());
                            break;
                        case "GBP":
                            resualtamount = (amount * Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First()))* Convert.ToDouble(rates.Where(r => r.Item1 == "CAD" && r.Item2 == "GBP").Select(r => r.Item3).First());
                            break;
                        case "EUR":
                            resualtamount = amount * Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "EUR").Select(r => r.Item3).First());
                            break;
                    }
                    break;
                case "CAD":
                    switch (toCurrency)
                    {
                        case "USD":
                            resualtamount = amount / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First());
                            break;
                        case "GBP":
                            resualtamount = amount * Convert.ToDouble(rates.Where(r => r.Item1 == "CAD" && r.Item2 == "GBP").Select(r => r.Item3).First());
                            break;
                        case "EUR":
                            resualtamount = (amount / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First()))* Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "EUR").Select(r => r.Item3).First());
                            break;
                    }
                    break;
                case "GBP":
                    switch (toCurrency)
                    {
                        case "USD":
                            resualtamount = (amount / Convert.ToDouble(rates.Where(r => r.Item1 == "CAD" && r.Item2 == "GBP").Select(r => r.Item3).First())) / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First());
                            break;
                        case "CAD":
                            resualtamount = amount / Convert.ToDouble(rates.Where(r => r.Item1 == "CAD" && r.Item2 == "GBP").Select(r => r.Item3).First());
                            break;
                        case "EUR":
                            resualtamount = ((amount / Convert.ToDouble(rates.Where(r => r.Item1 == "CAD" && r.Item2 == "GBP").Select(r => r.Item3).First())) / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First())) * Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "EUR").Select(r => r.Item3).First());
                            break;
                    }
                    break;
                case "EUR":
                    switch (toCurrency)
                    {
                        case "USD":
                            resualtamount = amount / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "EUR").Select(r => r.Item3).First());
                            break;
                        case "GBP":
                            resualtamount = ((amount / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "EUR").Select(r => r.Item3).First()))* Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First()))* Convert.ToDouble(rates.Where(r => r.Item1 == "CAD" && r.Item2 == "GBP").Select(r => r.Item3).First());
                            break;
                        case "CAD":
                            resualtamount = (amount / Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "EUR").Select(r => r.Item3).First()))* Convert.ToDouble(rates.Where(r => r.Item1 == "USD" && r.Item2 == "CAD").Select(r => r.Item3).First());
                            break;
                    }
                    break;

            }
            return resualtamount;
        }
    }
}
