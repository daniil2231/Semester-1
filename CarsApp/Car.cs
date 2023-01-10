using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Practice
{
    public class Car
    {
        private string model;
        private int topSpeed;
        private int speed;

        public void SetModel(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return this.model;
        }

        public void SetTopSpeed(int topSpeed)
        {
            this.topSpeed = topSpeed;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public int GetSpeed()
        {
            return this.speed;
        }

        public void Accelerate(int increaseBy)
        {
            if (this.speed + increaseBy > this.topSpeed)
            {
                this.speed = this.topSpeed;
            }
            else
            {
                this.speed = this.speed + increaseBy;
            }
        }

        public void Break()
        {
            this.speed = 0;
        }

        public string GetInfo()
        {
            return $"Car {this.model}: {this.speed}/{this.topSpeed}";
        }
    }
}
