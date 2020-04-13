using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdditionalTask
{
    class Program
    {
        static int counter = 0;

        static void Inrement()
        {
            for (int i = 0; i < 10; i++)
            {
                Interlocked.Increment(ref counter);
                Console.WriteLine($"Counter = {counter}, Thread = {Thread.CurrentThread.GetHashCode()}");
            }
            
        }

        static void Main(string[] args)
        {
            var threads = new Thread[3];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Inrement);
                threads[i].Start();
                threads[i].Join();
            }
        }
    }
}
