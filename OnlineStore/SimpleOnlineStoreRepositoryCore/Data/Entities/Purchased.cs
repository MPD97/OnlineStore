using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class Purchased
    {
        public int PurchasedId { get; set; }
        public AppUser AppUser { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime PurchaseTime { get; set; }
        public Transaction Transaction { get; set; }
    }
}
