using System.Diagnostics;

1.
using System;

class Program1
{
    public static void StaticMethod()
    {
        Console.WriteLine("Static method called.");
    }

    public void NonStaticMethod()
    {
        Console.WriteLine("Non-static method called.");
        StaticMethod(); 
    }

    static void Main()
    {
        Program1.StaticMethod();

        Program1 obj = new Program1();
        obj.NonStaticMethod();

        NonStaticMethod();  
    }
}
//O/P:error will come.because we can't call non-static method without using it's instance.


2. 
using System;

class Program2
{
    static void ModifyValue(ref int value)
    {
        value += 10;
    }

    static void Main()
    {
        int number = 5;
        Console.WriteLine("Before: " + number);

        ModifyValue(ref number);
        Console.WriteLine("After: " + number);
    }
}
//O/P:  Before:5
   // After:15



3.
using System;

class Program3
{
    static void CalculateValues(int input, out int doubled, out int tripled)
    {
        doubled = input * 2;
        tripled = input * 3;
    }

    static void Main()
    {
        int a, b;
        CalculateValues(3, out a, out b);
        Console.WriteLine($"Doubled: {a}, Tripled: {b}");
    }
}
//O/P: Doubled:6, Tripled:9
4. 
using System;

class Program4
{
    static void ModifyValue(ref int value)
    {
        value += 10;
    }

    static void Main()
    {
        ModifyValue(ref value);

        int number = 5;
        ModifyValue(ref number);
        Console.WriteLine("After modification: " + number);
    }
}
//O/P:  The name 'value' does not exist in the current context

5. 
using System;

class Program5
{
    static void PrintDetails(string name, int age = 18, string country = "USA")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Country: {country}");
    }

    static void Main()
    {
        PrintDetails("Alice");
        PrintDetails("Bob", 25);
        PrintDetails("Charlie", 30, "Canada");
    }
}

//O/P: Name:Alice,Age:18,Country:Usa
//O/P: Name:Bob,Age:25,Country:Usa
//O/P: Name:Charlie,Age:30,Country:Canada

6.
using System;

class Program6
{
    static void UpdateValue(ref int value, int increment = 5)
    {
        value += increment;
    }

    static void Main()
    {
        int number = 10;

        UpdateValue(ref number);
        Console.WriteLine("After default increment: " + number);

        UpdateValue(ref number, 15);
        Console.WriteLine("After custom increment: " + number);
    }
}

//O/P:  After default increment:15
       //After custom increment:30
7.
using System;

class Program7
{
    static void GenerateNumbers(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    static void Main()
    {
        int a, b;
        GenerateNumbers(out a, out b);
        Console.WriteLine($"Generated numbers: {a} and {b}");
    }
}
//O/P: Generated number:10 and 20

8.
using System;

class Program8
{
    static void Calculate(out int x, int y)
    {
        x = y * 2;
    }

    static void Main()
    {
        int result;
        Calculate(out result, 5);
        Console.WriteLine(result);

        Calculate(out int result);
    }
}

//O/P: error will come because result varible is already declared.

9.
using System;

class Program9
{
    static void DisplayInfo(string name, int age = 18, string country = "USA")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Country: {country}");
    }

    static void Main()
    {
        DisplayInfo("Alice", "Canada");

        DisplayInfo("Bob", country: "Canada");
    }
}
//O/P:  error will come because in first line of main method we cann't convert string to int.


10.
using System;

class Program10
{
    static void ModifyNumbers(ref int x, out int y)
    {
        x *= 2;
        y = x + 10;
    }

    static void Main()
    {
        int a = 5, b;
        ModifyNumbers(ref a, out b);

        Console.WriteLine($"Modified a: {a}, Calculated b: {b}");

        ModifyNumbers(ref a, out b);
    }
}

//O/P; modified a:10, calculated b: 20

11.
using System;

class Program11
{
    static void ModifyValues(ref int x, out int y, int increment = 5)
    {
        x += increment;
        y = x * 2;
    }

    static void Main()
    {
        int a = 10, b;
        
        ModifyValues(ref a, out b);
        Console.WriteLine($"After ModifyValues - a: {a}, b: {b}");

        ModifyValues(ref a, out b, 10); // Custom increment
        Console.WriteLine($"After ModifyValues with increment 10 - a: {a}, b: {b}");
    }
}

//o/p: After ModifyValues - a: 15 b:30
//o/p: After ModifyValueswith increment 10 - a: 25, b:50
12.
using System;

class Program12: Program11
{
    public int instanceValue = 100;

    public static void StaticMethod()
    {
        Console.WriteLine("Instance Value: " + instanceValue);
    }

