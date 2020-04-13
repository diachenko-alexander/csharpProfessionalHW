using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void SomeMethod()
        {
            Console.WriteLine("STARTED");
            Thread.Sleep(2000);
            Console.WriteLine("FINISHED");
        }

        static void CallbackMethod (IAsyncResult asyncResult)
        {
            Console.WriteLine("Info from Async Method" + asyncResult.AsyncState);
        }

        static void Main(string[] args)
        {
            var someDelegate = new Action(SomeMethod);
            var callback = new AsyncCallback(CallbackMethod);
            someDelegate.BeginInvoke(CallbackMethod, "INFO TO CALLBACK");
            Console.ReadKey();

        }
    }
}
