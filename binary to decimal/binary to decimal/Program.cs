using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dNumb; string binary; 
              Console.Write("enter binary number :");
                 binary = Console.ReadLine();
                     dNumb = Convert.ToInt32(binary , 2);
                           Console.WriteLine("decimal of your binary number is : " + dNumb);
                                Console.ReadKey();                   
        }
    }
}
