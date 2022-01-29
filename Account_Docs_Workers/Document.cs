using System;

namespace Account_Docs_Workers
{
    public class Document
    {
        public string name { get; private set; }
        public DateTime dateOfIssue { get; private set; }

        /// <summary> Выдача документа нового </summary>
        public Document(string name)
        {
            this.name = name;
            dateOfIssue = DateTime.Now;
        }

        /// <summary> Чтение из файла </summary>
        public Document(string name, DateTime date)
        {
            this.name = name;
            dateOfIssue = date;
        }
    }
}
