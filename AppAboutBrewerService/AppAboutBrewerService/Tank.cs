using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutBrewerService
{
    public class Tank
    {
        private String id;
        private int capacity;
        private int amountOfBeer;
        private Brewer tankClaimedBy;

        public Tank(String id, int capacity)
        {
            this.id = id;
            this.capacity = capacity;
        }

        public String Id
        {
            get { return this.id; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public int AmountOfBeer
        {
            get { return this.amountOfBeer; }
        }

        public bool IsFree
        {
            get
            {
                if (this.amountOfBeer <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Claim(Brewer b, int amountOfBeer)
        {
            this.tankClaimedBy = b;
            this.amountOfBeer = amountOfBeer;
        }

        public void MakeFree()
        {
            this.tankClaimedBy = null;
            this.amountOfBeer = 0;
        }

        public String GetInfo()
        {
            if (this.amountOfBeer <= 0)
            {
                return $"tankid: {this.Id}, capacity: {this.Capacity}, is empty";
            }
            else
            {
                return $"tankid: {this.Id}, capacity: {this.Capacity}, amount of beer: {this.amountOfBeer}";
            }
        }
    }
}
