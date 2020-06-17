using eShopSolution.ViewModels.Comon;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string keyword { set; get; }
        public List<int> CategoryId { set; get; }
    }
}
