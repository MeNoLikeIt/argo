using System.Data.Entity;
using Argo.common.data.dtos;

namespace Argo.dal
{
    public class ArgoDatabase : DbContext
    {
        public DbSet<ApplicationDto> Applications { get; set; }
        public DbSet<AccountDto> Accounts { get; set; }
        public DbSet<EntityDto> Entities { get; set; }
        public DbSet<PeriodDto> Periods { get; set; }
        public DbSet<PlanDto> Plans { get; set; }
        public DbSet<ScenarioDto> Scenarios { get; set; }
        public DbSet<VersionDto> Versions { get; set; }
        public DbSet<YearDto> Years { get; set; }
        public DbSet<UserDto> Users { get; set; }
        public DbSet<RoleDto> Roles { get; set; }
        public DbSet<AccessMatrixDto> AccessMatrix { get; set; }

        public ArgoDatabase():base("name=Argo")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationDto>().ToTable("Applications");
            modelBuilder.Entity<AccountDto>().ToTable("Accounts");
            modelBuilder.Entity<EntityDto>().ToTable("Entities");
            modelBuilder.Entity<PeriodDto>().ToTable("Periods");
            modelBuilder.Entity<PlanDto>().ToTable("Plans");
            modelBuilder.Entity<ScenarioDto>().ToTable("Scenarios");
            modelBuilder.Entity<VersionDto>().ToTable("Versions");
            modelBuilder.Entity<YearDto>().ToTable("Years");
            modelBuilder.Entity<UserDto>().ToTable("Users");
            modelBuilder.Entity<RoleDto>().ToTable("Roles");
            modelBuilder.Entity<AccessMatrixDto>().ToTable("AccessMatrix");
        }
    }
}
