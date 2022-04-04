using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Plane : Vehicle
    {
        double height;
        int countOfTheOccupants;
        //-------------------------

        public Plane() : base() { }

        public Plane(int x, int y, double price, double speed,
            string theDateOfIssue, double height, int countOfTheOccupants) 
            : base(x, y, price, speed, theDateOfIssue)
        {
            this.height = height;
            this.countOfTheOccupants = countOfTheOccupants;
        }
        //---------------------------------------------------

        public override void ShowDate()
        {
            Console.WriteLine($"X:\t{x}\nY:\t{y}\nPrice:\t{price}\n" +
                $"Speed:\t{speed}\nThe date of issue:\t{theDateOfIssue}\n" +
                $"Height:\t{height}\nCount of occupants:\t{countOfTheOccupants}\n");
        }
        //---------------------------------------------------
    }
}
