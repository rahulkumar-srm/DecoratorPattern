using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            beverage = new HouseBlend();
            beverage = new Mocha(beverage);
            beverage = new Soy(beverage);

            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Console.ReadKey();
        }
    }
}
