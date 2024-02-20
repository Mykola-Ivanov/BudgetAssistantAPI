using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetAssistantAPI.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string? BuildingCode { get; set; }
        public int StreetId { get; set; }
        public Street? Street { get; set; }
        public ICollection<Place> Places { get; set; } = new List<Place>();
    }
}