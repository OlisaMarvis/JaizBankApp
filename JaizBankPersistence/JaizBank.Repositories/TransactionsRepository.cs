using JaizBank.Application.JaizBank.Interfaces;
using JaizBankDomain.Entities;
using JaizBankPersistence.Context;
using Microsoft.EntityFrameworkCore;


namespace JaizBank.Application.JaizBank.Repositories
{
    public class TransactionsRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;

        public TransactionsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transactions>> GetAllTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }

        
    }
}
