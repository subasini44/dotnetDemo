// using System;

// class Calculator
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Simple Calculator ===\n");

//         // Get first number
//         Console.Write("Enter first number: ");
//         double num1 = double.Parse(Console.ReadLine());

//         // Get second number
//         Console.Write("Enter second number: ");
//         double num2 = double.Parse(Console.ReadLine());

//         // Perform operations
//         double addition = num1 + num2;
//         double subtraction = num1 - num2;
//         double multiplication = num1 * num2;
//         double division = num2 != 0 ? num1 / num2 : 0;

//         // Display results
//         Console.WriteLine("\n=== Results ===");
//         Console.WriteLine($"Addition: {num1} + {num2} = {addition}");
//         Console.WriteLine($"Subtraction: {num1} - {num2} = {subtraction}");
//         Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplication}");
//         Console.WriteLine($"Division: {num1} / {num2} = {(num2 != 0 ? division.ToString() : "Cannot divide by zero")}");
//     }
// }


// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     static int PlusMethod(int x, int y)
//     {
//       return x + y;
//     }

//     static double PlusMethod(double x, double y)
//     {
//       return x + y;
//     }

//     static void Main(string[] args)
//     {
//       int myNum1 = PlusMethod(8, 5);
//       double myNum2 = PlusMethod(4.3, 6.26);
//       Console.WriteLine("Int: " + myNum1);
//       Console.WriteLine("Double: " + myNum2);
//     }  
//   }
// }

// using System;

// namespace MyApplication
// {
//   class Program
//   {    static void Main(string[] args)
//     {
//         int age = 20;
//       if(age < 18)
//       {
//         Console.WriteLine("You are a minor.");
//       }
//       else
//       {
//         Console.WriteLine("You are an adult.");
//       }
//     }  
//   }
// }

using System;

namespace myapp{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Welcome to C# .net programming.");
        }
    }
}