## Constructors

The Queue<T> class provides four constructors which are listed below in the table:

| Constructor          | Description                                                                                                                            |
| -------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| Queue()              | Initializes an empty queue with the default capacity and growth factor.                                                                |
| Queue(ICollection)   | Initializes a queue that contains elements copied from the specified collection, with capacity equal to the number of elements copied. |
| Queue(Int32)         | Initializes an empty queue with the specified initial capacity and the default growth factor.                                          |
| Queue(Int32, Single) | Initializes an empty queue with the specified initial capacity and growth factor.                                                      |

## Properties

The Queue<T> class provides several properties to access its state.

| Property       | Description                                                                        |
| -------------- | ---------------------------------------------------------------------------------- |
| Count          | Gets the number of elements contained in the Queue.                                |
| IsSynchronized | Gets a value indicating whether access to the Queue is synchronized (thread safe). |
| SyncRoot       | Gets an object that can be used to synchronize access to the Queue.                |

## Methods

| Method               | Description                                                                                            |
| -------------------- | ------------------------------------------------------------------------------------------------------ |
| Clear()              | Removes all objects from the Queue.                                                                    |
| Clone()              | Creates a shallow copy of the Queue.                                                                   |
| Contains(Object)     | Determines whether an element is in the Queue.                                                         |
| CopyTo(Array, Int32) | Copies the Queue elements to an existing one-dimensional Array, starting at the specified array index. |
| Dequeue()            | Removes and returns the object at the beginning of the Queue.                                          |
| Enqueue(Object)      | Adds an object to the end of the Queue.                                                                |
| Equals(Object)       | Determines whether the specified object is equal to the current object.                                |
| GetEnumerator()      | Returns an enumerator that iterates through the Queue.                                                 |
| GetHashCode()        | Serves as the default hash function.                                                                   |
| GetType()            | Gets the Type of the current instance.                                                                 |
| MemberwiseClone()    | Creates a shallow copy of the current Object.                                                          |
| Peek()               | Returns the object at the beginning of the Queue without removing it.                                  |
| Synchronized(Queue)  | Returns a new Queue that wraps the original queue and is thread safe.                                  |
| ToArray()            | Copies the Queue elements to a new array.                                                              |
| ToString()           | Returns a string that represents the current object.                                                   |
| TrimToSize()         | Sets the capacity to the actual number of elements in the Queue.                                       |
