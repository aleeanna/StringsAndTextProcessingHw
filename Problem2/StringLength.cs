using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < 20; i++)
            {
                if (i < input.Length)
                {
                    Console.Write(input[i]);
                }
                else
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}
