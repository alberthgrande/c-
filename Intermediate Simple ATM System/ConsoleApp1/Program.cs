string?[] username = new string[10];
string?[] password = new string[10];
int[] balance = new int[10]; // ✅ each user has balance

int userCount = 0;
int choice;

do
{
    Console.WriteLine("\n1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");

    Console.Write("Enter choice: ");
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid choice!");
        continue;
    }

    if (choice == 1)
    {
        UserRegister(username, password, balance, ref userCount);
    }
    else if (choice == 2)
    {
        UserLogin(username, password, balance, userCount);
    }
    else if (choice == 3)
    {
        Console.WriteLine("Thank you for using the ATM!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid user input!");
    }

} while (choice != 3);

static void UserRegister(string?[] username, string?[] password, int[] balance, ref int userCount)
{
    if (userCount >= username.Length)
    {
        Console.WriteLine("User limit reached!");
        return;
    }

    Console.Write("\nEnter username: ");
    username[userCount] = Console.ReadLine();

    Console.Write("Enter password: ");
    password[userCount] = Console.ReadLine();

    balance[userCount] = 0; // ✅ start with 0 balance

    userCount++;

    Console.WriteLine("\nUser registered successfully!");
}

static void UserLogin(string?[] username, string?[] password, int[] balance, int userCount)
{
    Console.Write("Enter username: ");
    string? inputUser = Console.ReadLine();

    Console.Write("Enter password: ");
    string? inputPassword = Console.ReadLine();

    for (int i = 0; i < userCount; i++)
    {
        if (username[i] == inputUser && password[i] == inputPassword)
        {
            Console.WriteLine("\nLogin Successful!");

            ATMMenu(ref balance[i]); // ✅ pass THIS user's balance
            return;
        }
    }

    Console.WriteLine("Invalid username or password!");
}

static void ATMMenu(ref int balance)
{
    int choice;

    do
    {
        Console.WriteLine("\n\n1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");

        Console.Write("Choose: ");

        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input!");
            continue;
        }

        if (choice == 1)
        {
            Console.WriteLine("\nBalance: " + balance);
        }
        else if (choice == 2)
        {
            Console.Write("Enter Deposit Amount: ");

            if (int.TryParse(Console.ReadLine(), out int deposit) && deposit > 0)
            {
                balance += deposit;
                Console.WriteLine("New Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid amount!");
            }
        }
        else if (choice == 3)
        {
            Console.Write("Enter Withdraw Amount: ");

            if (int.TryParse(Console.ReadLine(), out int withdraw))
            {
                if (withdraw > 0 && withdraw <= balance)
                {
                    balance -= withdraw;
                    Console.WriteLine("New Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Invalid or insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        else if (choice == 4)
        {
            Console.WriteLine("Logging out...");
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

    } while (true);
}