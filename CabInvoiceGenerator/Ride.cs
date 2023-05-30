using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public RideTypes rideType;
        public readonly int MINIMUM_FAIR;
        public readonly int COST_PER_KM;
        public readonly int COST_PER_MINUTE;

        public Ride(double distance,int time,RideTypes ridetype)
        {
            this.distance = distance;
            this.time = time;
            this.rideType = rideType;

            if (RideTypes.NORMAL == rideType)
            {
                MINIMUM_FAIR = 5;
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;
            }
            else
            { 
                MINIMUM_FAIR = 10;
                COST_PER_KM = 15;
                COST_PER_MINUTE = 2;
            }
        }
        internal double CalculateFair(Ride ride1, Ride ride2)
        {
            throw new NotImplementedException();
        }
    }
}
