using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static Semaphore pool;

        public static void WriteToLog()
        {
            pool.WaitOne();
            File.AppendAllText("myLog.log", $"{DateTime.Now} Some event from Thread {Thread.CurrentThread.GetHashCode()}\n");
            Thread.Sleep(500);
            pool.Release();
        }

        static void Main(string[] args)
        {
            pool = new Semaphore(1, 2);

            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(WriteToLog);
                thread.Start();
            }

            Console.ReadKey();
        }
    }
}
