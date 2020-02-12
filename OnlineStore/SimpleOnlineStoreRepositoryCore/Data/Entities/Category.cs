using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductMain> ProductMains { get; set; }
    }
}
