using System;

namespace arayuzler_yeni
{
    class Program
    {
        static void Main(string[] args)
        {

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();


            DataBaseLogger dataBaseLogger = new DataBaseLogger();
            dataBaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();


            LogManager logManager = new LogManager(new FileLogger());

            logManager.WriteLog();
            

        }
    }
}
