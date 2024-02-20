namespace BudgetAssistantAPI.Models
{
    public class BudgetRecord
    {
        public int Id { get; set; }
        /// <summary>
        /// Currency in UAH
        /// </summary>
        public double Currency { get; set; }
        public DateTime AddedAt { get; set; }
        public User? AddedBy { get; set; }
        public Place? Place { get; set; }
        public BudgetRecordType? BudgetRecordType { get; set; }
        public BudgetGroup? BudgetGroup { get; set; }
    }
}