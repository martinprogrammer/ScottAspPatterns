using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.InterfaceSegregation
{
    public class BlueRayDisc: IProduct, IMovie
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
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Runningtime
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}