using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string Flag { get; set; }

        public Country(String name, String capital, String currency, String flag)
        {
            this.Name = name;
            this.Capital = capital;
            this.Currency = currency;
            this.Flag = flag;
        }

        public override string ToString()
        {
            return "Kraj: " + Name + "\r\nStolica: " + Capital + "\r\nWaluta: " + Currency;
        }
    }
}
