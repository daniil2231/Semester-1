using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutBrewerService
{
    public class BreweryService
    {
        private String name;
        private List<Brewer> brewers;
        private List<Tank> tanks;

        public BreweryService(String name)
        {
            this.name = name;
            brewers = new List<Brewer>();
            tanks = new List<Tank>();
        }

        public Brewer GetBrewer(String id)
        {
            foreach(Brewer b in this.brewers)
            { if (b.Id == id) return b; }
            return null;
        }

        private Tank GetTank(String id)
        {
            foreach (Tank t in this.tanks)
            { if (t.Id == id) return t; }
            return null;
        }

        public void AddBrewer(String name)
        {
            brewers.Add(new Brewer(name));
        }

        public bool AddTank(String id, int capacity)
        {
            tanks.Add(new Tank(id, capacity));
            return true;
        }

        public String RequestTank(String brewerId, int amountOfBeer)
        {
            int bestFittingTank = int.MaxValue;
            for (int i = 0; i < tanks.Count; i++)
            {
                if (tanks[i].IsFree)
                {
                    if (tanks[i].Capacity < bestFittingTank && tanks[i].Capacity - amountOfBeer >= 0)
                    {
                        bestFittingTank = tanks[i].Capacity;
                    }
                }
            }

            for (int j = 0; j < tanks.Count; j++)
            {
                if (tanks[j].Capacity == bestFittingTank && tanks[j].IsFree)
                {
                    tanks[j].Claim(GetBrewer(brewerId), amountOfBeer);
                    GetBrewer(brewerId).ClaimTank(tanks[j], amountOfBeer);
                    return $"{tanks[j].Id}";
                }
            }
            return "No tank is available for that amount of beer.";
        }

        public bool MakeTankEmpty(String brewerId, String tankId)
        {
            for (int i = 0; i < brewers.Count; i++)
            {
                if (brewers[i].Id == brewerId)
                {
                    for (int j = 0; j < brewers[i].ClaimedTanks.Count; j++)
                    {
                        if (brewers[i].ClaimedTanks[j].Id == tankId)
                        {
                            brewers[i].ClaimedTanks[j].MakeFree();
                            brewers[i].ReleaseTank(brewers[i].ClaimedTanks[j]);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public string GetInfoTanks()
        {
            string returnString = String.Empty;

            for (int i = 0; i < tanks.Count; i++)
            {
                returnString = returnString + tanks[i].GetInfo() + " ";
            }

            return returnString;
        }

        public string GetInfoBrewers()
        {
            string returnString = String.Empty;

            for (int i = 0; i < brewers.Count; i++)
            {
                returnString = returnString + brewers[i].GetInfo() + " ";
            }

            return returnString;
        }
    }
}
