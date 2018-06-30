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
                this.CarregaDataGrid();
            }
        }

        private void ConsultaResponsavel_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        public void CarregaDataGrid()
        {
            dgProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProduto.MultiSelect = false;
            dgProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProduto.AutoGenerateColumns = false;
            List<dbProduto> todosOsProdutos = Program.Gerenciador.TodosOsProdutos();
            var produtoSelecionado = todosOsProdutos.Where(p => p.Id == produto.Id);
            dgProduto.DataSource = produtoSelecionado;
        }
    }
}
