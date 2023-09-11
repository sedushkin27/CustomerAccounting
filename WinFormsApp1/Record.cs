﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    struct Record : IComparable<Record>
    {
        public readonly DateTime StartTime { get; }
        public readonly DateTime EndTime { get; }
        public readonly string Name { get; }

        public Record(DateTime startTime, string name, int howLongTime)
        {
            StartTime = startTime;
            EndTime = startTime + TimeSpan.FromMinutes(howLongTime);
            Name = name;
        }

        public override string ToString() => $"{StartTime:dd-MM-yyyy HH:mm}-{EndTime:HH:mm}: {Name}";

        public int CompareTo(Record other) => this.EndTime.CompareTo(other.EndTime);
    }
}
