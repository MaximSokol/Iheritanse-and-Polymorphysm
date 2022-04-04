using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Ship : Vehicle
    {
        int countOfOccupants;
        string thePlaceOfItsOwn;
        //-------------------------

        public Ship() { }

        public Ship(int x, int y, double price, double speed,
            string theDateOfIssue,int countOfOccupants, string thePlaceOfItsOwn)
            : base(x, y, price, speed, theDateOfIssue)
        {
            this.countOfOccupants = countOfOccupants;
            this.thePlaceOfItsOwn = thePlaceOfItsOwn;
        }
        //----------------------------------------------------------

        public override void ShowDate()
        {
            Console.WriteLine($"X:\t{x}\nY:\t{y}\nPrice:\t{price}\n" +
                $"Speed:\t{speed}\nThe date of issue:\t{theDateOfIssue}\n" +
                $"The place of its own:\t{thePlaceOfItsOwn}\nCount of occupants:\t{countOfOccupants}\n");
        }
        //----------------------------------------------------------
    }
}
