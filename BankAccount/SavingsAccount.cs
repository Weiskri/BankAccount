using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : Account
    {
        // fields
        private float savingsBalance = 1000;
        private float minimumBalance = 400;

        // properties
        public float SavingsBalance
        {
            get { return this.savingsBalance; }
        }

        public float MinimumBalance
        {
            get { return this.minimumBalance; }
            set { minimumBalance = value; }
        }

        // constructors

        public SavingsAccount ()
        {
            // default constructor
        }

        public SavingsAccount(float savingsBalance)
        {
            // nothing here
        }

        // methods
        public override float CheckBalance()
        {
            return savingsBalance;
        }

        public override void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            float withdrawFunds = float.Parse(Console.ReadLine());
            if ((withdrawFunds < savingsBalance) && ((savingsBalance - withdrawFunds) >= minimumBalance))
            {
                savingsBalance = (savingsBalance - withdrawFunds);
                base.Withdraw();
                Console.WriteLine("Your new balance is $" + savingsBalance);
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
            savingsBalance = (savingsBalance + depositFunds);
            base.Deposit();
            Console.WriteLine("Your new savings balance is $" + savingsBalance);
        }
    }
}
