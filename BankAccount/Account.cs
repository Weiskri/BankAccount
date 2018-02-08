using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        // fields

        // properties

        // constructors
        // none because this is abstract

        // methods
        public abstract float CheckBalance();
        public virtual void Withdraw ()
        {
            Console.WriteLine("You have withdrawn funds from your account.");
        }

        public virtual void Deposit ()
        {
            Console.WriteLine("You have successfully deposited funds into your account.");

        }
        
    }
}
