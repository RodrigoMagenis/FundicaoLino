using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio.Models
{
    public class TipoProduto
    {
        private long    CdTipoProduto { get; set; }
        private string  NmTipoProduto { get; set; }
        private decimal VlPeso { get; set; }
        private long    CdMateriais { get; set; }
    }

}
