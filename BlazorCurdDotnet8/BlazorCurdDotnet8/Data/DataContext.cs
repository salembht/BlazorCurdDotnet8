using BlazorCurdDotnet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCurdDotnet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
        : base(options) 
        {
        
        }
        public DbSet<Game> Games { get; set; }
    }
}
