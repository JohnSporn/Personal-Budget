using Budget.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ILogger<TransactionRepository> _logger;
        private readonly BudgetContext _dbContext;

        public TransactionRepository(ILogger<TransactionRepository> logger, BudgetContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<int> TransactionCreate(Transaction transaction)
        {
            await _dbContext.Transaction.AddAsync(transaction);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<int> TransactionDelete(Transaction transaction)
        {
            _dbContext.Transaction.Remove(transaction);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Transaction?> TransactionGet(int? id)
        {
            return await _dbContext.Transaction.FindAsync(id);
        }

        public async Task<int> TransactionUpdate()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async IAsyncEnumerable<Transaction> TransactionGetAll()
        {
            var list = await _dbContext.Transaction.ToListAsync();
            foreach (var transaction in list)
            {
                yield return transaction;
            }
        }
    }
}
