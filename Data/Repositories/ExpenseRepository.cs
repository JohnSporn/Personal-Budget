using Budget.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget.Data.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly ILogger<ExpenseRepository> _logger;
        private readonly BudgetContext _dbContext;

        public ExpenseRepository(ILogger<ExpenseRepository> logger, BudgetContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<int> ExpenseCreate(Expense expense)
        {
            await _dbContext.Expense.AddAsync(expense);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<int> ExpenseDelete(Expense expense)
        {
            _dbContext.Expense.Remove(expense);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Expense?> ExpenseGet(int? id)
        {
            return await _dbContext.Expense.FindAsync(id);
        }

        public async Task<int> ExpenseUpdate()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async IAsyncEnumerable<Expense> ExpenseGetAll() 
        {
            var list = await _dbContext.Expense.ToListAsync();
            foreach (var expense in list) 
            {
                yield return expense;
            }
        }
    }
}
