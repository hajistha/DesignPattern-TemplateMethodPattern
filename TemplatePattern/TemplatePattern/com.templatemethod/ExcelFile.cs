using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.com.templatemethod
{
    class ExcelFile : DataProcessor
    {
        
        public override void ReadData()
        {
            Console.WriteLine("Read data from Excel file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from Excel file");
        }

        
    }
}
