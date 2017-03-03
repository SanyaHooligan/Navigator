using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;
using System.Data.Entity.Infrastructure;

namespace WebApplication5.Models
{
    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("uuuConnection") { }

        public DbSet<News> News { get; set; }
    }
}