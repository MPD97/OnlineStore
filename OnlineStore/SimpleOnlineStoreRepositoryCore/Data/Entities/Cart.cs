using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    class Cart
    {
        public int CartId { get; set; }
        public AppRole Owner { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
