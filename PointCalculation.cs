using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using posConsole;

namespace posConsole
{
    class PointCalculation
    {
        public double PointsCalc(double productAmount) 
        {

            int points = 200;

            double resultPoints = productAmount / points;
            resultPoints = Math.Truncate(resultPoints);
            return resultPoints;
        }
    }
}
