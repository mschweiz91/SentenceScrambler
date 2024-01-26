using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph to rearrange:");
        string paragraph = Console.ReadLine();

        string shuffledParagraph = RandomlyRearrangeWords(paragraph);
        Console.WriteLine("\nRearranged paragraph:");
        Console.WriteLine(shuffledParagraph);
        Console.ReadLine(); // Keep the console window open
    }

    static string RandomlyRearrangeWords(string paragraph)
    {
        // Split the paragraph into words
        string[] words = paragraph.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Shuffle the words randomly
        Random rng = new Random();
        string[] shuffledWords = words.OrderBy(word => rng.Next()).ToArray();

        // Join the shuffled words back into a new paragraph
        string shuffledParagraph = string.Join(" ", shuffledWords);
        return shuffledParagraph;
    }
}
