using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Docs_Workers
{
    class Worker
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime BirthDay { get; private set; }

        public Worker(string name, string surname, string patronymic, DateTime birthDay)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDay = birthDay;
        }
    }
}
