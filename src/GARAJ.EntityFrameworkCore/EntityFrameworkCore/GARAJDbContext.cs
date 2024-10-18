using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using GARAJ.Authorization.Roles;
using GARAJ.Authorization.Users;
using GARAJ.MultiTenancy;

namespace GARAJ.EntityFrameworkCore
{
    public class GARAJDbContext : AbpZeroDbContext<Tenant, Role, User, GARAJDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public GARAJDbContext(DbContextOptions<GARAJDbContext> options)
            : base(options)
        {
        }
    }
}
