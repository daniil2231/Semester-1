using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutBrewerService
{
    public partial class FormBrewer : Form
    {
        BreweryService bs;

        public FormBrewer()
        {
            InitializeComponent();
        }

        public FormBrewer(BreweryService bs, Brewer brewer)
        {
            InitializeComponent();
            this.bs = bs;
            lblBrewerInfo.Text = brewer.GetInfo();
            double totalAmountOfBeer = 0;
            foreach (Tank tank in brewer.ClaimedTanks)
            {
                totalAmountOfBeer = totalAmountOfBeer + tank.AmountOfBeer;
                listBox1.Items.Add(tank.GetInfo());
            }
            listBox1.Items.Add("**************************************");
            listBox1.Items.Add($"Total amount of beer is: {totalAmountOfBeer}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
