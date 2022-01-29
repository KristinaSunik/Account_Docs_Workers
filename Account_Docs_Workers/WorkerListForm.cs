using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class WorkerListForm : Form
    {
        public static List<Worker> workers = new List<Worker>();
        public static string path;

        public WorkerListForm()
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

            foreach (var worker in workers)
            {
                workerListDataGridView.Rows.Add(worker.Name, worker.Surname, worker.Patronymic);
            }
        }

        private void workerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker currentWorker = workers[e.RowIndex];

            var workerCardForm = new WorkerCardForm(currentWorker);
            workerCardForm.Show();
        }
    }
}
