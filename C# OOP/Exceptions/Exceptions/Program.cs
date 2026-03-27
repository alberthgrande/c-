using System;


static void checkAge(int age)
{

    try
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }
    catch (System.Exception)
    {
        throw;
    }
    finally
    {
        Console.WriteLine("The 'try catch' is finished");
    }
}

checkAge(50);