bankAccount barclaysAccount = new bankAccount();
barclaysAccount.setPinNumber("1231");
barclaysAccount.setAccountNo("12345678");
barclaysAccount.SetSortCode("12-34-56");

//Console.WriteLine("Account Number " + barclaysAccount.getAccountNumber());
//Console.WriteLine("Sort code " + barclaysAccount.getSortCode());

//Console.WriteLine("Balance = " + barclaysAccount.getBalance());
//barclaysAccount.deposit(200);
//Console.WriteLine("Balance = " + barclaysAccount.getBalance());
//barclaysAccount.withdraw(56);
//Console.WriteLine("Balance = " + barclaysAccount.getBalance());

String AccountPin;
Console.WriteLine("Enter pin number");
AccountPin = Console.ReadLine();

int i = 0;

do
{



    if (AccountPin == "1231")
    {
        Console.WriteLine("ENTER AN INPUT NOW");
        Console.WriteLine("1. View Balance");
        Console.WriteLine("2. Withdraw Money");
        Console.WriteLine("3. Deposit Money");
        Console.WriteLine("4. Change Pin Number");
        Console.WriteLine("5. Exit");
        int choice;
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Balance = " + barclaysAccount.getBalance());
        }

        if (choice == 2)
        {
            double withdrawC;
            Console.WriteLine("Enter the amount you'd like to withdraw");
            withdrawC = Convert.ToDouble(Console.ReadLine());
            barclaysAccount.withdraw(withdrawC);
        }

        if (choice == 3)
        {
            double DepositC;
            Console.WriteLine("Enter the amount you'd like to deposit");
            DepositC = Convert.ToDouble(Console.ReadLine());
            barclaysAccount.deposit(DepositC);
        }

        if (choice == 4)
        {
            Console.WriteLine("Enter your new pin");
            AccountPin = Console.ReadLine();
            Console.WriteLine("Your pin has been set to " +AccountPin);
        }

        else if (choice == 5)
        {
            Console.WriteLine("Program Closed");
            break;
        }
    }
}
while (i < 5);

Console.ReadKey();