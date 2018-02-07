using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        // my fields are incognito
        
        // properties
        public string ClientFirstName { get; }
        public string ClientLastName { get; }
        public double CheckingAccountNumber { get; }
        public double SavingsAccountNumber { get; }

        // constructors
        
        public Client ()
        {
            // default constructor
        }

        public Client (string clientFirstName, string clientLastName, double checkingAccountNumber, double savingsAccountNumber)
        {
            ClientFirstName = clientFirstName;
            ClientLastName = clientLastName;
            CheckingAccountNumber = checkingAccountNumber;
            SavingsAccountNumber = savingsAccountNumber;
        }

        // methods

        public void DisplayAccountInformation ()
        {
            Console.WriteLine("Name: Friedrich Nietzsche");
            Console.WriteLine("Checking Account Number: 1532980");
            Console.WriteLine("Savings Account Number: 2968351");
            
        }
        
    }
}
