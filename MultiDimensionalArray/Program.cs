using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangular Multidimensional Arrays

            int[,] a = new int[3, 4] {
               {0, 1, 2, 3} ,   //  initializers for row indexed by 0
               {4, 5, 6, 7} ,   //  initializers for row indexed by 1
               {8, 9, 10, 11}   //  initializers for row indexed by 2 
            };

            Console.WriteLine("output using foreach loop");
            // output using foreach
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("output using nested for loop");
            /* output each array element's value */
            int i, j;
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
