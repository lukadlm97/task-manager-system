using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class TaskManagementDbContext:DbContext
    {
        public TaskManagementDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
        }
        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Project> Projects
         { get; set; }

        public Quote Quotes { get; set; }
        public Status Status { get; set; }
    }
}
