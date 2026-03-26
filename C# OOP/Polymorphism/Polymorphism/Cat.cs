using System;

namespace Polymorphism;

public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow meow");
    }
}
