using System.Windows.Forms;

namespace Account_Docs_Workers
{
    public partial class DocumentNameChooseForm : Form
    {
        public static string choosedDoc;
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
            choosedDoc = StartPageForm.documents[e.RowIndex];
            this.Close();
            WorkerListForm.workerCardForm.Refresh();
        }
    }
}
