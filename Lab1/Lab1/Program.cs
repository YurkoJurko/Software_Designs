using Lab1.ClassLibrary;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Reporting reporting = new Reporting();

Product laptop = new Product("Ноутбук", new Hryvnas(27999, 99));
Product tv = new Product("Телевізор", new Hryvnas(15999, 99));
Product pc = new Product("Компутер", new Hryvnas(69999, 99));
Product mouse = new Product("Миша", new Hryvnas(199, 99));

reporting.RegisterIncomingGoods(mouse, "шт", 100, DateTime.Now);
reporting.RegisterIncomingGoods(laptop, "шт", 100, DateTime.Now);

Console.WriteLine($"Загальний прибуток: {reporting.profitInDollars}");

reporting.RegisterOutgoingGoods(laptop, 2);

reporting.RegisterOutgoingGoods(mouse, 2);

Console.WriteLine(reporting.ToString());


Hryvnas hryvnas = new Hryvnas(3960);
Console.WriteLine(hryvnas.ToString());

Console.WriteLine("==========================");

Console.WriteLine(hryvnas.exchangeToDollar().ToString());
