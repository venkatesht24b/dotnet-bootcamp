Program 1: Mixed Data Types in ArrayList
using System;
using System.Collections;

class Program1
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

        list[1] = 100;
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}


Program 2: Hashtable with Non-String Keys
using System;
using System.Collections;

class Program2
{
    static void Main()
    {
        Hashtable table = new Hashtable();
        table[1] = "One";
        table["2"] = 2;
        table[3.0] = "Three";

        foreach (var key in table.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {table[key]}");
        }

        Console.WriteLine(table["2"]); 
    }
}

Program 3: SortedList with Type Confusion
using System;
using System.Collections;

class Program3
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        sortedList.Add("Four", 4); 
    }
}

Program 4: Stack with Peek and Pop Confusion
using System;
using System.Collections;

class Program4
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push("First");
        stack.Push(2);
        stack.Push(3.5);

        Console.WriteLine("Top Element (Peek): " + stack.Peek());
        Console.WriteLine("Removing Element (Pop): " + stack.Pop());
        Console.WriteLine("Next Element (Peek): " + stack.Peek());
    }
}

Program 5: Queue with Complex Data
using System;
using System.Collections;

class Program5
{
    static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue("First");
        queue.Enqueue(10);
        queue.Enqueue(new ArrayList { 1, 2, 3 });

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            if (item is ArrayList list)
            {
                Console.WriteLine("Dequeued List:");
                foreach (var i in list) Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Dequeued Item: " + item);
            }
        }
    }
}

Program 6: BitArray Manipulation
using System;
using System.Collections;

class Program6
{
    static void Main()
    {
        BitArray bits1 = new BitArray(new bool[] { true, false, true });
        BitArray bits2 = new BitArray(new bool[] { false, true, false });

        BitArray result = bits1.And(bits2);

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine($"Index {i}: {result[i]}");
        }
    }
}

Program 7: ArrayList with Capacity Dynamics
using System;
using System.Collections;

class Program7
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        Console.WriteLine("Initial Capacity: " + list.Capacity);

        for (int i = 0; i < 20; i++)
        {
            list.Add(i);
            if (i == 5 || i == 10 || i == 15)
                Console.WriteLine($"Capacity after adding {i + 1} items: {list.Capacity}");
        }
    }
}

Program 8: Hashtable with Custom Equality
using System;
using System.Collections;

class Program8
{
    static void Main()
    {
        Hashtable table = new Hashtable();
        table[new Person("Alice")] = "Engineer";
        table[new Person("Bob")] = "Doctor";

        Console.WriteLine(table[new Person("Alice")]);
    }
}

class Person
{
    public string Name;
    public Person(string name) => Name = name;

    public override int GetHashCode() => Name.GetHashCode();

    public override bool Equals(object obj) =>
        obj is Person p && Name == p.Name;
}

Program 9: SortedList with Case-Sensitive Keys
using System;
using System.Collections;

class Program9
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add("apple", 1);
        sortedList.Add("Apple", 2);

        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }
    }
}

Program 10: Complex Operations on Stack and Queue
using System;
using System.Collections;

class Program10
{
    static void Main()
    {
        Stack stack = new Stack();
        Queue queue = new Queue();

        for (int i = 1; i <= 5; i++)
        {
            stack.Push(i);
            queue.Enqueue(i);
        }

        Console.WriteLine("Stack to Queue Operations:");
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        Console.WriteLine("Queue Elements:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}


Program 11: Dive deep into ArrayList
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // 1. Creating an ArrayList and adding mixed elements
        ArrayList arrayList = new ArrayList();
        arrayList.Add(10); // Adding integers
        arrayList.Add("Hello"); // Adding strings
        arrayList.Add(3.14); // Adding doubles
        arrayList.Add(true); // Adding booleans
        Console.WriteLine("Initial ArrayList:");
        PrintArrayList(arrayList);

        // 2. Inserting an element at a specific position
        arrayList.Insert(2, "InsertedElement");
        Console.WriteLine("\nAfter inserting 'InsertedElement' at index 2:");
        PrintArrayList(arrayList);

        // 3. Removing specific elements and by index
        arrayList.Remove(10); // Remove the element with value 10
        Console.WriteLine("\nAfter removing element with value 10:");
        PrintArrayList(arrayList);

        arrayList.RemoveAt(1); // Remove the element at index 1
        Console.WriteLine("\nAfter removing element at index 1:");
        PrintArrayList(arrayList);

        // 4. Checking the existence of an element
        bool containsHello = arrayList.Contains("Hello");
        Console.WriteLine($"\nDoes ArrayList contain 'Hello'? {containsHello}");

        // 5. Sorting (with numbers and strings - tricky part)
        // Note: Sorting mixed types will throw an exception, so we filter first
        ArrayList numericList = new ArrayList();
        foreach (var item in arrayList)
        {
            if (item is int || item is double)
                numericList.Add(item);
        }
        numericList.Sort(); // Sorting numeric elements
        Console.WriteLine("\nSorted numeric elements:");
        PrintArrayList(numericList);

        // 6. Searching for an element
        int index = arrayList.IndexOf(3.14);
        Console.WriteLine($"\nIndex of 3.14 in ArrayList: {index}");

        // 7. Copying ArrayList to another ArrayList
        ArrayList copyList = new ArrayList(arrayList);
        Console.WriteLine("\nCopied ArrayList:");
        PrintArrayList(copyList);

        // 8. Clearing all elements
        arrayList.Clear();
        Console.WriteLine("\nArrayList after clearing all elements:");
        PrintArrayList(arrayList);

        // 9. Using capacity and count properties
        Console.WriteLine("\nProperties of the copied ArrayList:");
        Console.WriteLine($"Count: {copyList.Count}");
        Console.WriteLine($"Capacity: {copyList.Capacity}");

        // 10. Iterating with enumerator
        Console.WriteLine("\nIterating over copied ArrayList using enumerator:");
        IEnumerator enumerator = copyList.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine($"Item: {enumerator.Current}");
        }
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}

Key Methods:
    Add: Adds elements of various types to the ArrayList.
    Insert: Inserts an element at a specific index.
    Remove / RemoveAt: Removes elements by value and index.
    Contains: Checks if an element exists in the ArrayList.
    Sort: Sorts numeric elements (filtering done to avoid exceptions from mixed data types).
    IndexOf: Finds the index of an element.
    Clear: Removes all elements from the ArrayList.
    Capacity and Count: Accesses properties of the ArrayList.
    CopyTo or Manual Copying: Copies an ArrayList to another ArrayList.
    GetEnumerator: Uses an enumerator to iterate over the ArrayList.

Program 11: Dive deep into HashTable
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("A", 10);
        ht.Add("B", 20);
        ht.Add("C", 30);