    public void InstanceMethod()
    {
        Console.WriteLine("Instance Value: " + instanceValue);
    }

    static void Main()
    {
        Program12 obj = new Program11();
        obj.InstanceMethod();
        StaticMethod();
    }
}

//o/p:error

13.
using System;

class Program13
{
    public static void Calculate(int x, int y = 2)
    {
        Console.WriteLine("Product: " + (x * y));
    }

    public static void Calculate(int x, int y, int z)
    {
        Console.WriteLine("Sum: " + (x + y + z));
    }

    static void Main()
    {
        Calculate(5);
        Calculate(5, 3);
        Calculate(1, 2, 3);
    }
}

//o/p: Product: 10
//o/p: Product: 15
//o/p: sum: 6


14.
using System;

class Program14
{
    static void ModifyArray(ref int[] arr)
    {
        arr[0] = 99;
        arr = new int[] { 9, 8, 7 };
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine("Before: " + string.Join(", ", numbers));
        
        ModifyArray(ref numbers);
        Console.WriteLine("After: " + string.Join(", ", numbers));
    }
}

//o/p: 1,2,3
//     9,8,7

15.
using System;

class Program15
{
    public static void PrintNumbers(int count, int limit = 10)
    {
        if (count > limit)
            return;
        
        Console.WriteLine(count);
        PrintNumbers(count + 1, limit);
    }

    static void Main()
    {
        PrintNumbers(1);
    }
}

//O/P:    1
        //2
        //3
        //4
        //5
        //6
        //7
        //8
        //9
        //10
16.
using System;

class Program16
{
    static void DisplayMessage(string message = "Hello", int times = 1, bool uppercase = false)
    {
        string output = uppercase ? message.ToUpper() : message;

        for (int i = 0; i < times; i++)
            Console.WriteLine(output);
    }

    static void Main()
    {
        DisplayMessage();
        DisplayMessage("Custom Message", 2);
        DisplayMessage("Custom Upper", 3, true);
    }
}

//O/P: Hello
// Custom Message
// Custom Message
//CUSTOM UPPER
//CUSTOM UPPER
//CUSTOM UPPER

17.
using System;

class Program17
{
    static int DoubleValue(ref int x)
    {
        x *= 2;
        return x;
    }

    static void IncrementValue(out int x)
    {
        x = 5;
        x += 1;
    }

    static void Main()
    {
        int a = 10;
        IncrementValue(out a);//A=6
        int result = DoubleValue(ref a);

        Console.WriteLine($"Final Result: {result}, Modified Value: {a}");
    }
}

//O/P: Final Result: 12, Modified Value:12
18.
using System;

class Program18
{
    public void Display(string message)
    {
        Console.WriteLine("String message: " + message);
    }

    public void Display(int number)
    {
        Console.WriteLine("Integer message: " + number);
    }

    public void Display(int number, string text = "Default Text")
    {
        Console.WriteLine($"Number: {number}, Text: {text}");
    }

    static void Main()
    {
        Program18 obj = new Program18();
        obj.Display("Hello");
        obj.Display(10);
        obj.Display(5, "Custom Text");
    }
}

//O/P: String message: Hello
    //interger message:10
    //Number:5,Text:Custom Text
19.
using System;

class Program19
{
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called");
    }

    public void CallPrivateMethod()
    {
        Console.WriteLine("Public method calling private method:");
        PrivateMethod();
    }

    static void Main()
    {
        Program19 obj = new Program19();
        obj.CallPrivateMethod();
        
        obj.PrivateMethod();
    }
}

//O/P: Public method calling private method
    //Private method called
    //Private method called   

20.
using System;

class Program20
{
    static void CalculateValues(int input, out int square, out int cube)
    {
        square = input * input;
        cube = input * input * input;
    }

    static void Main()
    {
        int a, b;
        CalculateValues(3, out a, out b);

        Console.WriteLine($"Square: {a}, Cube: {b}");
    }
}
//O/P: Square:9, Cube:81


21. //doubt 
using System;

class OuterClass
{
    private int instanceVar = 10;
    protected static int protectedStaticVar = 20;

    private class InnerPrivateClass
    {
        public void AccessOuterInstance(OuterClass outer)
        {
            Console.WriteLine("Accessing private instanceVar: " + outer.instanceVar);
        }
    }

    protected class InnerProtectedClass
    {
        public static void AccessProtectedStatic()
        {
            Console.WriteLine("Accessing protected static variable: " + protectedStaticVar);
        }
    }

    public void TestAccess()
    {
        InnerPrivateClass inner = new InnerPrivateClass();
        OuterClass obj = this;
        inner.AccessOuterInstance(obj);

        inner.AccessOuterInstance(new OuterClass());

        new InnerPrivateClass().AccessOuterInstance(this);

        InnerProtectedClass.AccessProtectedStatic();
        
    }
   

}

