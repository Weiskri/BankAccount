using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client nietzsche = new Client("Friedrich", "Nietzsche", 1532980, 2968351);
            CheckingAccount nietzscheChecking = new CheckingAccount();
            SavingsAccount nietzscheSavings = new SavingsAccount();
            // user menu
            int userChoice = 0;
            string userChoiceMenu;

            do
            {
                Console.WriteLine("Welcome to the bank account program.");
                Console.WriteLine("");
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("[1] View client information.");
                Console.WriteLine("[2] View account balance:");
                Console.WriteLine("    [ ] Checking account balance.");
                Console.WriteLine("    [ ] Savings account balance.");
                Console.WriteLine("[3] Deposit funds:");
                Console.WriteLine("    [ ] In checking account.");
                Console.WriteLine("    [ ] In savings account.");
                Console.WriteLine("[4] Withdraw funds:");
                Console.WriteLine("    [ ] From checking account.");
                Console.WriteLine("    [ ] From savings account.");
                Console.WriteLine("[5] Exit.");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        nietzsche.DisplayAccountInformation();
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("To check your checking acccount balance, type \"checking.\"");
                        Console.WriteLine("To check your savings account balance, type \"savings.\"");
                        userChoiceMenu = Console.ReadLine().ToLower(); 
                        if (userChoiceMenu == "checking")
                        {
                            Console.WriteLine("Your balance is $" + nietzscheChecking.CheckBalance());
                        }
                        else
                        {
                            Console.WriteLine("Your balance is $" + nietzscheSavings.CheckBalance());
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("To deposit funds into your checking account, type \"checking.\"");
                        Console.WriteLine("To deposit funds into your savings account, type \"savings.\"");
                        userChoiceMenu = Console.ReadLine().ToLower();
                        if (userChoiceMenu == "checking")
                        {
                            nietzscheChecking.Deposit();
                        }
                        else
                        {
                            nietzscheSavings.Deposit();
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("To withdraw funds from your checking account, type \"checking.\"");
                        Console.WriteLine("To withdraw funds from your savings account, type \"savings.\"");
                        userChoiceMenu = Console.ReadLine().ToLower();
                        if (userChoiceMenu == "checking")
                        {
                            nietzscheChecking.Withdraw();
                        }
                        else
                        {
                            nietzscheSavings.Withdraw();
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }


            } while (userChoice != 5);
        }
    }
}
