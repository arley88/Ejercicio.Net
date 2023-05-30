using Microsoft.EntityFrameworkCore;
using EjercicioNet.Models.DataModels;

namespace EjercicioNet.DataAccess
{
    public class EjercicioNetDBContext: DbContext
    {
        public EjercicioNetDBContext(DbContextOptions<EjercicioNetDBContext> options): base(options)
        {
        }
            public DbSet<Curso>? Cursos { get; set; }
    }
}
