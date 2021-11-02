using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler
{
    public class LogManager:ILogger
    {

        //  Interface instance yaratalım

        public ILogger _logger;   // Interface ler soyut olduktuklarından new ile yaratılamazlar.Nesneleri olsuturulamazalar
                                  //  Tek baslarına anlamlı degillerdir

        // Constructor kısmı:
        public LogManager(ILogger logger)  // Interface tipinde nesne alsın; logger parametre gonderilen : logger interface referansı
        {
            _logger = logger;
        }

        public void WriteLog()
        {                                           // Genel olarak ILogger interface tureyen nesnenin WriteLog CALISTIRIR
            _logger.WriteLog();
        }
    }
}
