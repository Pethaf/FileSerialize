using FileSerialize;
using System;
using System.IO;

namespace FilesSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonSerializer ps = new($"{Path.Join(Directory.GetCurrentDirectory(), "slask")}");
            //ps.SerializeInOneFile(Data.People);
            //ps.SerializeIManyFiles(Data.People);
            PersonDeserializer pd = new($"{ Path.Join(Directory.GetCurrentDirectory(), "slask")}");
            //foreach (var person in pd.ReadFromSingleFile("persons.txt"))
            //{
            //    Console.WriteLine($"{person.Id} {person.Name} {person.Age}");
            //}
            foreach (var person in pd.ReadFromManyFiles())
            {
                Console.WriteLine($"{person.Id} {person.Name} {person.Age}");
            }

        }
    }
}