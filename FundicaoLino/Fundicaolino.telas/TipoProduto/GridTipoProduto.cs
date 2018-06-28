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
    public partial class dgTipoProduto : Form
    {
        public dgTipoProduto()
        {
            InitializeComponent();
        }

        private void CarregarTiposProdutos()
        {
            gridTipoProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTipoProduto.MultiSelect = false;
            gridTipoProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTipoProduto.AutoGenerateColumns = false;
            List<TipoProduto> usuarios = Program.Gerenciador.TodosOsTiposProdutos();
            gridTipoProduto.DataSource = usuarios;
        }

        private void dgTipoProduto_Load(object sender, EventArgs e)
        {
            this.CarregarTiposProdutos();
        }

        private bool VerificaSelecao()
        {
            if (gridTipoProduto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
