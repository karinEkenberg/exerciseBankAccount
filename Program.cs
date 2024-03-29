using exerciseBankAccount;
using System.Threading;
namespace exerciseBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount("anders", 5555, 5555);
            bool myBool = true;
            while (myBool)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("Welcome to the bank!");
                Console.WriteLine("[1] - Set balance.");
                Console.WriteLine("[2] - Get balance.");
                Console.WriteLine("[3] - Add to account.");
                Console.WriteLine("[4] - Withdraw from account.");
                Console.WriteLine("[5] - Exit.");

                Int32.TryParse(Console.ReadLine(), out int input);
                
                    switch (input)
                    {
                        case 1:
                            bank.SetBalance();
                            break;
                        case 2:
                            bank.GetBalance();
                            break;
                        case 3:
                            bank.AddToBalance();
                            break;
                        case 4:
                            bank.WithdrawFromBalance();
                            break;
                        case 5:
                            bank.Text("Shutting down....");
                            myBool = false;
                            return;
                        default:
                            bank.Text("Wrong input, try again.");
                            break;
                    }
            }

        }
    }
}
