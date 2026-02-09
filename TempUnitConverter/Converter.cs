using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempUnitConverter
{
    public class Converter
    {
        //Celziuszból átváltja kelvinbe
        public double CToK(double c)
        {
            return c +273.15;
        }

        //Celziuszból átváltja Farenheitbe
        public double CToF(double c)
        {
            return ((c * 9) / 5) + 32;
        }

        //Kelvinből vált át celziuszba
        public double KToC(double k)
        {
            return k - 273.15;
        }

        //Kelvinből vált át Farenheitbe
        public double KToF(double k)
        {
            return ((k * 9) / 5) - 459.67 ;
        }

        //Farenheitből vált át celziuszba
        public double FToC(double f)
        {
            return ((f - 32) * 5) / 9;
        }

        //Farenheitből vált át kelvinbe
        public double FToK(double f)
        {
            return ((f + 459.67) * 5) / 9;
        }
    }
}
