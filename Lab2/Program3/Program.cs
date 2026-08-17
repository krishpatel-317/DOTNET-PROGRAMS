using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (dict.ContainsKey(word))
                dict[word]++;
            else
                dict[word] = 1;
        }

        Console.WriteLine("\nWord Frequencies:");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}