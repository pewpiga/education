using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8_3
{
    class Operations
    {
        private HashSet<int> hashSet;
        public Operations()
        {
            this.hashSet = new HashSet<int>();
        }
        public void Start()
        {
            do
            {
                Console.Write("\nВведите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                CheckNum(num);
                
                PrintToConsole();
            }
            while (true);
        }
        private void CheckNum(int num)
        {
            if (hashSet.TryGetValue(num, out int val)) 
            {
                Console.WriteLine("Число уже есть в коллекции");
            }
            else
            {
                hashSet.Add(num);
                Console.WriteLine("Число добавлено в коллекцию");
            }
        }
        public void PrintToConsole()
        {
            Console.Write("Числа в коллекции: ");
            foreach (var item in hashSet)
            {
                Console.Write(item + " ");
            }
        }
    }
}
