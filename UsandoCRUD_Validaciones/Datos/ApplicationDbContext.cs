using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsandoCRUD_Validaciones.Models;

namespace UsandoCRUD_Validaciones.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        { 
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
