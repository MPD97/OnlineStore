using System.Collections.Generic;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class ProductVariant
    {
        public int ProductVariantId { get; set; }
        public string Name { get; set; }
        public string VariantValue { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}