using Microsoft.EntityFrameworkCore;
using Preueba.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Web.Models;

namespace Preueba.Web.Data.Entities
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Prueba.Web.Models.Country> Country { get; set; }
    }
}
