using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public readonly int MINIMUM_FARE;
        public readonly int COST_PER_KM;
        public readonly int COST_PER_MINUTE;
        public RideType rideType;

        public InvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            if (rideType == RideType.NORMAL)
            {
                MINIMUM_FARE = 5;
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;
            }
            else
            {
                MINIMUM_FARE = 20;
                COST_PER_KM = 15;
                COST_PER_MINUTE = 2;
            }
        }

        public double CalculateFare(double distance, int time)
        {
            double totalFare;
            if (distance < 0)
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_DISTANCE, "Distance cannot be zero");
            else if (time < 0)
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_TIME, "Time cannot be zero");
            else
            {
                totalFare = distance *COST_PER_KM + time *COST_PER_MINUTE;  
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
    }
}
