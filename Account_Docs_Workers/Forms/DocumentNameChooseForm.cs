using System.Windows.Forms;

namespace Account_Docs_Workers.Forms
{
    public partial class DocumentNameChooseForm : Form
    {

        public DocumentNameChooseForm()
        {
            InitializeComponent();

            foreach (var document in StartPageForm.documents)
            {
                ChooseNameForDocumentDataGridView.Rows.Add(document);
            }
            AutoSizeColumns();
        }

        private void AutoSizeColumns()
        {
            for (int i = 0; i < ChooseNameForDocumentDataGridView.Columns.Count; i++)
            {
                ChooseNameForDocumentDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkerListForm.workerCardForm.DocumentNameTextBox.Text = StartPageForm.documents[e.RowIndex];
            
            WorkerListForm.workerCardForm.Refresh();
            Close();
        }
    }
}
