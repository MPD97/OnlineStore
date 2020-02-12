using System.Collections.Generic;

namespace SimpleOnlineStoreRepositoryCore.Data.Entities
{
    public class ProductMain
    {
        public int ProductMainId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
