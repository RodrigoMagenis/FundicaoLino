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
        public Validacao RemoverUsuario(Usuario usuario)
        {
            Validacao validacao = new Validacao();
            banco.Usuarios.Remove(usuario);
            return validacao;
        }
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

            //if (String.IsNullOrEmpty(usuario.GrupoUsuario.Id.ToString()))
            //{
            //    validacao.Mensagens.Add("grupo", "Requer um grupo de acesso");
            //}

            if (validacao.Valido)
            {
                this.banco.Usuarios.Add(usuario);
                this.banco.SaveChanges();
            }

            return validacao;
        }

        public Validacao AlterarUsuario(Usuario UsuarioAlterado)
        {
            Validacao validacao = new Validacao();
            Usuario UsuarioBanco = BuscaUsuarioPorId(UsuarioAlterado.Id);

            if (String.IsNullOrEmpty(UsuarioAlterado.NmUsuario))
            {
                validacao.Mensagens.Add("nome", "Requer um nome de usuário");
            }

            if (String.IsNullOrEmpty(UsuarioAlterado.Idmatricula.ToString()))
            {
                validacao.Mensagens.Add("matricula", "Requer uma matrícula");
            }
            if (String.IsNullOrEmpty(UsuarioAlterado.Idgrupo.ToString()))
            {
                validacao.Mensagens.Add("grupo", "Requer um grupo de acesso");
            }

            if (validacao.Valido)
            {
                UsuarioBanco.Idgrupo = UsuarioAlterado.Idgrupo;
                UsuarioBanco.Idmatricula = UsuarioAlterado.Idmatricula;
                UsuarioBanco.NmUsuario = UsuarioAlterado.NmUsuario;
                UsuarioBanco.NmLogin = UsuarioAlterado.NmLogin;
                UsuarioBanco.IdSenha = UsuarioAlterado.IdSenha;
                this.banco.SaveChanges();
            }
            return validacao;
        }
        public Validacao AdicionarGrupo(Grupo grupo)
        {
            Validacao validacao = new Validacao();
            if (String.IsNullOrEmpty(grupo.NomeGrupo))
            {
                validacao.Mensagens.Add("nome", "Requer um nome de Grupo");
            }
            if (validacao.Valido)
            {
                this.banco.Grupos.Add(grupo);
                this.banco.SaveChanges();
            }
            return validacao;
        }
        public Validacao AlterarGrupo (Grupo GrupoAlterado)
        {
            Validacao validacao = new Validacao();
            Grupo GrupoBanco = BuscaGrupoPorId(GrupoAlterado.Id);
            if (String.IsNullOrEmpty(GrupoAlterado.NomeGrupo))
            {
                validacao.Mensagens.Add("nome", "Requer um nome de Grupo");
            }
            if (validacao.Valido)
            {
                GrupoBanco.NomeGrupo = GrupoAlterado.NomeGrupo;
                this.banco.SaveChanges();
            }
            return validacao;
        }
        public Usuario BuscaUsuarioPorId(long Id)
        {
            return this.banco.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
        }
        public Grupo BuscaGrupoPorId(long Id)
        {
            return this.banco.Grupos.Where(g => g.Id == Id).FirstOrDefault();
        }
        
    }
}
