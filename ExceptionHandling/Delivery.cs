using System;

namespace ExceptionHandling
{
     class Delivery
    {
        private int ID { get; }
        private string CustomerName { get; }
        private string Address{ get; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public Delivery(int _Id, string _custname, string _address)
        {
            this.ID = _Id;
            this.CustomerName = _custname;
            this.Address = _address;
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return
                $"      {this.ID}.\n" +
                $"      {this.CustomerName}.\n" +
                $"      {this.Address}.\n" +
                $"      {this.DeliveryStatus}.\n";
        }
    }
}
