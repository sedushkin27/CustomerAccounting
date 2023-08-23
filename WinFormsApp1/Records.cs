using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    internal class Records
    {
        public Record[] record = new Record[100];

        private void ArraySorting() 
        {
            Record save;
            for (int i = 0; i < record.Length; i++)
            {
                for (int j = 0; j < record.Length;  j++)
                {
                    if (record[i].EndTime < record[j].EndTime)
                    {
                        save = record[i];
                        record[i] = record[j];
                        record[j] = save;
                    }
                }
            }
        }

        public void AddClient(DateTime startTime, string name)
        {
            this.ArraySorting();
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i].Сreated == false)
                {
                    record[i] = new Record(startTime, name);
                    this.ArraySorting();
                    break;
                }
            }
        }

        public void RemoveClient(string name)
        {
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i].Name == name)
                {
                    record[i] = new Record();
                    this.ArraySorting();
                    break;
                }
            }
        }

        public void Clear()
        {
            for (int i = 0; i < record.Length; i++)
            {
                record[i] = new Record();
            }
        }
    }
}
