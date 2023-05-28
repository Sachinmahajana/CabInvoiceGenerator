using CabInvoiceGenerator;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceTestClass
    {
        [TestMethod]
        [DataRow("")]
        public void Given_RideDetails_Should_Return_TotalFair(string expectedMsg)
        {
            //5*10*1=55
            try
            {
                //Distance 5 minutes and RideTypes
                // 5*per distance 10 rs + 5minute * per 1 minute 1rs
                //5*10+5*1=55
                Ride ride = new Ride(5, 5, RideTypes.NORMAL);
                InvoiceGenerator invoice = new InvoiceGenerator();
                double actual = invoice.CalculateFair(ride);
                Assert.AreEqual(55, actual);
            }
            catch(CabInvoiceCustomException ex)
            {
                Assert.AreEqual(ex.Message, expectedMsg);      
            }
        }
    }
}