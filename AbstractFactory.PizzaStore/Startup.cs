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
            Console.WriteLine(pizza.ToString());

            PizzaStore chicagoStore = new ChicagoPizzaStore();

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine(pizza.ToString());
        }
    }
