using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.ProductImage
{
    public class ProductImageViewModel
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string ImagePath { set; get; }// đường dẫn ảnh
        public string Caption { set; get; }
        public bool IsDefauls { set; get; } // ảnh nào là ảnh mặc định
        public DateTime DateCreated { set; get; }
        public int SortOrder { set; get; } // thứ tự
        public long FileSize { set; get; }
    }
}
