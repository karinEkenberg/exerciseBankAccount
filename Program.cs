/*
 Skapa en klass för att representera en enkel bankkontoapplikation.
1. Skapa en klass med namnet Bankkonto.
2. Klassen ska ha medlemmar för kontonummer (kontonummer), kontoinnehavarens namn
(kontoinnehavare), och saldo (saldo).
3. Skapa metoder för att sätta saldo (SättSaldo) och hämta saldo (HämtaSaldo).
4. Skapa en metod för att genomföra en insättning (Insättning) och en metod för att genomföra
ett uttag (Uttag).
 */
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
