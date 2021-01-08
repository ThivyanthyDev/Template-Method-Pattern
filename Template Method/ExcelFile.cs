using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Template_Method
{
    public class ExcelFile : DataProcessor
    {

        public override void ReadData()
        {
            Console.WriteLine("Read data from excel file");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process data from excel file");
        }

    }
}
