using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaceler onu implement eden classın referans numarasını tutabilir.
            ICreditManager creditManagerPF = new CreditManagerPersonalFinance(); 
            ICreditManager creditManagerTransport = new CreditManagerTransport();
            ICreditManager creditManagerMortgage = new CreditManagerMortgage();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>
            {
                new SmsLoggerService(),
                new FileLoggerService(),
                new DatabaseLoggerService(),
            };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(new CreditManagerArtisan(), loggers); // polymorphism
            // ihtiyaç kredisi için 3 farklı loglama türünü aynı anda yaptık.

            List<ICreditManager> credits = new List<ICreditManager>() {
                creditManagerPF,
                creditManagerTransport,
                creditManagerMortgage
            };
            // applicationManager.MakeCreditPreview(credits);
        }
    }
}
