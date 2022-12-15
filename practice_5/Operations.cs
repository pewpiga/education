using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_5
{
    public class Operations
    {
        public void StartProgram()
        {
            Console.Write("Введите слово: ");
            string text = Console.ReadLine();
            WriteWords(text);
            Console.WriteLine("=======================");
            Reverse(text);
            
        }
        public void WriteWords(string text)
        {
            string[] split = SplitText(text);
            foreach (var word in split)
            {
                Console.WriteLine(word);
            }
        }
        public string Reverse(string text)
        {
            string reverseText;
            string[] words = SplitText(text);

            Array.Reverse(words);
            reverseText = string.Join(" ", words);

            return reverseText;
        }
        public string[] SplitText(string text)
        {
            string[] split = text.Split(' ');
            return split;
        }
    }
}
