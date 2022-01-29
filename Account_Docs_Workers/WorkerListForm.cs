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
    public partial class WorkerListForm : Form
    {
        private List<Worker> workers = new List<Worker>();

        public WorkerListForm()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory() + "Workers_Documents.xml";
            workers.Add(new Worker("Кристина", "Шуканова", "Олеговна", new DateTime(1988, 9, 14)));
            workers.Add(new Worker("Никифороов", "Андрей", "Алексеевич", new DateTime(1985, 10, 25)));
            workers.Add(new Worker("Иванов", "Иван", "Иванович", new DateTime(1980, 2, 7)));

            FileProvider.SerializeWorker(path, workers);
            workers = Worker.AddWorkersToList(workers, path);

            foreach (var worker in workers)
            {
                workerListDataGridView.Rows.Add(worker.Name, worker.Surname, worker.Patronymic);
            }
        }

        private void workerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker currentWorker = workers[e.RowIndex];
            //WorkerCardForm();
        }
    }
}
