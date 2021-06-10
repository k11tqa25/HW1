using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of row: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int space = rows - 1;
            for (int i = 1; i <= rows * 2 - 1; i++)
            {
                for (int k = 0; k < space; k++) Console.Write(" ");

                if (i <= rows)
                {
                    for (int j = 0; j < 1 + (i-1)*2; j++) Console.Write("*");
                }
                else
                {
                    int r = i - (i - rows) * 2;
                    for (int j = 0; j < 1 + (r - 1) * 2; j++) Console.Write("*");
                }
                space = i < rows ? space - 1: space + 1;
                Console.Write("\n");
            }
        }
    }
}
