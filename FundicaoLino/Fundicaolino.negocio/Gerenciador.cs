using Fundicaolino.negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundicaolino.negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        public Validacao AdicionarUsuario(Usuario usuario)
        {
            Validacao validacao = new Validacao();
            if (String.IsNullOrEmpty(usuario.NmUsuario))
            {
                validacao.Mensagens.Add("nome", "Requer um nome de usuário");
            }

            if (String.IsNullOrEmpty(usuario.Idmatricula.ToString()))
            {
                validacao.Mensagens.Add("matricula", "Requer uma matrícula");
            }

            if (this.banco.Usuarios.Where(x => x.Idmatricula == usuario.Idmatricula).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("matricula", "Essa matricula já está em uso");
            }

            if (String.IsNullOrEmpty(usuario.Idgrupo.ToString()))
            {
                validacao.Mensagens.Add("grupo", "Requer um grupo de acesso");
            }

            if (validacao.Valido)
            {
                this.banco.Usuarios.Add(usuario);
                this.banco.SaveChanges();
            }

            return validacao;
        }

        public Validacao AlterarUsuario(Usuario usuario)
        {
            Validacao validacao = new Validacao();
            //TODO
            return validacao;
        }
        
    }
}
