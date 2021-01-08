using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Template_Method
{
    class TestTemplateMethod
    {
        static void Main()
        {
            ExcelFile obj = new ExcelFile();
            obj.ReadProcessandSave();
            //obj.ReadData();
            //obj.ProcessData();
            //obj.SaveData();

            TextFile obj2 = new TextFile();
            obj2.ReadProcessandSave();
            //obj2.ReadData();
            //obj2.ProcessData();
            //obj2.SaveData();

        }
    }
}
