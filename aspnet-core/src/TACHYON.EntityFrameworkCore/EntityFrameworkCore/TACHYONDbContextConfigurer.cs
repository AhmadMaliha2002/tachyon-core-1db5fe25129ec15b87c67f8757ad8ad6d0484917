using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TACHYON.EntityFrameworkCore
{
    public static class TACHYONDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TACHYONDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TACHYONDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}