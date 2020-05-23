using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace HomeWork17._05.SOLID.S
{
    class Reader
    { 
        public string Path { get; set; }
        public List<string> Read()
        {
            using(FileStream ff = new FileStream(Path,FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(ff))
                {
                    return reader.ReadToEnd().Split(' ').ToList();
                }
            }
        }
        public void Write(IWriter writer,List<string> list)
        {
            writer.Write(list);
        }
    }
    class Writer : IWriter
    {
        public void Write(List<string> list)
        {
            Console.Write("Введите путь: ");
            string path = @Console.ReadLine();
            using (FileStream ff = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(ff))
                { 
                    foreach(var item in list)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
        }
    }
    interface IWriter
    {
        void Write(List<string> list);
    }
}
