using System;

namespace SavingsAccount
{
    class Program
    {
         static void Main(string[] args)
        {
             SavingsAccount saver1 = new SavingsAccount();
             SavingsAccount saver2 = new SavingsAccount();
           
           SavingsAccount.ModifyInterestRate(5);
           saver1.SavingsBalance = 2000m;
           saver2.SavingsBalance = 3000m;

            Console.WriteLine($"Total on Savings Account before modifying is {saver1}");
            Console.WriteLine($"Total on Savings Account before modifying is {saver2}");
        }
    }
}
