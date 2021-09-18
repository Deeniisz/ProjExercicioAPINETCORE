using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APINETCOREProjExercicio.Model;

namespace APINETCOREProjExercicio.Data
{
    public class APINETCOREProjExercicioContext : DbContext
    {
        public APINETCOREProjExercicioContext (DbContextOptions<APINETCOREProjExercicioContext> options)
            : base(options)
        {
        }

        public DbSet<APINETCOREProjExercicio.Model.Cliente> Cliente { get; set; }

        public DbSet<APINETCOREProjExercicio.Model.Padaria> Padaria { get; set; }

        public DbSet<APINETCOREProjExercicio.Model.Produto> Produto { get; set; }
    }
}
