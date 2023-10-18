using Microsoft.EntityFrameworkCore;

namespace NewsWebsit.Models
{
    public class NewsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {

            op.UseSqlServer("Data Source=DESKTOP-7HALKG1;Initial Catalog=NewsWebsite;Integrated Security=True");
        }
        public NewsContext(DbContextOptions<NewsContext> options)
            : base(options)
        {
        }
        public DbSet<News> News { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Members> Members { get; set; }



       


    }
}
