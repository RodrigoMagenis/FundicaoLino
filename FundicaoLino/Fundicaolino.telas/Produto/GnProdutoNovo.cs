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

namespace Fundicaolino.telas.Produto
{
    public partial class GnProdutoNovo : Form
    {
        public dbProduto produtoSelecionado = new dbProduto();
        public GnProdutoNovo()
        {
            InitializeComponent();
        }

        private void GnProdutoNovo_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
        }

        private void CarregaComboBox()
        {
            cbCodigoTipodeProduto.DisplayMember = "NmTipoProduto";
            cbCodigoTipodeProduto.ValueMember = "Id";
            cbCodigoTipodeProduto.DataSource = Program.Gerenciador.TodosOsTiposProdutos();

            cbResponsavel.DisplayMember = "NmUsuario";
            cbResponsavel.ValueMember = "Id";
            cbResponsavel.DataSource = Program.Gerenciador.TodosOsUsuarios();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                produtoSelecionado.Responsavel = cbResponsavel.SelectedItem as Usuario;
                produtoSelecionado.TPProduto = cbCodigoTipodeProduto.SelectedItem as TipoProduto;
                produtoSelecionado.DtProduto = DateTime.Now;

                Validacao validacao;
                validacao = Program.Gerenciador.AdicionarProduto(produtoSelecionado);

                if (validacao.Valido)
                {
                    MessageBox.Show("Produto registrado com sucesso!");
                    this.Close();
                }
                else
                {
                    String msg = "";
                    foreach (var mensagem in validacao.Mensagens)
                    {
                        msg += mensagem + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma falha grave, contate um administrador");
                this.Close();
            }

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbResponsavel_Click(object sender, EventArgs e)
        {

        }

        private void cbResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCodigoTipodeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCodigoTIpodeProduto_Click(object sender, EventArgs e)
        {

        }

    }
}
