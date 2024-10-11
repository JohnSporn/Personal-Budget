using Budget.Models;

namespace Budget.Data.Repositories
{
    public interface IIncomeRepository
    {
        public Task<int> IncomeCreate(Income income);
        public Task<int> IncomeUpdate();
        public Task<int> IncomeDelete(Income income);
        public Task<Income> IncomeGet(int? id);
    }
}
