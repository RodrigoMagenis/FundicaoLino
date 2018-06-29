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
    public partial class GridTipoProduto : Form
    {
        public GridTipoProduto()
        {
            InitializeComponent();
        }

        public void CarregarTipodeProduto()
        {
            dgTipodeProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTipodeProduto.MultiSelect = false;
            dgTipodeProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTipodeProduto.AutoGenerateColumns = false;
            List<TipoProduto> tipoProdutos = Program.Gerenciador.TodosOsTiposProdutos();
            dgTipodeProduto.DataSource = tipoProdutos;
        }
        private void GridTipoProduto_Load(object sender, EventArgs e)
        {
            CarregarTipodeProduto();
        }
        public bool VerificaSelecao()
        {
            if (dgTipodeProduto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
