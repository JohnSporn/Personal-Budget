using Budget.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Budget.Data.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly ILogger<IncomeRepository> _logger;
        private readonly BudgetContext _dbContext;

        public IncomeRepository(ILogger<IncomeRepository> logger, BudgetContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<int> IncomeCreate(Income income)
        {
            await _dbContext.Income.AddAsync(income);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<int> IncomeDelete(Income income)
        {
            _dbContext.Income.Remove(income);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Income?> IncomeGet(int? id)
        {
            return await _dbContext.Income.FindAsync(id);
        }

        public async Task<int> IncomeUpdate()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
