using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstAspNet.Models
{
    public class BookContext : DbContext
    {
            public DbSet<Book> Books { get; set; }
            public DbSet<Purchase> Purchases { get; set; }
    }
}