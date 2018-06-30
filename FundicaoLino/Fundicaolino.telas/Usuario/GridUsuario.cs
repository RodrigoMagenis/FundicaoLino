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
    public partial class GridUsuario : Form
    {
        public GridUsuario()
        {
            InitializeComponent();
        }

        public void CarregarUsuarios()
        {
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuario.MultiSelect = false;
            dgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuario.AutoGenerateColumns = false;
            List<Usuario> usuarios = Program.Gerenciador.TodosOsUsuarios();
            dgUsuario.DataSource = usuarios;
        }

        public void GridUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        public bool VerificaSelecao()
        {
            if (dgUsuario.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
    }
}
