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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (Program.Gerenciador.TodosOsUsuarios().Count() > 0) //valida se há usuários cadastrados no sistema
            {
                var usuarioLogando = Program.Gerenciador.TodosOsUsuarios().Where(u => u.NmLogin == TxLogin.Text);
                if (usuarioLogando.Count() == 1)
                {
                    if (usuarioLogando.First().NmSenha == TxSenha.Text)
                    {
                        MessageBox.Show("Iniciando seção");
                        TelaPrincipal telaprincipal = new TelaPrincipal();
                        telaprincipal.Show();
                        this.Hide();
                        telaprincipal.FormClosed += fecharTudo; //fecha quando a tela quando a principal é fechada
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha inválida");
                    }
                }
                else if (usuarioLogando.Count() == 0)
                {
                    MessageBox.Show("Login ou senha inválida");
                }
                else
                {
                    MessageBox.Show("Ocorreu um problema com o seu login, entre em contato com o administrador");
                }
            }
            else //cria o primeiro usuário
            {
                Usuario usuario = new Usuario();
                usuario.NmUsuario = "admin";
                usuario.Idmatricula = 0000;
                usuario.NmLogin = usuario.NmUsuario;
                usuario.FgUsuario = true;
                usuario.NmSenha = "gvt12345";
                //#Feature Haverá uma tela de configuração do sistema que permitirá selecionar uma senha padrão
                //#Feature Haverá relação com o grupo de acesso no cadastro de usuário;

                Validacao validacao;
                validacao = Program.Gerenciador.AdicionarUsuario(usuario);

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
                        MessageBox.Show("O sistema não possuia usuários ativos, foi criado um usuário administrador");
                        MessageBox.Show("Username: admin\nsenha: gvt12345");
                    }

                }

                catch
                {
                    MessageBox.Show("Ocorreu uma falha grave, contate um administrador");
                }
            }
            
        }

        private void fecharTudo(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void EsqueciMinhaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com Administrador");
        }
    }
}
