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
            List<List<string>> data = new List<List<string>>();
            
            if (File.Exists(fileName))
            {
                reader = new StreamReader(File.OpenRead(fileName));
               
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    List<string> col = new List<string>();
                    foreach (var i in values)
                    {
                        col.Add(i);
                        //Console.Write(item);
                        //Console.Write(" ");
                    }
                    data.Add(col);
                    //Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }


            printData(data);
        }

        public static void printData(List<List<string>> data)
        {
            foreach (var line in data)
            {
                foreach (var col in line) 
                {
                    Console.Write(col);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
