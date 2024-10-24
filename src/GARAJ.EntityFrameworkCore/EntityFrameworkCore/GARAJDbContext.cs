using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GARAJ.Abp.Authorization.Roles;
using GARAJ.Abp.Authorization.Users;
using GARAJ.Abp.MultiTenancy;
using GARAJ.GARAJ.Entities;

namespace GARAJ.EntityFrameworkCore
{
    public class GARAJDbContext : AbpZeroDbContext<Tenant, Role, User, GARAJDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Building> Buildings { get; set; }
        
        public GARAJDbContext(DbContextOptions<GARAJDbContext> options)
            : base(options)
        {
        }
    }
}
