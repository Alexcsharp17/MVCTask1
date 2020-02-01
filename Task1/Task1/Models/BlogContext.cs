using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class BlogContext : DbContext
    {
       public DbSet<Article> Articles { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}