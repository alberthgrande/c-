// using System;
class Program
{

    static void Main()
    {
        Car Ford = new Car("Mustang", "red", 1969);
        Console.WriteLine("Ford");
        Console.WriteLine(Ford);
        Ford.FullThrottle();

        Car Opel = new Car("Astra", "white", 2005);
        Console.WriteLine("\nOpel");
        Console.WriteLine(Opel);
        Opel.FullThrottle();

        Car RangeRover = new Car("Range Rover", "Dark Green", 2026);
        Console.WriteLine("\nRange Rover");
        Console.WriteLine(RangeRover);

        Car Toyota = new Car("Toyota", "Gray", 2022);
        Console.WriteLine("\nToyota");
        Console.WriteLine(Toyota);

        Console.WriteLine();
        Console.WriteLine();

        Person personObj = new Person();
        personObj.Name = "Alberth";
        Console.WriteLine(personObj.Name);


    }
}