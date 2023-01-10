using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp
{
    public class Honeycomb
    {
        private static int idSeeder = 10;
        private int id;
        private int numberOfCells;
        private List<BeeType> acceptedBeeTypes;
        private List<BeeGroup> beeGroupGuests = new List<BeeGroup>();

        public Honeycomb(int numberOfCells, List<BeeType> acceptedBeeTypes)
        {
            this.numberOfCells = numberOfCells;
            this.acceptedBeeTypes = acceptedBeeTypes;
            this.id = idSeeder;
            idSeeder += 10;
        }

        public List<BeeType> AcceptedBeeTypes
        {
            get { return this.acceptedBeeTypes; }
        }

        public int Id
        {
            get { return this.id; }
        }

        public int NumberOfCells
        {
            get { return this.numberOfCells; }
        }

        public List<BeeGroup> BeeGroupGuests
        {
            get { return this.beeGroupGuests; }
        }

        public int GetNumberOfVacantCells(BeeType beeType)
        {
            if (!acceptedBeeTypes.Contains(beeType))
            {
                return 0;
            }
            else
            {
                return this.numberOfCells;
            }
        }

        public bool AddGuests(BeeGroup beeGroup)
        {
            if (beeGroup.NumberOfBees > GetNumberOfVacantCells(beeGroup.BeeType))
            {
                return false;
            }
            else
            {
                beeGroupGuests.Add(beeGroup);
                this.numberOfCells = this.numberOfCells - beeGroup.NumberOfBees;
                return true;
            }
        }

        public string GetInfo()
        {
            string returnString = $"Honeycomb {this.id} has {this.numberOfCells} cells, accepted: ";
            foreach (BeeType beeType in this.acceptedBeeTypes)
            {
                returnString = returnString + beeType.ToString();
            }
            return returnString;
        }
    }
}
