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
    public partial class Dice : Form
    {
        public Dice(int roll)
        {
            InitializeComponent();
            if (roll == 1)
            {
                pictureBox1.ImageLocation = "C:/Users/35988/Desktop/uni/Software Engineering/Week14_Practice/Resources/DiceFace1.png";
            }
            else if (roll == 2)
            {
                pictureBox1.ImageLocation = "C:/Users/35988/Desktop/uni/Software Engineering/Week14_Practice/Resources/DiceFace2.png";
            }
            else if (roll == 3)
            {
                pictureBox1.ImageLocation = "C:/Users/35988/Desktop/uni/Software Engineering/Week14_Practice/Resources/DiceFace3.png";
            }
            else if (roll == 4)
            {
                pictureBox1.ImageLocation = "C:/Users/35988/Desktop/uni/Software Engineering/Week14_Practice/Resources/DiceFace4.png";
            }
            else if (roll == 5)
            {
                pictureBox1.ImageLocation = "C:/Users/35988/Desktop/uni/Software Engineering/Week14_Practice/Resources/DiceFace5.png";
            }
            else
            {
                pictureBox1.ImageLocation = "C:/Users/35988/Desktop/uni/Software Engineering/Week14_Practice/Resources/DiceFace6.png";
            }
        }
    }
}
