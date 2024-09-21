namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount account = new BankAccount("123456789", "Jetlir Kuci", 1000);
            account.Deposit(500);
            account.Withdraw(200);
            account.DisplayBalance();
        }
    }
}
