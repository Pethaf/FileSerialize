using FilesSerialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSerialize
{
    class PersonSerializer
    {
        private string _path;

        public PersonSerializer(string thePath)
        {
            this._path = thePath;
        }
        public void SerializeInOneFile(List<FilesSerialize.Person> Lop)
        {
            string completePath = System.IO.Path.Join(_path, "persons.txt");
            using(StreamWriter sw = new StreamWriter(completePath))
            {
               
                foreach (var person in Lop)
                {
                    sw.WriteLine($"{person.Id},{person.Name},{person.Age}");
                }
            }
        }
        public void SerializeIManyFiles(List<Person> LOP)
        {
            foreach(Person thePerson in LOP)
            {

            }
        }
    }
}
