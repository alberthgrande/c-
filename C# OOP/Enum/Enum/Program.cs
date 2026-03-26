using System;

namespace Enum
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myLevel = Level.Medium;
            Console.WriteLine(myLevel);

            int myMonths = (int)Months.July;
            Console.WriteLine(myMonths);

            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High");
                    break;
                default:
                    Console.WriteLine("Invalid Level");
                    break;
            }
        }
    }
}