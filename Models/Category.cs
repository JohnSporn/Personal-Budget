namespace Budget.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AllocatedAmount { get; set; }
        public decimal SpentAmount { get; set; }
        public int BudgetId { get; set; }
    }
}
