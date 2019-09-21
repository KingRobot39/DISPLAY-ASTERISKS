using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISPLAY_ASTERISKS_Dylan_Hughes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this int sets the number of rows the triange will have +1
            int max = 9;

            //everytime this for loop runs it creates a new line up to a max of 10
            for (int n = 0; n <= max; n++)
            {
                //this loop writes a number of * equal to how many times the first loop has run
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.WriteLine();

            for (int m = 0; m <= max; m++)
            {
                //this loop writes the maximum number of * then one less each time
                for (int r = 0; r <= max - m; r++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.WriteLine();

            for (int p = 0; p <= max; p++)
            {
                //writes spaces equal to the number of times the loop has run 
                for (int k = 0; k <= p; k++)
                {
                    Console.Write(" ");
                }

                //writes the maximum number of * then one less each time
                for (int o = 0; o <= max - p; o++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.WriteLine();

            for (int e = 0; e <= max; e++)
            {
                //writes spaces equal to the maximum - 1
                for (int q = 0; q <= max -e; q++)
                {
                    Console.Write(" ");
                }

                //writes an * equal to the nuber of times the loop has run
                for (int w = 0; w <= e; w++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
