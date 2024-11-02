
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
//output:x is greater than 5
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
//output:X is even
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
//output:x is positive
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
//output: x is 10
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
 //output: 0 1 2 3 4;
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
//output:- 0 1 2 3 4; 
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
//output:-0 1 2 3 4 ;
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
//output:- x is greater than 5 and y is greater than 15;
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
//output:- x is greater than 5 and y is greater than 15
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
//output:- x is greater than 5 and y is greater than 15
```c#

using System;

class Program1
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == j) continue;
                for (int k = 0; k < 5; k++)
                {
                    if (k == i + j) break;
                    Console.Write($"{i}{j}{k} ");
                }
            }
            Console.WriteLine();
        }
    }
}
//output:- 010 020 021 030 031 032 040 041 042 043
           100 120 121 122 130 131 132 133 140 141 142 143 144
           200 201 210 211 212 230 231 232 233 234 240 241 242 243 244
           300 301 302 310 311 312 313 320 321 322 323 324 340 341 342 343 344
           400 401 402 403 410 411 412 413 414 420 421 422 423 424 430 431 432 433 434
```c#
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
//output:- D
```c#
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
// output:- A:6 B:5
//          E:7 F:6:
```c#
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
//output:-ADBCBDADBC
```c#
using System;

class Program5
{
    static void Main()
    {
        for (int i = 0; i < 16; i++)
        {
            if ((i & 1) == 0)
                Console.Write("E");
            if ((i & 2) == 2)
                Console.Write("V");
            if ((i & 4) == 4)
                Console.Write("E");
            if ((i & 8) == 8)
                Console.Write("N");
            Console.Write(" ");
        }
    }
}
//output:- E  EV V EE E EVE VE EN N EVN VN EEN EN EVEN VEN 
```c#
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
                    Console.Write("X");
                    break;
                case 1:
                    switch (i % 2)
                    {
                        case 0:
                            Console.Write("Y");
                            break;
                        case 1:
                            Console.Write("Z");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("W");
                    break;
            }
            i++;
        }
    }
}
//output:- XZWXYWXZWX
```c#
using System;

class Program7
{
    static void Main()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write(i % 2 == 0 ? (i > 5 ? "A" : "B") : (i > 5 ? "C" : "D"));
        }
    }
}
//output:- ACACADBDBD
```c#
using System;

class Program8
{
    static void Main()
    {
        for (int i = 0; i < 16; i++)
        {
            {
                if ((i & 3) == 3)
                    Console.Write("P");
                else
                    Console.Write("Q");
            }
            else
            {
                if ((i | 3) == i)
                    Console.Write("R");
                else
                    Console.Write("S");
            }
        }
    }
}
//output:- 
```c#
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
            Console.Write(" ");
        } while (true);
    }
}
//output:- OOEOEOEOEOEOOEOEOEO
```c#
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
            Console.Write(" ");
        } while (true);
    }
}
//output:- OOEOEOEOEOEOOEOEOEO
```c#
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
//output:-ACBCACB
```c#
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
            Console.Write(" ");
        } while (true);
    }
}
//output:- O OE OEOE OEOEO OEOEOEO OEOEOEOE OEOEOEOEOE 
```c#
Generate c# program on loops with break and continue statements and goto make it complecate in the condition make use of different type of operators except bitwise operators
so that it will be complecate to understand.
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
//output:- 


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
 