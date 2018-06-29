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
    public partial class GnGrupoNovo : Form
    {
        public Grupo GrupoSelecionado { get; set; }

        public GnGrupoNovo()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();

            grupo.NomeGrupo = TxNameGroup.Text;
            grupo.Permissaousuario = XboxUsuario.Checked ? true : false;
            grupo.Permissaoproduto = XboxProduto.Checked ? true : false;
            grupo.Permissaoproducao = XboxProducao.Checked ? true : false;
            grupo.Permissaoprocesso = XboxProcesso.Checked ? true : false;
            grupo.Permissaocontroleproducao = XboxControleProducao.Checked ? true : false;
            grupo.Permissaoqualidade = XboxControleQualidade.Checked ? true : false;

            Validacao validacao;
            if (GrupoSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarGrupo(grupo);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarGrupo(grupo);
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
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
