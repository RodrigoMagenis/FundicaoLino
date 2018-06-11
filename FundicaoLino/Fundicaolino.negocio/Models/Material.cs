using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "Material")]
    public class Material
    {
        public long    Id { get; set; }
        public string  NmMaterial { get; set; }
        public decimal VlPesoMaterial { get; set; }
        // #Feature Adicionar status do material (ativo ou não)
    }
}
