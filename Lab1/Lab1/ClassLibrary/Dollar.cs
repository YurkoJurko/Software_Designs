using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ClassLibrary
{
    public class Dollars : Money
    {
        private const double exchangeRateDollar = 1;

        public Dollars(uint mainPart, uint coins) : base(mainPart, coins, exchangeRateDollar) {}
        public Dollars(uint mainPart) : base(mainPart, exchangeRateDollar) {}

    }
}
