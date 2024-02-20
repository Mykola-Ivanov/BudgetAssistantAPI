using System.Runtime.Loader;

namespace BudgetAssistantAPI.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string? CountryName { get; set; }
        public ICollection<District> Districts { get; set;} = new List<District>();
    }
}