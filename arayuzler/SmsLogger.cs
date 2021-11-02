using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler
{
    public class SmsLogger : ILogger
    {                   
                // Interface metotlarını impelemente etmemiz gerekir
        public void WriteLog()
        {
            //  throw new NotImplementedException();   govdesi bos bırakılabilir

            Console.WriteLine("Sms olarak log yazar");
        }
    }
}
