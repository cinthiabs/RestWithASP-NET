using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model.Context
{
    public class MySqlContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public MySqlContext()
        {

        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
        public System.Data.Entity.DbSet<Person> Persons { get; set; }
    }
}
