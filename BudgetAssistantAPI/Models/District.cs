namespace BudgetAssistantAPI.Models
{
    public class District
    {
        public int Id { get; set; }
        public string? DistrictName { get; set; }
        public Country? Country { get; set; }
        public ICollection<Settlement> Settlements { get; set; } = new List<Settlement>();
    }
}