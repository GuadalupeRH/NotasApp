using DataAccessLayer.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Datos
{
    public class AppNoteDbContext : DbContext
    {
        public AppNoteDbContext(DbContextOptions<AppNoteDbContext> options): base(options) { }
    
        public DbSet<Nota> Notas { get; set; }
    }

}
