using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        if (char.IsUpper(ch))
            Console.WriteLine("Uppercase Letter");
        else if (char.IsLower(ch))
            Console.WriteLine("Lowercase Letter");
        else
            Console.WriteLine("Not an alphabet");
    }
}
