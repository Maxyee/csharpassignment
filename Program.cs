using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname, addline1, addline2, city, state, zip, country;
            Console.WriteLine("Student Information\n");
            
            Console.WriteLine("First Name:");
            fname = Console.ReadLine();

            Console.WriteLine("Last Name:");
            lname = Console.ReadLine();

            Console.WriteLine("Address Line 1:");
            addline1 = Console.ReadLine();

            Console.WriteLine("Address Line 2:");
            addline2 = Console.ReadLine();

            Console.WriteLine("City:");
            city = Console.ReadLine();

            Console.WriteLine("State/Province:");
            state = Console.ReadLine();

            Console.WriteLine("Zip/Postal:");
            zip = Console.ReadLine();

            Console.WriteLine("Country:");
            country = Console.ReadLine();
            
            Console.WriteLine("\n");

            Console.WriteLine("So the inputed Values are:");
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            Console.WriteLine(addline1);
            Console.WriteLine(addline2);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zip);
            Console.WriteLine(country);
            Console.ReadKey();
        }
    }
}
