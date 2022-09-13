using System;
using System.Collections.Generic;
using System.Text;

namespace JaizBankDomain.Entities
{
    public class Transactions
    {
        public Guid TransactionId { get; set; }
        public int MerchantId { get; set; }
        public string? MerchantName { get; set; }
        public string? Location { get; set; }
        public string? TerminalID { get; set; }
        public int STAN { get; set; }
        public DateTime? DateTime { get; set; }
        public decimal Amount { get; set; }
        public string? DebitCardNo { get; set; }
        public string? ExpiryDate { get; set; }
        public string? AuthorizationCode { get; set; }
        public int ResponseCode { get; set; }
        public string? AID { get; set; }
        public int RRN { get; set; }
        public string? PTAD { get; set; }
    }
}
