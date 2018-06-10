using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "Processo")]
    public class Processo
    {
        public long     Id { get; set; }
        public String   NmProcesso { get; set; }
        // #Feature Inserir uma coleção de etapas de processos que possuam id e nome
    }
}
