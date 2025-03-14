﻿using ExemploEf.Models;
using Microsoft.EntityFrameworkCore;
using ExemploEF.Models;

namespace ExemploEf.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Categoria>().ToTable("tbCategorias");
        }
        public DbSet<ExemploEF.Models.Produto> Produto { get; set; } = default!;
    }
}
