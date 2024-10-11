using Budget.Models;

namespace Budget.Data.Repositories
{
    public interface ICategoryRepository
    {
        public Task<int> CategoryCreate(Category category);
        public Task<int> CategoryUpdate();
        public Task<int> CategoryDelete(Category category);
        public Task<Category> CategoryGet(int? id);
        public IAsyncEnumerable<Category> CategoryGetAll();
    }
}
