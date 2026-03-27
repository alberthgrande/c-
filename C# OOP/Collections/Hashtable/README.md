# Hashtable Constructors

| Constructor                                      | Description                                                                                               |
| ------------------------------------------------ | --------------------------------------------------------------------------------------------------------- |
| `Hashtable()`                                    | Initializes a new, empty instance with default parameters (initial capacity, load factor, etc.).          |
| `Hashtable(IDictionary)`                         | Copies elements from the specified dictionary to a new Hashtable with default parameters.                 |
| `Hashtable(IDictionary, IEqualityComparer)`      | Copies elements from the specified dictionary to a new Hashtable and uses the provided IEqualityComparer. |
| `Hashtable(Int32)`                               | Initializes a new, empty instance with a specified initial capacity and default parameters.               |
| `Hashtable(Int32, Single)`                       | Initializes a new, empty instance with a specified initial capacity and load factor.                      |
| `Hashtable(Int32, Single, IEqualityComparer)`    | Initializes a new, empty instance with a specified initial capacity, load factor, and IEqualityComparer.  |
| `Hashtable(SerializationInfo, StreamingContext)` | Initializes a new instance from serialized data (for deserialization purposes).                           |

## Properties

| Property         | Description                                                                            |
| ---------------- | -------------------------------------------------------------------------------------- |
| comparer         | Gets or sets the IComparer to use for the Hashtable.                                   |
| Count            | Gets the number of key/value pairs contained in the Hashtable.                         |
| EqualityComparer | Gets the IEqualityComparer to use for the Hashtable.                                   |
| hcp              | Gets or sets the object that can dispense hash codes.                                  |
| IsFixedSize      | Gets a value indicating whether the Hashtable has a fixed size.                        |
| IsReadOnly       | Gets a value indicating whether the Hashtable is read-only.                            |
| IsSynchronized   | Gets a value indicating whether access to the Hashtable is synchronized (thread safe). |
| Item[Object]     | Gets or sets the value associated with the specified key.                              |
| Keys             | Gets an ICollection containing the keys in the Hashtable.                              |
| SyncRoot         | Gets an object that can be used to synchronize access to the Hashtable.                |
| Values           | Gets an ICollection containing the values in the Hashtable.                            |

## Methods

| Method                                             | Description                                                                                    |
| -------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| Add(Object, Object)                                | Adds an element with the specified key and value into the Hashtable.                           |
| Clear()                                            | Removes all elements from the Hashtable.                                                       |
| Clone()                                            | Creates a shallow copy of the Hashtable.                                                       |
| Contains(Object)                                   | Determines whether the Hashtable contains a specific key.                                      |
| ContainsKey(Object)                                | Determines whether the Hashtable contains a specific key.                                      |
| ContainsValue(Object)                              | Determines whether the Hashtable contains a specific value.                                    |
| CopyTo(Array, Int32)                               | Copies the Hashtable elements to a one-dimensional Array instance at the specified index.      |
| Equals(Object)                                     | Determines whether the specified object is equal to the current object.                        |
| GetEnumerator()                                    | Returns an IDictionaryEnumerator that iterates through the Hashtable.                          |
| GetHashCode()                                      | Serves as the default hash function.                                                           |
| GetObjectData(SerializationInfo, StreamingContext) | Implements the ISerializable interface and returns the data needed to serialize the Hashtable. |
| GetType()                                          | Gets the Type of the current instance.                                                         |
| Remove(Object)                                     | Removes the element with the specified key from the Hashtable.                                 |
| Synchronized(Hashtable)                            | Returns a synchronized (thread-safe) wrapper for the Hashtable.                                |
| ToString()                                         | Returns a string that represents the current object.                                           |
