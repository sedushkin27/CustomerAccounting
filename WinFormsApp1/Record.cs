using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    struct Record 
    {
        public bool Сreated { get; } = false;
        public readonly DateTime StartTime { get; }
        public readonly DateTime EndTime { get; }
        public readonly string Name { get; }

        public Record(DateTime startTime, string name, int howLongTime)
        {
            StartTime = startTime;
            EndTime = startTime + TimeSpan.FromMinutes(howLongTime);
            Name = name;
            Сreated = true;
        }

        public override string ToString()
        {
            return $"{StartTime.ToString("dd-MM-yyyy HH:mm")}-{EndTime.ToString("HH:mm")}: {Name}";
        }
    }
}
