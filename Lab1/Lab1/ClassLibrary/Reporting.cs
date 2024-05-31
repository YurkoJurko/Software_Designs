using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.ClassLibrary
{
    public class Reporting
    {
        private List<Warehouse> warehouseInventory;
        public float profitInDollars { get; set; }

        public Reporting()
        {
            warehouseInventory = new List<Warehouse>();
        }

        public void RegisterIncomingGoods(Product product, string unitOfMeasurement, int quantity, DateTime deliveryDate)
        {
            int temp = GetWarehouseIdByProduct(product);
            if (temp != -1)
            {
                warehouseInventory[temp].AddItems(quantity, deliveryDate);
            }
            else
            {
                warehouseInventory.Add(new Warehouse(product, unitOfMeasurement, quantity, deliveryDate));
            }
            Console.WriteLine($"Доставлено новий товар: {product}\nУ кількості: {quantity} {unitOfMeasurement}\nДата доставки: {deliveryDate}");
        }

        public void RegisterOutgoingGoods(Product product, int quantity)
        {
            int temp = GetWarehouseIdByProduct(product);
            if (temp != -1)
            {
                if (warehouseInventory[temp].RemoveItems(quantity))
                {
                    Console.WriteLine($"Відвантажено: {quantity} {warehouseInventory[temp].unitOfMeasurement} товару {product}");
                    Dollars tempPrice = product.price.exchangeToDollar();
                    Console.WriteLine("1231231231231" + ' ' + tempPrice);
                    float profitInMoment = quantity * Money.ToFloat(tempPrice);
                    profitInDollars += profitInMoment;
                    Console.WriteLine($"Прибуток: {profitInMoment}$\nЗагальний прибуток: {profitInDollars}$");
                }
                else
                {
                    Console.WriteLine($"Неможливо відвантажити, недостатня кількість {product.name}");
                }
            }
            else
            {
                Console.WriteLine($"Неможливо відвантажити: {product} не знайдено на складі");
            }
        }

        public int GetWarehouseIdByProduct(Product product)
        {
            for (int i = 0; i < warehouseInventory.Count; i++)
            {
                if (warehouseInventory[i].product == product)
                {
                    return i;
                }
            }
            return -1; 
        }

        public void InventoryReport()
        {
            Console.WriteLine("Склад містить:");
            Console.WriteLine("==================================================================================");
            foreach (var item in warehouseInventory)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public override string ToString()
        {
            InventoryReport();
            return $"Загальний дохід складає: {profitInDollars}$\n";
        }
    }
}
