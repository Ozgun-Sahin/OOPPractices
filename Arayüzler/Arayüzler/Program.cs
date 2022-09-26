using System;

namespace Arayüzler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger();
            fl.WriteLog();

            DatabaseLogger dbl = new DatabaseLogger();
            dbl.WriteLog();

            SMSLogger smsl = new SMSLogger();
            smsl.WriteLog();

            LogManager lm = new LogManager(new FileLogger());
            lm.WriteLog();
           
        }
    }
}
