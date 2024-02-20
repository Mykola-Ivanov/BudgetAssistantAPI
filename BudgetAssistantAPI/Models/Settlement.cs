using System.IO;

namespace BudgetAssistantAPI.Models
{
    public class Settlement
    {
        public int Id { get; set; }
        public string? SettlementName { get; set; }
        public District? District { get; set; }
        public ICollection<Street> Streets { get; set; } = new List<Street>();
    }
}