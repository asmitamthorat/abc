using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuantityMeasurement
{
    public enum Weight
    {
        kg,
        grams,
        tonne

    }

    public enum Temparature { 
    celsius,
    Faherenheit
    }




    public class ConversionWight
    {

        public static double[] conversionRate = new double[]
        {
        1,//kg
        1000,//grrams
        0.001//tonne
        };

        public double ConvertMethod(double valueToConvert, Weight from, Weight to)
        {
            double ValueToWorkin;
            if (from == Weight.kg)
            {
                ValueToWorkin = valueToConvert;
            }
            else
            {
                ValueToWorkin = valueToConvert / conversionRate[(int)from];
            }
            if (to != Weight.kg)
            {
                ValueToWorkin = ValueToWorkin * conversionRate[(int)to];
            }
            return ValueToWorkin;

        }

        public double Addition(double element1, Weight firstElementUnit, double element2, Weight secondElementUnit)
        {
            double a = ConvertMethod(element1, firstElementUnit, Weight.kg);
            double b = ConvertMethod(element2, secondElementUnit, Weight.kg);
            return a + b;
        }

        public double tempConversion(double tempature, Temparature from,Temparature to) {
            double ValueToWorkin;
            if (to == Temparature.celsius) {
                 ValueToWorkin = tempature / 2.12;
            }
            else
            {
                ValueToWorkin = tempature / 0.471;
            }
            return ValueToWorkin;
        }


    }
}
