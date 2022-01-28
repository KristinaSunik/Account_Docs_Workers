using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Account_Docs_Workers
{
    class FileProvider
    {
        /// <summary>
        /// чтение XML файла с работниками и документами 
        /// </summary>
        /// <param name="path">путь к файлу для чтения</param>
        /// <returns>список работников</returns>
        public static List<XElement> DeserializeWorker(string path)
        {
            string xml = File.ReadAllText(path);
            var workersFromFile = XDocument.Parse(xml)
                .Descendants("WORKER")
                .ToList();
            return workersFromFile;
        }

        /// <summary>
        /// полностью перезаписывает файл с данными о работниках и документах в формате XML
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <param name="workers">список работников</param>
        public static void SerializeWorker(string path, List<Worker> workers)
        {
            XElement workersXElements = new XElement("AllWorkers");

            foreach (var worker in workers)
            {
                XElement unicNumber = new XElement("unicNumber", worker.UnicNumber);
                XElement name = new XElement("name", worker.Name);
                XElement surname = new XElement("surname", worker.Surname);
                XElement patronymic = new XElement("patronymic", worker.Patronymic);
                XElement birthDay = new XElement("birthDay", worker.BirthDay);

                XElement documentsXElements = new XElement("issuedDocuments");
                foreach (var document in worker.IssuedDocuments)
                {
                    XElement documentXElement = new XElement("document", document);
                    documentsXElements.Add(documentXElement);
                }

                XElement workerXElement = new XElement("WORKER", unicNumber, name, surname, patronymic, birthDay, documentsXElements);
                workersXElements.Add(workerXElement);
            }

            workersXElements.Save(path);
        }

        /// <summary>
        /// дозаписывает в формат hml данные по новому сотруднику, введенные пользователем
        /// </summary>
        /// <param name="path">файл куда дозаписывается информация</param>
        /// <param name="worker">данные по работнику новому</param>
        public static void AddWorkerToFile(string path, Worker worker)
        {                                                                                                                                                                  
            XDocument xml = XDocument.Load(path);
            XElement unicNumber = new XElement("unicNumber", worker.UnicNumber);
            XElement name = new XElement("name", worker.Name);
            XElement surname = new XElement("surname", worker.Surname);
            XElement patronymic = new XElement("patronymic", worker.Patronymic);
            XElement birthDay = new XElement("birthDay", worker.BirthDay);

            XElement documentsXElements = new XElement("documents");
            foreach (var document in worker.IssuedDocuments)
            {
                XElement issuedDocument = new XElement("issuedDocument", document);
                documentsXElements.Add(issuedDocument);
            }

            xml.Root.Add(new XElement("WORKER", unicNumber, name, surname, patronymic, birthDay, documentsXElements));
            xml.Save(path);
        }
    }
}

