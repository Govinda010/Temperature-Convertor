/*******************************************************
 * Temeperature convertor class libbaray
 ********************************************************/

using System;

namespace ClassLibrary1
{
    public class ConversionCalculator
    {
        public float BaseTemp { get; set; }
        public char BaseScaleName { get; set; }

        public ConversionCalculator(float baseTemp, char baseScaleName)
        {
            BaseTemp = baseTemp;
            BaseScaleName = baseScaleName;
        }

        /// <summary>
        /// Conver to Fahrenheight
        /// </summary>
        /// <returns>Fahrenheight</returns>
       public float toFahrenheight()
        {
            float computedTemp = -10000;
            switch (BaseScaleName)
            {
                case 'F':
                    computedTemp = BaseTemp;
                    break;
                case 'C':
                    computedTemp = BaseTemp * 9 / 5 + 32;
                    break;
                case 'K':
                    computedTemp = (BaseTemp - 273) * 9 / 5 + 32;
                    break;
            }
            return computedTemp;
        }

        /// <summary>
        /// Convert to Celsisus
        /// </summary>
        /// <returns>Celcius</returns>
        public float toCelsius()
        {
            float computedTemp = -10000;
            switch (BaseScaleName)
            {
                case 'F':
                    computedTemp = (BaseTemp - 32) * 5 / 9;
                    break;
                case 'C':
                    computedTemp = BaseTemp;
                    break;
                case 'K':
                    computedTemp = BaseTemp - 273;
                    break;
            }
            return computedTemp;
        }

        /// <summary>
        /// Convert to Kelvin
        /// </summary>
        /// <returns>Kelvin</returns>
        public float toKelvin()
        {
            float computedTemp = -10000;

            switch (BaseTemp)
            {
                case 'F':
                    computedTemp = (BaseTemp - 32) * 5 / 9 + 273;
                    break;
                case 'C':
                    computedTemp = BaseTemp + 272;
                    break;
                case 'K':
                    computedTemp = BaseTemp;
                    break;
            }
            return computedTemp;
        }
    }
}
