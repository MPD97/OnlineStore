using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ProduceDate { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
