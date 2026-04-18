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
    public partial class HabitTrackerForm : Form
    {
        public HabitTrackerForm()
        {
            InitializeComponent();
        }

        private void HabitTrackerForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
            txtHabitTitle.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string habit = txtHabitTitle.Text.Trim();

                if (string.IsNullOrEmpty(habit))
                {
                    throw new Exception("Please enter a habit title.");
                }

                lstHabits.Items.Add($"[ ] {habit}");

                txtHabitTitle.Clear();
                txtHabitTitle.Focus();
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedIndex != -1)
            {
                int index = lstHabits.SelectedIndex;
                string currentItem = lstHabits.Items[index].ToString();

                if (currentItem.StartsWith("[ ]"))
                {
                    string updatedHabit = currentItem.Replace("[ ]", "[✔]");
                    lstHabits.Items[index] = updatedHabit;
                }
                else
                {
                    MessageBox.Show("This habit is already completed!", "Information");
                }
            }
            else
            {
                MessageBox.Show("Please select a habit to mark as done.", "Selection Required");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstHabits.SelectedIndex != -1)
            {
                lstHabits.Items.RemoveAt(lstHabits.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a habit to remove.", "Selection Required");
            }
        }
    }
}
