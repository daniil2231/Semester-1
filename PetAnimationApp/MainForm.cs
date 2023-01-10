using System;
using System.Windows.Forms;

namespace PetAnimationApp
{
    public partial class MainForm : Form
    {
        int originalLeft;
        int seconds;

        public MainForm()
        {
            InitializeComponent();
            originalLeft = pbPet.Left;
        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            pbPet.Left += 5;
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            tmrAnimation.Enabled = !tmrAnimation.Enabled;
            SetAnimateButtonText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrAnimation.Enabled = false;
            pbPet.Left = originalLeft;
            SetAnimateButtonText();
        }

        private void SetAnimateButtonText()
        {
            if (tmrAnimation.Enabled)
            {
                btnAnimate.Text = "Stop animation";
            }
            else
            {
                btnAnimate.Text = "Animate";
            }
        }

        private void btnStopwatch_Click(object sender, EventArgs e)
        {
            if (!tmrStopwatch.Enabled)
            {
                seconds = 0;
                lblStopwatch.Text = $"{seconds}";
                lblStopwatch.Text = $"00:00:00";
            }
            tmrStopwatch.Enabled = !tmrStopwatch.Enabled;
            SetStopwatchButtonText();
        }

        private void SetStopwatchButtonText()
        {
            if (tmrStopwatch.Enabled)
            {
                btnStopwatch.Text = "Stop watch";
            }
            else
            {
                btnStopwatch.Text = "Start watch";
            }
        }

        private void tmrStopwatch_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblStopwatch.Text = $"{seconds / 3600:D2}:{seconds / 60:D2}:{seconds % 60:D2}";
        }
    }
}
