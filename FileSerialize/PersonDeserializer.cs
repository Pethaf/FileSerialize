using FilesSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSerialize
{
    class PersonDeserializer
    {
        private string _path;
        public PersonDeserializer(string thePath)
        {
            this._path = thePath;
        }
        public List<Person> ReadFromSingleFile(string fileName)
        {
            List<Person> LOP = new();
            using (StreamReader sr = new StreamReader($"{System.IO.Path.Join(_path, fileName)}"))
            {
                while (!sr.EndOfStream)
                {
                    var personString = sr.ReadLine();
                    var personProps = personString.Split(",");
                    var newPerson = new Person() { Id = Convert.ToInt32(personProps[0]), Age = Convert.ToInt32(personProps[2]), Name = personProps[1] };
                    LOP.Add(newPerson);

                }
                return LOP; 
            }
        }
        public List<Person> ReadFromManyFiles()
        {
            List<Person> LOP = new List<Person>();
            var allFiles = Directory.GetFileSystemEntries(_path);
            List<String> filesToRead = new List<string>();
            foreach (string file in allFiles)
            {
                if (Path.GetFileName(file).StartsWith("person_"))
                {
                    filesToRead.Add(Path.GetFileName(file));
                }
                
            }
            
            foreach(var fileName in filesToRead)
            {
                using (StreamReader sr = new StreamReader(System.IO.Path.Join(_path, fileName)))
                {
                    LOP.Add(new Person() { Id = Convert.ToInt32(sr.ReadLine()), Name = sr.ReadLine(), Age = Convert.ToInt32(sr.ReadLine()) });
                }


            }
            return LOP;
        }

    }
}
