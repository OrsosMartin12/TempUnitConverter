using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    public class Converter
    {
        public double CToK(double c)
        {
            return c +273.15;
        }

        public double CToF(double c)
        {
            return ((c * 9) / 5) + 32;
        }

        public double KToC(double k)
        {
            return k - 273.15;
        }

        public double KToF(double k)
        {
            return ((k * 9) / 5) - 459.67 ;
        }

        public double FToC(double f)
        {
            return ((f - 32) * 5) / 9;
        }

        public double FToK(double f)
        {
            return ((f + 459.67) * 5) / 9;
        }
    }
}
