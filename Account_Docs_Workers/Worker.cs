using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Docs_Workers
{
    public class Worker
    {
        public Guid UnicNumber { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime BirthDay { get; private set; }
        public List<Document> IssuedDocuments { get; private set; }

        /// <summary> Абсолютно новый работник </summary>
        public Worker(string name, string surname, string patronymic, DateTime birthDay)
        {
            UnicNumber = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            BirthDay = birthDay;
            IssuedDocuments = new List<Document>();
        }


        /// <summary> Для считывания работников из файла</summary>
        public Worker(Guid uniqNumber, string name, string surname, string patronymic, DateTime birthDay, List<Document> issuedDocuments)
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
        public static void AddWorkersToList(ref List<Worker> workers, string path)
        {
            var workersFromFile = FileProvider.DeserializeWorker(path);
            foreach (var workerXElement in workersFromFile)
            {
                Guid unicNumber = new Guid(workerXElement.Element("unicNumber").Value);
                string name = workerXElement.Element("name").Value;
                string surname = workerXElement.Element("surname").Value;
                string patronymic = workerXElement.Element("patronymic").Value;
                DateTime birthDay = new DateTime(Convert.ToInt64(workerXElement.Element("birthDay").Value));
                List<Document> issuredDocuments = new List<Document>();
                //var documentsXElement = workerXElement.Element();
                //foreach (var item in documentsXElement)
                //{

                //    var element = workerXElement.Element("issuedDocuments").Value;
                //    if (element != "")
                //    {
                //        //issuredDocuments = workerXElement.Element("issuedDocuments").Value;
                //    }
                //}
                workers.Add(new Worker(unicNumber, name, surname, patronymic, birthDay, issuredDocuments));
            }
        }
    }
}
