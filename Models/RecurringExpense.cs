using System.Runtime.CompilerServices;

namespace Budget.Models
{
    public class RecurringExpense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public Frequency Frequency { get; set; }
        public DateTime NextDueDate { get; set; }
    }
}
