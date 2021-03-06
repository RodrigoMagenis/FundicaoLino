﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundicaolino.negocio.Models
{
    [Table(name: "Producao")]
    public class Producao
    {
        public long                             Id { get; set; }
        public int                              QtProduto { get; set; }
        public virtual ICollection<Processo>    Processo { get; set; }
        public DateTime                         DtProducao { get; set; }
        public virtual ICollection<TipoProduto> TipoProduto { get; set; }
        public Int32                            FgProducao { get; set; } //1 - a iniciar, 2- em andamento, 3- suspensa, 4- finalizada
    }
}
