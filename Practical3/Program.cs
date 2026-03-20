using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Uppercase: " + str.ToUpper());
        Console.WriteLine("Lowercase: " + str.ToLower());
    }
}
