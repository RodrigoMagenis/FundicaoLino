using Fundicaolino.negocio;
using Fundicaolino.negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundicaolino.telas
{
    public partial class GnUsuarioNovo : Form
    {
        public Usuario UsuarioSelecionado { get; set; }
    
        public GnUsuarioNovo()
        {
            InitializeComponent();
        }

        private void CancelarNovoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAutoEncremento_Click(object sender, EventArgs e)
        {
            TxMatricula.Text = Convert.ToString(Program.Gerenciador.NovaMatricula());
        }

        private void GnUsuarioNovo_Load(object sender, EventArgs e)
        {

        }

        private void SalvarNovoUsuario_Click(object sender, EventArgs e)
        {
           
            Usuario usuario = new Usuario();
            Boolean resultado;
            Int64 longConvertido;
            Int32 intConvertido;

            resultado = Int64.TryParse(TxIdentificador.Text, out longConvertido);
            if (resultado)
            {
                usuario.Id = longConvertido;
            }
            else
            {
                usuario.Id = -1;
            }

            usuario.NmUsuario = TxNomeUsuario.Text;

            resultado = Int32.TryParse(TxMatricula.Text, out intConvertido);
            if (resultado)
            {
                usuario.Idmatricula = intConvertido;
            }
            else
            {
                usuario.Idmatricula = -1;
            }

            usuario.NmLogin = TxNomeUsuario.Text;
            usuario.FgUsuario = true;
            usuario.NmSenha = "cop12345"; 
            //#Feature Haverá uma tela de configuração do sistema que permitirá selecionar uma senha padrão
            //#Feature Haverá relação com o grupo de acesso no cadastro de usuário;

            Validacao validacao;
            if (UsuarioSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarUsuario(usuario);
            }
            else
            {
                usuario.Id = UsuarioSelecionado.Id;
                validacao = Program.Gerenciador.AlterarUsuario(usuario);
            }

            try
            {

                if (!validacao.Valido)
                {
                    String mensagemValidacao = "";
                    foreach (var chave in validacao.Mensagens.Keys)
                    {
                        String msg = validacao.Mensagens[chave];
                        mensagemValidacao += msg;
                        mensagemValidacao += Environment.NewLine;
                    }
                    MessageBox.Show(mensagemValidacao);
                }

                else
                {
                    MessageBox.Show("Usuário salvo com sucesso");
                    this.Close();
                }

            }

            catch
            {
                MessageBox.Show("Ocorreu uma falha grave, contate um administrador");
                this.Close();
            }
        }

        private void GnUsuarioNovo_Shown(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                this.TxIdentificador.Text = UsuarioSelecionado.Id.ToString();
                this.TxNomeUsuario.Text = UsuarioSelecionado.NmUsuario.ToString();
                this.TxMatricula.Text = UsuarioSelecionado.Idmatricula.ToString();
                //this.dgGruposSelecionados.Text = UsuarioSelecionado.GrupoUsuario.ToString();
            }
        }
    }
}
