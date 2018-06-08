using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "Grupo")]
    public class Grupo
    {
        public string NomeGrupo { get; set; }
        public long   Id { get; set; }
        public Int16  FgGrupo { get; set; }
        public Int16  Permissaousuario { get; set; }
        public Int16  Permissaoproducao { get; set; }
        public Int16  Permissaoqualidade { get; set; }
        public Int16  Permissaoprocesso { get; set; }
        public Int16  Permissaoproduto { get; set; }
    }
}
