using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\zm1142\\source\\repos\\Files\\Files\\data.csv";

            StreamReader reader = null;

            if (File.Exists(fileName))
            {
                reader = new StreamReader(File.OpenRead(fileName));
                List<string> data = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    
                    foreach (var item in values)
                    {
                        data.Add(item);
                        Console.Write(item);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
       
        }
        
    }
}
