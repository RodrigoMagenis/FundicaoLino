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
    public partial class GridGrupo : Form
    {
        public GridGrupo()
        {
            InitializeComponent();
        }

        public void CarregarGrupos()
        {
            dgGrupo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgGrupo.MultiSelect = false;
            dgGrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGrupo.AutoGenerateColumns = false;
            List<Grupo> grupos = Program.Gerenciador.TodosOsGrupos();
            dgGrupo.DataSource = grupos;
        }

        public void GridGrupo_Load(object sender, EventArgs e)
        {
            CarregarGrupos();
        }

        public bool VerificaSelecao()
        {
            if(dgGrupo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
