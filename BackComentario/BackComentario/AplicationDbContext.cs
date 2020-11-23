using BackComentario.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackComentario
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Comentario> Comentario { get; set; }

        public AplicationDbContext()
        {

        }

        public AplicationDbContext (DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ABMComentario;Trusted_Connection=True;");

            }

        }
    }
}
