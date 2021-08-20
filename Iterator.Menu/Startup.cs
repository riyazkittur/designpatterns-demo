using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Startup
    {
        public static void Main()
        {            
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinnerMenu dinnerMenu = new DinnerMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinnerMenu, cafeMenu);
            
            Console.WriteLine(waitress.PrintMenu());
        }
    }
