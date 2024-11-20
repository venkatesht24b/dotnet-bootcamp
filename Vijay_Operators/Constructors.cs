Please generate 20 practice constructors programs with multiple classes with static and non-static constructors also static and non-static methods and static and non-static variables and their accessibility their execution order how it will call and execute. please dont add any comments please generate 20 programs with complex and tricker approach.use base and this keywords as well for better understanding
1.
class Program
{
    static void Main()
    {
        Example ex1 = new Example();
        Example ex2 = new Example();
    }
}

class Example
{
    static Example()
    {
        Console.WriteLine("Static constructor called");
    }

    public Example()
    {
        Console.WriteLine("Instance constructor called");
    }
}
// output:- Static constructor called
//          Instance constructor called
//          Instance constructor called
2.-------------------------------------------------------------
class Base
{
    public Base() : this(0)
    {
        Console.WriteLine("Base()");
    }

    public Base(int x)
    {
        Console.WriteLine($"Base({x})");
    }
}

class Derived : Base
{
    public Derived() : base()
    {
        Console.WriteLine("Derived()");
    }
}

class Program
{
    static void Main()
    {
        Derived d = new Derived();
    }
}
// output:- Base(0)
//     `    base()
//          Derived()
3.-------------------------------------------------------
class Counter
{
    private static int staticCount = 0;
    private int instanceCount = 0;

    public Counter()
    {
        staticCount++;
        instanceCount++;
    }

    public static void DisplayStaticCount()
    {
        Console.WriteLine($"Static count: {staticCount}");
    }

    public void DisplayInstanceCount()
    {
        Console.WriteLine($"Instance count: {instanceCount}");
    }
}
// 
class Program
{
    static void Main()
    {
        Counter c1 = new Counter();
        Counter c2 = new Counter();

        Counter.DisplayStaticCount();
        c1.DisplayInstanceCount();
        c2.DisplayInstanceCount();
    }
}
//output:-Static count:2
//         Instance count:1
//         Instance count:1

4.----------------------------------------------------------
class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

class Program
{
    static void Main()
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();
        Console.WriteLine(s1 == s2);
    }
}
//output:- true
5.---------------------------------------------------
class Person
{
    private string name;
    private int age;

    public Person() : this("Unknown", 0) { }

    public Person(string name) : this(name, 0) { }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        Person p2 = new Person("Alice");
        Person p3 = new Person("Bob", 30);

        p1.Display();
        p2.Display();
        p3.Display();
    }
}
// output:-
// Name: Unknown, Age: 0
// Name: Alice, Age: 0
// Name: Bob, Age: 30
6.----------------------------------------------
class Base6
{
    private static int staticField = StaticMethod();
    private int instanceField = InstanceMethod();

    static Base6()
    {
        Console.WriteLine("Base static constructor");
    }

    public Base6()
    {
        Console.WriteLine("Base instance constructor");
    }

    private static int StaticMethod()
    {
        Console.WriteLine("Base static field initialization");
        return 1;
    }

    private int InstanceMethod()
    {
        Console.WriteLine("Base instance field initialization");
        return 1;
    }
}

class Derived6 : Base6
{
    private static int derivedStaticField = DerivedStaticMethod();
    private int derivedInstanceField = DerivedInstanceMethod();

    static Derived6()
    {
        Console.WriteLine("Derived static constructor");
    }

    public Derived6()
    {
        Console.WriteLine("Derived instance constructor");
    }

    private static int DerivedStaticMethod()
    {
        Console.WriteLine("Derived static field initialization");
        return 2;
    }

    private int DerivedInstanceMethod()
    {
        Console.WriteLine("Derived instance field initialization");
        return 2;
    }
}

class Base7
{
    protected string baseValue;

    public Base7()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        baseValue = "Base";
        Console.WriteLine($"Base Initialize: {baseValue}");
    }
}

class Derived7 : Base7
{
    private string derivedValue;

    public Derived7() : base()
    {
        derivedValue = "Derived";
        Console.WriteLine($"Derived constructor: {baseValue}, {derivedValue}");
    }

    protected override void Initialize()
    {
        baseValue = "Overridden";
        Console.WriteLine($"Derived Initialize: {baseValue}");
    }
}

class Helper
{
    static Helper()
    {
        Console.WriteLine("Helper static constructor");
    }

    public static void HelperMethod()
    {
        Console.WriteLine("Helper method called");
    }
}

class MainClass
{
    private static readonly Helper helper;

    static MainClass()
    {
        Console.WriteLine("MainClass static constructor start");
        Helper.HelperMethod();
        Console.WriteLine("MainClass static constructor end");
    }

    public MainClass()
    {
        Console.WriteLine("MainClass instance constructor");
    }
}

abstract class Shape
{
    protected double area;

    protected Shape()
    {
        Console.WriteLine("Shape default constructor");
    }

    protected Shape(double initialArea)
    {
        area = initialArea;
        Console.WriteLine($"Shape parameterized constructor: {area}");
    }

    public abstract void Calculate();
}

class Circle : Shape
{
    private double radius;

    {
        this.radius = radius;
        Console.WriteLine($"Circle constructor: {radius}");
    }

    public override void Calculate()
    {
        Console.WriteLine($"Circle area: {area}");
    }
}

class Tricky
{
    private static readonly string data;

    static Tricky()
    {
        try
        {
            Console.WriteLine("Static constructor starting");
            throw new Exception("Static constructor failed");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught in static constructor: {ex.Message}");
        }
    }

    public Tricky()
    {
        Console.WriteLine("Instance constructor");
    }

    public static void Method()
    {
        Console.WriteLine("Static method called");
    }
}

