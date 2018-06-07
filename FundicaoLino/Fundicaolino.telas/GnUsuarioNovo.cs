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
    public partial class GnUsuarioNovo : Form
    {
        public Usuario UsuarioSelecionado { get; set; }

        public GnUsuarioNovo()
        {
            InitializeComponent();
        }

        private void CancelarNovoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtAutoEncremento_Click(object sender, EventArgs e)
        {

        }

        private void GnUsuarioNovo_Load(object sender, EventArgs e)
        {

        }

        private void SalvarNovoUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Boolean resultado;
            Int64 longConvertido;

            resultado = Int64.TryParse(TxIdentificador.Text, out longConvertido);
            if (resultado)
            {
                usuario.cdUsuario = longConvertido;
            }
            else
            {
                usuario.cdUsuario = -1;
            }

            usuario.nmUsuario = TxNomeUsuario.Text;
            usuario.cdmatricula = TxM
        }
    }
}
