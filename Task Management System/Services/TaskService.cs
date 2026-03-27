using System;
using Task_Management_System.Models;
using Task_Management_System.Data;

namespace Task_Management_System.Services;

public class TaskService
{
    private List<TaskItem> tasks = new();
    private readonly FileStorage storage = new();

    public void LoadFromFile()
    {
        tasks = storage.Load();
    }

    public void SaveToFile()
    {
        storage.Save(tasks);
    }

    public void AddTask(TaskItem task)
    {
        tasks.Add(task);
    }

    public void ViewTasks()
    {
        if (!tasks.Any())
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        foreach (var task in tasks)
        {
            task.Display();
        }
    }

    public void CompleteTask(int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.CompleteTask();
            Console.WriteLine("Task completed!");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    public void AssignUser(int id, string userName)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.AssignedUser = new User { Name = userName };
            Console.WriteLine("User assigned!");
        }
    }

    public void SearchTask(string keyword)
    {
        var results = tasks.Where(t => t.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase));

        foreach (var task in results)
        {
            task.Display();
        }
    }

    public int GetNextId()
    {
        return tasks.Any() ? tasks.Max(t => t.Id) + 1 : 1;
    }
}