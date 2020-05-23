using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork17._05.SOLID.O
{
    class ReadFromDb
    {
        public List<Tmodel> ReadAllFromTable<Tmodel>(IReadAllFromTable read)
        {
            return read.ReadAllFromTable<Tmodel>();
        }
    }
    interface IReadAllFromTable
    {
        List<TModel> ReadAllFromTable<TModel>();
    }
    class ReadFromPerson : IReadAllFromTable
    {
        public List<Person> ReadAllFromTable<Person>()
        {
            return new List<Person>();
        }
    }
    class ReadFromCompany : IReadAllFromTable
    {
        public List<Company> ReadAllFromTable<Company>()
        {
            return new List<Company>();
        }
    }
    class Person
    { 

    }
    class Company
    { 
    
    }
}
