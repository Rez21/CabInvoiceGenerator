using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public double CalculateFare(Ride ride)
        {
            double totalFare;
            if (ride.distance < 0)
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_DISTANCE, "Distance cannot be zero");
            else if (ride.time < 0)
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_TIME, "Time cannot be zero");
            else
            {
                totalFare = ride.distance *ride.COST_PER_KM + ride.time *ride.COST_PER_MINUTE;  
            }
            return Math.Max(totalFare, ride.MINIMUM_FARE);
        }

        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateFare(ride);
            }
            return new InvoiceSummary(totalFare, rides.Length);
        }
    }
}
