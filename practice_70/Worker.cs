using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_70
{
    struct Worker
    {
        public int Id { get; set; }
        public DateTime RecordingDate { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public DateTime BirthDay { get; set; } 
        public string BirthPlace { get; set; }

        public Worker(int id, DateTime RecordingDate, string FIO, int Age, int Height, DateTime BirthDay, string BirthPlace)
        {
            this.Id = id;
            this.RecordingDate = RecordingDate;
            this.FIO = FIO;
            this.Age = Age;
            this.Height = Height;
            this.BirthDay = BirthDay;
            this.BirthPlace = BirthPlace;
        }

    }
}
