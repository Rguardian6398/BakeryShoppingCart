using System;

namespace BakeryShoppingCart
{
    class Assignment1
    {
        static void Main()
        {
            ConcatanationOfStrings("my first srting", "My second string");
        }

        static void ConcatanationOfStrings(string parameter1, string parameter2)
        {
            string result = parameter1 + parameter2;

            Console.WriteLine(result);
        }
    }
}