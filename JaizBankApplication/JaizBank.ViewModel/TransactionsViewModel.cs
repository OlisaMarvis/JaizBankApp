using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.Application.JaizBank.ViewModel
{
    public class TransactionsViewModel
    {
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
