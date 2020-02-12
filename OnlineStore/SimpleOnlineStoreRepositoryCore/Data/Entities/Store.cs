using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
