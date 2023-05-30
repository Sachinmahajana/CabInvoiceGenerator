using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {   
        public  double CalculateFair(Ride ride)
        {
            try
            {
                if (ride.distance < 0)
                {
                    throw new CabInvoiceCustomException("Invalid distance", CabInvoiceCustomException.ExceptionTypes.INVALID_DISTANCE);
                }
                else if (ride.time < 0)
                {
                    throw new CabInvoiceCustomException("Invalid time", CabInvoiceCustomException.ExceptionTypes.INVALID_TIME);
                }
                else
                {
                    double totalFair = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MINUTE;
                    return Math.Max(totalFair, ride.MINIMUM_FAIR);
                }   
            }
            catch(NullReferenceException ex)
            {
                throw new CabInvoiceCustomException("null object", CabInvoiceCustomException.ExceptionTypes.EMPTY_RIDE);  
            }
        }

        public double CalculateFair(Ride[] rides)
        {
            double totalFair = 0;
            try
            {
                foreach (Ride ride in rides)
                {
                    totalFair += CalculateFair(ride);
                }
                return totalFair;
            }
            catch (Exception ex)
            {
                throw new CabInvoiceCustomException("null object", CabInvoiceCustomException.ExceptionTypes.EMPTY_RIDE);
            }
        }
    }
}
