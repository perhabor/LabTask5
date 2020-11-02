using System;

namespace SavingsAccount
{
    class SavingsAccount
    {
        private static decimal annualInterestRate = 0.04m;
        private decimal savingsBalance;

        public decimal SavingsBalance
        {
            get{return savingsBalance;}
            set{savingsBalance = value + CalculateMonthlyInterest(value);}
        }

        public decimal CalculateMonthlyInterest(decimal value)
        {
            return value * (annualInterestRate / 12);
        }

        public static void ModifyInterestRate(decimal rate)
        {
            annualInterestRate = rate / 100;
        }

        public override string ToString()
        {
            return string.Format("{0:C}", SavingsBalance);
        }
    }
}
