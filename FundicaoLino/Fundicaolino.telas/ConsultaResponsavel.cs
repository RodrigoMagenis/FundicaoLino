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
    public partial class ConsultaResponsavel : Form
    {
        dbProduto produto = new dbProduto();
        public ConsultaResponsavel()
        {
            InitializeComponent();
        }

private void btPesquisar_Click(object sender, EventArgs e)
        {
            Boolean resultado;
            Int64 longConvertido;

            resultado = Int64.TryParse(tbIdProduto.Text, out longConvertido);
            if (resultado)
            {
                produto.Id = longConvertido;
                this.CarregaDadosNosCampos();
            }
            else
            {
                MessageBox.Show("Insira um valor válido");
            }
        }

        private void ConsultaResponsavel_Load(object sender, EventArgs e)
        {
        }

        public void CarregaDadosNosCampos()
        {
            List<dbProduto> todosOsProdutos = Program.Gerenciador.TodosOsProdutos();
            try
            {
                var produtoSelecionado = todosOsProdutos.Where(p => p.Id == produto.Id).First();
                this.TbResponsavel.Text = produtoSelecionado.Responsavel.NmUsuario;
                this.TbMatricula.Text = produtoSelecionado.Responsavel.Idmatricula.ToString();

                this.TbNmTipoProduto.Text = produtoSelecionado.NmTipoProduto;
                this.TbIdTipoProduto.Text = produtoSelecionado.IdTipoProduto.ToString();

                this.TbData.Text = produtoSelecionado.DtProduto.ToString();
            }
            catch
            {
                MessageBox.Show("Produto não encontrado, verifique o valor informado");
            }
        }
    }
}
