using System.Collections;
using System.Collections.Generic;

static void Stack1()
{
    Stack<int> s = new Stack<int>();

    // Push elements onto the stack
    s.Push(1);
    s.Push(2);
    s.Push(3);
    s.Push(4);

    // Pop elements from the stack
    while (s.Count > 0)
    {
        Console.WriteLine(s.Pop());

    }
}
Stack1();

static void Stack2()
{
    // Non-generic Stack (can hold any type)
    Stack stack = new Stack();
    stack.Push("GFG");
    stack.Push(1);
    stack.Push(2.5);
    stack.Push(null);
    stack.Push("Geeks123");

    Console.WriteLine("Non-Generic Stack:");
    foreach (var item in stack)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
}
Stack2();

static void Stack3()
{
    // Generic Stack (holds only strings)
    Stack<string> genericStack = new Stack<string>();
    genericStack.Push("GFG");
    genericStack.Push("GeeksForGeeks");
    genericStack.Push("Stack Example");

    Console.WriteLine("Generic Stack:");
    foreach (var item in genericStack)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();
}
Stack3();

static void Stack4()
{
    // Creating a Stack
    Stack s = new Stack();

    // Pushing elements into the Stack
    s.Push(10);
    s.Push(20);
    s.Push(30);
    s.Push(40);
    s.Push(50);
    s.Push(60);

    // Displaying the count of elements in the Stack
    Console.Write("Total elements in Stack: ");
    Console.WriteLine(s.Count);

    // Displaying the top element of the Stack without removing it
    Console.WriteLine("Top element is: " + s.Peek());

    // Displaying the top element of the Stack again
    Console.WriteLine("Top element again is: " + s.Peek());

    // Displaying the updated count of elements
    Console.Write("Updated count of elements: ");
    Console.WriteLine(s.Count);
}
Stack4();


static void Stack5()
{
    // Creating a Stack
    Stack s = new Stack();

    // Pushing elements into the Stack
    s.Push(10);
    s.Push(20);
    s.Push(30);
    s.Push(40);
    s.Push(50);
    s.Push(60);

    // Displaying the count of elements in the Stack
    Console.Write("Total number of elements in the Stack are: ");
    Console.WriteLine(s.Count);
}
Stack5();

static void Stack6()
{
    // Creating a Stack
    Stack s = new Stack();

    // Pushing elements into the Stack
    s.Push(10);
    s.Push(20);
    s.Push(30);
    s.Push(40);
    s.Push(50);
    s.Push(60);

    // Displaying the count of elements in the Stack
    Console.Write("Total number of elements in the Stack are: ");
    Console.WriteLine(s.Count);

    // Removing all elements from the Stack
    s.Clear();

    // Displaying the count of elements after clearing the Stack
    Console.Write("Total elements in Stack after clear: ");
    Console.WriteLine(s.Count);
}
Stack6();

static void Stack7()
{
    // Creating a Stack
    Stack s = new Stack();

    // Inserting the elements into the Stack
    s.Push("Geek1");
    s.Push("Geek2");
    s.Push("Geek3");
    s.Push("Geek4");
    s.Push("Geek5");

    // Checking whether the element is present in the Stack or not
    Console.WriteLine("The element Geek2 is present? :" + s.Contains("Geek2"));
    Console.WriteLine("The element Geek10 is present? :" + s.Contains("Geek10"));
}
Stack7();

