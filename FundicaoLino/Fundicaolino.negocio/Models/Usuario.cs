﻿using System;
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
        public long                       Id { get; set; }
        public string                     NmUsuario { get; set; }
        public int                        Idmatricula { get; set; }
        public virtual ICollection<Grupo> GrupoUsuario { get; set; }
        public string                     NmLogin { get; set; }
        public string                     NmSenha { get; set; }
        public Boolean                    FgUsuario { get; set; }

    }
}
