﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabDriver
{
    public class InvoiceSummery
    {
        private int numberOfRides;
        private double totalFare;
        private double averageFare;


        // Initializes a new instance of the class.
        // initializes number of rides, total fare and generates average fare for rides.
        //Creating Parameterised constructor for numberofrides and totalfare
        //getting value for that element
        public InvoiceSummery(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare / numberOfRides;
        }

        // Determines whether the specified ,is equal to this instance.
        //to compare with this instance.</param>
        // <returns>
        //  value isntrue if the specified  is equal to this instance; otherwise, <c>false</c>.

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummery))
            {
                return false;
            }
            InvoiceSummery imputedObject = (InvoiceSummery)obj;
            return this.numberOfRides == imputedObject.numberOfRides && this.totalFare == imputedObject.totalFare && this.averageFare == imputedObject.averageFare;
        }
    }
}