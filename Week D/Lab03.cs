using System;
using System.Collections.Generic;
using System.Text;

namespace it483
{

    public class Lab03
    {

        public static void Main(string[] args)
        {
            double curBal = 45.32;
            double amount;
            Console.Write("Please enter a amount to update account by $");
            amount = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Customer’s balance (before transaction) = $");
            Console.WriteLine(curBal + "\n");
            Console.Write("Requested update amount = $");
            Console.WriteLine(amount + "\n");
            double actAmount;
            actAmount = Transaction(curBal, amount);
            curBal += actAmount;
            Console.Write("Actual update amount = $");
            Console.WriteLine(actAmount + "\n");
            Console.Write("Customer’s balance (after transaction) = $");
            Console.WriteLine(curBal + "\n");
            Console.WriteLine("\nThank you and good-bye!\n");
            Console.ReadLine();
        }
        public static double Transaction(double bal, double amount)
        {
            double total;
            if (amount < 0)
            {
                if ((bal + amount) < 0)
                {
                    total = 0.00;
                }
                else
                {
                    total = amount;
                }
            }
            else
            {
                total = amount;
            }
            return total;
        }
    }
}

