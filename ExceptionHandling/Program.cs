using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AzZazi!";
            Delivery DeliveringDetails = new Delivery(1001,"Ehap Azzazi", "Zagazig, Ash Sharqia, Egypt");
            var FakeIt = new DeliveryService();
            FakeIt.Start(DeliveringDetails);
            Console.WriteLine(DeliveringDetails);
            Console.ReadKey();
        }
    }
}
