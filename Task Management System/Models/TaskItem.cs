using System;

namespace Task_Management_System.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TaskPriority Priority { get; set; }
    public bool IsCompleted { get; set; }
    public User AssignedUser { get; set; }
    public string TaskType { get; set; } = "Normal";
    public DateTime? Deadline { get; set; }

    public TaskItem() { } // Needed for JSON

    public TaskItem(int id, string title, string description, TaskPriority priority)
    {
        Id = id;
        Title = title;
        Description = description;
        Priority = priority;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{Id} | {Title} | {Priority} | Assigned: {AssignedUser?.Name ?? "None"} | Done: {IsCompleted}");
    }

    public void CompleteTask()
    {
        IsCompleted = true;
    }
}