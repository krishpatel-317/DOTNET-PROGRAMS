using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> history = new Stack<string>();
        int choice;

        do
        {
            Console.WriteLine("\n1. Visit New Webpage");
            Console.WriteLine("2. Go Back");
            Console.WriteLine("3. View Current Page");
            Console.WriteLine("4. Display Browsing History");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter webpage: ");
                    history.Push(Console.ReadLine());
                    break;

                case 2:
                    if (history.Count > 0)
                        Console.WriteLine("Back from: " + history.Pop());
                    else
                        Console.WriteLine("No pages in history.");
                    break;

                case 3:
                    if (history.Count > 0)
                        Console.WriteLine("Current Page: " + history.Peek());
                    else
                        Console.WriteLine("No current page.");
                    break;

                case 4:
                    if (history.Count > 0)
                    {
                        Console.WriteLine("Browsing History:");
                        foreach (string page in history)
                            Console.WriteLine(page);
                    }
                    else
                    {
                        Console.WriteLine("History is empty.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 5);
    }
}