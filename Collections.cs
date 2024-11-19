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

        Console.WriteLine(table["2"]); // Will this throw an error?
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

        // sortedList.Add("Four", 4); // Uncommenting this will throw an error at runtime
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

        Console.WriteLine(table[new Person("Alice")]); // Will this work?
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
