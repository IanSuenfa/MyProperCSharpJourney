using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.SoloLearn
{
    public static class AssignmentOperators
    {
        public static void Example()
        {
            double PropertyValue = 245679;
            double RateIncrease = 662.34;
            PropertyValue += RateIncrease;//PropertyValue = PropertyValue + RateIncrease
            Console.WriteLine(PropertyValue);
        }
    }
}
