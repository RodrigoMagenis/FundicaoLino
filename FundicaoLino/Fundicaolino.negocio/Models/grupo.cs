using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio.Models
{
    public class Grupo
    {
        private string nomeGrupo { get; set; }
        private long cdGrupo { get; set; }
        private Int16 fgGrupo { get; set; }
        private Int16 permissaousuario { get; set; }
        private Int16 permissaoproducao { get; set; }
        private Int16 permissaoqualidade { get; set; }
        private Int16 permissaoprocesso { get; set; }
        private Int16 permissaoproduto { get; set; }
    }
}
