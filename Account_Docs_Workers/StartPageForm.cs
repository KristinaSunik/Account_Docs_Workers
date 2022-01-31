using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class StartPageForm : Form
    {
        public static string pathWorkers;
        public static string pathDocuments;
        public static List<Worker> workers = new List<Worker>();
        public static List<string> documents = new List<string>();
       
        public StartPageForm()
        {
            InitializeComponent();
            pathWorkers = Directory.GetCurrentDirectory() + "\\Workers_Documents.xml";
            pathDocuments = Directory.GetCurrentDirectory() + "\\Names_Documents.xml";
            if (!File.Exists(pathWorkers) || !File.Exists(pathDocuments))
            {
                TemporaryMethodToFillInTables();
            }

            if (workers.Count == 0)
            {
                Worker.AddWorkersToList(ref workers, pathWorkers);
            }
            if (documents.Count == 0)
            {
                Document.AddDocNamesToList(ref documents, pathDocuments);
            }
        }

        private static void TemporaryMethodToFillInTables()
        {
            if (!File.Exists(pathWorkers))
            {
                workers.Add(new Worker("Кристина", "Шуканова", "Олеговна", new DateTime(1988, 9, 14)));
                workers.Add(new Worker("Никифороов", "Андрей", "Алексеевич", new DateTime(1985, 10, 25)));
                workers.Add(new Worker("Иванов", "Иван", "Иванович", new DateTime(1980, 2, 7)));

                FileProvider.SerializeWorker(pathWorkers, workers);
            }

            if (!File.Exists(pathDocuments))
            {
                documents = new List<string>{
                "Схема тайных ходов Кремля",
                "Обязательство о неразглашении №12",
                "Военная тайна №52",
                "Архив пациентов №10",
                "Дело №43"};

                FileProvider.SerializeDocument(pathDocuments, documents);
            }
        }

        private void WorkersListButton_Click(object sender, EventArgs e)
        {
            var workersListForm = new WorkerListForm(workers);
            workersListForm.Show();
        }

        private void DocumentsListButton_Click(object sender, EventArgs e)
        {
            var documentsListForm = new DocumentsListForm(workers);
            documentsListForm.Show();
        }

        private void AddNewWorkerButton_Click(object sender, EventArgs e)
        {
            var addNewWorkerForm = new AddNewWorkerForm();
            addNewWorkerForm.Show();
        }
    }
}
