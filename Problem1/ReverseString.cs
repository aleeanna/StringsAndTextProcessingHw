using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetReversedString(input));
        }

        static string GetReversedString(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);

            string reversed = new string(inputArray);

            return reversed;
        }
    }
}
