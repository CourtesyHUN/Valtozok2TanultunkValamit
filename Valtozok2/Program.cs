using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            /*if (y == 0) 
              {
                  Console.WriteLine("Hiba");
              }
              else
              {
                  Console.WriteLine((double)x / y);
              }
              Console.ReadKey(); */
            Console.WriteLine((double)x / y);

            char betu = 'C';
            Console.WriteLine(Convert.ToInt32(betu));

            bool A = true;
            Console.WriteLine(A || false == A);
            A = false;
            Console.WriteLine(A || false == A);

            Console.WriteLine("\n");
            Console.WriteLine("AND\tTrue \tFalse");
            Console.WriteLine("True\t{0}\t{1}", true && true, true && false);
            Console.WriteLine("False\t{0}\t{1}", false && true,false && false);
            Console.WriteLine("\n---------------\n");

            Console.WriteLine("OR\tTrue \tFalse");
            Console.WriteLine("True\t{0}\t{1}", true && true, true && false);
            Console.WriteLine("False\t{0}\t{1}", false && true, false && false);
            Console.WriteLine("\n---------------\n");

            Console.WriteLine("NOT\tTrue");
            Console.WriteLine("True\t{0}", true && true);
            Console.WriteLine("False\t{0}", false && true);
            Console.WriteLine("\n---------------\n");

            /*
             
            A ||false == A
            A || true == true             
            A && false == false
            A && true == A
            A || !A == true


            */


            Console.ReadKey();

        }
    }
}
