using CapInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenerator_Test
{
    [TestClass]
    public class UnitTest1
    {

        InvoiceGenerator invoiceGenerator = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {

            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double distance = 2.0;
            int time = 5;

            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }

        [TestMethod]
        public void GivenMultipleRideShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expected = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(expected, invoiceSummary);

        }
        [TestMethod]
        public void GivenPremium_RideType_ShouldReturnInvoice()
        {
            
            double distance = 2.0;
            int time = 5;
           
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            
            double totalActualFare = invoiceGenerator.CalculateFare(distance, time);
            double totalExpectedFare = 40.0;
         
            Assert.AreEqual(totalExpectedFare, totalActualFare);
        }
    }
}
