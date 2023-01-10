using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp
{
    public class BeeGroup
    {
        private string name;
        private BeeType beeType;
        private int numberOfBees;
        private Random random = new Random();

        public BeeGroup(string name, BeeType beeType)
        {
            this.name = name;
            this.beeType = beeType;
            if (beeType == BeeType.GUARD)
            {
                this.numberOfBees = random.Next(10, 41);
            }
            else if (beeType == BeeType.QUEEN)
            {
                this.numberOfBees = 1;
            }
            else
            {
                this.numberOfBees = random.Next(50, 201);
            }
        }

        public int NumberOfBees
        {
            get { return this.numberOfBees; }
        }

        public BeeType BeeType
        {
            get { return this.beeType; }
        }

        public string GetInfo()
        {
            return $"Group '{this.name}', {this.numberOfBees} {this.beeType} bees";
        }
    }
}
