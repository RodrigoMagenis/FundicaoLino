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

namespace Fundicaolino.telas.MateriaPrima
{
    public partial class GridMateriaPrima : Form
    {
        public GridMateriaPrima()
        {
            InitializeComponent();
        }

        public void CarregarMateriasPrimas()
        {
            dgMateriaPrima.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMateriaPrima.MultiSelect = false;
            dgMateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMateriaPrima.AutoGenerateColumns = false;
            List<Material> materiasPrimas = Program.Gerenciador.TodasAsMateriasPrimas();
            dgMateriaPrima.DataSource = materiasPrimas;
        }

        private void GridMateriaPrima_Load(object sender, EventArgs e)
        {
            this.CarregarMateriasPrimas();
        }

        public bool VerificaSelecao()
        {
            if (dgMateriaPrima.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
