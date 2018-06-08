using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "Usuario")]
    public class Usuario
    {
        public long cdUsuario { get; set; }
        public string nmUsuario { get; set; }
        public int cdmatricula { get; set; }
        public long cdgrupo { get; set; }
        public string nmLogin { get; set; }
        public int cdSenha { get; set; }
    }
}
