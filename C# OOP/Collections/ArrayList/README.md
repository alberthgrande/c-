## Properties

The ArrayList class provides several properties to access its state.

| Property       | Description                                                                            |
| -------------- | -------------------------------------------------------------------------------------- |
| Capacity       | Gets or sets the number of elements that the ArrayList can contain.                    |
| Count          | Gets the number of elements actually contained in the ArrayList.                       |
| IsFixedSize    | Gets a value indicating whether the ArrayList has a fixed size.                        |
| IsReadOnly     | Gets a value indicating whether the ArrayList is read-only.                            |
| IsSynchronized | Gets a value indicating whether access to the ArrayList is synchronized (thread safe). |
| Item[Int32]    | Gets or sets the element at the specified index.                                       |
| SyncRoot       | Gets an object that can be used to synchronize access to the ArrayList.                |

## Methods

| Method                                                 | Description                                                   |
| ------------------------------------------------------ | ------------------------------------------------------------- |
| Add(Object)                                            | Adds an element to the end of the ArrayList.                  |
| AddRange(ICollection)                                  | Adds a collection of elements to the end.                     |
| Remove(Object)                                         | Removes the first occurrence of a specific element.           |
| RemoveAt(Int32)                                        | Removes an element at a specific index.                       |
| RemoveRange(Int32, Int32)                              | Removes a range of elements.                                  |
| Insert(Int32, Object)                                  | Inserts an element at a specific index.                       |
| InsertRange(Int32, ICollection)                        | Inserts a collection of elements at a specific index.         |
| Contains(Object)                                       | Checks if an element exists in the ArrayList.                 |
| IndexOf(Object)                                        | Returns the index of the first occurrence of an element.      |
| LastIndexOf(Object)                                    | Returns the index of the last occurrence of an element.       |
| Clear()                                                | Removes all elements.                                         |
| Sort() / Sort(IComparer)                               | Sorts elements in ascending order or using a custom comparer. |
| Reverse() / Reverse(Int32, Int32)                      | Reverses the order of elements.                               |
| BinarySearch(Object) / BinarySearch(Object, IComparer) | Searches a sorted ArrayList for an element.                   |
| ToArray() / ToArray(Type)                              | Copies elements to a new array.                               |
| Clone()                                                | Creates a shallow copy.                                       |
| TrimToSize()                                           | Adjusts the capacity to match the number of elements.         |
| ReadOnly(ArrayList)                                    | Returns a read-only wrapper.                                  |
