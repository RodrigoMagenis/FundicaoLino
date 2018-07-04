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
using System.Windows.Forms.DataVisualization.Charting;

namespace Fundicaolino.telas.Controle
{
    public partial class GraficoProdutosProduzidos : Form
    {
        public GraficoProdutosProduzidos()
        {
            InitializeComponent();
        }

        private void GraficoProdutosProduzidos_Load(object sender, EventArgs e)
        {
            CarregarGrafico();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrafico();
        }

        public void CarregarGrafico()
        {
            //ProducaoChart.ChartAreas.Clear();
            ProducaoChart.Series.Clear();
            ProducaoChart.ResetAutoValues();
            try
            {
                DateTime dataInicial = dpDataInicial.Value.Date;
                DateTime dataFinal = dpDataFinal.Value.Date.AddDays(1); // adiciona um dia para contar no término dele
                var TESTE = dataFinal - dataInicial;
                if (TESTE.TotalMilliseconds > 0) //verifica se a data de fim é menor que a data de inicio
                {
                    IEnumerable<dbProduto> todosOsProdutos = Program.Gerenciador.TodosOsProdutos();
                    if (XboxFiltroPorResponsavel.Checked)
                    {
                        todosOsProdutos = todosOsProdutos.Where(r => r.NmResponsavel == CbResponsavel.Text); // Se a opção de filtro por usuário estiver ativa
                    }
                    var produtosSelecionados = todosOsProdutos.Where(d => d.DtProduto >= dataInicial && d.DtProduto <= dataFinal)
                        .GroupBy(t => t.TPProduto)
                        .Select(n => new
                        {
                            MetricName = n.Key,
                            MetricCount = n.Count()
                        }
                        )
                        .OrderByDescending(n => n.MetricCount).Take(25);
                    if (produtosSelecionados.Count() != 0)
                    {
                        foreach (var produto in produtosSelecionados)
                        {
                            String nome = Convert.ToString(produto.MetricName.NmTipoProduto);
                            ProducaoChart.Series.Add(nome);
                            ProducaoChart.Series[nome].ChartType = SeriesChartType.Column;
                            ProducaoChart.Series[nome].Points.AddY(produto.MetricCount);
                            ProducaoChart.Series[nome].ChartArea = "ChartArea1";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto foi produzido nesse intervalo de tempo");
                    }
                }
                else
                {
                    MessageBox.Show("A data final não pode ser anterior a data inicial");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu uma falha grave, por favor comunique o administrador");
            }

            

        }

        private void XboxFiltroPorResponsavel_CheckedChanged(object sender, EventArgs e)
        {
            if (XboxFiltroPorResponsavel.Checked)
            {
                CbResponsavel.Enabled = true;
                CarregaComboBox();
            }
            else
            {
                CbResponsavel.Enabled = false;
            }
        }

        private void CarregaComboBox()
        {
            CbResponsavel.DisplayMember = "NmUsuario";
            CbResponsavel.ValueMember = "Id";
            CbResponsavel.DataSource = Program.Gerenciador.TodosOsUsuarios();
        }
    }
}
