using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ClassLibrary
{
    public class Product
    {
        public string name { get; private set; }
        public Money price { get; private set; }
        public string description { get; private set; }

        public Product(string name, Money price, string description) { 
            this.name = name;
            this.price = price;
            this.description = description;
        }
        public Product(string name, Money price) { 
            this.name = name;
            this.price = price;
            this.description = "не надано продавцем";
        }

        public override string ToString()
        {
            return $"Назва: {this.name}\nЦіна: {this.price}\nОпис: {this.description}";
        }

        public void updatePrice(Money price)
        {
            this.price = price;
        }

    }
}
