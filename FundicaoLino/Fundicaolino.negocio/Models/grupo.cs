using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio.Models
{
    public class Grupo
    {
        private string NomeGrupo { get; set; }
        private long   CdGrupo { get; set; }
        private Int16  FgGrupo { get; set; }
        private Int16  Permissaousuario { get; set; }
        private Int16  Permissaoproducao { get; set; }
        private Int16  Permissaoqualidade { get; set; }
        private Int16  Permissaoprocesso { get; set; }
        private Int16  Permissaoproduto { get; set; }
    }
}