// Test code for each example
class Program
{
    static void Main()
    {
        Console.WriteLine("Example 6:");
        Derived6 d6 = new Derived6();

        Console.WriteLine("\nExample 7:");
        Der`ived7 d7 = new Derived7();

        Console.WriteLine("\nExample 8:");
        MainClass mc = new MainClass();

        Console.WriteLine("\nExample 9:");
        Circle circle = new Circle(5);
        circle.Calculate();

        Console.WriteLine("\nExample 10:");
        try
        {
            Tricky.Method();
            Tricky t = new Tricky();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Main caught: {ex.Message}");
        }
    }
}

--------------------------
// Example 1: Multi-level inheritance with constructor chaining
class Animal
{
    protected string species;
    
    public Animal(string species)
    {
        this.species = species;
        Console.WriteLine($"Animal constructor: {species}");
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

class Mammal : Animal
{
    protected string habitat;
    
    public Mammal(string species, string habitat) : base(species)
    {
        this.habitat = habitat;
        Console.WriteLine($"Mammal constructor: {habitat}");
    }
    
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Mammal specific sound");
    }
}

class Dog : Mammal
{
    private string breed;
    
    public Dog(string breed) : base("Canine", "Domestic")
    {
        this.breed = breed;
        Console.WriteLine($"Dog constructor: {breed}");
    }
}

// Example 2: Constructor chaining between sibling classes
class Vehicle
{
    protected string type;
    
    public Vehicle(string type)
    {
        this.type = type;
    }
}

class Car : Vehicle
{
    protected string model;
    
    public Car(string model) : this(model, "Standard")
    {
    }
    
    protected Car(string model, string type) : base(type)
    {
        this.model = model;
    }
}

class SportsCar : Car
{
    private int horsePower;
    
    public SportsCar(string model, int horsePower) : base(model, "Sports")
    {
        this.horsePower = horsePower;
    }
}

// Example 3: Virtual method calls in constructors
class Parent
{
    public Parent()
    {
        Initialize();
    }
    
    protected virtual void Initialize()
    {
        Console.WriteLine("Parent Initialize");
    }
}

class Child : Parent
{
    private string data = "Uninitialized";
    
    public Child()
    {
        data = "Initialized";
    }
    
    protected override void Initialize()
    {
        Console.WriteLine($"Child Initialize: {data}");
    }
}

// Example 4: Constructor delegation and method inheritance
class Shape
{
    protected double area;
    
    public Shape()
    {
        CalculateArea();
    }
    
    protected virtual void CalculateArea()
    {
        area = 0;
    }
    
    public virtual void Display()
    {
        Console.WriteLine($"Area: {area}");
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;
    
    public Rectangle(double width, double height) : base()
    {
        this.width = width;
        this.height = height;
        CalculateArea();
    }
    
    protected override void CalculateArea()
    {
        area = width * height;
    }
}

// Example 5: Constructor chaining with interfaces
interface ILoggable
{
    void Log(string message);
}

class Logger
{
    protected readonly string logPrefix;
    
    public Logger(string prefix)
    {
        logPrefix = prefix;
    }
    
    protected void LogMessage(string message)
    {
        Console.WriteLine($"{logPrefix}: {message}");
    }
}

class Component : Logger, ILoggable
{
    public Component() : base("COMP")
    {
        Log("Component created");
    }
    
    public void Log(string message)
    {
        LogMessage(message);
    }
}

// Example 6: Abstract base class with constructor requirements
abstract class DatabaseConnection
{
    protected string connectionString;
    
    protected DatabaseConnection(string server, string database)
    {
        connectionString = $"Server={server};Database={database}";
        Initialize();
    }
    
    protected abstract void Initialize();
    public abstract void Connect();
}

class SqlConnection : DatabaseConnection
{
    public SqlConnection(string server, string database) 
        : base(server, database)
    {
    }
    
    protected override void Initialize()
    {
        Console.WriteLine("SQL Connection initialized");
    }
    
    public override void Connect()
    {
        Console.WriteLine($"Connecting to: {connectionString}");
    }
}

// Example 7: Constructor chaining with property initialization
class Configuration
{
    public string Name { get; }
    public string Version { get; }
    
    public Configuration(string name)
        : this(name, "1.0")
    {
    }
    
    public Configuration(string name, string version)
    {
        Name = name;
        Version = version;
    }
}

class AppConfig : Configuration
{
    public string Environment { get; }
    
    public AppConfig(string name, string environment)
        : base(name)
    {
        Environment = environment;
    }
    
    public AppConfig(string name, string version, string environment)
        : base(name, version)
    {
        Environment = environment;
    }
}

// Example 8: Generic base class with constructor constraints
class Repository<T> where T : class, new()
{
    protected T instance;
    
    public Repository()
    {
        instance = new T();
        Initialize();
    }
    
    protected virtual void Initialize()
    {
        Console.WriteLine($"Repository<{typeof(T).Name}> initialized");
    }
}

class UserRepository : Repository<User>
{
    public UserRepository() : base()
    {
        Console.WriteLine("UserRepository initialized");
    }
    
    protected override void Initialize()
    {
        base.Initialize();
        // Additional initialization
    }
}

// Test class
class Program
{
    static void Main()
    {
        // Test each example here
        Console.WriteLine("Example 1:");
        var dog = new Dog("Labrador");
        dog.MakeSound();

        Console.WriteLine("\nExample 2:");

        Console.WriteLine("\nExample 3:");
        var child = new Child();

        // Add more test cases for other examples
    }
}

class User
{
    public string Name { get; set; }
}