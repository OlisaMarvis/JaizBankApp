using JaizBank.Application.JaizBank.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.Application.JaizBank.Interfaces
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionsViewModel>> GetAllTransactions();
    }
}
