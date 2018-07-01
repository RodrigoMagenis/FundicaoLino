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
    public partial class dgTipodeProdutoFundo : Form
    {
        public dgTipodeProdutoFundo()
        {
            InitializeComponent();
        }

        public void CarregarTiposProdutos()
        {
            GridTipoProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridTipoProduto.MultiSelect = false;
            GridTipoProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridTipoProduto.AutoGenerateColumns = false;
            List<TipoProduto> usuarios = Program.Gerenciador.TodosOsTiposProdutos();
            GridTipoProduto.DataSource = usuarios;
        }

        public void dgTipoProduto_Load(object sender, EventArgs e)
        {
            this.CarregarTiposProdutos();
        }

        public bool VerificaSelecao()
        {
            if (GridTipoProduto.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
