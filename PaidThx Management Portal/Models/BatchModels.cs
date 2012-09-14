using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaidThx_Management_Portal.Models
{
    public class BatchModels
    {
        public class BatchResponseModel {
            public string ClosedDate { get; set; }
            public string CreateDate { get; set; }
            public string Id { get; set; }
            public bool IsClosed { get; set; }
            public string LastDateUpdated { get; set; }
            public int TotalNumberOfDeposits { get; set; }
            public double TotalDepositAmount { get; set; }
            public int TotalNumberOfWithdrawals { get; set; }
            public double TotalWithdrawalAmount { get; set; }
        }
        public class IndexModel: BaseModel
        {
            public string BatchId { get; set; }
            public int TotalNumberOfDeposits { get; set; }
            public double TotalDepositAmount { get; set; }
            public int TotalNumberOfWithdrawals { get; set; }
            public double TotalWithdrawalAmount { get; set; }
            public int TotalNumberOfTransactions { get; set; }
            public double TotalTransactionAmount { get; set; }
            public string BatchStatus { get; set; }
            public DateTime BatchOpened { get; set; }
            public DateTime? BatchClosed { get; set; }
            public DateTime? BatchVerified { get; set; }
            public DateTime? BatchSent { get; set; }
        }
    }
}