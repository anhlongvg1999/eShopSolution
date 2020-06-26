﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.ProductImage
{
    public class ProductImageUpdateRequest
    {
        public int Id { set; get; }
        public string Caption { set; get; }
        public bool IsDefauls { set; get; } // ảnh nào là ảnh mặc định
        public int SortOrder { set; get; } // thứ tự
        public IFormFile ImageFile { set; get; }
    }
}
