﻿using Microsoft.EntityFrameworkCore;
using ProyectoCursos.Shared;

namespace ProyectoCursos.Server.DAL
{
    public class Context : DbContext
    {
       
        public DbSet<Cursos> Cursos { get; set; }

        public DbSet<Precios> Precios { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
 