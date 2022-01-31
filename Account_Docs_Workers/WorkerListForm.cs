using System.Collections.Generic;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class WorkerListForm : Form
    {
        private static List<Worker> _workers = new List<Worker>();
        public static WorkerCardForm workerCardForm;
        public WorkerListForm(List <Worker> workers)
        {
            _workers = workers;

            InitializeComponent();
           
            foreach (var worker in workers)
            {
                workerListDataGridView.Rows.Add(worker.Name, worker.Surname, worker.Patronymic);
            }

            AutosizeColumn();
        }

        private void workerListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Worker currentWorker = _workers[e.RowIndex];

            workerCardForm = new WorkerCardForm(currentWorker);
            workerCardForm.Show();
        }

        private void AutosizeColumn()
        {
            for (int i = 0; i < workerListDataGridView.Columns.Count; i++)
            {
                workerListDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
