using Fundicaolino.negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fundicaolino.negocio
{
    public class Banco : DbContext
    {
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<Material> Materiais { get; set; }
        public virtual DbSet<Processo> Processos { get; set; }
        public virtual DbSet<Producao> Producoes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<TipoProduto> TipoProdutos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}
