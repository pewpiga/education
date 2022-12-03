using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_70
{
    class Repository
    {
        private Worker[] workers;
        private string path;
        private int id;
        public Repository(string path)
        {
            this.path = path;
            this.workers = new Worker[2];
        }
        private void Resize(bool flag)
        {
            if (flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }
        public void Add(Worker worker)
        {
            this.Resize(id >= workers.Length);
            this.workers[id] = worker;
            this.id++;
        }
        public void InitializeData()
        {
            using (StreamReader sr = new StreamReader(this.path))
            {
                while(!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');
                    Add(new Worker(Convert.ToInt32(args[0]), Convert.ToDateTime(args[1]), args[2], Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToDateTime(args[5]), args[6]));
                }
            }
        }
        /// <summary>
        /// Создание записи о работнике
        /// </summary>
        /// <param name="worker"></param>
        public void AddWorker(Worker worker)
        {
            InitializeData();

            using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.Unicode))
            {
                Add(worker);

                string data = $"{this.id}#{worker.RecordingDate}#{worker.FIO}#{worker.Age}#{worker.Height}#{worker.BirthDay}#{worker.BirthPlace}";

                sw.WriteLine(data);
            }
        }
        /// <summary>
        /// Удаление записи о работнике по Id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteWorker(int id)
        {
            string data = String.Empty;

            using (StreamReader sr = new StreamReader(this.path))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');
                    Add(new Worker(Convert.ToInt32(args[0]), Convert.ToDateTime(args[1]), args[2], Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToDateTime(args[5]), args[6]));
                }
            }

            File.WriteAllText(path, string.Empty, Encoding.Unicode);

            using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.Unicode))
            {
                
                for (int i = 0; i < workers.Length; i++)
                {
                    if (workers[i].Id != id && workers[i].Id < id && workers[i].Id != 0)
                    {
                        data = $"{workers[i].Id}#{workers[i].RecordingDate}#{workers[i].FIO}#{workers[i].Age}#{workers[i].Height}#{workers[i].BirthDay}#{workers[i].BirthPlace}";
                        sw.WriteLine(data);
                    }
                    else if (workers[i].Id > id && workers[i].Id != 0)
                    {
                        data = $"{workers[i].Id - 1}#{workers[i].RecordingDate}#{workers[i].FIO}#{workers[i].Age}#{workers[i].Height}#{workers[i].BirthDay}#{workers[i].BirthPlace}";
                        sw.WriteLine(data);
                    }
                }
            }
        }
        /// <summary>
        /// Возврат всех считанных Workers
        /// </summary>
        public Worker[] GetAllWorkers()
        {
            InitializeData();
            return workers;
        }
        /// <summary>
        /// Просмотр записи по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Worker GetWorkerById(int id)
        {
            InitializeData();
            Worker worker = workers[id];
            return worker;
        }
        /// <summary>
        /// Просмотр записей в диапазоне указанных дат
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <returns></returns>
        public Worker[] GetWorkersBetweenDate(DateTime fromDate, DateTime toDate)
        {
            InitializeData();

            Worker[] data = new Worker[this.id];
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].RecordingDate >= fromDate && workers[i].RecordingDate <= toDate)
                {
                    data[i] = workers[i];
                }
            }
            return data;
        }
        /// <summary>
        /// Вывести данные в консоль
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public void PrintToConsole(string path)
        {
            Worker[] worker = GetAllWorkers();
            for (int i = 0; i < worker.Length; i++)
            {
                if (worker[i].Id != 0)
                {
                    Console.WriteLine($"\nID: {worker[i].Id}");
                    Console.WriteLine($"Дата записи : {worker[i].RecordingDate}");
                    Console.WriteLine($"ФИО: {worker[i].FIO}");
                    Console.WriteLine($"Возраст: {worker[i].Age}");
                    Console.WriteLine($"Рост: {worker[i].Height}");
                    Console.WriteLine($"Дата рождения: {worker[i].BirthDay}");
                    Console.WriteLine($"Место рождения: {worker[i].BirthPlace}");
                }
            }
        }
        /// <summary>
        /// Вывести данные в консоль по ID
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="id">ID сотрудника</param>
        public void PrintToConsole(string path, int id)
        {
            Worker[] worker = GetAllWorkers();
            for (int i = 0; i < worker.Length; i++)
            {
                if (worker[i].Id == id)
                {
                    Console.WriteLine($"\nID: {worker[i].Id}");
                    Console.WriteLine($"Дата записи : {worker[i].RecordingDate}");
                    Console.WriteLine($"ФИО: {worker[i].FIO}");
                    Console.WriteLine($"Возраст: {worker[i].Age}");
                    Console.WriteLine($"Рост: {worker[i].Height}");
                    Console.WriteLine($"Дата рождения: {worker[i].BirthDay}");
                    Console.WriteLine($"Место рождения: {worker[i].BirthPlace}");
                }
            }
        }
        /// <summary>
        /// Вывести данные в консоль в выбранном диапазоне
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="fromDate">Начальная дата записи</param>
        /// <param name="toDate">Конечная дата записи</param>
        public void PrintToConsole(string path, DateTime fromDate, DateTime toDate)
        {
            Worker[] worker = GetAllWorkers();
            for (int i = 0; i < worker.Length; i++)
            {
                if (worker[i].RecordingDate >= fromDate && worker[i].RecordingDate <= toDate)
                {
                    Console.WriteLine($"\nID: {worker[i].Id}");
                    Console.WriteLine($"Дата записи : {worker[i].RecordingDate}");
                    Console.WriteLine($"ФИО: {worker[i].FIO}");
                    Console.WriteLine($"Возраст: {worker[i].Age}");
                    Console.WriteLine($"Рост: {worker[i].Height}");
                    Console.WriteLine($"Дата рождения: {worker[i].BirthDay}");
                    Console.WriteLine($"Место рождения: {worker[i].BirthPlace}");
                }
            }
        }
    }
}
