using System;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class HongLienDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
