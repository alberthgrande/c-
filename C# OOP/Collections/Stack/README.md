## Declaration of Stack

1. **Generic Stack**: Holds elements of a specific type.

```
    Stack<T> stackName = new Stack<T>();
```

2. **Non-Generic Stack**: Can hold elements of any type but requires casting when retrieving elements.

```
   Stack stack = new Stack();
```

## Constructors

The Stack<T> class provides three constructors, listed below:

| Constructor        | Description                                                                                                       |
| ------------------ | ----------------------------------------------------------------------------------------------------------------- |
| Stack()            | Initializes an empty stack with the default initial capacity.                                                     |
| Stack(ICollection) | Initializes a new stack containing elements copied from a specified collection.                                   |
| Stack(Int32)       | Initializes an empty stack with the specified initial capacity (or the default if the given capacity is smaller). |

## Properties

The Stack<T> class provides several properties to access its state.

| Property       | Description                                            |
| -------------- | ------------------------------------------------------ |
| Count          | Returns the number of elements currently in the stack. |
| IsSynchronized | Indicates whether the stack is thread-safe.            |
| SyncRoot       | Provides an object to synchronize access to the stack. |

## Methods

| Method               | Description                                                                                   |
| -------------------- | --------------------------------------------------------------------------------------------- |
| Clear()              | Removes all objects from the Stack.                                                           |
| Clone()              | Creates a shallow copy of the Stack.                                                          |
| Contains(Object)     | Determines whether an element is in the Stack.                                                |
| CopyTo(Array, Int32) | Copies the Stack to an existing one-dimensional Array, starting at the specified array index. |
| Equals(Object)       | Determines whether the specified object is equal to the current object.                       |
| GetEnumerator()      | Returns an IEnumerator for the Stack.                                                         |
| GetHashCode()        | Serves as the default hash function.                                                          |
| GetType()            | Gets the Type of the current instance.                                                        |
| MemberwiseClone()    | Creates a shallow copy of the current Object.                                                 |
| Peek()               | Returns the object at the top of the Stack without removing it.                               |
| Pop()                | Removes and returns the object at the top of the Stack.                                       |
| Push(Object)         | Inserts an object at the top of the Stack.                                                    |
| Synchronized(Stack)  | Returns a synchronized (thread safe) wrapper for the Stack.                                   |
| ToArray()            | Copies the Stack to a new array.                                                              |
| ToString()           | Returns a string that represents the current object.                                          |
