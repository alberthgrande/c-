string?[] tasks = new string[10];
string?[] status = new string[10];
int[] ids = new int[10];
int nextId = 1;
int count = 0;
int choice;

static string CapitalizeFirstLetter(string str)
{
    if (string.IsNullOrWhiteSpace(str)) return str;

    return char.ToUpper(str[0]) + str.Substring(1).ToLower();
}

do
{
    Console.WriteLine("\n1 Add Task");
    Console.WriteLine("2 View Tasks");
    Console.WriteLine("3 Update Task");
    Console.WriteLine("4 Delete Task");
    Console.WriteLine("5 Exit");

    Console.Write("\nExecute selected action: ");
    if (!int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("Invalid choice.");
        continue;
    }

    if (choice == 1)
    {
        if (count < tasks.Length)
        {
            Console.Write("Enter Task name: ");
            tasks[count] = Console.ReadLine();
            status[count] = "Pending";
            ids[count] = nextId;

            nextId++;
            count++;

            Console.WriteLine("Task successfully added!");
        }
        else
        {
            Console.Write("Storage is full!");
        }
    }

    if (choice == 2)
    {
        if (count == 0)
        {
            Console.WriteLine("No task available.");
        }
        else
        {
            Console.WriteLine("ID \t Tasks Name \t Status");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{ids[i]} \t {tasks[i]} \t {CapitalizeFirstLetter(status[i]!)}");
            }

            // Completed tasks counter
            int completedTasks = 0;
            for (int i = 0; i < count; i++)
            {
                if (status[i]?.Equals("Done", StringComparison.OrdinalIgnoreCase) == true)
                    completedTasks++;
            }
            Console.WriteLine($"\nYou completed: {completedTasks} task{(completedTasks != 1 ? "s" : "")}");
        }
    }

    if (choice == 3)
    {
        Console.WriteLine("Enter Tasks IDs: ");
        if (!int.TryParse(Console.ReadLine(), out int search))
        {
            Console.WriteLine("Invalid Input!");
            continue;
        }

        bool found = false;


        for (int i = 0; i < count; i++)
        {
            if (ids[i] == search)
            {
                Console.Write($"Enter new task name (leave blank to keep '{tasks[i]}'): ");
                string? newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    tasks[i] = newName.Trim();
                }

                Console.Write($"Enter new status (Done/Pending, leave blank to keep '{status[i]}'): ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    // Keep existing status
                }
                else if (input.Equals("Done", StringComparison.OrdinalIgnoreCase))
                {
                    status[i] = "Done";
                }
                else if (input.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                {
                    status[i] = "Pending";
                }
                else
                {
                    Console.WriteLine("Invalid input, keeping previous status.");
                }

                Console.WriteLine("Task updated.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Task not found!");
        }

    }

    if (choice == 4)
    {
        Console.Write("Enter Task ID: ");
        if (!int.TryParse(Console.ReadLine(), out int search))
        {
            Console.WriteLine("Invalid Input!");
            continue;
        }

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (ids[i] == search)
            {
                Console.Write($"Are you sure you want to delete the task '{tasks[i]}'? (y/n): ");
                string? confirm = Console.ReadLine()?.Trim().ToLower();

                if (confirm == "y")
                {
                    // Shift everything left to overwrite deleted task
                    for (int j = i; j < count - 1; j++)
                    {
                        tasks[j] = tasks[j + 1];
                        status[j] = status[j + 1];
                        ids[j] = ids[j + 1];
                    }

                    // Clear last element
                    tasks[count - 1] = null;
                    status[count - 1] = null;
                    ids[count - 1] = 0;
                    count--;
                    Console.WriteLine("Task deleted!");
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                }

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Task not found!");
        }
    }

} while (choice != 5);

Console.WriteLine("\nProgram exit...");