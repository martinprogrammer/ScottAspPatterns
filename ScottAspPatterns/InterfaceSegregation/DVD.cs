using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.InterfaceSegregation
{
    public class DVD : IProduct, IMovie
    {

        public decimal Price
        {
            get;
            set;
        }

        public decimal WeightInKg
        {
            get;
            set;
        }

        public int Stock
        {
            get;
            set;
        }

        public int Certification
        {
            get;
            set;
        }

        public int Runningtime
        {
            get;
            set;
        }
    }
}