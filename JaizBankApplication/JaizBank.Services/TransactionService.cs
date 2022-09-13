using AutoMapper;
using JaizBank.Application.JaizBank.Interfaces;
using JaizBank.Application.JaizBank.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.Application.JaizBank.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<TransactionsViewModel>> GetAllTransactions()
        {
            var result = await _repository.GetAllTransactions();
            return _mapper.Map<IEnumerable<TransactionsViewModel>>(result);
        }
    }
}
