
namespace BudgetAssistantAPI.Models
{
    public class Place
    {
        public int Id {  get; set; }
        public string? PlaceName { get; set; }
        public Building? Building { get; set; }
        public ICollection<BudgetRecord>? BudgetRecords { get; set; } = new List<BudgetRecord>();
    }
}