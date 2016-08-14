using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA_2016_08
{
    class Program
    class Program
    {
        static void Main(string[] args)
        {
           int n = 0;
            while (n < 3)
            {
                Console.WriteLine("Please Enter your Username: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Please enter your password: ");
                string password = Console.ReadLine();

                if (userName == "dipesh" && password == "password")
                {
                    Console.WriteLine("Correct, {0}", userName);
                    break;
                }
                n++;
                Console.Clear();
                Console.WriteLine("Incorrect, Please try again. try {0}/3", n);
            }
            Console.WriteLine("Thank you! press any key to exit");
          Console.ReadKey();
        }
    }
}
