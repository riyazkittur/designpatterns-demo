using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Startup
    {
        public static void Main()
        {
            Turkey wildTurkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);
            Console.WriteLine(turkeyAdapter.Quack());

            Duck mallard = new MallardDuck();
            Turkey duckAdapter = new DuckAdapter(mallard);

            Console.WriteLine(duckAdapter.Gobble());
            Console.WriteLine(duckAdapter.Fly());
           
        }
    }
}
