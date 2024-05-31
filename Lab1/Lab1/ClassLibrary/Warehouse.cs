using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ClassLibrary
{
    public class Warehouse
    {
        public Product product { get; private set; }
        public string unitOfMeasurement { get; private set; }
        public int quantity { get; private set; }
        public DateTime lastDeliveryDate { get; private set; }

        public Warehouse(Product product, string unitOfMeasurement, int quantity, DateTime lastDeliveryDate)
        {
            this.product = product;
            this.unitOfMeasurement = unitOfMeasurement;
            this.quantity = quantity;
            this.lastDeliveryDate = lastDeliveryDate;
        }

        public void AddItems(int quantity, DateTime deliveryDate)
        {
            this.quantity += quantity;
            this.lastDeliveryDate = deliveryDate;
        }

        public bool RemoveItems(int quantity)
        {
            if (quantity > this.quantity)
            {
                Console.WriteLine("Недостатньо товарів на складі.");
                return false;
            }

            this.quantity -= quantity;
            return true;
        }

        public void UpdateUnitPrice(Money newPrice)
        {
            this.product.updatePrice(newPrice);
        }

        public override string ToString()
        {
            return $"Товар: {this.product}\nОдиниці виміру: {this.unitOfMeasurement}\nЦіна за одиниці: {this.product.price}\nКількість: {this.quantity}\nОстання поставка: {this.lastDeliveryDate:d}";
        }
    }
}