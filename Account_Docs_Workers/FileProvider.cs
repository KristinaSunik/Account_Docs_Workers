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
        /// чтение XML файла
        /// </summary>
        /// <param name="path">путь к файлу для чтения</param>
        public static List<XElement> Deserialize(string path, string descendant)
        {
            string xml = File.ReadAllText(path);
            if (xml != "")
            {
                return XDocument.Parse(xml)
                    .Descendants(descendant)
                    .ToList();
            }

            return null;
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
                        XElement docName = new XElement("docName", document.Name);
                        XElement docDate = new XElement("docDate", document.DateOfIssue.Ticks);
                        documentsXElements.Add(new XElement("document", docName, docDate));
                    }
                }

                XElement workerXElement = new XElement("WORKER", unicNumber, name, surname, patronymic, birthDay, documentsXElements);
                workersXElements.Add(workerXElement);
            }

            workersXElements.Save(path);
        }

        /// <summary>
        /// полностью перезаписывает/перезаписывает файл с названиями документов в формате XML    <br/>
        /// по заданному пути
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <param name="documents">список документов</param>
        public static void SerializeDocument(string path, List<string> documents)
        {
            XElement documentsXElements = new XElement("DOCUMENT");

            foreach (var document in documents)
            {
                documentsXElements.Add(new XElement("name", document));
            }

            documentsXElements.Save(path);
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
            XElement birthDay = new XElement("birthDay", Convert.ToInt64(worker.BirthDay.Ticks));

            XElement documentsXElements = new XElement("issuedDocuments");

            if (worker.IssuedDocuments.Count != 0)
            {
                foreach (var document in worker.IssuedDocuments)
                {
                    XElement docName = new XElement("docName", document.Name);
                    XElement docDate = new XElement("docDate", Convert.ToInt64(document.DateOfIssue.Ticks));
                    documentsXElements.Add(new XElement("document", docName, docDate));
                }
            }

            xml.Root.Add(new XElement("WORKER", unicNumber, name, surname, patronymic, birthDay, documentsXElements));
            xml.Save(path);
        }

        /// <summary>
        /// дозаписывает в формат hml данные по новому документу, введенные пользователем
        /// </summary>
        /// <param name="path">файл куда дозаписывается информация</param>
        /// <param name="document">имя нового документа</param>
        public static void AddDocumentToFile(string path, String document)
        {
            XDocument xml = XDocument.Load(path);
            xml.Root.Add(new XElement("name", document));
            xml.Save(path);
        }
    }
}

