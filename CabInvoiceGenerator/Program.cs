namespace CabInvoiceGenerator
{
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the CabInvoiceGenerator program");
                Ride ride = new Ride(5, 5, RideTypes.NORMAL);
                InvoiceGenerator invoice = new InvoiceGenerator();
                double actual = invoice.CalculateFair(ride);
            }
        }
}
