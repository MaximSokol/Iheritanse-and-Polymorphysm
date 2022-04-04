using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Vehicle
    {
        protected int x;
        protected int y;
        protected double price;
        protected double speed;
        protected string theDateOfIssue;
        //------------------------------

        public Vehicle() { }

        public Vehicle(int x, int y, double price,
            double speed, string theDateOfIssue)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.theDateOfIssue = theDateOfIssue;
        }
        //--------------------------------------------

        public virtual void ShowDate() { }

    }
}
