namespace CabInvoiceGenerator
{
        public class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Welcome to the CabInvoiceGenerator program");
            Ride[] rides = new Ride[]
               {
                    new Ride (5,5,RideTypes.NORMAL),//55
                    new Ride (2,3,RideTypes.PREMIUM)//30 + 6 = 36
               };
            InvoiceGenerator invoice = new InvoiceGenerator();
            double actual = invoice.CalculateFair(rides);
        }
        }
}
