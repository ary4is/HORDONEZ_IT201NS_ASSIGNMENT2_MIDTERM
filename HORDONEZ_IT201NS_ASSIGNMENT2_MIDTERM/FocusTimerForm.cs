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
    public partial class FocusTimerForm : Form
    {
        public FocusTimerForm()
        {
            InitializeComponent();
        }

        private void FocusTimerForm_Load(object sender, EventArgs e)
        {

        }

        private int timeLeft;

        private void focusTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateLabel();
            }
            else
            {
                focusTimer.Stop();
                MessageBox.Show("Time's up!");
            }
        }

        private void UpdateLabel()
        {
            // This math turns total seconds into Minutes : Seconds
            int min = timeLeft / 60;
            int sec = timeLeft % 60;

            // The "D2" ensures it always has 2 digits (e.g., 05 instead of 5)
            lblTimer.Text = $"{min:D2}:{sec:D2}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int minutes = int.Parse(txtTime.Text);
                timeLeft = minutes * 60;

                UpdateLabel();
                focusTimer.Start();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number of minutes!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            focusTimer.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            focusTimer.Stop();
            timeLeft = 0;
            txtTime.Clear();
            lblTimer.Text = "00:00";
        }
    }
}
