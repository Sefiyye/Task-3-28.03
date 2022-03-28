using System;

namespace _28._03_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "I am studying at the Azerbaijan Technical University";
            Console.WriteLine(Sentence);
            Console.WriteLine("First Word: ");
            Console.WriteLine(FindFirstWord(Sentence));
        }
        public static string FindFirstWord(string sentence)
        {
            string[] word = sentence.Split();
            return word[0];
        }
    }
}