        ht["D"] = 40;
        ht["E"] = 50;

        foreach (DictionaryEntry de in ht)
        {
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }

        Console.WriteLine("Contains 'A': " + ht.ContainsKey("A"));
        Console.WriteLine("Contains 'F': " + ht.ContainsKey("F"));

        Console.WriteLine("Value for 'C': " + ht["C"]);

        ht.Remove("B");

        Console.WriteLine("After removing 'B':");
        foreach (DictionaryEntry de in ht)
        {
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }

        ht.Clear();

        Console.WriteLine("After clearing:");
        foreach (DictionaryEntry de in ht)
        {
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }
    }
}

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add("3", 3.0);
        hashtable.Add(4.5, true);

        Console.WriteLine("Initial Hashtable:");
        PrintHashtable(hashtable);

        hashtable[2] = "Updated Two";
        hashtable[5] = "Five";
        Console.WriteLine("\nAfter updating key 2 and adding key 5:");
        PrintHashtable(hashtable);

        Console.WriteLine("\nRemoving key '3' and checking if key 5 exists:");
        hashtable.Remove("3");
        Console.WriteLine(hashtable.Contains(5) ? "Key 5 exists" : "Key 5 does not exist");

        Console.WriteLine("\nIterating keys and values separately:");
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine($"Key: {key}");
        }
        foreach (var value in hashtable.Values)
        {
            Console.WriteLine($"Value: {value}");
        }

        Console.WriteLine("\nCloning Hashtable:");
        Hashtable clonedTable = (Hashtable)hashtable.Clone();
        PrintHashtable(clonedTable);

        Console.WriteLine("\nClearing original Hashtable:");
        hashtable.Clear();
        Console.WriteLine("Original Hashtable after clearing:");
        PrintHashtable(hashtable);

        Console.WriteLine("\nCount and capacity details of cloned Hashtable:");
        Console.WriteLine($"Count: {clonedTable.Count}");
        Console.WriteLine($"Capacity: Not directly available in Hashtable");

        Console.WriteLine("\nTrying to access a missing key:");
        if (clonedTable.ContainsKey(10))
        {
            Console.WriteLine($"Value for key 10: {clonedTable[10]}");
        }
        else
        {
            Console.WriteLine("Key 10 does not exist");
        }

    }

    static void PrintHashtable(Hashtable table)
    {
        foreach (DictionaryEntry entry in table)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
Key Methods and Features Covered
    Add: Adds key-value pairs.
    Indexer ([]): Updates and retrieves values.
    Remove: Removes an entry by key.
    ContainsKey / Contains: Checks the existence of keys.
    Clone: Creates a shallow copy of the hashtable.
    Clear: Removes all key-value pairs.
    Keys / Values: Accesses keys and values separately.
    Synchronized: Creates a thread-safe version of the Hashtable.
    SyncRoot: Locks the Hashtable for thread safety.

Program 13. Dive Deep into SortedList
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");
        sortedList.Add(5, "Five");

        PrintSortedList(sortedList);

        sortedList[4] = "Four";
        sortedList[3] = "Updated Three";

        Console.WriteLine("\nAfter adding key 4 and updating key 3:");
        PrintSortedList(sortedList);

        Console.WriteLine($"\nValue at index 2: {sortedList.GetByIndex(2)}");
        Console.WriteLine($"Key at index 2: {sortedList.GetKey(2)}");

        Console.WriteLine($"\nDoes key 1 exist? {sortedList.ContainsKey(1)}");
        Console.WriteLine($"Does value 'Four' exist? {sortedList.ContainsValue("Four")}");

        Console.WriteLine("\nKeys:");
        foreach (var key in sortedList.Keys)
        {
            Console.Write($"{key} ");
        }

        Console.WriteLine("\n\nValues:");
        foreach (var value in sortedList.Values)
        {
            Console.Write($"{value} ");
        }

        sortedList.Remove(2);
        Console.WriteLine("\n\nAfter removing key 2:");
        PrintSortedList(sortedList);

        sortedList.RemoveAt(1);
        Console.WriteLine("\nAfter removing element at index 1:");
        PrintSortedList(sortedList);

        Console.WriteLine("\nCloning SortedList:");
        SortedList clonedList = (SortedList)sortedList.Clone();
        PrintSortedList(clonedList);

        Console.WriteLine("\nClearing the original SortedList:");
        sortedList.Clear();
        PrintSortedList(sortedList);

        Console.WriteLine($"\nCloned SortedList Count: {clonedList.Count}");

        Console.WriteLine("\nIterating over cloned list using enumerator:");
        IDictionaryEnumerator enumerator = clonedList.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine($"Key: {enumerator.Key}, Value: {enumerator.Value}");
        }
    }

    static void PrintSortedList(SortedList list)
    {
        foreach (DictionaryEntry entry in list)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}

