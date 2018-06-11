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
        public Boolean  FgGrupo { get; set; }
        public Boolean Permissaousuario { get; set; }
        public Boolean Permissaoproducao { get; set; }
        public Boolean Permissaoqualidade { get; set; }
        public Boolean Permissaoprocesso { get; set; }
        public Boolean Permissaoproduto { get; set; }
    }
}
