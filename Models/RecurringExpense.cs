namespace Budget.Models
{
    public class RecurringExpense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Frequency PaymentFrequency { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
