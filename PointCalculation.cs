using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using posConsole;

namespace posConsole
{
    public static class PointCalculation
    {
        private const int points = 200;

        public static double PointsCalc(double productAmount) 
        {
            double resultPoints = productAmount / points;
            return Math.Truncate(resultPoints);
        }
    }
}
