using System;

namespace Exercise7
{
    public class ATM
    {
        private decimal balance = 1000m;

        public void CheckBalance()
        {
            Console.WriteLine($"You're account balance is: {balance}RS.");
        }

        public decimal Withdraw(decimal amount)
        {            
            balance -= amount;
            return balance;
        }

        public decimal Deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Pin Number:");
            Console.ReadLine();
            ATM atm = new ATM();
            int option = 0;
            while(option != 4)
            {
                DisplayOptions();
                Console.WriteLine("Enter Your Choice:");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        atm.CheckBalance();
                        break;
                    case 2:
                        Console.WriteLine("Amout: ");
                        int w = Convert.ToInt32(Console.ReadLine());
                        atm.Withdraw(w);
                        break;
                    case 3:
                        Console.WriteLine("Amout: ");
                        int  d = Convert.ToInt32(Console.ReadLine());
                        atm.Deposit(d);
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
        }

        static void DisplayOptions()
        {
            Console.WriteLine("********Welcome to ATM Service**************");
            Console.WriteLine();
            Console.WriteLine("1. Check Balance");
            Console.WriteLine();
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine();
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine();
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.WriteLine("*********************************************");
        }
    }
}
