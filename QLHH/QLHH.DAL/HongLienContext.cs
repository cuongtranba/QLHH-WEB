using Microsoft.EntityFrameworkCore;
using QLHH.DAL.Model;

namespace QLHH.DAL
{
    public class HongLienContext : DbContext
    {

        public HongLienContext(DbContextOptions<HongLienContext> options)
            : base(options)
        {

        }

        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Entity> Entitys { get; set; }
        public DbSet<EntityAttribute> EntityAttributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CompanyBrand> CompanyBrands { get; set; }
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<CategoryDetail> CategoryDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
