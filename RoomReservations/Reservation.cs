using System.Collections.Generic;

namespace S_Week14_Reservation
{
    public class Reservation
    {
        private int numberOfNights;
        private string name;
        private int nrSeeder;
        List<Room> rooms = new List<Room>();

        public Reservation(string name, int numberOfNights)
        {
            this.name = name;
            this.numberOfNights = numberOfNights;
            this.nrSeeder = 0;
        }

        public void AddRoom()
        {
            rooms.Add(new Room(++this.nrSeeder));
        }

        public void AddRoom(RoomType roomType, bool isSmooking)
        {
            Room room = new Room(++this.nrSeeder, roomType, isSmooking);
            rooms.Add(room);
            nrSeeder++;
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0.0;

            for (int i = 0; i < rooms.Count; i++)
            {
                totalPrice = totalPrice + rooms[i].GetPriceOneNight() * numberOfNights;
            }

            return totalPrice;
        }

        public string GetInfo()
        {
            return $"{name} with {rooms.Count} rooms.";
        }
    }
}
