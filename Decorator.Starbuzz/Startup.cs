using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Startup
    {
        public static void Main()
        {
            BeverageSize beverageSize = BeverageSize.GRANDE;
            Beverage beverage = new Expresso();
            beverage.Size = beverageSize;
            beverage = new Mocha(beverage);
            beverage.Size = beverageSize;
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());


            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            Console.WriteLine( beverage.GetDescription() +" $" + beverage2.Cost());
        }

    }
}
