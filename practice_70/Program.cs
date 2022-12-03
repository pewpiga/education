using practice_70;

string path = @"data.txt";
int id = 0;

Repository rep = new Repository(path);

Console.Write("1 - вывести данные из файла на экран;\n" +
              "2 - вывести данные по ID;\n" +
              "3 - заполнить данные и добавить новую запись в конец файла.\n" +
              "4 - удалить запись по id\n" +
              "5 - вывести записи за указанный период\n" +
              "Ввод: ");
string key = Console.ReadLine();

switch (Convert.ToInt32(key))
{
    case 1:
        {
            rep.PrintToConsole(path);
        }
        break;
    case 2:
        {
            Console.Write("Введите id: ");
            id = Convert.ToInt32(Console.ReadLine());

            rep.PrintToConsole(path, id);
        }
        break;
    case 3:
        {
            Console.Write("ФИО: ");
            string fio = $"{Console.ReadLine()}";

            Console.Write("Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Рост: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Дата рождения: ");
            DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Место рождения: ");
            string birthPlace = $"{Console.ReadLine()}";

            rep.AddWorker(new Worker(id, DateTime.Now, fio, age, height, birthDay, birthPlace));
        }
        break;
    case 4:
        {
            Console.Write("Введите id: ");
            id = Convert.ToInt32(Console.ReadLine());
            rep.DeleteWorker(id);
        }
        break;
    case 5:
        {
            Console.Write("Начальный период (dd.MM.YYYY HH:mm:ss): ");
            DateTime fromDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Конечный период  (dd.MM.YYYY HH:mm:ss): ");
            DateTime toDate = Convert.ToDateTime(Console.ReadLine());

            rep.PrintToConsole(path, fromDate, toDate);
        }
        break;
}