Key Methods and Features
    Add: Adds key-value pairs to the SortedList.
    Indexer ([]): Adds or updates elements by key.
    GetByIndex and GetKey: Accesses elements by their index.
    ContainsKey and ContainsValue: Checks if specific keys or values exist.
    Keys and Values: Retrieves all keys and values as collections.
    Remove and RemoveAt: Removes elements by key or index.
    Clone: Creates a shallow copy of the SortedList.
    Clear: Removes all elements from the SortedList.
    GetEnumerator: Iterates over the SortedList using an enumerator.
Program 14. Dive deep into Stack & Queue

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        Queue queue = new Queue();

        Console.WriteLine("=== Stack Operations ===");
        stack.Push(1);
        stack.Push(2);
        stack.Push("Three");
        stack.Push(4.5);
        stack.Push(true);

        Console.WriteLine("Initial Stack:");
        PrintCollection(stack);

        Console.WriteLine($"\nTop element (Peek): {stack.Peek()}");

        stack.Pop();
        Console.WriteLine("\nAfter popping top element:");
        PrintCollection(stack);

        Console.WriteLine("\nChecking if Stack contains 'Three':");
        Console.WriteLine(stack.Contains("Three") ? "Yes, it contains 'Three'" : "No, it doesn't contain 'Three'");

        Stack clonedStack = new Stack(stack.ToArray());
        Console.WriteLine("\nCloned Stack:");
        PrintCollection(clonedStack);

        stack.Clear();
        Console.WriteLine("\nAfter clearing the original Stack:");
        PrintCollection(stack);

        Console.WriteLine("\n=== Queue Operations ===");
        queue.Enqueue("One");
        queue.Enqueue(2);
        queue.Enqueue(3.5);
        queue.Enqueue(false);

        Console.WriteLine("Initial Queue:");
        PrintCollection(queue);

        Console.WriteLine($"\nFront element (Peek): {queue.Peek()}");

        queue.Dequeue();
        Console.WriteLine("\nAfter dequeuing the front element:");
        PrintCollection(queue);

        Console.WriteLine("\nChecking if Queue contains 3.5:");
        Console.WriteLine(queue.Contains(3.5) ? "Yes, it contains 3.5" : "No, it doesn't contain 3.5");

        Queue clonedQueue = new Queue(queue.ToArray());
        Console.WriteLine("\nCloned Queue:");
        PrintCollection(clonedQueue);

        queue.Enqueue("New Element");
        Console.WriteLine("\nAfter adding a new element to the original Queue:");
        PrintCollection(queue);

        queue.Clear();
        Console.WriteLine("\nAfter clearing the original Queue:");
        PrintCollection(queue);

        Console.WriteLine("\nIterating over Cloned Queue:");
        foreach (var item in clonedQueue)
        {
            Console.WriteLine($"Item: {item}");
        }
    }

    static void PrintCollection(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
Key Methods and Features
    Stack
        Push: Adds elements to the stack.
        Pop: Removes and returns the top element.
        Peek: Retrieves the top element without removing it.
        Contains: Checks if a specific element exists in the stack.
        ToArray: Converts the stack to an array for cloning or processing.
        Clear: Removes all elements from the stack.
    Queue
        Enqueue: Adds elements to the end of the queue.
        Dequeue: Removes and returns the element at the front of the queue.
        Peek: Retrieves the front element without removing it.
        Contains: Checks if a specific element exists in the queue.
        ToArray: Converts the queue to an array for cloning or processing.
        Clear: Removes all elements from the queue.
