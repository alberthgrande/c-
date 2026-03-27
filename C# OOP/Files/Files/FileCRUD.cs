using System;
using System.IO;
using System.Linq;

namespace FileCRUD
{
    class Program
    {
        static string filePath = "users.txt";

        static void Main(string[] args)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an option: 1-Create, 2-Read, 3-Update, 4-Delete, 5-Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateUser(); break;
                    case "2": ReadUsers(); break;
                    case "3": UpdateUser(); break;
                    case "4": DeleteUser(); break;
                    case "5": running = false; break;
                    default: Console.WriteLine("Invalid option"); break;
                }
            }
        }

        static void CreateUser()
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            string record = $"{id}|{name}|{age}";
            File.AppendAllText(filePath, record + Environment.NewLine);

            Console.WriteLine("User added!");
        }

        static void ReadUsers()
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("\nUsers:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void UpdateUser()
        {
            Console.Write("Enter ID to update: ");
            string id = Console.ReadLine();
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts[0] == id)
                {
                    Console.Write("Enter new Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter new Age: ");
                    string age = Console.ReadLine();

                    lines[i] = $"{id}|{name}|{age}";
                    found = true;
                    break;
                }
            }

            if (found)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("User updated!");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        static void DeleteUser()
        {
            Console.Write("Enter ID to delete: ");
            string id = Console.ReadLine();
            string[] lines = File.ReadAllLines(filePath);
            var newLines = lines.Where(line => line.Split('|')[0] != id).ToArray();

            if (newLines.Length != lines.Length)
            {
                File.WriteAllLines(filePath, newLines);
                Console.WriteLine("User deleted!");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}