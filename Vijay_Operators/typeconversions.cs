1. In the below program identify which conversions are correct and which are not.
class TypeCastingExamples
{
    static void Main()
    {
        byte byteValue = 100;
        int intValue = byteValue;
        Console.WriteLine($"Implicit conversion from byte to int: {intValue}");
        //output:-Implicit conversion from byte to int:100;

        double value = 99.99;
        int truncatedValue = value;
        // explicit conversion double to int 
        //output: 99
        
        double doubleValue = 10.8;
        int truncatedValue = (int)doubleValue;
        Console.WriteLine($"Explicit conversion from double to int (truncated): {truncatedValue}");
        //output: Explicit conversion from double to int (truncated):10

        string strNumber = "250";
        int convertedValue = Convert.ToInt32(strNumber); 
        Console.WriteLine($"Using Convert class to convert string to int: {convertedValue}");
        //output: Explicit unboxing string to int 
        //Using Convert class to convert string to int:250

        string strToParse = "300";
        int parsedInt = int.Parse(strToParse); 
        Console.WriteLine($"Using Parse method to convert string to int: {parsedInt}");
        //Explicit unboxing string to int
        //Using Parse method to convert string to int:300;

        string invalidString = "Hello";
        int result;
        bool isParsed = int.TryParse(invalidString, out result); 
        Console.WriteLine($"TryParse with invalid input (expected false): {isParsed}, Result: {result}");
        //Explicit conversion string to int;
        //output: TryParse with invalid input (expected false): false,0
        //string contains numeric values its convert to int by 'using tryprase converter' its retrun 'true'--1;
        //string contains alphabets values its convert to int by 'using tryprase converter' its retrun 'false'--2;

        string nullStr = null;
        int intValue = Convert.ToInt32(nullStr); //its will returns 0
        int intValue2 = int.Parse(nullStr); // its  will throw an rumtime error


        string nonNumericStr = "abc123";
        int parsedValue = int.Parse(nonNumericStr);  
        // its  will throw an rumtime error

        int num = 100;
        object boxedNum = num; // Boxing: int to object (reference type)
        int unboxedNum = (int)boxedNum; // Unboxing: object back to int
        Console.WriteLine($"Boxing and Unboxing an int: {unboxedNum}");
        //Boxing and Unboxing an int:100

        object obj = "Hello World!";
        int incompatibleCast = (int)obj;//unboxing obj to int 
        //A object contains characters its will taken as string datatype and it is impossible to convert int  
        //runtime error will throw

        int? nullableInt = 500; // Nullable int using '?'
        int regularInt = nullableInt ?? 0; // If nullableInt has a value, use it; otherwise, use 0
        Console.WriteLine($"Nullable to int with null-coalescing: {regularInt}");
        //output:-Nullable to int with null-coalescing: 500;

        object obj = "Hello World";
        string str = obj as string;
        Console.WriteLine($"Using 'as' for type conversion: {str}");
        //output:-Using 'as' for type conversion:Hello World

        object obj = 10;
        string invalidAsCast = obj as string;  
        Console.WriteLine(invalidAsCast.Length);
        //output:- its thorw an runtime error  

        object patternObj = 123;
        if (patternObj is int patternInt) 
        {
            Console.WriteLine($"Pattern matching with 'is' keyword: {patternInt}");
        }
        //output:Pattern matching with 'is' keyword:123


        bool boolVal = true;
        int invalidConversion = (int)boolVal; 
        // connot convert to bool to int 
        // output:- error

        int? nullableNum = 42;
        if (nullableNum.HasValue) // Check if nullable has a value
        {
            int regularNum = nullableNum.Value; 
            Console.WriteLine($"Nullable<int> to int: {regularNum}");
        }
        //output:-Nullable<int> to int:42 

        string validString = "42";
        int result;
        bool success = int.TryParse(validString, result);
        //output:- true,1  

        int? nullableValue = null;
        int nonNullableValue = nullableValue;
        //output:-compliation error  

        object boxedValue = "100";//Boxing
        int unboxedInt = (int)boxedValue; //Un-Boxing 
        //output:- run time error

        object boxedValue = int.Parse("100");//Boxing
        int unboxedInt = (int)boxedValue;//Un-Boxing
        //output:- 100
    }
}


2. Banking System Simulation with Type Conversions and Casting

using System;

