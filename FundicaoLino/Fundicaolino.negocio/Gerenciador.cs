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

 /*--------------------------------------------------------------------------------------------------------------*/

        /* Adiciona / Altera Usuario */
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

            if (banco.Usuarios.Where(x => x.Idmatricula == usuario.Idmatricula).Any() && validacao.Mensagens.Count == 0)
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

            if (validacao.Valido)
            {
                //UsuarioBanco.Idgrupo = UsuarioAlterado.Idgrupo;
                UsuarioBanco.Idmatricula = UsuarioAlterado.Idmatricula;
                UsuarioBanco.NmUsuario = UsuarioAlterado.NmUsuario;
                UsuarioBanco.NmLogin = UsuarioAlterado.NmLogin;
                UsuarioBanco.NmSenha = UsuarioAlterado.NmSenha;
                this.banco.SaveChanges();
            }
            return validacao;
        }

 /*--------------------------------------------------------------------------------------------------------------*/

        /* Adiciona / Altera grupo */
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
        

        /*--------------------------------------------------------------------------------------------------------------*/

        /* Adiciona / Altera Produção */
        public Validacao AdicionarProducao(Producao producao)
        {
            Validacao validacao = new Validacao();
            if (String.IsNullOrEmpty(producao.QtProduto.ToString()))
            {
                validacao.Mensagens.Add("qtd", "A quantidade não pode ser nula ou vazia");
            }

            if (producao.QtProduto <= 0 && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("qtd", "A quantidade não pode ser negativa");
            }
            if (validacao.Valido)
            {
                this.banco.Producoes.Add(producao);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao AlterarProducao(Producao producaoAlterada)
        {
            Validacao validacao = new Validacao();
            Producao producaoBanco = BuscaProducaoPorId(producaoAlterada.Id);
            if (String.IsNullOrEmpty(producaoAlterada.QtProduto.ToString()))
            {
                validacao.Mensagens.Add("qtd", "A quantidade não pode ser nula ou vazia");
            }

            if (producaoAlterada.QtProduto <= 0 && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("qtd", "A quantidade não pode ser negativa");
            }
            if (validacao.Valido)
            {
                producaoBanco.QtProduto = producaoAlterada.QtProduto;
                this.banco.SaveChanges();
            }
            return validacao;
        }

        /*--------------------------------------------------------------------------------------------------------------*/

        /* Adiciona / Altera Tipo de produto */
        public Validacao AdicionarTipoProduto(TipoProduto tipoProduto)
        {
            Validacao validacao = new Validacao();
            if (String.IsNullOrEmpty(tipoProduto.NmTipoProduto.ToString()))
            {
                validacao.Mensagens.Add("nome", "O nome do tipo do produto deve ser informado");
            }

            if (banco.TipoProdutos.Where(x => x.NmTipoProduto == tipoProduto.NmTipoProduto).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("qtd", "A quantidade não pode ser negativa");
            }

            if (tipoProduto.VlPeso != Convert.ToDecimal(null))
            {
                if(tipoProduto.VlPeso < 0)
                {
                    validacao.Mensagens.Add("peso", "O peso deve ser constituido de apenas valores positivos");
                }
            }
            else
            {
                tipoProduto.VlPeso = 0;
            }

            if (validacao.Valido)
            {
                this.banco.TipoProdutos.Add(tipoProduto);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao AlterarTipoProduto(TipoProduto tipoProduto)
        {
            Validacao validacao = new Validacao();
            TipoProduto tipoProdutoBanco = BuscaTipoProdutoPorId(tipoProduto.Id);
            if (String.IsNullOrEmpty(tipoProduto.NmTipoProduto.ToString()))
            {
                validacao.Mensagens.Add("nome", "O nome do tipo do produto deve ser informado");
            }

            if (banco.TipoProdutos.Where(x => x.NmTipoProduto == tipoProduto.NmTipoProduto).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("nome", "A quantidade não pode ser negativa");
            }

            if ( tipoProduto.VlPeso != Convert.ToDecimal ( null ) )
            {
                if (tipoProduto.VlPeso < 0)
                {
                    validacao.Mensagens.Add("peso", "O peso deve ser constituido de apenas valores positivos");
                }
            }
            else
            {
                tipoProduto.VlPeso = 0;
            }

            if (validacao.Valido)
            {
                tipoProdutoBanco.NmTipoProduto = tipoProduto.NmTipoProduto;
                tipoProdutoBanco.VlPeso = tipoProduto.VlPeso;
                this.banco.SaveChanges();
            }
            return validacao;
        }

        /*--------------------------------------------------------------------------------------------------------------*/

        /* Retorna todos os resultados - Usado nas grids */
        public List<Grupo> TodosOsGrupos()
        {
                return this.banco.Grupos.ToList();
        }

        public List<Usuario> TodosOsUsuarios()
        {
            return this.banco.Usuarios.ToList();
        }

        public List<Producao> TodasAsProducoes()
        {
            return this.banco.Producoes.ToList();
        }


        /*--------------------------------------------------------------------------------------------------------------*/

        /* Outros métodos */
        public int NovaMatricula()
        {
            try
            {
                return this.banco.Usuarios.Max(m => m.Idmatricula) + 1;
            }
            catch
            {
                return 1;
            }
        }

        public Usuario BuscaUsuarioPorId(long Id)
        {
            return this.banco.Usuarios.Where(u => u.Id == Id).FirstOrDefault();
        }

        public Grupo BuscaGrupoPorId(long Id)
        {
            return this.banco.Grupos.Where(g => g.Id == Id).FirstOrDefault();
        }

        public Producao BuscaProducaoPorId(long Id)
        {
            return this.banco.Producoes.Where(g => g.Id == Id).FirstOrDefault();
        }

        public TipoProduto BuscaTipoProdutoPorId(long Id)
        {
            return this.banco.TipoProdutos.Where(g => g.Id == Id).FirstOrDefault();
        }
    }
}
