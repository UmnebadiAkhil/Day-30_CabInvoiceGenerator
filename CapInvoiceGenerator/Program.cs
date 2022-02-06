using CapInvoiceGenerator;
using System;
using System.Collections.Generic;

namespace CabInvoiceGenerator
{
    class CabInvoiceGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(fare);

            InvoiceGenerator invoiceGenerator1 = new InvoiceGenerator(RideType.PREMIUM);

            double fare1 = invoiceGenerator.CalculateFare(2.0, 5);

            Console.WriteLine(fare1);

        }
    }
}