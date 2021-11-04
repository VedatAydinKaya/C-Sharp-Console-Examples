using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler_yeni
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Sms yazar");
        }
    }
}
