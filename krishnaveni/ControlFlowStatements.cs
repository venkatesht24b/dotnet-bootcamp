

1. If statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        if (x > 5)
        {
            Console.WriteLine("x is greater than 5");
        }
    }
}
//X is greater than 5
``` 

2. If-else statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        if (x % 2 == 0)
        {
            Console.WriteLine("x is even");
        }
        else
        {
            Console.WriteLine("x is odd");
        }
    }
}
//x is even
```
3. If-else-if statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        if (x > 0)
        {
            Console.WriteLine("x is positive");
        }
        else if (x < 0)
        {
            Console.WriteLine("x is negative");
        }
        else
        {
            Console.WriteLine("x is zero");
        }
    }
}
//x is postive
```
4. Switch-case statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        switch (x)
        {
            case 5:
                Console.WriteLine("x is 5");
                break;
            case 10:
                Console.WriteLine("x is 10");
                break;
            default:
                Console.WriteLine("x is not 5 or 10");
                break;
        }
    }
}
//x is 10
```
5. For loop:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}
//0
//    1
//    2
//    3
//    4
```
6. While loop:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
//0
//    1
//    2
//    3
//    4
```
7. Do-while loop:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 5);
    }
}
//0
//    1
//    2
//    3
//    4
```
8. Nested if statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        if (x > 5)
        {
            if (y > 15)
            {
                Console.WriteLine("x is greater than 5 and y is greater than 15");
            }
        }
    }
}
//x is greater than 5 and y is greater than 15
```
9. Nested if-else statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        if (x > 5)
        {
            if (y > 15)
            {
                Console.WriteLine("x is greater than 5 and y is greater than 15");
            }
            else
            {
                Console.WriteLine("x is greater than 5 but y is not greater than 15");
            }
        }
        else
        {
            Console.WriteLine("x is not greater than 5");
        }
    }
}
//x is greater than 5 and y is greater than 15
```
10. Nested if-else-if statement:

```c#
using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        if (x > 5)
        {
            if (y > 15)
            {
                Console.WriteLine("x is greater than 5 and y is greater than 15");
            }
            else if (y > 10)
            {
                Console.WriteLine("x is greater than 5 but y is not greater than 15");
            }
           else
            {
                Console.WriteLine("x is greater than 5 but y is not greater than 10");
            }
        }
        else
        {
            Console.WriteLine("x is not greater than 5");
        }
    }
}
//x is greater than 5 and y is greater than 15
11```c#

using System;

class Program1
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j) continue;
                for (int k = 0; k < 3; k++)
                {
                    if (k == i + j) break;
                    Console.Write($"{i}{j}{k} ");
                }
            }
            Console.WriteLine();
        }
    }
}
//0 1 0
//    0 2 0
//    0 2 1
//1 0 0
//    1 2 0
//    1 2 1
//    1 2 2
//    2 0 0
//    2 0 1
//   2 1 0 
//    2 1 1
//    2 1 2

12```c#
using System;

class Program2
{
    static void Main()
    {
        int x = 5;
        switch (x)
        {
            case 1:
            case 2:
                Console.Write("A");
                goto case 4;
            case 3:
                Console.Write("B");
                break;
            case 4:
                Console.Write("C");
                goto case 5;
            case 5:
                Console.Write("D");
                goto default;
            default:
                Console.Write("E");
                break;
        }
    }
}
13```c#
using System;

class Program3
{
    static void Main()
    {
        int a = 5, b = 5;
        if (++a > 5 || ++b > 5)
        {
            Console.Write($"A:{a} B:{b} ");
        }
        if (a++ > 6 && ++b > 6)
        {
            Console.Write($"C:{a} D:{b}");
        }
        else
        {
            Console.Write($"E:{a} F:{b}");
        }
    }
}
//a =6,b =5
//    a=6,b =7

14```c#
using System;

class Program4
{
    static void Main()
    {
        int i = 0;
        do
        {
            if (i % 2 == 0)
            {
                if (i % 3 == 0)
                    Console.Write("A");
                else
                    Console.Write("B");
            }
            else
            {
                if (i % 3 == 0)
                    Console.Write("C");
                else
                    Console.Write("D");
            }
        } while (++i < 10);
    }
}
//ADBCBDADBC

15```c#
using System;

class Program6
{
    static void Main()
    {
        int i = 0;
        while (i < 10)
        {
            switch (i % 3)
            {
                case 0:
                    Console.WriteLine("X");
                    break;
                case 1:
                    switch (i % 2)
                    {
                        case 0:
                            Console.WriteLine("Y");
                            break;
                        case 1:
                            Console.WriteLine("Z");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("W");
                    break;
            }
            i++;
        }
    }
}
//X
//    Z
//    Y
//    X
//    Y
//    W
//    X
//    Z
//    W
//    X

16```c#
using System;

