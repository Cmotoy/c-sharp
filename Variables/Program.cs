using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name");
            Console.Write("Type your first name");
            string x;
            x = Console.ReadLine();

            string myLastName;
            Console.Write("Type your Last name");
            myLastName = Console.ReadLine();


            Console.Write("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("Hello," + x + " " + myLastName + "\n" + " You are " + " " + age + "years old" );

    
                Console.ReadLine();
        }
    }
}
