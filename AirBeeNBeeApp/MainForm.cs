using System;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class MainForm : Form
    {
        AirBeeNBee airBeeNBee;

        public MainForm()
        {
            InitializeComponent();

            airBeeNBee = new AirBeeNBee("Daniil Blagoev");
            airBeeNBee.AddCustomerTestData();
            foreach (BeeGroup beeGroup in airBeeNBee.BeeGroups)
            {
                lbBeeGroups.Items.Add(beeGroup.GetInfo());
            }

            cbBeeTypes.Items.Add(BeeType.DRONE.ToString());
            cbBeeTypes.Items.Add(BeeType.GUARD.ToString());
            cbBeeTypes.Items.Add(BeeType.HOUSEKEEPER.ToString());
            cbBeeTypes.Items.Add(BeeType.NECTARGATHERER.ToString());
            cbBeeTypes.Items.Add(BeeType.QUEEN.ToString());

            //airBeeNBee.AddHoneycombTestData();
        }

        private void btnAddHoneycomb_Click(object sender, EventArgs e)
        {
            lbHoneycombs.Items.Clear();

            if (cbBeeTypes.Text == "DRONE")
            {
                airBeeNBee.AddHoneycomb(Convert.ToInt32(tbNumberOfCells.Text), BeeType.DRONE);
            }
            else if (cbBeeTypes.Text == "GUARD")
            {
                airBeeNBee.AddHoneycomb(Convert.ToInt32(tbNumberOfCells.Text), BeeType.GUARD);
            }
            else if (cbBeeTypes.Text == "HOUSEKEEPER")
            {
                airBeeNBee.AddHoneycomb(Convert.ToInt32(tbNumberOfCells.Text), BeeType.HOUSEKEEPER);
            }
            else if (cbBeeTypes.Text == "NECTARGATHERER")
            {
                airBeeNBee.AddHoneycomb(Convert.ToInt32(tbNumberOfCells.Text), BeeType.NECTARGATHERER);
            }
            else if (cbBeeTypes.Text == "QUEEN")
            {
                airBeeNBee.AddHoneycomb(Convert.ToInt32(tbNumberOfCells.Text), BeeType.QUEEN);
            }

            foreach (Honeycomb honeycomb in airBeeNBee.Honeycombs)
            {
                lbHoneycombs.Items.Add(honeycomb.GetInfo());
            }
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            if (airBeeNBee.TryCreateBooking(airBeeNBee.BeeGroups[lbBeeGroups.SelectedIndex]))
            {
                MessageBox.Show("Booking successful :^]");
                lbBeeGroups.Items.RemoveAt(lbBeeGroups.SelectedIndex);
                lbBeeGroups.Items.Clear();
                foreach (BeeGroup beeGroup in airBeeNBee.BeeGroups)
                {
                    lbBeeGroups.Items.Add(beeGroup.GetInfo());
                }
            }
            else
            {
                MessageBox.Show("Booking unsuccessful >:^[");
            }
        }

        private void lbBeeGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBeeGroups.SelectedIndex == -1)
            {
                btnCreateBooking.Enabled = false;
            }
            else
            {
                btnCreateBooking.Enabled = true;
            }
        }

        private void btnViewHoneycomb_Click(object sender, EventArgs e)
        {
            HoneycombInfo honeycombInfo = new HoneycombInfo(this.airBeeNBee, lbHoneycombs.SelectedIndex);
            honeycombInfo.Show();
        }

        private void lbHoneycombs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHoneycombs.SelectedIndex == -1)
            {
                btnViewHoneycomb.Enabled = false;
            }
            else
            {
                btnViewHoneycomb.Enabled = true;
            }
        }
    }
}
