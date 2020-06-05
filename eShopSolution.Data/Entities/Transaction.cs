using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    /// <summary>
    /// giao dịch
    /// </summary>
    public class Transaction
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; }//giao dịch bên ngoài
        public decimal Amount { set; get; }//số tiền
        public decimal Fee { set; get; }//phí giao dịch
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }//nhà cung cấp
    }
}
