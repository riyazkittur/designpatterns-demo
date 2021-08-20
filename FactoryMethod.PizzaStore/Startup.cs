using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Startup
    {
        public static void Main()
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine(nyStore.ToString());

            PizzaStore chicagoStore = new ChicagoPizzaStore();
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine(pizza.ToString());
        }
    }
