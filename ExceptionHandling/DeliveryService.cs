using System;

namespace ExceptionHandling
{
    class DeliveryService
    {
        private readonly Random rnd = new Random();
        public  void Start(Delivery Delivering)
        {
            try
            {
            Process(Delivering);
            Ship(Delivering);
            Transit(Delivering);
            Delivered(Delivering);
            }
            catch(DeliveringException ex)
            {
                Console.WriteLine($"\nDeliver fails due to: {ex.Message}");
                Delivering.DeliveryStatus = DeliveryStatus.UNKNOWN;
            }
            finally
            {
                if(Delivering.DeliveryStatus == DeliveryStatus.UNKNOWN)
                Console.WriteLine("Sorry.");
                else
                    Console.WriteLine("Done.");
            }
        }
        private void Process(Delivery Delivering)
        {
            FakeIt("Processing");
            Delivering.DeliveryStatus = DeliveryStatus.PROCESSED;
        }
        private void Ship(Delivery Delivering)
        {
            FakeIt("Shipping");
            Delivering.DeliveryStatus = DeliveryStatus.SHIPPED;
        }
        private void Transit(Delivery Delivering)
        {
            FakeIt("Transitting");
            Delivering.DeliveryStatus = DeliveryStatus.INTRANSIT;
        }
        private void Delivered(Delivery Delivering)
        {
            FakeIt("Delivering");
            Delivering.DeliveryStatus = DeliveryStatus.DELIVERED;
        }
        private void FakeIt(string title)
        {
            Console.Write(title);
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(400);
            }
            if (rnd.Next(1, 10) == 5)
            {
                throw new DeliveringException($"Problem while {title} your item.");
            }
            Console.WriteLine(".");
        }
    }
}
