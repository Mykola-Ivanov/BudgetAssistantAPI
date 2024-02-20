using System.Collections;

namespace BudgetAssistantAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        
        public ICollection<BudgetGroup> BudgetGroups { get; set; } = new List<BudgetGroup>();
    }
}
