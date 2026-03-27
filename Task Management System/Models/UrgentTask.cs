using System;

namespace Task_Management_System.Models;

public class UrgentTask : TaskItem
{

    public UrgentTask() { } // for JSON

    public UrgentTask(int id, string title, string desc, TaskPriority priority, DateTime deadline)
    : base(id, title, desc, priority)
    {
        Deadline = deadline;
        TaskType = "Urgent";
    }

    public override void Display()
    {
        Console.WriteLine($"{Id} | {Title} | {Priority} | DEADLINE: {Deadline:yyyy-MM-dd} | Assigned: {AssignedUser?.Name ?? "None"} | Done: {IsCompleted}");
    }
}