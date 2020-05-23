using System;
using HomeWork17._05.SOLID.O;
using HomeWork17._05.SOLID.S;
using System.Collections.Generic;

namespace HomeWork17._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadFromDb read = new ReadFromDb();
            //var listP = read.ReadAllFromTable<Person>(new ReadFromPerson());
            //var listC = read.ReadAllFromTable<Company>(new ReadFromCompany());
            Reader r = new Reader();
            r.Path = @"C:\Users\Рухшод Назаров\source\repos\HomeWork17.05\HomeWork17.05\1.txt";
            var s = r.Read();
            r.Write(new Writer(), s);
            Console.WriteLine("sd");
        }
    }
}
