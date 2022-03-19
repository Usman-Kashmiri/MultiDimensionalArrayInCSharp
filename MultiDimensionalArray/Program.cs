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
            //Jagged Multidimensional Arrays

            int[][] jagged_arr = new int[][]
            {
                new int[] {1, 2, 3, 4},
                new int[] {11, 34, 67},
                new int[] {89, 23},
                new int[] {0, 45, 78, 53, 99}
            };

            Console.WriteLine("output using foreach loop");
            // output using foreach
            foreach (var item in jagged_arr)
            {
                foreach (var index in item)
                {
                    Console.WriteLine(index);
                }
            }

            Console.WriteLine("output using nested for loop");
            /* output each array element's value */
            int i, j;
            for (i = 0; i < jagged_arr.Length; i++)
            {
                for (j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.WriteLine(jagged_arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
