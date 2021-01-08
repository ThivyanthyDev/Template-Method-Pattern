using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Template_Method
{
    public abstract class DataProcessor
    {
        public void ReadProcessandSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }
        public abstract void ReadData();
        public abstract void ProcessData();

        public void SaveData()
        {
            Console.WriteLine("Save data to Db");

        }
    }
}
