using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritanse_and_Polymorphysm
{
    class Car : Vehicle
    {
        double theTimeOfSpeedUp;
        string theMaterialOfProducing;

        public Car() : base() { }

        public Car(int x, int y, double price, double speed, string theDateOfIssue,
            double theTimeOfSpeedUp, string theMaterialOfProducing)
            : base(x, y, price, speed, theDateOfIssue)
        {
            this.theTimeOfSpeedUp = theTimeOfSpeedUp;
            this.theMaterialOfProducing = theMaterialOfProducing;
        }
        //-------------------------------------------------

        public override void ShowDate()
        {
            Console.WriteLine($"X:\t{x}\nY:\t{y}\nPrice:\t{price}\n" +
                $"Speed:\t{speed}\nThe date of issue:\t{theDateOfIssue}\n" +
                $"The time of speed up:\t{theTimeOfSpeedUp}\n" +
                $"The material of producing:\t{theMaterialOfProducing}\n");
        }
        //-------------------------------------------------
    }
}
