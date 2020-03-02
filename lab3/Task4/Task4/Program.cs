using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char? buf = null;
            int counter = 0;
            string line; 
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' };
            StringBuilder answer = new StringBuilder();
            Console.WriteLine("Reading file:");
            using (StreamReader File = new StreamReader("text.txt"))
            {
                while ((line = File.ReadLine()) != null)
                {
                    Console.WriteLine(line); 
                    string[] words = line.Split(separator);
                    foreach (string word in words) 
                    {
                        if (buf == null)
                        {
                            buf = word[word.Length - 1];
                        }
                        
                        else if (!string.IsNullOrWhiteSpace(word) && 
                                 word.All(s => char.IsLetter(s)) && word[word.Length - 1] == buf)
                        {
                            counter ++;
                            answer.Append(word).Append(" ");
                        }
                    }
                }
            }
            Console.WriteLine("There were {0} sequences.", counter);
            Console.WriteLine(answer.ToString());
            Console.ReadLine();
        }
    }
}