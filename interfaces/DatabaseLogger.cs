using System;

namespace interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
    }
}