using System;

namespace SoloPrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Account Detail..........");
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            System.Console.WriteLine("Balance: " + b.GetBalance());

        }
    }
    class BankAccount
    {
        private double balance = 0;
        public void Deposit(double n)
        {
            balance += n;
        }
        public void Withdraw(double n)
        {
            balance -= n;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
