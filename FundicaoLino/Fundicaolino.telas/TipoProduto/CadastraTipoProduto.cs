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
        TipoProduto tipoProduto = new TipoProduto();

        public CadastraTipoProduto()
        {
            InitializeComponent();
        }

        private void btSalvarProcesso_Click(object sender, EventArgs e)
        {
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

        private void CadastraTipoProduto_Load(object sender, EventArgs e)
        {
            this.CarregarMateriasPrimasExistentes();
            this.CarregarMateriasPrimasSelecionadas();
        }

        private void CarregarDataGrids()
        {
            CarregarMateriasPrimasExistentes();
            CarregarMateriasPrimasSelecionadas();
        }

        private void CarregarMateriasPrimasExistentes()
        {
            dgMateriaisExistentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMateriaisExistentes.MultiSelect = false;
            dgMateriaisExistentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMateriaisExistentes.AutoGenerateColumns = false;
            IEnumerable<Material> materiasPrimas = Program.Gerenciador.TodasAsMateriasPrimas();
            if (this.tipoProduto.Materiais.Count > 0)
            {
                //var materiasExistentes = materiasPrimas.Except(this.tipoProduto.Materiais);

                List<Material> mats = new List<Material>();

                foreach (Material material in materiasPrimas)
                {
                    bool tem = false;
                    foreach (Material mat in this.tipoProduto.Materiais)
                    {
                        if(mat.Id.Equals(material.Id))
                        {
                            tem = true;
                            break;
                        }
                    }

                    if(!tem)
                    {
                        mats.Add(material);
                    }
                }

                dgMateriaisExistentes.DataSource = mats;
            }
            else
            {
                dgMateriaisExistentes.DataSource = materiasPrimas;
            }
            
        }

        private void CarregarMateriasPrimasSelecionadas()
        {
            dgMateriasSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMateriasSelecionados.MultiSelect = false;
            dgMateriasSelecionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMateriasSelecionados.AutoGenerateColumns = false;
            List<Material> materiasPrimasSelecionadas = this.tipoProduto.Materiais.ToList();
            dgMateriasSelecionados.DataSource = materiasPrimasSelecionadas;
        }

        private bool VerificaSelecaoMateriasPrimasExistentes()
        {
            if (dgMateriaisExistentes.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private bool VerificaSelecaoMateriasPrimasSelecionadas()
        {
            if (dgMateriasSelecionados.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btDireita_Click(object sender, EventArgs e)
        {
            if (this.VerificaSelecaoMateriasPrimasExistentes())
            {
                Material materialSelecionado = (Material)dgMateriaisExistentes.SelectedRows[0].DataBoundItem;
                tipoProduto.Materiais.Add(materialSelecionado);
                CarregarDataGrids();
            }
        }

        private void btEsquerdo_Click(object sender, EventArgs e)
        {
            if (this.VerificaSelecaoMateriasPrimasSelecionadas())
            {
                Material materialSelecionado = (Material)dgMateriasSelecionados.SelectedRows[0].DataBoundItem;
                tipoProduto.Materiais.Remove(materialSelecionado);
                CarregarDataGrids();
            }
        }
    }

}
