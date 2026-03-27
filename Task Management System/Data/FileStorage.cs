using System;
using System.Text.Json;
using Task_Management_System.Models;

namespace Task_Management_System.Data;

public class FileStorage
{
    private readonly string filePath = "tasks.json";

    public void Save(List<TaskItem> tasks)
    {
        var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, json);
    }

    public List<TaskItem> Load()
    {
        if (!File.Exists(filePath))
            return new List<TaskItem>();

        var json = File.ReadAllText(filePath);

        var rawTasks = JsonSerializer.Deserialize<List<TaskItem>>(json);

        if (rawTasks == null)
            return new List<TaskItem>();

        var tasks = new List<TaskItem>();

        foreach (var t in rawTasks)
        {
            if (t.TaskType == "Urgent")
            {
                var urgent = new UrgentTask(
                    t.Id,
                    t.Title,
                    t.Description,
                    t.Priority,
                    t.Deadline ?? DateTime.Now
                )
                {
                    AssignedUser = t.AssignedUser,
                    IsCompleted = t.IsCompleted
                };

                tasks.Add(urgent);
            }
            else
            {
                tasks.Add(t);
            }
        }

        return tasks;
    }
}