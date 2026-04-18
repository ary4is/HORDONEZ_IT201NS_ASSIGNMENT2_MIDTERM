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

        private void UpdateLabel()
        {
            int min = timeLeft / 60;
            int sec = timeLeft % 60;

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

        private void focusTimer_Tick_1(object sender, EventArgs e)
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
    }
}
