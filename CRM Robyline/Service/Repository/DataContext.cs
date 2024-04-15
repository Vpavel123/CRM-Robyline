using CRM_Robyline.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Robyline.Service.Repository
{
    class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DataBaseConnectionString.Inst.Set();
            optionsBuilder.UseSqlServer(DataBaseConnectionString.Inst.Set());
        }
        public DbSet<Clients> clients { get; set; }
    }
}
