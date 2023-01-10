using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace S_Week14_Reservation
{
    public partial class MainForm : Form
    {
        private List<Reservation> reservations = new List<Reservation>();

        public MainForm()
        {
            InitializeComponent();
            foreach (RoomType roomType in Enum.GetValues(typeof(RoomType)))
            {
                cbRoomType.Items.Add(roomType.ToString());
            }
            cbRoomType.SelectedIndex = 0;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (reservations.Count > 0)
            {
                Reservation lastReservation = reservations[reservations.Count - 1];
                lastReservation.AddRoom((RoomType)Enum.Parse(typeof(RoomType), cbRoomType.Text), rbSmoking.Checked);
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            reservations.Add(new Reservation(tbName.Text, (int)numericUpDown1.Value));
        }

        private void tabHotelManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabHotelManagement.SelectedIndex == 1)
            {
                // Re-build reservations
                lvReservations.Items.Clear();
                foreach (Reservation reservation in reservations)
                {
                    lvReservations.Items.Add(new ListViewItem(
                        new string[]
                        {
                            reservation.GetInfo(), $"€ {reservation.GetTotalPrice():f2}"
                        }));
                }
            }
        }
    }
}
