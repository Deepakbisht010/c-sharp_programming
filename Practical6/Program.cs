using System;
using System.Globalization; 
class Program
{
static void Main()
{
Console.WriteLine("Select a date from the calendar below:");
 DateTime selectedDate = DateTime.Today;
Console.WriteLine("Today's Date: " + selectedDate.ToString("dd-MM-yyyy")); 
Console.Write("Enter a future date (dd-MM-yyyy): ");
string input = Console.ReadLine();
if (DateTime.TryParseExact(input, "dd-MM-yyyy", null, DateTimeStyles.None, out selectedDate))
{
Console.WriteLine("Selected Date Details:"); 
Console.WriteLine("Day: " + selectedDate.Day);
Console.WriteLine("Month: " + selectedDate.Month); 
Console.WriteLine("Year: " + selectedDate.Year);
}
else
{
Console.WriteLine("Invalid date format. Please enter in dd-MM-yyyy format.");
}
}
}