class Program21
{
    static void Main()
    {
        OuterClass outer = new OuterClass();
        outer.TestAccess();
        
        OuterClass.InnerPrivateClass privateInner = new OuterClass.InnerPrivateClass();
    }
}
//O/P:


22.
using System;

class BaseClass
{
    protected int protectedVar = 100;

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal Method in BaseClass");
    }

    public virtual void Display(string message = "Base Class")
    {
        Console.WriteLine("Message: " + message);
    }
}

class DerivedClass : BaseClass
{
    public override void Display(string message = "Derived Class")
    {
        Console.WriteLine("Overridden Message: " + message);
    }

    public void ShowProtectedVar()
    {
        Console.WriteLine("Protected Var from BaseClass: " + protectedVar);
        ProtectedInternalMethod();
    }
}

class Program22
{
    static void Main()
    {
        DerivedClass derived = new DerivedClass();
        derived.ShowProtectedVar();
        derived.Display();
        
        BaseClass baseRef = derived;
        baseRef.Display("Called from BaseClass reference");
    }
}
//o/p:Protected Var from BaseClass: 100
//Protected Internal Method in BaseClass
//Overridden Message:DerivedClass
//Overridden Message:Called from BaseClass Reference.


23.
using System;

internal class InternalClass
{
    public static int Counter = 0;

    public static void IncrementCounter()
    {
        Counter++;
        Console.WriteLine("Counter incremented to: " + Counter);
    }

    public void ShowCounter()
    {
        Console.WriteLine("Counter: " + Counter);
    }
}

class Program23
{
    private InternalClass internalObj = new InternalClass();

    public void AccessInternalMembers()
    {
        InternalClass.IncrementCounter();
        internalObj.ShowCounter();
    }

    static void Main()
    {
        Program23 program = new Program23();
        program.AccessInternalMembers();

        InternalClass.IncrementCounter();
    }
}


//O/P: Counter incremented to:1
        //Counter:1
//O/P: Counter incremented to:2
24.
using System;

class BasePrivateProtected : String
{
    private protected int baseVar = 50;

    private protected void BaseMethod()
    {
        Console.WriteLine("BaseMethod called in BasePrivateProtected");
    }
}

class DerivedPrivateProtected : BasePrivateProtected
{
    public void AccessBaseMembers()
    {
        Console.WriteLine("Accessing baseVar in Derived: " + baseVar);
        BaseMethod();
    }

    private class NestedDerived
    {
        public void AttemptAccess(DerivedPrivateProtected derived)
        {
            Console.WriteLine("baseVar: " + derived.baseVar);
            derived.BaseMethod();
        }
    }

}


class Program24
{
    static void Main()
    {
        DerivedPrivateProtected derived = new DerivedPrivateProtected();
        derived.AccessBaseMembers();
    }
}


//O/P: Accessing baseVar in Derived:50
//BaseMethod called in BasePrivateProtected

25.
using System;

class BaseCalculator
{
    public static int Add(int a, int b) => a + b;

    private protected int Subtract(int a, int b) => a - b;
}

class AdvancedCalculator : BaseCalculator
{
    public void CalculateValues(ref int x, out int y)
    {
        y = Add(x, 10); // Using inherited public static method
        x = Subtract(y, 5); // Using inherited private protected method
    }

    public static void Square(ref int x)
    {
        x *= x;
    }
}



class Program25
{
    static void Main()
    {
        int value = 5, result;
        AdvancedCalculator calculator = new AdvancedCalculator();

        calculator.CalculateValues(ref value, out result);
        Console.WriteLine($"Value after calculations: {value}, Result: {result}");

        AdvancedCalculator.Square(ref result);
        Console.WriteLine($"Square of Result: {result}");
    }
}

//O/P: Value after calculation:10,Result:15
        //Square of Result:225
26.
using System;

class Program26
{
    static int MultiplyByTwo(int number)
    {
        return number * 2;
    }

    static void Main()
    {
        int value = 5;
        int result = MultiplyByTwo(value);
        Console.WriteLine($"Original Value: {value}, After Multiplication: {result}");
    }
}

//O/P: Original Value:5,After Multipication:10

27.//doubt
using System;

class Rectangle
{
    public int Length { get; set; }
    public int Width { get; set; }
}

class Program27
{
    static Rectangle CreateRectangle(int length, int width)
    {
        return new Rectangle { Length = length, Width = width };
    }

