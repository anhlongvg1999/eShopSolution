using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Comon
{
    public class PagingRequestBase
    {
        public int PageIndex { set; get; } //vị trí trang 

        public int PageSize { set; get; }
    }
}
