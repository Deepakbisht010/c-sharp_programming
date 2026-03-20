using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        ch = char.ToLower(ch);

        if ("aeiou".Contains(ch))
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Not a Vowel");
    }
}
