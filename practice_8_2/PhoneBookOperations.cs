using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practice_8_2
{
    class PhoneBookOperations
    {
        private Dictionary<string, string> phoneBook;
        public PhoneBookOperations()
        {
            this.phoneBook = new Dictionary<string, string>();
        }
        public void StartProgram()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("1 - Ввод данных;\n" +
                          "2 - Поиск данных;\n" +
                          "3 - Выход;\n" +
                          "Ввод: ");

                int id = Convert.ToInt32(Console.ReadLine());

                switch (id)
                {
                    case 1:
                        InputData();
                        break;
                    case 2:
                        OutputData();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }            
        }
        private void InputData()
        {
            string inputPhone;
            string inputName;

            while (true)
            {
                Console.Write("Введите телефон: ");
                inputPhone = Console.ReadLine();

                if (inputPhone == "") break;

                Console.Write("Введите имя: ");
                inputName = Console.ReadLine();

                phoneBook.Add(inputPhone, inputName);
            }
        }
        private void OutputData() 
        {
            string inputPhone;
            string name;

            Console.Write("Введите телефон: ");
            inputPhone = Console.ReadLine();

            foreach (var key in phoneBook.Keys)
            {
                if (key == inputPhone)
                {
                    Console.WriteLine("Владелец данного номера: {0}", name = phoneBook[key]);
                }
            }
        }
    }
}
