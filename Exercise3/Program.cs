using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string below:");
            string s = Console.ReadLine();
            string result = "";
            for (int i = s.Length-1; i >= 0;  i--)
            {
                result += s[i];
            }
            Console.WriteLine(result);
        }
    }
}
