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
        public GnNovaMateriaPrima()
        {
            InitializeComponent();
        }
        public Material MaterialSelecionado { get; set; }
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            Boolean resultado;
            Int64 longConvertido;

            resultado = Int64.TryParse(tbNmMaterial.Text, out longConvertido);
            if (resultado)
            {
                material.Id = longConvertido;
            }
            else
            {
                material.Id = -1;
            }

            Validacao validacao;
            if (MaterialSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarMaterial(material);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarMaterial(material);
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
                    MessageBox.Show("Material salvo com sucesso");
                    this.Close();
                }

            }

            catch
            {
                MessageBox.Show("Ocorreu uma falha grave, contate um administrador");
                this.Close();
            }
        }
    }
}
