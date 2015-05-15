using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem3
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string searchString = Console.ReadLine();           

            int count = text.Select((c, i) => text.Substring(i))
                .Count(x => x.StartsWith(searchString, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);
        }
    }
}
