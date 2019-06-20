using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Mandala.Models;

namespace Mandala.Dados
{
    public class MandalaContext : DbContext
    {
        public MandalaContext() : base("MandalaContext") { }

        public DbSet<MandalaLunar> Mandalas { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<CategoriaParametros> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}