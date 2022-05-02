using System;

namespace _1_bankszamla_kivetelkezeles
{
    class Runnable
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount(42);
            Console.WriteLine("Depositing $500...");
            account.Deposit(500);

            try
            {
                Console.WriteLine("\nWithdrawing $100...");
                account.Withdraw(100);

                Console.WriteLine("\nWithdrawing $600...");
                account.Withdraw(600);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("Sorry, but you are short $" + e.GetAmount());
                //Console.WriteLine(e);
                //Console.WriteLine(System.Environment.StackTrace);
                Console.WriteLine("\nStackTrace ---\n{0}", e.StackTrace);

                Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine("\nTargetSite ---\n{0}", e.TargetSite);
                Console.WriteLine("\nHelpLink ---\n{0}", e.HelpLink);
            }
        }
    }
}
