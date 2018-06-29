using Fundicaolino.negocio;
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
    public partial class GnNovaMateriaPrima : Form
    {
        public Usuario MateriaPrimaSelecionado { get; set; }

        public GnNovaMateriaPrima()
        {
            InitializeComponent();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Material materiaPrima = new Material();
            Boolean resultado;
            Decimal decimalConvertido;

            resultado = Decimal.TryParse(tbPesoMaterial.Text, out decimalConvertido);
            if (resultado)
            {
                materiaPrima.VlPesoMaterial = decimalConvertido;
            }
            else
            {
                materiaPrima.VlPesoMaterial = -1;
            }

            materiaPrima.NmMaterial = tbNmMaterial.Text;

            Validacao validacao;
            if (MateriaPrimaSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarMateriaPrima(materiaPrima);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarMateriaPrima(materiaPrima);
            }

            try
            {

                if (!validacao.Valido)
                {
                    String mensagemValidacao = "";
                    foreach (var chave in validacao.Mensagens.Keys)
                    {
                        String msg = validacao.Mensagens[chave];
                        mensagemValidacao += msg;
                        mensagemValidacao += Environment.NewLine;
                    }
                    MessageBox.Show(mensagemValidacao);
                }

                else
                {
                    MessageBox.Show("Usuário salvo com sucesso");
                    this.Close();
                }

            }

            catch
            {
                MessageBox.Show("Ocorreu uma falha grave, contate um administrador");
                this.Close();
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
