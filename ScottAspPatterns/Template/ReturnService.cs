using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Template
{
    public class ReturnService
    {
        public void Process(ReturnOrder returnOrder)
        {
            ReturnProcessTemplate returnProcess = ReturnProcessFactory.CreateFrom(returnOrder.Action);

            returnProcess.Process(returnOrder);
        }
    }
}