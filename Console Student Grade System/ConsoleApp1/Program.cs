Console.WriteLine("Enter Student Name: ");
string? name = Console.ReadLine();

Console.WriteLine("Enter Math Score: ");
int math = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter English Score: ");
int english = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Science Score: ");
int science = Convert.ToInt32(Console.ReadLine());

double average = (math + english + science) / 3.0;

char grade;
string status;

if(average >= 90)
{
    grade = 'A';
}
else if (average >= 80)
{
    grade = 'B';
}
else if (average >= 70)
{
    grade = 'C';
}
else
{
    grade = 'F';
}

if(average >= 75)
{
    status = "Passed";
}
else
{
    status = "Failed";
}

Console.WriteLine("Student Name: " + name);
Console.WriteLine("Average: " + Math.Round(average, 2));
Console.WriteLine("Grade: " + grade);
Console.WriteLine("Status: " + status);