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
    public partial class GridProduto : Form
    {
        public GridProduto()
        {
            InitializeComponent();
        }

        public void CarregarProdutos()
        {
            dgProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProduto.MultiSelect = false;
            dgProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProduto.AutoGenerateColumns = false;
            List<dbProduto> produtos = Program.Gerenciador.TodosOsProdutos();
            dgProduto.DataSource = produtos;
        }

        public void GridProduto_Load(object sender, EventArgs e)
        {
            this.CarregarProdutos();
        }

        public bool VerificaSelecao()
        {
            if (dgProduto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
