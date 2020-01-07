using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList names = new MyList();

            //names.firstItem = new ListItem();

            //names.firstItem.textData = "Dunham";

            //Console.WriteLine(names.firstItem.textData);
            //Console.ReadKey();
            //names.firstItem.nextItem = new ListItem();
            //names.firstItem.nextItem.textData = "Walter";

            //Console.WriteLine(names.firstItem.nextItem.textData);

            //names.firstItem.nextItem.nextItem = new ListItem();
            //names.firstItem.nextItem.nextItem.textData = "Peanut";

            MyList names = new MyList();

            names.AddItem("Alice");
            names.AddItem("Bob");
            names.AddItem("Charlie");

            Console.WriteLine(names.Length);
            Console.ReadKey();

        }
    }
}
