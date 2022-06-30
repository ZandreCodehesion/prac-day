using System;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace prac_day
{
    public class AuthorContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        //public DbSet<book> Authors { get; set; }
        

        public string DbPath { get; }

        public AuthorContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "author.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // "Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;"
            options.UseSqlServer("Server=localhost;Database=MyDatabase;user id=sa;password=MyPass@word;");
        }
    }

}

