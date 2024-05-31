using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ClassLibrary
{
    public abstract class Money
    {
        protected Money(uint mainPart, uint coins, double exchangeRateDollar)
        {
            this.mainPart = mainPart;
            this.coins = coins;
            this.exchangeRateDollar = exchangeRateDollar;
        }
        protected Money(uint mainPart, double exchangeRateDollar)
        {
            this.mainPart = mainPart;
            this.coins = 0;
            this.exchangeRateDollar = exchangeRateDollar;
        }

        public uint mainPart { get; private set; }
        public uint coins { get; private set; }
        private double exchangeRateDollar;

        public Dollars exchangeToDollar()
        {
            double totalCents = (this.mainPart * 100 + this.coins) / this.exchangeRateDollar;

            uint dollars = (uint)(totalCents / 100);
            uint cents = (uint)(totalCents % 100);

            return new Dollars(dollars, cents);
        }





        static public float ToFloat(Money money)
        {
            return money.mainPart + money.coins/100;
        }

        public override string ToString()
        {
            return $"{mainPart}.{coins} {(GetType().Name).ToLower()}s";
        }
    }
}
