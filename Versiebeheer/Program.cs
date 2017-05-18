using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versiebeheer
{
    class Program
    {
        static void Main(string[] args)
        {
            int priemteller = 0;
            int invoer;
            
            Console.Write("Geef een getal in: ");
            invoer = Convert.ToInt16(Console.ReadLine());
            
            for (int teller = 1; teller <= invoer; teller ++)
            {
                if (invoer % teller = 0)
                {
                    priemteller ++;
                }
            }
            
            if (priemteller = 2)
            {
                Console.WriteLine("{0} is een priemgetal.", invoer.ToString());
            }
            else
            {
                Console.WriteLine("{0} is geen priemgetal.", invoer.ToString())
            }
            Console.ReadLine();
        }
    }
}
