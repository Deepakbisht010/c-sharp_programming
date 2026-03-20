using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Practical7
{
    static int score = 0;
    static int timeLimit = 10; // seconds per question

    static void Main()
    {
        List<(string Question, string[] Options, int CorrectOption)> quiz =
            new List<(string, string[], int)>
        {
            ("What is the capital of France?",
                new string[] {"1. Paris", "2. London", "3. Berlin", "4. Madrid"}, 1),

            ("Which is the largest planet in our solar system?",
                new string[] {"1. Earth", "2. Mars", "3. Jupiter", "4. Saturn"}, 3),

            ("Who wrote 'Hamlet'?",
                new string[] {"1. Dickens", "2. Shakespeare", "3. Tolstoy", "4. Hemingway"}, 2),

            ("Which gas do plants use for photosynthesis?",
                new string[] {"1. Oxygen", "2. Nitrogen", "3. Carbon Dioxide", "4. Hydrogen"}, 3),

            ("What is 5 + 7?",
                new string[] {"1. 10", "2. 12", "3. 14", "4. 15"}, 2),

            ("Which element has atomic number 1?",
                new string[] {"1. Oxygen", "2. Hydrogen", "3. Helium", "4. Carbon"}, 2),

            ("What is the currency of Japan?",
                new string[] {"1. Yen", "2. Dollar", "3. Peso", "4. Rupee"}, 1),

            ("Who discovered gravity?",
                new string[] {"1. Einstein", "2. Newton", "3. Galileo", "4. Kepler"}, 2),

            ("What is the square root of 64?",
                new string[] {"1. 6", "2. 7", "3. 8", "4. 9"}, 3),

            ("Which ocean is the largest?",
                new string[] {"1. Atlantic", "2. Indian", "3. Arctic", "4. Pacific"}, 4)
        };

        Console.WriteLine("Welcome to the Timer-Based Quiz!\n");

        for (int i = 0; i < quiz.Count; i++)
        {
            Console.WriteLine($"Question {i + 1}: {quiz[i].Question}");

            foreach (var option in quiz[i].Options)
                Console.WriteLine(option);

            Console.Write($"Enter your answer (1-4) within {timeLimit} seconds: ");

            string userInput = ReadLineWithTimeout(timeLimit);

            if (int.TryParse(userInput, out int answer) &&
                answer == quiz[i].CorrectOption)
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong or Time's up!");
                Console.WriteLine("Correct Answer: " + quiz[i].CorrectOption + "\n");
            }
        }

        Console.WriteLine($"Quiz Over! Your Final Score: {score}/10");
        Console.ReadKey();
    }

    static string ReadLineWithTimeout(int seconds)
    {
        var task = Task.Run(() => Console.ReadLine());

        if (task.Wait(TimeSpan.FromSeconds(seconds)))
        {
            return task.Result;
        }
        else
        {
            Console.WriteLine("\nTime's up!");
            return "";
        }
    }
}
