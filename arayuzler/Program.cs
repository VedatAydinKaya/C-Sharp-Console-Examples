using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();


            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();



            LogManager logManager = new LogManager(new FileLogger()); // Instance yaratmıs oldugumuz Ilogger dan tureyen sınıfın writelog metotu
            logManager.WriteLog();


       }
    }
}
