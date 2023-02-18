using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A5FI6ME\\SQLEXPRESS; database=MyBlog; uid=sa; pwd=12345");
        }

        public DbSet<About> Abouts { get; set; }
        
        public DbSet<Blog> Blogs { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Comment> Comments { get; set; }
        
        public DbSet<Contact> Contacts { get; set; }
        
        public DbSet<Writer> Writers { get; set; }

        public DbSet<Subscriber> Subscribers { get; set; }

    }
}
