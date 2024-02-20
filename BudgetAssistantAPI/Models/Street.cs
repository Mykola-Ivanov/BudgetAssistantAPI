using System.Diagnostics.Metrics;

namespace BudgetAssistantAPI.Models
{
    public class Street
    {
        public int Id { get; set; }
        public string? StreetName { get; set; }
        public Settlement? Settlement { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();
    }
}