using System;

class Program
{
    // Memory storage
    static double memory = 0;
    static double lastResult = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== CALCULATOR =====");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Memory Store (MS)");
            Console.WriteLine("6. Memory Recall (MR)");
            Console.WriteLine("7. Memory Clear (MC)");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double num1, num2;

            switch (choice)
            {
                case 1:
                    GetNumbers(out num1, out num2);
                    lastResult = num1 + num2;
                    Console.WriteLine("Result: " + lastResult);
                    break;

                case 2:
                    GetNumbers(out num1, out num2);
                    lastResult = num1 - num2;
                    Console.WriteLine("Result: " + lastResult);
                    break;

                case 3:
                    GetNumbers(out num1, out num2);
                    lastResult = num1 * num2;
                    Console.WriteLine("Result: " + lastResult);
                    break;

                case 4:
                    GetNumbers(out num1, out num2);
                    if (num2 != 0)
                    {
                        lastResult = num1 / num2;
                        Console.WriteLine("Result: " + lastResult);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                    break;

                case 5:
                    memory = lastResult;
                    Console.WriteLine("Stored in Memory.");
                    break;

                case 6:
                    Console.WriteLine("Memory Value: " + memory);
                    break;

                case 7:
                    memory = 0;
                    Console.WriteLine("Memory Cleared.");
                    break;

                case 8:
                    Console.WriteLine("Calculator Closed.");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }

    static void GetNumbers(out double n1, out double n2)
    {
        Console.Write("Enter first number: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        n2 = Convert.ToDouble(Console.ReadLine());
    }
}
