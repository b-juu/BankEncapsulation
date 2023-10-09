using BankEncapsulation;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        while (true)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Get Balance");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount to deposit: ");
                        double depositAmount;
                        if (double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for deposit amount.");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: ${account.GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }
}
