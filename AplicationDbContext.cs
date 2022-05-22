using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }
    }
}
