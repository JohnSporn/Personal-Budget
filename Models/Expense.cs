namespace Budget.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string PaymentFrequency { get; set; } // Change to Enum
        public DateTime PaymentDate { get; set; }
        public Category Category { get; set; }
    }
}
