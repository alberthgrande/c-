using System;

namespace Abstraction;

public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow bow");
    }
}
