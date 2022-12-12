using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace practice_8_4
{
    class Operations
    {
        private string fileName;
        public Operations()
        {
            this.fileName = "NoteBook.xml";
        }
        public void Initialization()
        {
            XDocument doc = new XDocument();

            //Создание элемента Person
            XElement person = new XElement("Person");
            Console.Write("Введите ФИО: ");
            person.Add(new XAttribute("name", Console.ReadLine()));
            doc.Add(person);

            //Создание элемента Address внутри Person
            XElement addr = new XElement("Address");
            person.Add(addr);

            //Создание элемента Street
            XElement street = new XElement("Street");
            Console.Write("Введите улицу: ");
            street.Value = Console.ReadLine();
            addr.Add(street);

            //Создание элемента HouseNumber
            XElement houseNum = new XElement("HouseNumber");
            Console.Write("Введите номер дома: ");
            houseNum.Value = Convert.ToString(Console.ReadLine());
            addr.Add(houseNum);

            //Создание элемента FlatNumber
            XElement flatNum = new XElement("FlatNumber");
            Console.Write("Введите номер квартиры: ");
            flatNum.Value = Convert.ToString(Console.ReadLine());
            addr.Add(flatNum);

            //Создание элемента Phones внутри Person
            XElement phones = new XElement("Phones");
            person.Add(phones);

            //Создание элемента MobilePhone
            XElement mobPhone = new XElement("MobilePhone");
            Console.Write("Введите мобильный номер: ");
            mobPhone.Value = Convert.ToString(Console.ReadLine());
            phones.Add(mobPhone);

            //Создание элемента FlatPhone
            XElement flatPhone = new XElement("FlatPhone");
            Console.Write("Введите номер домашнего телефона: ");
            flatPhone.Value = Convert.ToString(Console.ReadLine());
            phones.Add(flatPhone);

            doc.Save(fileName);
        }
    }
}
