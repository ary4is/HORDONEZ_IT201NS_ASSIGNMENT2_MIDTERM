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
    public partial class MDIProductivityDashboard : Form
    {
        public MDIProductivityDashboard()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm.GetType() == childForm.GetType())
                {
                    openForm.Activate();
                    return;
                }
            }

            // If not open, set parent and show
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void dailyPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyPlannerForm());
        }

        private void habitTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HabitTrackerForm());
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NotesForm());
        }

        private void focusTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FocusTimerForm());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dailyPlannerToolStripLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DailyPlannerForm());
        }

        private void habitTrackerToolStripLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HabitTrackerForm());
        }

        private void notesToolStripLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NotesForm());
        }

        private void focusTimerToolStripLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FocusTimerForm());
        }

        private void aboutToolStripLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new About());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new About());
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
