using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CheckingAccount : Account
    {
        // fields
        private float checkingBalance = 10000;

        // properties
        public float CheckingBalance
        {
            get { return this.checkingBalance; }
        }

        // constructors
        public CheckingAccount ()
        {
            // default constructor
        }

        public CheckingAccount(float checkingBalance)
        {
            // nothing here
        }

        // methods 

        public override float CheckBalance()
        {
            return checkingBalance;
        }

        public override void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            float withdrawFunds = float.Parse(Console.ReadLine());
            if (withdrawFunds < checkingBalance)
            {
                checkingBalance = (checkingBalance - withdrawFunds);
                base.Withdraw();
                Console.WriteLine("Your new checking balance is $" + checkingBalance);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
   
        }

        public override void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            float depositFunds = float.Parse(Console.ReadLine());
            checkingBalance = (checkingBalance + depositFunds);
            base.Deposit();
            Console.WriteLine("Your new balance is $" + checkingBalance);
        }
    }
}
