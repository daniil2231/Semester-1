using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14_Practice
{
    public partial class Form1 : Form
    {
        private Car car1;
        private Car car2;
        private Car car3;
        public Form1()
        {
            InitializeComponent();
            // Select the fist car
            this.car1 = new Car();
            this.car1.SetModel("Porsche 911 Turbo");
            this.car1.SetTopSpeed(320);
            this.car1.SetSpeed(0);

            this.car2 = new Car();
            this.car2.SetModel("Ferrari  812 GTS");
            this.car2.SetTopSpeed(340);
            this.car2.SetSpeed(0);

            this.car3 = new Car();
            this.car3.SetModel("Volkswagen Beetle");
            this.car3.SetTopSpeed(130);
            this.car3.SetSpeed(0);

            cbbCars.Items.Add(this.car1.GetModel());
            cbbCars.Items.Add(this.car2.GetModel());
            cbbCars.Items.Add(this.car3.GetModel());
            cbbCars.SelectedIndex = 0;
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(nudSpeed.Value);
            this.GetSelectedCar().Accelerate(speed);    
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            this.GetSelectedCar().Break();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.GetSelectedCar().GetInfo());
        }

        private Car GetSelectedCar()
        {
            switch (cbbCars.SelectedIndex)
            {
                case 1:
                    return this.car2; 
                    break;
                case 2:
                    return this.car3;
                    break;
                case 0:
                default:
                    return this.car1;
                    break;
            }
        }        
    }
}
