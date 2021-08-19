using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repo.Data
{
    public class e_CommerceContext : DbContext
    {
        public e_CommerceContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products{get;set;}
    }
}