using System; using System.IO; class Program
{		static string text = ""; static string clipboard = "";
static void Main(string[] args)
{
while (true)
{
Console.WriteLine("\n===== MINI TEXT EDITOR ====="); Console.WriteLine("1. Write Text");
Console.WriteLine("2. Cut"); Console.WriteLine("3. Copy"); Console.WriteLine("4. Paste"); Console.WriteLine("5. Save");
Console.WriteLine("6. Display Text"); Console.WriteLine("7. Close"); Console.Write("Enter your choice: ");
int choice = Convert.ToInt32(Console.ReadLine()); switch (choice)
{
case 1:
Console.Write("Enter text: "); text = Console.ReadLine(); break;
case 2:
clipboard = text; text = "";
Console.WriteLine("Text Cut Successfully!"); break;
case 3:
clipboard = text;
Console.WriteLine("Text Copied Successfully!"); break;
case 4:
text += clipboard;
 
Console.WriteLine("Text Pasted Successfully!"); break;
case 5:
File.WriteAllText("savedText.txt", text);
Console.WriteLine("Text Saved to savedText.txt"); break;
case 6:
Console.WriteLine("Current Text: " + text); break;
case 7:
Console.WriteLine("Editor Closed."); return;
default:
Console.WriteLine("Invalid Choice!"); break;
}
}
}
}
