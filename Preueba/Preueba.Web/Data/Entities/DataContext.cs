using Microsoft.EntityFrameworkCore;
using Preueba.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Preueba.Web.Data.Entities
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
    }
}
