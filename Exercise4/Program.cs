using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in 2 numbers for the range.");
            Console.Write("From: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("To: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (IsArmstrongNumber(i)) Console.Write(i + " ");
            }
        }

        static bool IsArmstrongNumber(int n)
        {
            List<int> digits = new List<int>();
            int temp = n;
            int sum = 0;
            while(temp > 0)
            {
                digits.Add(temp % 10);
                temp = temp / 10;
            }
            digits.ForEach(d =>
           {
               sum += (int)Math.Pow(d, digits.Count);
           });
            return sum == n;
        }
    }
}
