using System;
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
        /// полностью перезаписывает/перезаписывает файл с данными о работниках и документах в формате XML    <br/>
        /// по заданному пути
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
                XElement birthDay = new XElement("birthDay", worker.BirthDay.Ticks);
                XElement documentsXElements = new XElement("issuedDocuments", "");

                if (worker.IssuedDocuments.Count != 0)
                {
                    documentsXElements = new XElement("issuedDocuments");
                    foreach (var document in worker.IssuedDocuments)
                    {
                        XElement docName = new XElement("docName", document.name);
                        XElement docDate = new XElement("docDate", document.dateOfIssue.Ticks);
                        documentsXElements.Add(new XElement("document", docName, docDate));
                    }
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

            XElement documentsXElements = new XElement("issuedDocuments", "");

            if (worker.IssuedDocuments.Count != 0)
            {
                documentsXElements = new XElement("issuedDocuments");
                foreach (var document in worker.IssuedDocuments)
                {
                    XElement docName = new XElement("docName", document.name);
                    XElement docDate = new XElement("docDate", document.dateOfIssue);
                    documentsXElements.Add(new XElement("document", docName, Convert.ToInt64(docDate)));
                }
            }

            xml.Root.Add(new XElement("WORKER", unicNumber, name, surname, patronymic, birthDay, documentsXElements));
            xml.Save(path);
        }
    }
}

