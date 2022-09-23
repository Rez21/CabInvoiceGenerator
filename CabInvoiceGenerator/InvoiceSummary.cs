using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public double totalFare;
        public int numOfRides;
        public double average;

        public InvoiceSummary(double totalFare, int numOfRides)
        {
            this.totalFare = totalFare;
            this.numOfRides = numOfRides;
            this.average = totalFare/numOfRides;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary imputedObject = (InvoiceSummary)obj;
            return this.numOfRides ==imputedObject.numOfRides && this.totalFare ==imputedObject.totalFare && this.average == imputedObject.average; 
        }
    }
}
