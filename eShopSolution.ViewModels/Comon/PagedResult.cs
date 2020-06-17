using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Comon
{
    public class PagedResult<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }//tổng số sản phẩm
    }
}
