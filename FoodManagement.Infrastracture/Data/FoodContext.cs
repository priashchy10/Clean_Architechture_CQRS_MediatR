using FoodManagement.Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagement.Infrastracture.Data
{
    public class FoodContext:DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) :base (options) { }

        public DbSet<Menu> Menu { get; set; }
    }
}
