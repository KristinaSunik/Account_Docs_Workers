using System;
using System.Collections.Generic;

namespace Account_Docs_Workers
{
    public class Document
    {
        public string Name { get; private set; }
        public DateTime DateOfIssue { get; private set; }

        /// <summary> Выдача документа нового </summary>
        public Document(string name)
        {
            Name = name;
            DateOfIssue = DateTime.Now;
        }

        /// <summary> Чтение из файла </summary>
        public Document(string name, DateTime date)
        {
            Name = name;
            DateOfIssue = date;
        }

        /// <summary>
        /// записывает все названия документов из файла в список
        /// </summary>
        /// <param name="documents">пустой список названий документов</param>
        public static void AddDocNamesToList(ref List<string> documents, string path)
        {
            var docsFromFile = FileProvider.Deserialize(path, "name");
            foreach (var docXElement in docsFromFile)
            {
                documents.Add(docXElement.Value);
            }
        }
    }
}
