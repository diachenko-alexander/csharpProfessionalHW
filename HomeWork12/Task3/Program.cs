using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static string mutexName = "MyMutex123";
        private static readonly Mutex mutex = new Mutex(false, mutexName); 

        static void Main(string[] args)
        {
            mutex.WaitOne();

            Console.WriteLine("Поток {0} зашел в защищенную область.", Thread.CurrentThread.Name);
            Console.ReadKey();
            Console.WriteLine("Поток {0}  покинул защищенную область.\n", Thread.CurrentThread.Name);
            Console.ReadKey();
            mutex.ReleaseMutex();
        }
    }
}
