namespace BudgetAssistantAPI.Models
{
    /// <summary>
    /// Spent or Earned or something else
    /// </summary>
    public class BudgetRecordType
    {
        public int Id { get; set; }
        public string? BudgetRecordTypeName { get; set; }
        public ICollection<BudgetRecord> BudgetRecords { get; set; } = null!;
    }
}