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
        public long Id { get; set; }
        public long IdTipoProduto { get; set; }
        public long IdResponsavel { get; set; }
    }
}
