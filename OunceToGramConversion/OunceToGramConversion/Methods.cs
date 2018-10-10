using System;
using System.Collections.Generic;
using System.Text;

namespace OunceToGramConversion
{
    public class Methods
    {
        private double OunceConv = 28.34952;
        public double ToOunces(double grams)
        {
                return grams / OunceConv;
        }
        public double ToGrams(double ounces)
        {
            return ounces * OunceConv;
        }
    }
}
