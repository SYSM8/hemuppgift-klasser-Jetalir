using System.ComponentModel.Design;
using System.Data;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            string option;
            
            BankAccount account1 = new BankAccount("123456789", "Jetlir Kuci", 1000);
            BankAccount account2 = new BankAccount("987654321", "Brown Boy", 2000);
            BankAccount current = new BankAccount();
            do
            {
                Console.WriteLine("Write your AccountNumber");
                Console.WriteLine("Write 1 to exit");
                option = Console.ReadLine();
                Console.Clear();
                if (option == account1.AccountNumber)
                {
                    current = account1;
                }
                else if (option == account2.AccountNumber)
                {
                    current = account2;
                }
                else if (option != "1")
                {
                    Console.WriteLine("That number isnt valid, Try again!");
                }
                
                if (option == current.AccountNumber)
                {

                    do
                    {
                        Console.WriteLine($"Account: {current.AccountHolder}");
                        Console.WriteLine("Choose an option:");
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Deposit");
                        Console.WriteLine("3. Withdraw");
                        Console.WriteLine("4. Exit");
                        option = Console.ReadLine();
                        Console.Clear();

                        if (option == "1")
                        {
                            current.DisplayBalance();
                        }

                        else if (option == "2")
                        {
                            Console.WriteLine("How much do you want to deposit?");
                            double deposit = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            current.Deposit(deposit);
                        }

                        else if (option == "3")
                        {
                            Console.WriteLine("How much do you want to withdraw?");
                            double withdraw = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                            current.Withdraw(withdraw);
                        }
                        else if (option != "4")
                        {
                            Console.WriteLine("That option doesn't exist, try again!");
                        }
                        
                    } while (option != "4");
                }
            } while (option != "1");
            
        }
        
    }
}


                   
