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
    public partial class GridProducao : Form
    {
        public GridProducao()
        {
            InitializeComponent();
        }

        private void GridProducao_Load(object sender, EventArgs e)
        {
            CarregarProducoes();
        }
        public void CarregarProducoes()
        {
            dgProducao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProducao.MultiSelect = false;
            dgProducao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducao.AutoGenerateColumns = false;
            List<Producao> producoes = Program.Gerenciador.TodasAsProducoes();
            dgProducao.DataSource = producoes;
        }

        public bool VerificaSelecao()
        {
            if (dgProducao.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
