using System;

namespace Polymorphism;

public class Bird : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The bird says: tweet tweet");
    }
}
