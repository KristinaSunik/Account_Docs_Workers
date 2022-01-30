using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class StartPageForm : Form
    {
        public static List<Worker> workers = new List<Worker>();
        public static string path;

        public StartPageForm()
        {
            InitializeComponent();
            path = Directory.GetCurrentDirectory() + "Workers_Documents.xml";
            //workers.Add(new Worker("Кристина", "Шуканова", "Олеговна", new DateTime(1988, 9, 14)));
            //workers.Add(new Worker("Никифороов", "Андрей", "Алексеевич", new DateTime(1985, 10, 25)));
            //workers.Add(new Worker("Иванов", "Иван", "Иванович", new DateTime(1980, 2, 7)));

            //FileProvider.SerializeWorker(path, workers);
            if (workers.Count == 0)
            {
                Worker.AddWorkersToList(ref workers, path);
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
