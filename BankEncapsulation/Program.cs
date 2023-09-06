

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning Mr. Bond!");



            BankAccount bankAccount = new BankAccount();    

            Console.WriteLine($"Your Balanace is {bankAccount.GetBalance()}");

            Console.WriteLine($"Make a deposit, enter amount: ");
            string? tmpInput = Console.ReadLine();
            if ( tmpInput != null )
            {
                bankAccount.Deposit(int.Parse(tmpInput));
                Console.WriteLine($"Thank your for your deposit of {int.Parse(tmpInput)}");
            }
            else
            {
                Console.WriteLine($"You entered an invalid amount...."); 
            }
            
            Console.WriteLine($"Your Balanace is {bankAccount.GetBalance()}");
        }
    }
}
