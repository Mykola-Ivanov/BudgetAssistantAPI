using Microsoft.EntityFrameworkCore;

namespace BudgetAssistantAPI.Models
{
    public class BudgetAssistantDbContext : DbContext
    {
        public BudgetAssistantDbContext(DbContextOptions<BudgetAssistantDbContext> option):base(option)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BudgetGroup> BudgetGroups { get; set; } = null!; 
        public DbSet<BudgetRecord> BudgetRecords { get; set; } = null!;
        public DbSet<BudgetRecordType> BudgetRecordTypes { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<District> Districts { get; set; } = null!;
        public DbSet<Settlement> Settlements { get; set; } = null!;
        public DbSet<Street> Streets { get; set; } = null!;
        public DbSet<Building> Buildings { get; set; } = null!;
        public DbSet<Place> Places { get; set; } = null!;
    }
}
