using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    

    class Program
    {
        public static StreamWriter writer = File.CreateText("result.txt");
        static object block = new object();

        public static void ReadFile(object file)
        {
            StreamReader reader = new StreamReader((string)file);
            string result = reader.ReadToEnd();
            reader.Close();
            
            lock (block)
            {
                writer.WriteLine(result);                
            }

        }

        static void Main(string[] args)
        {
            
            var threads = new Thread[2];
            threads[0] = new Thread(ReadFile);
            threads[0].Start("file1.txt");
            threads[0].Join();

            threads[1] = new Thread(ReadFile);
            threads[1].Start("file2.txt");
            threads[1].Join();

            writer.Close();
        }
    }
}