class Program7
{
    static void Main()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i % 2 == 0 ? (i > 5 ? "A" : "B") : (i > 5 ? "C" : "D"));
        }
    }
}
//A 
//    C
//    A
//    C
//    A
//    D
//    B
//    D
//    B
//    D

17```c#
using System;

class Program9
{
    static void Main()
    {
        int i = 0;
        do
        {
            i++;
            if (i % 3 == 0) continue;
            if (i > 10) break;
            for (int j = 0; j < i; j++)
            {
                if (j % 2 == 0) Console.Write("O");
                else Console.Write("E");
            }
            Console.WriteLine();
        } while (true);
    }
}
//O
//   OE
//   OEOE
//   OEOEO
//   OEOEOEO
//   OEOEOEOE

18```c#
using System;

class Program9
{
    static void Main()
    {
        int i = 0;
        do
        {
            i++;
            if (i % 3 == 0) continue;
            if (i > 10) break;
            for (int j = 0; j < i; j++)
            {
                if (j % 2 == 0) Console.Write("O");
                else Console.Write("E");
            }
            Console.WriteLine();
        } while (true);
    }
}
//O
//   OE
//   OEOE
//   OEOEO
//   OEOEOEO
//   OEOEOEOE


19```c#
using System;

class Program10
{
    static void Main()
    {
        int a = 0, b = 10;
        while (a < 10 && b > 0)
        {
            if (a % 2 == 0 && b % 2 == 0)
                Console.Write("A");
            else if (a % 2 == 1 && b % 2 == 1)
                Console.Write("B");
            else
                Console.Write("C");

            a += a % 3 == 0 ? 2 : 1;
            b -= b % 3 == 0 ? 2 : 1;
        }
    }
}
20```c#
using System;

class Program11
{
    static void Main()
    {
        int i = 0;
        do
        {
            i++;
            if (i % 3 == 0) continue;
            if (i > 10) break;
            for (int j = 0; j < i; j++)
            {
                if (j % 2 == 0) Console.Write("O");
                else Console.Write("E");
            }
            Console.WriteLine();
        } while (true);
    }
}
//O
//   OE
//   OEOE
//   OEOEO
//   OEOEOEO
//   OEOEOEOE




21```c#
using System;

class ComplexLoopProgram
{
    static void Main()
    {
        int i = 0, j = 10;
        string result = "";

    start:
        while (i < 20)
        {
            i++;
            if (i % 3 == 0 && i % 5 != 0)
            {
                result += "Fizz";
                continue;
            }
            
            for (int k = 0; k < 5; k++)
            {
                if ((i + k) % 7 == 0)
                {
                    goto skipLoop;
                }
                
                if (j-- <= 0)
                {
                    break;
                }
                
                result += (i * k).ToString();
            }
            
            if (i >= 15 && j <= 5)
            {
                break;
            }
            
        skipLoop:
            result += "-";
        }

        Console.WriteLine($"Final result: {result}");
        Console.WriteLine($"i: {i}, j: {j}");
    }
}

22```c#
using System;

class IntricateLoopProgram
{
    static void Main()
    {
        int x = 1, y = 20;
        double result = 0;
        string output = "";

    outerLoop:
        for (int i = 0; i < 15; i++)
        {
            if (i % 2 == 0 && x < y)
            {
                x *= 2;
                continue;
            }

            int j = 0;
            while (j < 10)
            {
                {
                    result += Math.Pow(x, 0.5) / (y + 0.1);
                    if (result > 10)
                    {
                        goto exitLoop;
                    }
                }

                if (j % 3 == 2 && i % 4 == 1)
                {
                    output += "A";
                    j += 2;
                    continue;
                }

                y--;
                if (y <= 0)
                {
                    break;
                }

                output += (char)(65 + (x % 26));
                j++;
            }

            if (x > y || result > 5)
            {
                break;
            }

            x += i;
        }

    exitLoop:
        for (int k = 0; k < Math.Min(x, y); k++)
        {
            if (k % 3 == 0 || k % 5 == 0)
            {
                output = output.Insert(0, k.ToString());
            }
        }

        Console.WriteLine($"Final output: {output}");
        Console.WriteLine($"x: {x}, y: {y}, result: {result:F2}");
    }
}

23```c#
using System;

class Program
{
    static void Main()
    {
        int i = 0;
        do
        {
            i++;
            if (i % 3 == 0) continue;
            if (i > 10) break;
            for (int j = 0; j < i; j++)
            {
                if (j % 2 == 0) Console.Write("O");
                else Console.Write("E");
            }
            Console.WriteLine();
        } while (true);
    }
}
//O
//   OE
//   OEOE
//   OEOEO
//   OEOEOEO
//   OEOEOEOE


24```c#
What are Extension Methods?
Extension methods enable you to "add" methods to existing types without creating a new derived type, 
recompiling, or otherwise modifying the original type. Extension methods are static methods, 
but they're called as if they were instance methods on the extended type. 
For client code written in C#, there's no need to actually modify the type to add the method;
