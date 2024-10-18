using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.EntityFrameworkCore
{
    public static class GARAJDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<GARAJDbContext> builder, string connectionString)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<GARAJDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
        
    }
}
