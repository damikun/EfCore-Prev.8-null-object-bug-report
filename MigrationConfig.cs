using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Presistence {
    public class DesignDBContextFactory : IDesignTimeDbContextFactory<AppDbContext> {
        public AppDbContext CreateDbContext(string[] args) {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlite( "Data Source=appDB.db");
            return new AppDbContext(builder.Options);
        }
    }
}
