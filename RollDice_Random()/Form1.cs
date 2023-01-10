using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14_PracticalAssignment6
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(tbDiceAmount.Text); i++)
            {
                int rolledNum = random.Next(1, 7);
                Dice dice = new Dice(rolledNum);
                dice.Show();
            }
        }
    }
}
