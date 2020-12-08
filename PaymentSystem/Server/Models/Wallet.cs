using System;

namespace PaymentSystem.Server.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }


    }
}
