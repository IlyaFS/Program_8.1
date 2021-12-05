using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Program_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Илья\\YandexDisk\\_work_";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Папки:");
                string[] folder = Directory.GetDirectories(path); // папки

                foreach (string a in folder)
                {
                    Console.WriteLine(a);

                    string[] infolder = Directory.GetDirectories(a);

                    foreach (string c in infolder)
                    {
                        Console.WriteLine(c);
                    }
                }
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path); // файлы

                foreach (string b in files)
                {
                    Console.WriteLine(b);
                }
            }
            Console.ReadKey();
        }
    }
}
