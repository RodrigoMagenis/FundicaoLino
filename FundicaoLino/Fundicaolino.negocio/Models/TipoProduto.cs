using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "TipoProduto")]
    public class TipoProduto
    {
        public long                  Id { get; set; }
        public string                NmTipoProduto { get; set; }
        public decimal               VlPeso { get; set; }
        public ICollection<Material> Materiais { get; set; }
        public Boolean               FgTipoProduto { get; set; }

        public TipoProduto()
        {
            this.Materiais = new List<Material>();
        }
    }
}
