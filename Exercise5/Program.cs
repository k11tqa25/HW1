using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    count++;
                    Console.Write(Convert.ToInt32(count % 2 == 1));
                }
                Console.Write("\n");
            }
        }
    }
}
