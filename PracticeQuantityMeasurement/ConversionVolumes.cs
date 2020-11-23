using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuantityMeasurement
{

    public enum Volumes
    {
        litre,
        gallon,
        millititres

    }


    public class ConversionVolumes
    {
        public static double[] conversionRate = new double[]
        {
        1,//litre
       0.26,//gallon
       1000//feet   
        };


        public double ConvertMethod(double valueToConvert, Volumes from, Volumes to)
        {
            double ValueToWorkin;
            if (from == Volumes.litre)
            {
                ValueToWorkin = valueToConvert;
            }
            else
            {
                ValueToWorkin = valueToConvert / conversionRate[(int)from];
            }
            if (to != Volumes.litre)
            {
                ValueToWorkin = ValueToWorkin * conversionRate[(int)to];
            }
            return ValueToWorkin;
        }

        public double Addition(double element1, Volumes firstElementUnit, double element2, Volumes secondElementUnit) {
            double a = ConvertMethod(element1, firstElementUnit,Volumes.litre);
            double b = ConvertMethod(element2, secondElementUnit, Volumes.litre);
            return a + b;
        }


    }
}