namespace TypeConversionComplexExample1
{
    class Program
    {
        static void Main()
        {
            // Part 1: Account Balance and Conversion
            double accountBalance = 1520.75;
            int roundedBalance = (int)accountBalance;  // Explicit cast
            Console.WriteLine($"Rounded Account Balance: {roundedBalance}");
            //output:-Rounded Account Balance:1520;

            // Part 2: Deposit
            string depositStr = "200";
            int depositAmount = int.Parse(depositStr);  // Parsing string to int
            double newBalance = accountBalance + depositAmount;
            Console.WriteLine($"New Balance after Deposit: {newBalance}");
            //output:-New Balance after Deposit:1720.75

            // Part 3: Withdrawal
            object withdrawalObj = "150";
            int withdrawalAmount;
            if (int.TryParse((string)withdrawalObj, out withdrawalAmount))
            {
                if (newBalance >= withdrawalAmount)
                {
                    newBalance -= withdrawalAmount;
                    Console.WriteLine($"Balance after Withdrawal: {newBalance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds for withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            //output:- Balance after Withdrawal:1570.75

            // Part 4: Calculate Annual Interest with Nullable
            double interestRate = 0.03;
            double? interest = null;
            if (newBalance > 1000)
            {
                interest = newBalance * interestRate;
                Console.WriteLine($"Calculated Interest: {interest.Value}");
            }
            else
            {
                Console.WriteLine("Balance too low for interest calculation.");
            }
            //output:- Calculated Interest:47.1225;

            // Part 5: Simulate Monthly Transactions in a Loop
            Console.WriteLine("Simulating Monthly Transactions:");
            for (int i = 1; i <= 12; i++)
            {
                double transaction = i % 2 == 0 ? 100.50 : -50.25;  // Alternating deposit/withdrawal
                newBalance += transaction;
                Console.WriteLine($"Month {i}: Balance = {newBalance:F2}");
            }
            //output:- Simulating Monthly Transactions;
                        // Month 1: Balance = 1520.50
                        // Month 2: Balance = 1621.00
                        // Month 3: Balance = 1570.75
                        // Month 4: Balance = 1671.25
                        // Month 5: Balance = 1621.00
                        // Month 6: Balance = 1721.50
                        // Month 7: Balance = 1671.25
                        // Month 8: Balance = 1771.75
                        // Month 9: Balance = 1721.50
                        // Month 10: Balance = 1822.00
                        // Month 11: Balance = 1771.75
                        // Month 12: Balance = 1872.25          

            // Part 6: Error-prone casting attempt
            //Note: try catch blocks are used when an runtime exception occures instead of raising the error 
            //the execution will move to the catch block from the line where exception raised.
            //we can discuss in more detail in Exception Handling topic.
            object accountId = 12345;
            try
            {
                string invalidCast = (string)accountId;  // Intentional error: invalid cast
            }
            catch (InvalidCastException ex)

            {
                Console.WriteLine("Error: Attempted invalid cast from int to string.");
            }
            //output:-Error: Attempted invalid cast from int to string.

            // Final balance and message
            Console.WriteLine($"Final Account Balance after Transactions: {newBalance:F2}");
            //output:- Final Account Balance after Transactions:1872.25

            Console.WriteLine(newBalance >= 0 ? "Account is in good standing." : "Account is overdrawn.");    
            // output:- Account is in good standing.
        }
    }
}

3. E-Commerce Inventory System with Type Conversions and Parsing
using System;

namespace TypeConversionComplexExample2
{
    class Program
    {
        static void Main()
        {
            // Part 1: Product Information
            string productId = "1001";
            int parsedProductId;
            if (int.TryParse(productId, out parsedProductId))
            {
                Console.WriteLine($"Parsed Product ID: {parsedProductId}");
            }
            else
            {
                Console.WriteLine("Invalid Product ID.");
            }
            //output:- Parsed Product ID:1001

            // Part 2: Inventory and Sales Conversion
            object stockCountObj = 500;
            int stockCount = (int)stockCountObj;//500 // Unboxing from object
            double pricePerItem = 19.99;
            decimal totalInventoryValue = (decimal)(pricePerItem * stockCount);  // Explicit cast
            Console.WriteLine($"Total Inventory Value: {totalInventoryValue:C}");
            //output:- Total Inventory Value:9,995.00;

            // Part 3: Sales and Nullable Handling
            int? soldItems = null;
            soldItems = 50;
            double? revenue = soldItems * pricePerItem;  // Nullable type calculation
            Console.WriteLine($"Revenue from Sold Items: {revenue:C}");
            //output:- Revenue from Sold Items:999.50;

            // Part 4: Discount Calculation with Casting
            string discountStr = "10";  // 10% discount
            int discountPercent;
            if (int.TryParse(discountStr, out discountPercent))
            {
                double discountAmount = pricePerItem * discountPercent / 100;
                Console.WriteLine($"Discount Amount per Item: {discountAmount:C}");
            }
            else
            {
                Console.WriteLine("Invalid discount value.");
            }
            //output:- Discount Amount per Item:?2;

            // Part 5: Profit Calculation and Loop
            Console.WriteLine("Calculating Monthly Profits:");
            double monthlyProfit = 0;
            for (int month = 1; month <= 6; month++)
            {
                int sales = month % 2 == 0 ? 100 : 80;  // Alternating sales count
                double monthlyRevenue = sales * (pricePerItem - (double)discountPercent / 100);
                monthlyProfit += monthlyRevenue;
                Console.WriteLine($"Month {month}: Profit = {monthlyProfit:C}");
            }
            //output:-Calculating Monthly Profits:
            

            // Part 6: Error-prone Nullable Unboxing
            object nullableBoxed = (object)revenue;  // Boxing nullable double
            try
            {
                int invalidUnbox = (int)nullableBoxed;  // Error: Unboxing double as int
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Error: Invalid unboxing from double to int.");
            }

            // Final Inventory Status
            Console.WriteLine(stockCount > 0 ? "Inventory available." : "Out of stock.");
        }
    }
}

