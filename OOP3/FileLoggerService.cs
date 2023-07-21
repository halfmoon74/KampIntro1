using System;

namespace OOP3
{
    partial class DataBaseLoggerService
    {
        class FileLoggerService : ILoggerService
        {
            public void Log()
            {
                Console.WriteLine("Dosyaya loglandı");
            }
        }
    }
}
