using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        private string AccountNumber { get; set; } // känslig info så den ska vara privat
        public string AccountHolder { get; set; }
        private double Balance { get; set; } // känslig info så den ska vara privat

        //Lägg till Konstruktor
        public BankAccount(string accountnumber, String accountholder, double balance) 
        {
            AccountNumber = accountnumber;
            AccountHolder = accountholder;
            Balance = balance;
        }
        //Lägg till Metoder
        public void Deposit(double amount)
        {
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance += amount}");
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("You didn't have enough balance to Withdraw!");
            }
            else
            {
                Console.WriteLine($"Withdrew: {amount}, New Balance: {Balance -= amount}");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}"); 
        }



        //Lycka till! :)
    }
}
