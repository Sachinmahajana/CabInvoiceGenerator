using CabInvoiceGenerator;

namespace CabInvoiceTestProject
{
    [TestClass]
    public class CabInvoiceTestClass
    {
        [TestMethod]
        [DataRow("")]
        //[DataRow("Invalid distance")]
       // [DataRow("null object")]
        public void Given_MultipleRides_Should_Return_TotalFair(string expectedMsg)
        {
            //5*10*1=55
            try
            {
                //Distance 5 minutes and RideTypes 
                // 5*per distance 10 rs + 5minute * per 1 minute 1rs
                //5*10+5*1=55
                // Ride ride = null;
                Ride[] rides = new Ride[]
                {
                    new Ride (5,5,RideTypes.NORMAL),//55
                    new Ride (2,3,RideTypes.PREMIUM)//30 + 6 = 36
                };
                InvoiceGenerator invoice = new InvoiceGenerator();
                double actual = invoice.CalculateFair(rides);
                Assert.AreEqual(91, actual);
            }
            catch (CabInvoiceCustomException ex)
            {
                Assert.AreEqual (ex.Message,expectedMsg);
            }
        }
    }

}
