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
    public partial class GnCadProducao : Form
    {
        public Usuario ProducaoSelecionada { get; set; }

        public GnCadProducao()
        {
            InitializeComponent();
        }

        private void SalvarNovoUsuario_Click(object sender, EventArgs e)
        {
            Producao producao = new Producao();
            Boolean resultado;
            Int64 longConvertido;
            Int32 intConvertido;

            resultado = Int64.TryParse(TxIdentificador.Text, out longConvertido);
            if (resultado)
            {
                producao.Id = longConvertido;
            }
            else
            {
                producao.Id = -1;
            }

            resultado = Int32.TryParse(TxQuantidade.Text, out intConvertido);
            if (resultado)
            {
                producao.QtProduto = intConvertido;
            }
            else
            {
                producao.Id = -1;
            }

            producao.FgProducao = 1;
            producao.DtProducao = DateTime.Now;

            //#Feature Haverá ligação com o tipos de produtos
            //#Feature Haverá ligação com processos
            //#Feature Poderá selecionar uma data ao invés de apenas a data atual
            //#Feature A funcionalidade de status da produção será implementada futuramente

            Validacao validacao;
            if (ProducaoSelecionada == null)
            {
                validacao = Program.Gerenciador.AdicionarProducao(producao);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarProducao(producao);
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
                    MessageBox.Show("Produção salvo com sucesso");
                    this.Close();
                }

            }

            catch
            {
                MessageBox.Show("Ocorreu uma falha grave, contate um administrador");
                this.Close();
            }
        }

        private void CancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
