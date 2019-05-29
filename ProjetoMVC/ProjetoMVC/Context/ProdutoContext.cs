using ProjetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoMVC.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext() : base ("ConexaoHoracio")
        {


        }

        public DbSet<Produto> Produtos { get; set; }

        /* para mudar o nome do  banco */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralingTableNameConvertion>();

            base.OnModelCreating(modelBuilder);
        }

    }
}