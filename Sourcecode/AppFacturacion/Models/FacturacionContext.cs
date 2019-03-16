using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppFacturacion.Models
{
    public class FacturacionContext : DbContext
    {
        public FacturacionContext (DbContextOptions<FacturacionContext> options)
            : base(options)
        {
        }

        /**
        * Modelos a mapear con el ORM Entity Framework Core
         */
        public DbSet<AppFacturacion.Models.Facturas> Facturas { get; set; }
        public DbSet<AppFacturacion.Models.Detalles> Detalles { get; set; }
        public DbSet<AppFacturacion.Models.Productos> Productos { get; set; }
    }
}