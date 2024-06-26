using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace Service.Model
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
        {
        }

        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlite("Data Source=../Service/blogging.db");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("name=DbConnection");
            }
            else
            {
                //run when migrate
                //optionsBuilder.UseSqlite("Data Source=blogging.db");
            }
        }

    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
}