using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio
{
    public class Program
    {
        Banco banco = new Banco();
        public Program()
        {
          banco.SaveChanges();
            this.banco.SaveChanges();
        }

        static void Main(string[] args)
        {
           
        }
    }
}
