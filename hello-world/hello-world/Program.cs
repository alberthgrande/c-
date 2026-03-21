using PasswordGenerator;

Console.Write("Enter your username: ");
string username = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine($"username: {username} password: {password.ToString()} age: {age}");
