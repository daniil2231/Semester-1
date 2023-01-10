namespace S_Week14_Reservation
{
    public class Room
    {
        private int number;
        private RoomType roomType;
        private bool isSmoking;

        public Room(int number)
        {
            this.number = number;
        }

        public Room(int number, RoomType roomType, bool isSmoking)
        {
            this.number = number;
            this.roomType = roomType;
            this.isSmoking = isSmoking;
        }

        public double GetPriceOneNight()
        {
            double price = 0.0;
            switch (roomType)
            {
                case RoomType.Single:
                    price = 75;
                    break;
                case RoomType.Normal:
                    price = 100;
                    break;
                case RoomType.Family:
                    price = 150;
                    break;
            }
            return price;
        }

        public string GetInfo()
        {
            string smoking = isSmoking ? "Smoking" : "Non smoking";
            return $"Room {number} type {roomType} {smoking}";
        }
    }
}
