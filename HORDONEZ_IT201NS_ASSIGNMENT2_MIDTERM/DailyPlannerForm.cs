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
    public partial class DailyPlannerForm : Form
    {
        public DailyPlannerForm()
        {
            InitializeComponent();
        }

        private void DailyPlannerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string taskName = txtTask.Text.Trim();

                if (string.IsNullOrEmpty(taskName))
                    throw new Exception("Please enter a task name.");

                if (cboPrio.SelectedItem == null)
                    throw new Exception("Please select a priority level.");

                string priority = cboPrio.SelectedItem.ToString();

                switch (priority)
                {
                    case "High":
                        lstHighPrio.Items.Add(taskName);
                        break;
                    case "Medium":
                        lstMedPrio.Items.Add(taskName);
                        break;
                    case "Low":
                        lstLowPrio.Items.Add(taskName);
                        break;
                    default:
                        MessageBox.Show("Invalid priority selection.");
                        break;
                }

                txtTask.Clear();
                cboPrio.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Validation Error");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstHighPrio.SelectedIndex != -1)
                lstHighPrio.Items.RemoveAt(lstHighPrio.SelectedIndex);
            else if (lstMedPrio.SelectedIndex != -1)
                lstMedPrio.Items.RemoveAt(lstMedPrio.SelectedIndex);
            else if (lstLowPrio.SelectedIndex != -1)
                lstLowPrio.Items.RemoveAt(lstLowPrio.SelectedIndex);
            else
                MessageBox.Show("Please select a task to remove.", "Selection Required");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTask.Clear();
            cboPrio.SelectedIndex = -1;
        }
    }
}
