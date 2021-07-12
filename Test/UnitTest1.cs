using NUnit.Framework;
using PracticeQuantityMeasurement;

namespace Test
{
    public class Tests
    {
       

        [Test]
        public void implimentationForConversion()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output=conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }

        [Test]
        public void demo1()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }


        [Test]
        public void demo2()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }

        [Test]
        public void demo3()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }



        [Test]
        public void InMaster()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }

        [Test]
        public void implimentsdsationForConversion()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }

        [Test]
        public void implimesfgdfgdntsdsationForConversion()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1.0, Distance.Meters, Distance.Meters);
            Assert.AreEqual(1.0, output);
        }


        [Test]
        public void givenZeroFeet_shouldRetrunZeroFeet()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(0.0, Distance.Feet, Distance.Feet);
            Assert.AreEqual(0.0, output);
        }

        [Test]
        public void givenFeet_shouldRetruninch()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(1, Distance.Feet, Distance.Inches);
            Assert.AreEqual(12.00, output, 0.01);
        }


        [Test]
        public void given_ft_shouldReturnYD()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(3, Distance.Feet, Distance.Yards);
            Assert.AreEqual( 1.00, output, 0.01);
        }

        [Test]
        public void giveninches_ShouldConvertCM() {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.ConvertMethod(2, Distance.Inches, Distance.Centimeters);
            Assert.AreEqual(5.08, output, 0.01);

        }

        [Test]
        public void addition()
        {
            ConversionForDistance conversion = new ConversionForDistance();
            double output = conversion.Addition(2, Distance.Inches,3, Distance.Inches);
            Assert.AreEqual(5.00, output, 0.01);

        }

        [Test]
        public void givenlitere_shouldConvertGallon() {
            ConversionVolumes conversionVolumes = new ConversionVolumes();
            double output = conversionVolumes.ConvertMethod(1, Volumes.gallon, Volumes.litre);
            Assert.AreEqual(3.84, output, 0.01);
        
        }

        [Test]
        public void addition1() {
            ConversionVolumes conversionVolumes = new ConversionVolumes();
            double output = conversionVolumes.Addition(1, Volumes.gallon, 3.78, Volumes.litre);
            Assert.AreEqual(7.62, output, 0.01);

        }


        [Test]
        public void addition4()
        {
            ConversionWight conversionWight = new ConversionWight();
            double output = conversionWight.Addition(1, Weight.tonne, 1000, Weight.grams);
            Assert.AreEqual(1001, output, 0.01);

        }

        [Test]
        public void convertionTemp() {
            ConversionWight conversionWight = new ConversionWight();
            double output = conversionWight.tempConversion(212,Temparature.Faherenheit, Temparature.celsius);
            Assert.AreEqual(100, output, 0.01);

        }


    }
}