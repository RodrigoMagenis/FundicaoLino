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

namespace Fundicaolino.telas
{
    public partial class CadastraTipoProduto : Form
    {
        public TipoProduto TipoSelecionado { get; set; }

        public CadastraTipoProduto()
        {
            InitializeComponent();
        }

        private void btSalvarProcesso_Click(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = new TipoProduto();
            Boolean resultado;
            Int64 longConvertido;
            Decimal decimalConvertido;

            resultado = Int64.TryParse(TxIdentificador.Text, out longConvertido);
            if (resultado)
            {
                tipoProduto.Id = longConvertido;
            }
            else
            {
                tipoProduto.Id = -1;
            }

            tipoProduto.NmTipoProduto = TxNmProduto.Text;

            resultado = Decimal.TryParse(TxVlPeso.Text, out decimalConvertido);
            if (resultado)
            {
                tipoProduto.VlPeso = decimalConvertido;
            }
            else
            {
                tipoProduto.VlPeso = -1;
            }

            tipoProduto.FgTipoProduto = true;
            //#Feature Haverá relação com o material

            Validacao validacao;
            if (TipoSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarTipoProduto(tipoProduto);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarTipoProduto(tipoProduto);
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
                    MessageBox.Show("Tipo de produto salvo com sucesso");
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
