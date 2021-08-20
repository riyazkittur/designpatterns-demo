﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Startup
    {
        public static void Main()
        {
            MenuComponent pancakeHouseMenu;
            MenuComponent dinnerMenu;
            MenuComponent cafeMenu;
            MenuComponent dessertMenu;
            MenuComponent allMenus;
            Waitress waitress;

            //create menus
            pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            dinnerMenu = new Menu("DINNER MENU", "Lunch");
            cafeMenu = new Menu("CAFE MENU", "Dinner");
            dessertMenu = new Menu("DESSERT MENU", "Dessert of course");

            //create the all menus to act as the container for the menus
            allMenus = new Menu("ALL MENUS", "All menus combined");

            //add the menus to the All Menus menu
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinnerMenu);
            allMenus.Add(cafeMenu);

            //breakfast menu
            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, and sausage",
                false,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59));

            //dinner menu
            dinnerMenu.Add(new MenuItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat",
                true,
                2.99));
            dinnerMenu.Add(new MenuItem("Soup of the day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29));
            dinnerMenu.Add(new MenuItem("Hotdog",
                "A hot dog with saurkraut, relish, onions, topped with cheese",
                false,
                3.05));
            dinnerMenu.Add(new MenuItem("Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice",
                true,
                3.99));

            //cafe menu
            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the Day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69));
            cafeMenu.Add(new MenuItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29));

            //add the dessert as a child node off the dinner menu
            dinnerMenu.Add(dessertMenu);

            //dinner menu
            dessertMenu.Add(new MenuItem("Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true, 1.59));
            dessertMenu.Add(new MenuItem("Chocolate Cake",
                "Creamy chololate cake with caramel icing",
                true, 2.59));
            dessertMenu.Add(new MenuItem("Icecream Pie",
                "Icecream pie with crunchy crust",
                true, 1.50));

            //instantiate the waitress passing in all the menus
            waitress = new Waitress(allMenus);
           Console.WriteLine( waitress.PrintMenu());
        }
    }
}
