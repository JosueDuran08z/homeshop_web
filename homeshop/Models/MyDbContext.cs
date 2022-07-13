using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace homeshop.Models
{
    public class MyDbContext:DbContext
    {
        private const string ConnectionString = "DefaultConnection";
        public MyDbContext(): base(ConnectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}