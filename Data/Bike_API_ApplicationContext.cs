using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_API_Application.Model;

namespace Web_API_Application.Models
{
    public class Bike_API_ApplicationContext : DbContext
    {
        public Bike_API_ApplicationContext (DbContextOptions<Bike_API_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Web_API_Application.Model.Bike> Bike { get; set; }
    }
}
