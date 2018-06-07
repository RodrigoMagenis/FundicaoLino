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
        public long Id { get; set; }
        public string nmUsuario { get; set; }
        public int Idmatricula { get; set; }
        public long Idgrupo { get; set; }
        public string nmLogin { get; set; }
        public int IdSenha { get; set; }
    }
}
