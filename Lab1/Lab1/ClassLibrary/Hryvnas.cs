using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ClassLibrary
{
    public class Hryvnas : Money
    {
        private const double exchangeRateDollar = 39.60;

        public Hryvnas(uint mainPart, uint coins) : base(mainPart, coins, exchangeRateDollar) { }
        public Hryvnas(uint mainPart) : base(mainPart, 0, exchangeRateDollar) { } 
    }
}
