using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "Produto")]
    public class Produto
    {
        public long                         Id { get; set; }
        public TipoProduto                  TPProduto { get; set; }
        public virtual ICollection<Usuario> Responsavel { get; set; }
        public DateTime                     DtProduto { get; set; }
        public Producao                     ProducaoProduto { get; set; }
        // #Feature vincula o processo (ou etapa) a data de término
    }
}
