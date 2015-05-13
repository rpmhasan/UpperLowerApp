using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lower Limit: ");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Upper Limit: ");
            int upper = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nResult is: \n");
            for (int i = lower; i <=upper ; i++)
            {
                Console.WriteLine(i + "\n");
            }
            Console.Read();
        }
    }
}
