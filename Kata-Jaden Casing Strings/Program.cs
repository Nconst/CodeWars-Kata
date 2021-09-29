using System.Globalization;
using System;

namespace CodeWars
{
    class Program
    {
        static int Main(string[] args)
        {
            string phrase = Console.ReadLine();
            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase));
            Console.ReadLine();
            return 0;
        }
    }
}
