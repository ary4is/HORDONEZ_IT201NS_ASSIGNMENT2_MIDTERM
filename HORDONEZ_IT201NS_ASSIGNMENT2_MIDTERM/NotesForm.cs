using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HORDONEZ_IT201NS_ASSIGNMENT2_MIDTERM
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {

        }

        private Dictionary<string, string> notesStorage = new Dictionary<string, string>();

        private void ClearInputs()
        {
            txtNoteTitle.Clear();
            txtNotes.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtNoteTitle.Text.Trim();
                string content = txtNotes.Text.Trim();

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
                {
                    throw new Exception("Please provide both a Title and Note content.");
                }

                if (notesStorage.ContainsKey(title))
                {
                    notesStorage[title] = content;
                    MessageBox.Show("Note updated successfully!", "Success");
                }
                else
                {
                    notesStorage.Add(title, content);
                    lstNotes.Items.Add(title);
                    MessageBox.Show("Note saved!", "Success");
                }

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Validation Error");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem != null)
            {
                string selectedTitle = lstNotes.SelectedItem.ToString();
                txtNoteTitle.Text = selectedTitle;
                txtNotes.Text = notesStorage[selectedTitle];
            }
            else
            {
                MessageBox.Show("Please select a note from the list to open.", "Selection Required");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedItem != null)
            {
                string selectedTitle = lstNotes.SelectedItem.ToString();
                notesStorage.Remove(selectedTitle);
                lstNotes.Items.Remove(selectedTitle);
                ClearInputs();
            }
        }
    }
}
