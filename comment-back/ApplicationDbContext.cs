using comment_back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comment_back
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Comment> Comment { get; set; }

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseMySql("Server=localhost;Database=Comments;Uid=root;Pwd=");
            }
        }
    }
}
