using System.Reflection.Metadata.Ecma335;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstAccount = new BankAccount();

            Console.WriteLine("Hello, Please tell me if you would like to see your balance? y/n?");
            var userBalanceResponse = Console.ReadLine().ToLower();
            

            if (userBalanceResponse == "y")
            {
                Console.WriteLine($"{firstAccount.GetBalance()}");


            }
         
            else
            {
                Console.WriteLine("Would you like to make a deposit? y/n?");
                var userDepositResponse = Console.ReadLine().ToLower();

                if (userDepositResponse == "y")
                {
                    Console.WriteLine($"How much would you like to deposit?");
                    var depositAmount = double.Parse(Console.ReadLine());
                    firstAccount.Deposit(depositAmount);
                    
                    Console.WriteLine($"Thank you, your balance is now {firstAccount.GetBalance()}.");
                    

                }
                else
                {
                    
                    {
                        if(userBalanceResponse == "n")
                        {
                            Console.WriteLine($"Thank you for visiting ABC Financial Services and have a great day!");
                        }
                        else
                        {
                            
                        }
                    }
                }
            }

            
        }
    }
}
