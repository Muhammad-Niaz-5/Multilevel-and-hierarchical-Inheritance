using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Lab_6
{
    class Account
    {
        protected double accountBalance;
        public int transaction = 0;
        public double account
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }
        public void credit()
        {

            Console.WriteLine("Enter Amount to be Deposited: ");
            double credit_Amount = int.Parse(Console.ReadLine());
            accountBalance = accountBalance + credit_Amount;
            transaction++;
        }
        public void debit()
        {

            Console.WriteLine("Enter Amount to be Withdrawn: ");
            double debit_amount = int.Parse(Console.ReadLine());
            if (debit_amount > accountBalance)
            {

                Console.WriteLine("\nDebit Amount is Higher!! ");
            }
            else
            {
                accountBalance = accountBalance - debit_amount;
                transaction++;
                Console.WriteLine("Number of Transaction: " + transaction);
            }
        }
        public double getBalance()
        {
            return accountBalance;
        }
    }
    class SavingsAccount : Account
    {
        public double InterestRate = 0.09;
        public double CalculateInterest()
        {

            return (accountBalance * InterestRate);
        }
    }
    class CheckingAccount : Account
    {
        public int Show_transaction()
        {
            return transaction;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            double get_acc;
            Account a = new Account();
            Console.WriteLine("*****Bank Al-Habib*****");
            Console.WriteLine("Hello Sir, Good Morning.");
            Console.WriteLine("\nEnter Your Total Amount in The Bank: ");
            get_acc = double.Parse(Console.ReadLine());
            a.account = get_acc;
            while (i == 0)
            {
                Console.WriteLine("1. Deposit Amount ");
                Console.WriteLine("2. Withdraw Amount ");
                Console.WriteLine("3. Show Interest Rate ");
                Console.WriteLine("Enter Your Choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        a.credit();
                        Console.WriteLine("New Amount: " + a.getBalance());
                        break;
                    case 2:
                        a.debit();
                        Console.WriteLine("Amount left: " + a.getBalance());
                        break;
                    case 3:
                        SavingsAccount sa = new SavingsAccount();
                        sa.CalculateInterest();
                        CheckingAccount ca = new CheckingAccount();
                        Console.WriteLine("Amount charged per Transaction: " + (a.transaction * 20));
                        break;
                    default:
                        Console.WriteLine("Invalid input!! ");
                        break;

                }
            }
            Console.ReadKey();

        }
    }
}