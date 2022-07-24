using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Gernerator");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);

            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);

            double premiumfare = invoiceGenerator.CalculateFare(2.0, 5);
            double normalfare = invoice.CalculateFare(2.0, 5);
            Console.WriteLine("The total fare for Premium Ride is :" + premiumfare);
            Console.WriteLine("The total fare for Normal Ride is :" + normalfare);
        }
    }
}