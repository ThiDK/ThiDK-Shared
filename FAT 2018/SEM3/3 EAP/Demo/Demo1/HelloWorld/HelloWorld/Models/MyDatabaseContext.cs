using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("name=MyDbConnection")
        {
        }

        public DbSet<Todo> Todoes { get; set; }
    }
}