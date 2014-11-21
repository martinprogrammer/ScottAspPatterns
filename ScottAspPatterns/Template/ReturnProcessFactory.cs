using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Template
{
    public class ReturnProcessFactory
    {
      public static ReturnProcessTemplate CreateFrom( ReturnAction returnAction)
        {
          switch(returnAction){
              case (ReturnAction.FaultyReturn) :
                  return new FaultyReturn();
              case (ReturnAction.NoQuibbleReturn) :
                  return new NoQuibblesReturn();
              default :
                  throw new ApplicationException(
                      "No process template defined for Return Action of " + returnAction.ToString());
                  

          }
               
        }
    }
}