using System.Collections;
using System.Collections.Generic;

static void Array1()
{
    // Declaring an ArrayList
    ArrayList aL = new ArrayList();

    // Adding Elements
    aL.Add(1);
    aL.Add(2);
    aL.Add(3);

    // Iterating to print elements
    foreach (var item in aL)
        Console.WriteLine(item);

    Console.WriteLine("Count: " + aL.Count);
    Console.WriteLine("Capacity: " + aL.Capacity);
}
Array1();

static void Array2()
{
    ArrayList al = new ArrayList();
    al.AddRange(new[] { "A", "B", "C", "D", "E" });
    Console.WriteLine(al.IsFixedSize);
    Console.WriteLine(al.IsReadOnly);
}
Array2();

static void Array3()
{
    ArrayList al = new ArrayList();

    al.Add("A");
    al.Add("B");
    al.Add("C");
    al.Add("D");
    al.Add("E");

    if (al.Contains("E"))
        Console.WriteLine("Yes, exists at index " + al.IndexOf("E"));

    else
        Console.WriteLine("No, doesn't exists");
}
Array3();

static void Array4()
{
    ArrayList al = new ArrayList();

    al.Add(2);
    al.Add(4);
    al.Add(6);
    al.Add(8);

    Console.WriteLine("The initial ArrayList: ");

    foreach (var i in al)
    {
        Console.WriteLine(i);
    }

    al.RemoveRange(0, 2);

    Console.WriteLine("The ArrayList after Removing elements: ");

    foreach (var i in al)
    {
        Console.WriteLine(i);
    }
}
Array4();