    static void Main()
    {
        //int a =CreateRectangle(5, 10);
        Rectangle rect = CreateRectangle(5, 10);
        Rectangle rect = new Rectangle { Length = 5, Width = 10 };
        Console.WriteLine($"Rectangle - Length: {rect.Length}, Width: {rect.Width}");
    }
}

//O/P: Rectangle-Lenght:5,width:10

28.
using System;

class Program28
{
    static int[] GenerateEvenNumbers(int count)
    {
        int[] evenNumbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            evenNumbers[i] = i * 2;
        }
        return evenNumbers;
    }

    static void Main()
    {
        int[] evens = GenerateEvenNumbers(5);
        Console.WriteLine("Generated Even Numbers:");
        foreach (int num in evens)
        {
            Console.WriteLine(num);
        }
    }
}


//o/p:Generated Even Numbers:
//  0
// 2
//4
//6
//8
//10

29.//doubt
using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program29
{
    static Person CreatePerson(string name, int age)
    {
        Person person = new Person { Name = name, Age = age };
        return person;
    }

    static void Main()
    {
        Person person = CreatePerson("Alice", 30);
        Console.WriteLine($"Person - Name: {person.Name}, Age: {person.Age}");

        Console.WriteLine($"Name in uppercase: {person.Name.ToUpper()}");
    }
}


//O/P: Person-Name:Alice, Age:30
    //Name in Uppercase:ALICE


30.//doubt
using System;

class Calculator
{
    public int Number { get; set; }

    public int DoubleValue(int number)
    {
        return number * 2;
    }

    public Calculator IncreaseNumber(int increment)
    {
        Number += increment;
        return this;
    }
}

class Program30
{
    static void Main()
    {
        Calculator calc = new Calculator() { Number = 10 };

        int doubled = calc.DoubleValue(5);
        Console.WriteLine("Doubled Value: " + doubled);

        Calculator updatedCalc = calc.IncreaseNumber(15);
        Console.WriteLine($"Original Calculator Number: {calc.Number}");
        Console.WriteLine($"Returned Calculator Number: {updatedCalc.Number}");

        Console.WriteLine("Are both references the same? " + (calc == updatedCalc));
    }
}

//O/P:Doubled Value: 10
// Original Calculator Number: 25
// Returned Calculator Number: 25
// Are both references the same? True


31.
using System;

namespace Program31
{
    static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    class Program
    {
        static void Main()
        {
            string message = "Hello World";
            string reversed = message.Reverse();
            Console.WriteLine("Reversed String: " + reversed);
        }
    }
}
//O/P:Reversed String: dlrow olleH


32.
using System;

namespace Program32
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static class PersonExtensions
    {
        public static void DisplayInfo(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person() { Name = "Alice", Age = 25 };
            
            p.DisplayInfo();

            PersonExtensions.DisplayInfo(p);
        }
    }
}

//O/P: Name:Alice, Age=25

33.

using System;

namespace Program33
{
    static class IntExtensions
    {
        public static void DoubleValue(this ref int number)
        {
            number *= 2;
        }
    }

    class Program
    {
        static void Main()
        {
            int value = 5;

            value.DoubleValue();

            Console.WriteLine("Value: " + value);
        }
    }
}

//Value:10
34.
using System;

namespace Program34
{
    class Calculator
    {
        public int Value { get; set; }
    }

    static class CalculatorExtensions
    {
        public static Calculator Add(this Calculator calc, int amount)
        {
            calc.Value += amount;
            return calc;
        }

        public static Calculator Multiply(this Calculator calc, int factor)
        {
            calc.Value *= factor;
            return calc;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator { Value = 10 };
            
            calc.Add(5).Multiply(3);
            Console.WriteLine("Final Value: " + calc.Value);
        }
    }
}
//o/p:Final Value:45


35.

using System;

namespace Program35
{
    static class StringExtensions
    {
        public static bool IsValidEmail(this string str)
        {
            return str.Contains("@") && str.Contains(".") && str.IndexOf("@") < str.LastIndexOf(".");
        }

        public static string MaskEmail(this string str)
        {
            if (!str.IsValidEmail()) 
                return "Invalid email";

            int atIndex = str.IndexOf("@");
            return new string('*', atIndex) + str.Substring(atIndex);
        }
    }

    class Program
    {
        static void Main()
        {
            string email = "example@domain.com";
            Console.WriteLine("Is valid email: " + email.IsValidEmail());
            Console.WriteLine("Masked email: " + email.MaskEmail());

            string invalidEmail = "invalid-email";
            Console.WriteLine("Masked invalid email: " + invalidEmail.MaskEmail());
        }
    }
}

//O/P: is Valid email: true
    //Masked email:*******@domain.com
    //Masked invalid email: Invalid email
