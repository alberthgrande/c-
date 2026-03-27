using System.Collections;

static void Hash1()
{
    // Initialize Hashtable
    Hashtable ht1 = new Hashtable();
    Hashtable ht2 = new Hashtable();

    // Inserting elements using Add() method
    ht1.Add(1, "One");
    ht1.Add(2, "Two");
    ht1.Add(3, "Three");

    ht2.Add(4, "Four");
    ht2.Add(5, "Five");
    ht2.Add(6, "Six");

    // Print mappings to the console
    Console.WriteLine("Mappings of ht1: ");
    foreach (DictionaryEntry i in ht1)
    {
        Console.WriteLine($"{i.Key} - {i.Value}");
    }

    Console.WriteLine("Mappings of ht2: ");
    foreach (DictionaryEntry i in ht2)
    {
        Console.WriteLine($"{i.Key} - {i.Value}");
    }
}
Hash1();

static void Hash2()
{
    Hashtable ht1 = new Hashtable();

    ht1.Add("1", "Welcome");
    ht1.Add("2", "to");
    ht1.Add("3", "geeks");
    ht1.Add("4", "for");
    ht1.Add("5", "geeks");

    Hashtable ht2 = Hashtable.Synchronized(ht1);

    Console.WriteLine("ht1 Hashtable is {0}",
                ht1.IsSynchronized ? "synchronized" : "not synchronized");

    Console.WriteLine("h2 Hashtable is {0}.",
                ht2.IsSynchronized ? "synchronized" : "not synchronized");

    Console.WriteLine("Total Number of Elements in h1: " + ht1.Count);

}
Hash2();


static void Hash3()
{
    Hashtable ht1 = new Hashtable();

    ht1.Add("1", "Greek1");
    ht1.Add("2", "Greek2");
    ht1.Add("3", "Greek3");
    ht1.Add("4", "Greek4");
    ht1.Add("5", "Greek5");

    ICollection k = ht1.Keys;

    Console.WriteLine("Hashtable Contains");

    foreach (var i in k)
    {
        Console.WriteLine(i + "-" + ht1[i]);
    }

    Console.WriteLine();

    ht1.Remove("4");
    ht1.Remove("5");

    Console.WriteLine("Hashtable after removing element 4");

    foreach (var i in k)
    {
        Console.WriteLine(i + "-" + ht1[i]);
    }
}
Hash3();