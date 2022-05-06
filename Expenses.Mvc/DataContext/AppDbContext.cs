using Expenses.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Expenses.Mvc.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options ): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
