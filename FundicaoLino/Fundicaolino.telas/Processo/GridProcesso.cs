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
    public partial class GridProcesso : Form
    {
        public GridProcesso()
        {
            InitializeComponent();
        }
        public void CarregarProcessos()
        {
            dgProcesso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProcesso.MultiSelect = false;
            dgProcesso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProcesso.AutoGenerateColumns = false;
            List<Processo> processos = Program.Gerenciador.TodosOsProcessos();
            dgProcesso.DataSource = processos;
        }
        private void GridProcesso_Load(object sender, EventArgs e)
        {
            CarregarProcessos();
        }
        public bool VerificaSelecao()
        {
            if (dgProcesso.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
