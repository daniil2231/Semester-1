using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutBrewerService
{
    public class Brewer
    {
		private String name;
		private String id;
		private static int nextFreeNr = 210;
        private List<Tank> claimedTanks;

        public Brewer(String name)
        {
            this.name = name;
            this.id = $"br{nextFreeNr}";
            nextFreeNr += 10;
            claimedTanks = new List<Tank>();
        }

        public String Id
        {
            get { return this.id; }
        }

        public List<Tank> ClaimedTanks
        {
            get { return this.claimedTanks; }
        }

        public String GetInfo()
        {
            return $"{this.name}, id {this.Id}, uses {claimedTanks.Count} tanks.";
        }

        public void ClaimTank(Tank t, int amountOfBeer)
        {
            claimedTanks.Add(t);
        }

        public void ReleaseTank(Tank t)
        {
            t.MakeFree();
            claimedTanks.Remove(t);
        }
	}
}
