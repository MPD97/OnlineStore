﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    class Purchased
    {
        public int PurchaseId { get; set; }
        public AppUser AppUser { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime PurchaseTime { get; set; }
        public Transaction Transaction { get; set; }

    }
    public class Transaction
    {
        public int TransactionId { get; set; }

    }
}
