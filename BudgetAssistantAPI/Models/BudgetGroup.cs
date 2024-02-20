namespace BudgetAssistantAPI.Models
{
    public class BudgetGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }


        public ICollection<User> Users { get; set; } = null!;
        public ICollection<BudgetRecord> BudgetRecords { get; set; } = null!;
    }
}