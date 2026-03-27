using System;
using System.IO;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "filename.txt";
            string copyPath = "filename_copy.txt";
            string replacePath = "replace.txt";

            // 1. Create() - Creates or overwrites a file
            using (FileStream fs = File.Create(filePath))
            {
                Console.WriteLine("File created: " + filePath);
            }

            // 2. WriteAllText() - Writes to the content file (overwrites if exist)
            File.WriteAllText(filePath, "Hello, Alberth!\n");
            Console.WriteLine("Written to file: Hello, Alberth");

            // 3. AppendText() - Appends text at the end of the file
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("This is appended text.");
            }
            Console.WriteLine("Appended text file");

            // 4. ReadAllText() - Reads the contents of file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content: \n" + content);

            // 5. Exists() - checks if the file exists
            if (File.Exists(filePath))
            {
                Console.WriteLine($"{filePath} exists");
            }

            // 6. Copy() - Copies a file
            File.Copy(filePath, copyPath, true); // true to overwrite if exists
            Console.WriteLine($"File copied to {copyPath}");

            // 7. Replace() - Replaces contents of a file with another file
            File.WriteAllText(replacePath, "Replacement file content.");
            File.Replace(replacePath, filePath, destinationBackupFileName: "backup.txt");
            Console.WriteLine($"{filePath} replaced with {replacePath}, backup created as backup.txt");

            // 8. Delete() - Deletes a file
            File.Delete(copyPath);
            Console.WriteLine($"{copyPath} deleted.");
        }
    }
}