namespace Task_Management_System;

using Task_Management_System.Models;
using Task_Management_System.Services;

class Program
{
    static void Main()
    {
        TaskService service = new();
        service.LoadFromFile();

        while (true)
        {
            Console.WriteLine("\n==== TASK MANAGER ====");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Assign User");
            Console.WriteLine("5. Search Task");
            Console.WriteLine("6. Exit");

            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Description: ");
                    string desc = Console.ReadLine();

                    Console.Write("Priority (0=Low,1=Medium,2=High): ");
                    TaskPriority priority = (TaskPriority)int.Parse(Console.ReadLine());

                    Console.WriteLine("1. Normal Task");
                    Console.WriteLine("2. Urgent Task");
                    int type = int.Parse(Console.ReadLine());

                    int id = service.GetNextId();

                    if (type == 1)
                    {
                        service.AddTask(new TaskItem(id, title, desc, priority));
                    }
                    else
                    {
                        Console.Write("Deadline (yyyy-mm-dd): ");
                        DateTime deadline = DateTime.Parse(Console.ReadLine());

                        service.AddTask(new UrgentTask(id, title, desc, priority, deadline));
                    }
                    break;

                case 2:
                    service.ViewTasks();
                    break;

                case 3:
                    Console.Write("Task ID: ");
                    int completeId = int.Parse(Console.ReadLine());
                    service.CompleteTask(completeId);
                    break;

                case 4:
                    Console.Write("Task ID: ");
                    int assignId = int.Parse(Console.ReadLine());

                    Console.Write("User Name: ");
                    string userName = Console.ReadLine();

                    service.AssignUser(assignId, userName);
                    break;

                case 5:
                    Console.Write("Search keyword: ");
                    string keyword = Console.ReadLine();
                    service.SearchTask(keyword);
                    break;

                case 6:
                    service.SaveToFile();
                    return;
            }
        }
    }
}