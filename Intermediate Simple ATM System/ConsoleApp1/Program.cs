using UserClass;
using System;
using System.Collections.Generic;

List<User> users = new List<User>();

do
{
    Console.Clear(); // 🔹 clear screen before showing menu

    int choice;

    Console.WriteLine("=== ATM SYSTEM ===\n");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Admin Login");
    Console.WriteLine("4. Exit");

    Console.Write("\nEnter choice: ");
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid choice!");
        Pause();
        continue;
    }

    if (choice == 1)
    {
        UserRegister(users);
    }
    else if (choice == 2)
    {
        UserLogin(users);
    }
    else if (choice == 3)
    {
        AdminLogin(users);
    }
    else if (choice == 4)
    {
        Console.WriteLine("Thank you for using the ATM!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid user input!");
        Pause();
    }

} while (true);


// ====================== Helper Methods ======================

static void Pause()
{
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

// ---------------------- User Registration -------------------
static void UserRegister(List<User> users)
{
    Console.Clear();
    Console.WriteLine("=== REGISTER ===\n");

    Console.Write("Enter username: ");
    string? inputUser = Console.ReadLine();

    // ✅ check if username exists
    foreach (var user in users)
    {
        if (user.Username == inputUser)
        {
            Console.WriteLine("Username already exists!");
            Pause();
            return;
        }
    }

    Console.Write("Enter password: ");
    string? inputPass = ReadPassword(); // 🔒 hidden input

    users.Add(new User(inputUser!, inputPass!));

    Console.WriteLine("\nUser registered successfully!");
    Pause();
}

// ---------------------- User Login -------------------------
static void UserLogin(List<User> users)
{
    Console.Clear();
    Console.WriteLine("=== USER LOGIN ===\n");

    Console.Write("Enter username: ");
    string? inputUser = Console.ReadLine();

    Console.Write("Enter password: ");
    string? inputPass = ReadPassword(); // 🔒 hidden input

    foreach (var user in users)
    {
        if (user.Username == inputUser && user.Password == inputPass)
        {
            Console.WriteLine("\nLogin Successful!");
            Pause();
            ATMMenu(user); // ✅ pass whole object
            return;
        }
    }

    Console.WriteLine("Invalid username or password!");
    Pause();
}

// ---------------------- ATM Menu ---------------------------
static void ATMMenu(User user)
{
    int choice;

    do
    {
        Console.Clear();
        Console.WriteLine($"=== ATM MENU ({user.Username}) ===\n");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");

        Console.Write("\nChoose: ");
        if (!int.TryParse(Console.ReadLine(), out choice))
            continue;

        if (choice == 1)
        {
            Console.WriteLine($"\nBalance: {user.Balance}");
            Pause();
        }
        else if (choice == 2)
        {
            Console.Write("\nDeposit: ");
            if (int.TryParse(Console.ReadLine(), out int amt) && amt > 0)
            {
                user.Balance += amt;
                Console.WriteLine($"Deposit successful! New balance: {user.Balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount!");
            }
            Pause();
        }
        else if (choice == 3)
        {
            Console.Write("\nWithdraw: ");
            if (int.TryParse(Console.ReadLine(), out int amt) && amt > 0 && amt <= user.Balance)
            {
                user.Balance -= amt;
                Console.WriteLine($"Withdrawal successful! New balance: {user.Balance}");
            }
            else
            {
                Console.WriteLine("Invalid or insufficient amount!");
            }
            Pause();
        }
        else if (choice == 4)
        {
            break;
        }

    } while (true);
}

// ---------------------- Admin Login ------------------------
static void AdminLogin(List<User> users)
{
    Console.Clear();
    Console.WriteLine("=== ADMIN LOGIN ===\n");

    const string adminUser = "admin";
    const string adminPass = "123";

    Console.Write("Enter username: ");
    string? inputUser = Console.ReadLine();

    Console.Write("Enter password: ");
    string? inputPass = ReadPassword(); // 🔒 hidden input

    if (inputUser == adminUser && inputPass == adminPass)
    {
        Console.WriteLine("\nAdmin Login Successful!");
        Pause();
        AdminMenu(users);
        return;
    }

    Console.WriteLine("Invalid admin credentials!");
    Pause();
}

// ---------------------- Admin Menu ------------------------
static void AdminMenu(List<User> users)
{
    int choice;

    do
    {
        Console.Clear();
        Console.WriteLine("=== ADMIN MENU ===\n");
        Console.WriteLine("1. View Users");
        Console.WriteLine("2. View Balances");
        Console.WriteLine("3. Delete User");
        Console.WriteLine("4. Exit");

        Console.Write("\nChoose: ");
        if (!int.TryParse(Console.ReadLine(), out choice))
            continue;

        if (choice == 1)
        {
            Console.WriteLine();
            if (users.Count == 0)
            {
                Console.WriteLine("No users found!");
            }
            else
            {
                foreach (var user in users)
                {
                    Console.WriteLine($"- {user.Username}");
                }
            }
            Pause();
        }
        else if (choice == 2)
        {
            Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Username}: {user.Balance}");
            }
            Pause();
        }
        else if (choice == 3)
        {
            Console.Write("\nEnter username to delete: ");
            string? name = Console.ReadLine();

            var user = users.Find(u => u.Username == name);

            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User deleted.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
            Pause();
        }
        else if (choice == 4)
        {
            break;
        }

    } while (true);
}

// ---------------------- Read Password ----------------------
static string ReadPassword()
{
    string password = "";
    ConsoleKeyInfo key;

    do
    {
        key = Console.ReadKey(true);

        if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
        {
            password += key.KeyChar;
            Console.Write("*");
        }
        else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
        {
            password = password[..^1];
            Console.Write("\b \b");
        }

    } while (key.Key != ConsoleKey.Enter);

    Console.WriteLine();
    return password;
}