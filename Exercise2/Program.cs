using System;

namespace Exercise2
{
    public class Arithmetic
    {
        int a = 4, b = 2;
        public void Addition()
        {
            Console.WriteLine(a+b);
        }
        public void Subtraction()
        {
            Console.WriteLine(a-b);
        }
        public void Multiplication()
        {
            Console.WriteLine(a*b);
        }
        public void Division()
        {
            Console.WriteLine(a / b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            Console.Write("Type in a, s, m, d for addition, subtraction, multiplication, and division. ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "a":
                    arithmetic.Addition();
                    break;
                case "s":
                    arithmetic.Subtraction();
                    break;
                case "m":
                    arithmetic.Multiplication();
                    break;
                case "d":
                    arithmetic.Division();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
