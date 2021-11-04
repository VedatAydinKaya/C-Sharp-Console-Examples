using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler_yeni
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("File 'a yazar");
        }
    }
}
