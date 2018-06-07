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
        public long CdProduto { get; set; }
        public long CdTipoProduto { get; set; }
        public long CdResponsavel { get; set; }
    }
}
