namespace Lab02_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
        }
        public static decimal Balance;

        public static decimal ViewBalance()
        {
            decimal balance = 1000.00M;
            return balance;
        }
        public static decimal Withdraw(decimal amount)
        {
            decimal currentBalance = ViewBalance(); // Get the current balance
            decimal newBalance = currentBalance - amount;
            if (newBalance < 0)
            {
                Console.WriteLine("Insufficient funds.");
                    return currentBalance;
            }
            return newBalance;
        }
        public static decimal Deposit(decimal amount)
        {
            decimal currentBalance = ViewBalance(); // Get the current balance
            decimal newBalance = currentBalance + amount;

            if (amount < 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return currentBalance;
            }
            return newBalance;
        }
        public static void UserInterface()
        {
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1.View Balance");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        decimal balance = ViewBalance();
                        Console.WriteLine($"Current Balance:{balance}");
                        break;
                    case "2":
                        Console.WriteLine("Enter withdraw amount:");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        decimal newBalance = Withdraw(withdrawAmount);
                        Console.WriteLine($"New Balance: {newBalance}");
                        break;
                    case "3":
                        Console.WriteLine("Enter the amount to deposit:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        decimal updatedBalance = Deposit(depositAmount);
                        Console.WriteLine($"Updated Balance: {updatedBalance}");
                        break;
                    case "4":
                        return; // Exit the method
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}