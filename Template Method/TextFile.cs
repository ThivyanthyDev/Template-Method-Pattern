using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Template_Method
{
    public class TextFile : DataProcessor
    {

        public override void ReadData()
        {
            Console.WriteLine("Read data from Text file");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process data from Text file");
        }

    }
}
