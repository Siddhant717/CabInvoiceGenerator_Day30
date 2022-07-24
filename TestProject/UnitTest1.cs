using NUnit.Framework;
using CabInvoiceGenerator;

namespace TestProject
{
    public class Tests
    {
        [Test]
        //Testing fare for normal ride
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double expected = 25;

            double fare = invoice.CalculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }
        [Test]
        //Testing fare for premium ride
        public void GivenDistanceAndTimeShouldReturntotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 2.0;
            int time = 5;
            double expected = 40;

            double fare = invoice.CalculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }
    }
}