using System.Data;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false; // Keep check of whether the note is being edited or not

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            // Whenever we modify notes in the backend, the user display will be updated
            previousNotes.DataSource = notes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check the current cell that the user has selected in the notes grid and remove it from our data grid.
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Note a valid note");
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // Clear the text from the text boxes
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}