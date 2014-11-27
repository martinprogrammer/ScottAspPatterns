using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.InterfaceSegregation
{
    public class TShirt : IProduct
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

        public int RunningTime
        {
            get;
            set;
        }
    }
}