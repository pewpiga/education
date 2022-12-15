using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8_1
{
    class ListOperations
    {
        private int num;
        private List<int> rndNums;
        public ListOperations(int num, List<int> rndNums)
        {
            this.num = num;
            this.rndNums = rndNums;
        }
        public void FillList()
        {
            Random rnd = new Random();
            for (int n = 0; n < num; n++)
            {
                this.rndNums.Add(rnd.Next(101));
            }
        }
        public void DeleteNums()
        {
            for (int n = 0; n < rndNums.Count; n++)
            {
                if (rndNums[n] > 25 && rndNums[n] < 50)
                {
                    rndNums.RemoveAt(n);
                    n -= 1;
                }
            }
        }
        public void PrintToConsole()
        {
            int count = 1;
            foreach(var item in rndNums)
            {
                if (count > 10)
                {
                    Console.Write("\n");
                    count = 1;
                }
                Console.Write(item + "\t");
                count++;
            }
            Console.WriteLine("\n");
        }
    }
}
