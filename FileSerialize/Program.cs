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
            ps.SerializeInOneFile(Data.People);

        }
    }
}