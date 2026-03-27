using System.Collections;
using System.Collections.Generic;

static void Queue1()
{
    Queue q = new Queue();
    q.Enqueue("GFG");
    q.Enqueue(1);
    q.Enqueue(10);
    q.Enqueue(null);
    q.Enqueue(2.4);
    q.Enqueue("Geeks123");

    Console.WriteLine("Non-Generic Queue:");
    foreach (var item in q)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();

    // Generic Queue (holds only strings)
    Queue<string> genericQueue = new Queue<string>();
    genericQueue.Enqueue("GFG");
    genericQueue.Enqueue("GeeksForGeeks");
    genericQueue.Enqueue("Queue Example");

    Console.WriteLine("Generic Queue:");
    foreach (var item in genericQueue)
    {
        Console.WriteLine(item);
    }
}
Queue1();

static void Queue2()
{
    Queue q = new Queue();

    // Inserting the elements into the Queue
    q.Enqueue("one");
    q.Enqueue("two");
    q.Enqueue("three");
    q.Enqueue("four");
    q.Enqueue("five");

    // Displaying the count of elements contained in the Queue
    Console.Write("Total number of elements in the Queue are : ");

    Console.WriteLine(q.Count);
}
Queue2();

static void Queue3()
{
    Queue q = new Queue();

    // Adding elements to Queue
    q.Enqueue(1);
    q.Enqueue(2);
    q.Enqueue(3);
    q.Enqueue(4);
    q.Enqueue(5);

    lock (q.SyncRoot)
    {
        foreach (Object i in q)
        {
            Console.WriteLine(i);
        }
    }
}
Queue3();

static void Queue4()
{
    Queue q = new Queue();

    // Adding elements to Queue
    q.Enqueue(5);
    q.Enqueue(10);
    q.Enqueue(15);
    q.Enqueue(20);
    q.Enqueue(25);

    // Checking whether the element is present in the Queue or not
    Console.WriteLine("The queue contains 7 ? :" + q.Contains(7));
    Console.WriteLine("The queue contains 10 ? :" + q.Contains(10));

}
Queue4();

static void Queue5()
{
    Queue q = new Queue();

    // Adding elements to Queue
    q.Enqueue("Geeks");
    q.Enqueue("For");
    q.Enqueue("Geeks");

    // Converting the Queue into object array 
    Object[] arr = q.ToArray();

    // Displaying the elements in array 
    foreach (Object i in arr)
    {
        Console.WriteLine(i);
    }

}
Queue5();

