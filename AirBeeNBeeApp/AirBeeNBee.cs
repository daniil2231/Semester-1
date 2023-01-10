using System;
using System.Collections.Generic;

namespace ManagementApp
{
    public class AirBeeNBee
    {
        private string name;
        private List<BeeGroup> beeGroups = new List<BeeGroup>();
        private List<Honeycomb> honeycombs = new List<Honeycomb>();

        public AirBeeNBee(string name)
        {
            this.name = name;
        }

        public List<BeeGroup> BeeGroups
        {
            get { return this.beeGroups; }
        }

        public List<Honeycomb> Honeycombs
        {
            get { return this.honeycombs; }
        }

        public void AddCustomer(string name, BeeType beeType)
        {
            beeGroups.Add(new BeeGroup(name, beeType));
        }

        public void AddHoneycomb(int numberOfCells, BeeType acceptedBeeType)
        {
            honeycombs.Add(new Honeycomb(numberOfCells, new List<BeeType>() { acceptedBeeType }));
        }

        public void AddHoneycomb(int numberOfCells, List<BeeType> acceptedBeeTypes)
        {
            honeycombs.Add(new Honeycomb(numberOfCells, acceptedBeeTypes));
        }

        public bool TryCreateBooking(BeeGroup beeGroup)
        {
            int bestFittingComb = int.MaxValue;
            for (int i = 0; i < honeycombs.Count; i++)
            {
                if (honeycombs[i].GetNumberOfVacantCells(beeGroup.BeeType) - beeGroup.NumberOfBees >= 0)
                {
                    if (honeycombs[i].GetNumberOfVacantCells(beeGroup.BeeType) < bestFittingComb)
                    {
                        bestFittingComb = honeycombs[i].GetNumberOfVacantCells(beeGroup.BeeType);
                    }
                }
            }

            for (int j = 0; j < honeycombs.Count; j++)
            {
                if (honeycombs[j].GetNumberOfVacantCells(beeGroup.BeeType) == bestFittingComb)
                {
                    honeycombs[j].AddGuests(beeGroup);
                    beeGroups.Remove(beeGroup);
                    return true;
                }
            }

            return false;
        }

        public void AddHoneycombTestData()
        {
            AddHoneycomb(400, new List<BeeType>() { BeeType.HOUSEKEEPER, BeeType.NECTARGATHERER });
            AddHoneycomb(50, BeeType.GUARD);
            AddHoneycomb(1, BeeType.QUEEN);
            AddHoneycomb(300, BeeType.DRONE);
            AddHoneycomb(400, new List<BeeType>() { BeeType.HOUSEKEEPER, BeeType.GUARD });
            AddHoneycomb(200, BeeType.HOUSEKEEPER);
            AddHoneycomb(200, BeeType.NECTARGATHERER);
            AddHoneycomb(25, new List<BeeType>() { BeeType.GUARD, BeeType.DRONE });
            AddHoneycomb(1, BeeType.QUEEN);
        }

        public void AddCustomerTestData()
        {
            AddCustomer("The cleaners", BeeType.HOUSEKEEPER);
            AddCustomer("Drones R Us", BeeType.DRONE);
            AddCustomer("Somebody to love", BeeType.QUEEN);
            AddCustomer("Oh Beehave", BeeType.GUARD);
            AddCustomer("Defenders of the Earth", BeeType.GUARD);
        }
    }
}
