using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.InterfaceSegregation
{
    public interface IMovie
    {
        int Certification { get; set; }
        int Runningtime { get; set; }
    }
}