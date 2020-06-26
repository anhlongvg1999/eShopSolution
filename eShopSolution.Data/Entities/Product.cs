using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    /// <summary>
    /// Sản phẩm
    /// </summary>
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public List<ProductInCategory> ProductInCategories { set; get; }
        public List<OrderDetail> OrderDatails { set; get; }
        public List<Cart> Carts { set; get; }
        public List<ProductTranslation> ProductTranslations { set; get; }
        public List<ProductImage> ProductImages { set; get; }
    }
}
