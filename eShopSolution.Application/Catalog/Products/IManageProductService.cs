﻿using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Comon;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    /// <summary>
    /// Product cho phần Admin
    /// </summary>
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request); // trả về kiểu int : trả về mã của sản phẩm vừa tạo

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId,string caption,bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);

    }
}
