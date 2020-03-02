using System;
using System.IO;
using System.Linq;
using System.Text;
namespace ComsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool onlyNumbers = true;
            bool hasNumbersWithoutD = true;
            bool fileIsNotEmpty = false;
            int counter = 0; // лічильник слів, де d стоїть на 2-му місці
            string line; // допоміжний рядок
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' }; // масив
            StringBuilder otvet = new StringBuilder(); // рядок-відповідь
            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                // читання рядка з файлу, поки це можливо
                while ((line = MyFile.ReadLine()) != null)
                {
                    fileIsNotEmpty = true;
                    Console.WriteLine(line); // друкуємо, що прочитали
//виділяємо слова
                    string[] words = line.Split(separator);
                    foreach (string slovo in words) //цикл за словами, цикл foreach
                    {
                        if (onlyNumbers == true && slovo.Any(s => char.IsLetter(s)))
                        {
                            onlyNumbers = false;
                        }

                        if (slovo[1] != 'd')
                        {
                            hasNumbersWithoutD = false;
                        }
                    }
                }
            }

            if (onlyNumbers)
            {
                Console.WriteLine("Input file has only numbers");
            }
            else if (hasNumbersWithoutD && !onlyNumbers)
            {
                Console.WriteLine("Input file has only text, but without numbers");
            }
            else if (!fileIsNotEmpty)
            {
                Console.WriteLine("Input file");
            }
            else
            {
                Console.WriteLine("Another variant");
            }
            
        }
    }
}