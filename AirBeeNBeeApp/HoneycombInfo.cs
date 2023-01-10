using System;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class HoneycombInfo : Form
    {
        AirBeeNBee airBeeNBee;

        public HoneycombInfo()
        {
            InitializeComponent();
        }

        public HoneycombInfo(AirBeeNBee airBeeNBee, int indexOfSelectedComb)
        {
            InitializeComponent();
            this.airBeeNBee = airBeeNBee;
            lblName.Text = $"The id of this honeycomb is {airBeeNBee.Honeycombs[indexOfSelectedComb].Id}";
            foreach (BeeType beeType in airBeeNBee.Honeycombs[indexOfSelectedComb].AcceptedBeeTypes)
            {
                lbAcceptedBeeTypes.Items.Add(beeType.ToString());
            }

            lblNumberOfCells.Text = airBeeNBee.Honeycombs[indexOfSelectedComb].NumberOfCells.ToString();
            foreach (BeeGroup beeGroup in airBeeNBee.Honeycombs[indexOfSelectedComb].BeeGroupGuests)
            {
                lbGuests.Items.Add(beeGroup.GetInfo());
            }
        }
    }
}
