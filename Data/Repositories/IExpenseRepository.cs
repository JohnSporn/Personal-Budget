using Budget.Models;

namespace Budget.Data.Repositories
{
    public interface IExpenseRepository
    {
        public Task<int> ExpenseCreate(Expense income);
        public Task<int> ExpenseUpdate();
        public Task<int> ExpenseDelete(Expense income);
        public Task<Expense> ExpenseGet(int? id);
        public IAsyncEnumerable<Expense> ExpenseGetAll();
    }
}
