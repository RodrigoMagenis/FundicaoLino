using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio.Models
{
    public class Usuario
    {
        private long cdUsuario { get; set; }
        private string nmUsuario { get; set; }
        private int cdmatricula { get; set; }
        private long cdgrupo { get; set; }
        private string nmLogin { get; set; }
        private int cdSenha { get; set; }
    }
}
