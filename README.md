### Bank Account Application

This simple console application represents a basic bank account system. Users can create accounts, check balances, deposit funds, withdraw funds, and exit the application.

#### How to Use

1. **Set Balance:**
   - Choose option [1] to set the initial balance.
   - Enter your name, account number, and initial balance.

2. **Get Balance:**
   - Choose option [2] to view a list of all bank accounts with their respective details.

3. **Add to Account:**
   - Choose option [3] to add funds to an existing account.
   - Enter your account number and the amount to add.

4. **Withdraw from Account:**
   - Choose option [4] to withdraw funds from an existing account.
   - Enter your account number and the amount to withdraw.

5. **Exit:**
   - Choose option [5] to exit the application.

#### Notes:

- The application uses a simple `BankAccount` class to manage accounts.
- Each account has a unique account number, account holder's name, and balance.
- The application keeps a list of created bank accounts.

#### How to Build and Run:

1. Clone the repository.

```bash
git clone https://github.com/your/repository.git
```

2. Open the project in your preferred C# development environment.

3. Build and run the application.

4. Follow the on-screen instructions to interact with the bank account application.

#### Sample Interaction:

```plaintext
Welcome to the bank!
[1] - Set balance.
[2] - Get balance.
[3] - Add to account.
[4] - Withdraw from account.
[5] - Exit.

1
Enter your name:
John Doe
Enter account number:
12345
Enter your balance:
1000

Welcome to the bank!
[1] - Set balance.
[2] - Get balance.
[3] - Add to account.
[4] - Withdraw from account.
[5] - Exit.

2
List of bank accounts:
Name: John Doe, accountnumber: 12345, balance: 1000

Press Enter to return to the main menu.

3
Add to your balance!
Please enter your account number:
12345
Enter the amount to add to your balance:
500

Balance updated! New balance: 1500

...

5
Shutting down....
```

Feel free to explore and modify the code as needed for educational or personal use.
