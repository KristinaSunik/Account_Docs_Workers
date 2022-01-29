using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Docs_Workers
{
    public class Document
    {
        public string name { get; private set; }
        public DateTime dateOfIssue { get; private set; }

        public Document(string name)
        {
            this.name = name;
            dateOfIssue = DateTime.Now;
        }
    }
}
