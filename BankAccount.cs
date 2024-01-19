using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 Skapa en klass för att representera en enkel bankkontoapplikation.
1. Skapa en klass med namnet Bankkonto.
2. Klassen ska ha medlemmar för kontonummer (kontonummer), kontoinnehavarens namn
(kontoinnehavare), och saldo (saldo).
3. Skapa metoder för att sätta saldo (SättSaldo) och hämta saldo (HämtaSaldo).
4. Skapa en metod för att genomföra en insättning (Insättning) och en metod för att genomföra
ett uttag (Uttag).
 */

namespace exerciseBankAccount
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public static List<BankAccount> BankAccounts = new List<BankAccount>();

        public BankAccount(string name, int accountNumber, double balance) 
        {
            Name = name;
            Balance = balance;
            AccountNumber = accountNumber;
        }


        public void SetBalance()
        {
            while (true)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter account number:");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your balance:");
                double balance = double.Parse(Console.ReadLine());
                BankAccount bankAccount = new BankAccount(name, accountNumber, balance);
                BankAccounts.Add(bankAccount);
                break;
            }
  
            
        }

        public void GetBalance()
        {
            Console.WriteLine("List of bank accounts:");
            foreach (BankAccount bankAccount in BankAccounts)
            {
                Console.WriteLine(bankAccount.ToString());
            }

            // Vänta på användarens Enter-inmatning
            Console.WriteLine("\nPress Enter to return to the main menu.");
            Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name: {Name}, accountnumber: {AccountNumber}, balance: {Balance}";
        }

        public void AddToBalance()
        {
            Console.WriteLine("Add to your balance!");
            Console.WriteLine("Please enter your account number:");

            if (int.TryParse(Console.ReadLine(), out int existingAccountNumber))
            {
                // Hitta bankkontot med det angivna kontonumret
                BankAccount existingAccount = BankAccounts.FirstOrDefault(account => account.AccountNumber == existingAccountNumber);

                if (existingAccount != null)
                {
                    Console.WriteLine($"Account found! Current balance: {existingAccount.Balance}");

                    Console.WriteLine("Enter the amount to add to your balance:");

                    if (double.TryParse(Console.ReadLine(), out double amountToAdd))
                    {
                        // Uppdatera saldot
                        existingAccount.Balance += amountToAdd;

                        Console.WriteLine($"Balance updated! New balance: {existingAccount.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a valid numeric value.");
                    }
                }
                else
                {
                    Console.WriteLine("Account not found. Please check your account number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid account number. Please enter a valid numeric value.");
            }
        }


        public void WithdrawFromBalance()
        {
            Console.WriteLine("Withdraw from your account!");
            Console.WriteLine("Enter your accountnumber:");

            if (int.TryParse(Console.ReadLine(), out int existingAccountNumber))
            {
                BankAccount existingAccount = BankAccounts.FirstOrDefault(account => account.AccountNumber == existingAccountNumber);

                if (existingAccount != null)
                {
                    Console.WriteLine($"Account found! Current balance: {existingAccount.Balance}");

                    Console.WriteLine("Enter the amount to withdraw from your balance:");

                    if (double.TryParse(Console.ReadLine(), out double amountToAdd))
                    {
                        existingAccount.Balance -= amountToAdd;

                        Console.WriteLine($"Balance updated! New balance: {existingAccount.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a valid numeric value.");
                    }
                }
                else
                {
                    Console.WriteLine("Account not found. Please check your account number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid account number. Please enter a valid numeric value.");
            }
        }

        public void Text(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Thread.Sleep(2000);
        }
    }
}
