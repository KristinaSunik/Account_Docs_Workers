using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class DocumentsListForm : Form
    {
        public DocumentsListForm(List<Worker> workers)
        {
            InitializeComponent();

            var workersWithDocuments = workers.FindAll(x => x.IssuedDocuments.Count != 0);

            foreach (var worker in workersWithDocuments)
            {
                foreach (var document in worker.IssuedDocuments)
                {
                    documentsListDataGridView.Rows
                        .Add(document.Name, $"{worker.Surname} {worker.Name} {worker.Patronymic}", document.DateOfIssue);
                }
            }

            AutosizeColumn();
        }

        private void AutosizeColumn()
        {
            for (int i = 0; i < documentsListDataGridView.Columns.Count; i++)
            {
                documentsListDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
