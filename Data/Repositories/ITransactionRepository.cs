using Budget.Models;

namespace Budget.Data.Repositories
{
    public interface ITransactionRepository
    {
        public Task<int> TransactionCreate(Transaction transaction);
        public Task<int> TransactionUpdate();
        public Task<int> TransactionDelete(Transaction transaction);
        public Task<Transaction> TransactionGet(int? id);
        public IAsyncEnumerable<Transaction> TransactionGetAll();
    }
}
