﻿using System;
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
        public long     CdProcesso { get; set; }
        public String     NmProcesso { get; set; }
        public Int16    EtapaProcesso { get; set; }
    }
}
