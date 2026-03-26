using System;

namespace Abstraction;

public abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
