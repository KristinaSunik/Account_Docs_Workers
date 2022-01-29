using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Docs_Workers
{
    class Worker
    {
        public Guid UnicNumber { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime BirthDay { get; private set; }
        public List<string> IssuedDocuments { get; private set; }

        /// <summary> Абсолютно новый работник </summary>
        public Worker(string name, string surname, string patronymic, DateTime birthDay)
        {
            UnicNumber = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDay = birthDay;
            IssuedDocuments = new List<string>();
        }


        /// <summary> Для считывания работников из файла</summary>
        public Worker(Guid uniqNumber, string name, string surname, string patronymic, DateTime birthDay, List<string> issuedDocuments)
        {
            UnicNumber = uniqNumber;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDay = birthDay;
            IssuedDocuments = issuedDocuments;
        }

        /// <summary>
        /// записывает всех работников и их данные в список, через структуру Worker
        /// </summary>
        /// <param name="workers">пустой список работников</param>
        public static List<Worker> AddWorkersToList(List<Worker> workers, string path)
        {
            var workersFromFile = FileProvider.DeserializeWorker(path);
            foreach (var workerXElement in workersFromFile)
            {
                Guid unicNumber = new Guid(workerXElement.Element("unicNumber").Value);
                String name = workerXElement.Element("name").Value;
                String surname = workerXElement.Element("surname").Value;
                String patronymic = workerXElement.Element("patronymic").Value;
                DateTime birthDay = new DateTime(Convert.ToInt64(workerXElement.Element("birthDay").Value));
                List<string> issuredDocuments = new List<string>();
                var element = workerXElement.Element("issuedDocuments").Value;
                if (element != "")
                {
                    //issuredDocuments = workerXElement.Element("issuedDocuments").Value;
                }
                workers.Add(new Worker(unicNumber, name, surname, patronymic, birthDay, issuredDocuments));
            }

            return workers;
        }
    }
}
