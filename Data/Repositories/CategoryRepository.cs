using Budget.Models;
using Microsoft.EntityFrameworkCore;

namespace Budget.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ILogger<CategoryRepository> _logger;
        private readonly BudgetContext _dbContext;

        public CategoryRepository(ILogger<CategoryRepository> logger, BudgetContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<int> CategoryCreate(Category category)
        {
            await _dbContext.Category.AddAsync(category);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<int> CategoryDelete(Category category)
        {
            _dbContext.Category.Remove(category);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Category?> CategoryGet(int? id)
        {
            return await _dbContext.Category.FindAsync(id);
        }

        public async Task<int> CategoryUpdate()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async IAsyncEnumerable<Category> CategoryGetAll()
        {
            var list = await _dbContext.Category.ToListAsync();
            foreach (var category in list)
            {
                yield return category;
            }
        }
    }
}
