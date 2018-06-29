using Fundicaolino.negocio;
using Fundicaolino.negocio.Models;
using Fundicaolino.telas.Controle;
using Fundicaolino.telas.MateriaPrima;
using Fundicaolino.telas.Produto;
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
    public partial class TelaPrincipal : Form
    {
        private int childFormNumber = 0;
        private int tela;

        public TelaPrincipal()
        {
            InitializeComponent();
        }
        public static GridUsuario GridUsuario = new GridUsuario();
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
            private void GenericaExluir_Click(object sender, EventArgs e)
        {

            switch (tela)
            {
                case 1://grupo
                    var gridGrupo = (GridGrupo)panel4.Controls[0];

                    break;
                case 2://usuario
                    var gridUsuario = (GridUsuario)panel4.Controls[0];
                    if (gridUsuario.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                                Usuario usuarioSelecionado = (Usuario)gridUsuario.dgUsuario.SelectedRows[0].DataBoundItem;
                                var validacao = Program.Gerenciador.RemoverUsuario(usuarioSelecionado);
                                if (validacao.Valido)
                                {
                                    MessageBox.Show("Usuario removido com sucesso");
                                }
                                else
                                {
                                    MessageBox.Show("Ocorreu um problema ao remover o Usuario");
                                }
                            gridUsuario.CarregarUsuarios();
                            }
                    }
                break;
                case 3:
                    break;
                case 4:
                    break;
                case 5://producao
                    var gridProducao = (GridProducao)panel4.Controls[0];
                    if (gridProducao.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            Producao producaoSelecionada = (Producao)gridProducao.dgProducao.SelectedRows[0].DataBoundItem;
                            var validacao = Program.Gerenciador.RemoverProducao(producaoSelecionada);
                            if (validacao.Valido)
                            {
                                MessageBox.Show("Produção removida com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um problema ao remover a Produção");
                            }
                            gridProducao.CarregarProducoes();
                        }
                    }
                    break;
                case 6://processo
                   /* var gridProcesso = (GridProcesso)panel4.Controls[0];
                    if (gridProcesso.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            Processo processoSelecionado = (Processo)gridProcesso.dgProcesso.SelectedRows[0].DataBoundItem;
                            var validacao = Program.Gerenciador.RemoverProcesso(processoSelecionado);
                            if (validacao.Valido)
                            {
                                MessageBox.Show("Processo removido com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um problema ao remover o Processo");
                            }
                            gridProcesso.CarregarProcessos();
                        }
                    }*/
                    break;
                case 7://tipo de produto
                    var gridTipodeProduto = (GridTipoProduto)panel4.Controls[0];
                    if (gridTipodeProduto.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            TipoProduto tipoProdutoSelecionado = (TipoProduto)gridTipodeProduto.dgTipodeProduto.SelectedRows[0].DataBoundItem;
                            var validacao = Program.Gerenciador.RemoverTipodeProduto(tipoProdutoSelecionado);
                            if (validacao.Valido)
                            {
                                MessageBox.Show("Tipo de produto removido com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um problema ao remover o tipo de produto");
                            }
                            gridTipodeProduto.CarregarTipodeProduto();
                        }
                    }
                        break;
                case 8:
                    break;
                case 9:
                    break;
                case 10://materia prima
                    var gridMateriaPrima = (GridMateriaPrima)panel4.Controls[0];
                    if (gridMateriaPrima.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            Material materialSelecionado = (Material)gridMateriaPrima.dgMateriaPrima.SelectedRows[0].DataBoundItem;
                            var validacao = Program.Gerenciador.RemoverMateriaPrima(materialSelecionado);
                            if (validacao.Valido)
                            {
                                MessageBox.Show("Tipo de produto removido com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um problema ao remover o tipo de produto");
                            }
                            gridMateriaPrima.CarregarMateriasPrimas();
                        }
                    }
                    break;
                case 11://produto
                    var gridProduto = (GridProduto)panel4.Controls[0];
                    if (gridProduto.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            dbProduto produtoSelecionado = (dbProduto)gridProduto.dgProduto.SelectedRows[0].DataBoundItem;
                            var validacao = Program.Gerenciador.RemoverProduto(produtoSelecionado);
                            if (validacao.Valido)
                            {
                                MessageBox.Show("Tipo de produto removido com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um problema ao remover o tipo de produto");
                            }
                            gridProduto.CarregarProdutos();
                        }
                    }
                    break;
                default:
                    
                    break;

            }
        }

        private void GenericoNovo_Click(object sender, EventArgs e)
        {
            switch (tela)
                {
                case 1:
                    //gridGrupo.Close();
                    GnGrupoNovo telaNovoGrupo = new GnGrupoNovo();
                    telaNovoGrupo.MdiParent = this;
                    panel4.Controls.Add(telaNovoGrupo);
                    telaNovoGrupo.Show();
                    break;
                case 2:
                    //gridUsuario.Close();
                    GnUsuarioNovo telaNovoUsuario = new GnUsuarioNovo();
                    telaNovoUsuario.MdiParent = this ;
                    panel4.Controls.Add(telaNovoUsuario);
                    telaNovoUsuario.Show();
                    break;
                case 3:
                    ///////////////////////////////////////////////////////////////////////FAZER///////////////////////////////////////////////////
                    break;
                case 4:
                    ///////////////////////////////////////////////////////////////////////FAZER///////////////////////////////////////////////////
                    break;
                case 5:
                    //gridProducao.Close();
                    GnCadProducao CadastraNovaProducao = new GnCadProducao();
                    CadastraNovaProducao.MdiParent = this;
                    panel4.Controls.Add(CadastraNovaProducao);
                    CadastraNovaProducao.Show();
                    break;
                case 6:
                    //gridProcesso.Close();
                    GnGerProcesso cadastraNovoProcesso = new GnGerProcesso();
                    cadastraNovoProcesso.MdiParent = this;
                    panel4.Controls.Add(cadastraNovoProcesso);
                    cadastraNovoProcesso.Show();
                    break;
                case 7:
                    //gridProduto.Close();
                    CadastraTipoProduto cadastraNovoTipoProduto = new CadastraTipoProduto();
                    cadastraNovoTipoProduto.MdiParent = this;
                    panel4.Controls.Add(cadastraNovoTipoProduto);
                    cadastraNovoTipoProduto.Show();


                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    GnNovaMateriaPrima gnNovaMateriaPrima = new GnNovaMateriaPrima();
                    gnNovaMateriaPrima.MdiParent = this;
                    panel4.Controls.Add(gnNovaMateriaPrima);
                    gnNovaMateriaPrima.Show();
                    break;
                case 11:
                    GnProdutoNovo gnProdutoNovo = new GnProdutoNovo();
                    gnProdutoNovo.MdiParent = this;
                    panel4.Controls.Add(gnProdutoNovo);
                    gnProdutoNovo.Show();
                    break;
                default:
                    Console.WriteLine("ZONA DE CONFORTO");
                    break;
            }
        }



        private void Genericagerenciargrupo_Click(object sender, EventArgs e)
        {
            GridGrupo gridGrupo = new GridGrupo();
            gridGrupo.MdiParent = this;
            panel4.Controls.Add(gridGrupo);
            gridGrupo.Show();
            tela = 1;
        }

        private void Genericagerenciarusuario_Click(object sender, EventArgs e)
        {
            GridUsuario gridUsuario = new GridUsuario();
            gridUsuario.MdiParent = this;
            panel4.Controls.Add(gridUsuario);
            gridUsuario.Show();
            tela = 2;
        }

        private void GenericaControleProducao_Click(object sender, EventArgs e)
        {
            GraficoProducao graficoProducao = new GraficoProducao();
            graficoProducao.MdiParent = this;
            panel4.Controls.Add(graficoProducao);
            graficoProducao.Show();
            tela = 3;
        }

        private void GenericaControleQualidade_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////FAZER///////////////////////////////////////////////////
            tela = 4;
        }
        private void btCadastraProducao_Click(object sender, EventArgs e)
        {
            GridProducao gridProducao = new GridProducao();
            gridProducao.MdiParent = this;
            panel4.Controls.Add(gridProducao);
            gridProducao.Show();
            tela = 5;
        }
        private void Genericacadastrarprocesso_Click(object sender, EventArgs e)
        {
            GridProcesso gridProcesso = new GridProcesso();
            gridProcesso.MdiParent = this;
            panel4.Controls.Add(gridProcesso);
            gridProcesso.Show();
            tela = 6;
        }

        private void Genericacadastrarproduto_Click(object sender, EventArgs e)
        {
            dgTipoProduto gridTipoProduto = new dgTipoProduto();
            gridTipoProduto.MdiParent = this;
            panel4.Controls.Add(gridTipoProduto);
            gridTipoProduto.Show();
            tela = 7;
        }

        private void Genericaexibirfiladeproducao_Click(object sender, EventArgs e)
        {
            GridFiladeProducao gridFilaProducao = new GridFiladeProducao();
            gridFilaProducao.MdiParent = this;
            panel4.Controls.Add(gridFilaProducao);
            gridFilaProducao.Show();
            tela = 8;
        }

        private void Genericacontroleemtemporeal_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////FAZER///////////////////////////////////////////////////
            tela = 9;
        }

        private void btCadastraMateriaPrima_Click(object sender, EventArgs e)
        {
            GridMateriaPrima gridMateriaPrima = new GridMateriaPrima();
            gridMateriaPrima.MdiParent = this;
            panel4.Controls.Add(gridMateriaPrima);
            gridMateriaPrima.Show();
            tela = 10;
        }

        private void btGerenciarProdutos_Click(object sender, EventArgs e)
        {
            GridProduto gridProduto = new GridProduto();
            gridProduto.MdiParent = this;
            panel4.Controls.Add(gridProduto);
            gridProduto.Show();
            tela = 11;
        }

        private void GenericaVisualizarProduto_Click(object sender, EventArgs e)
        {
            ConsultarResponsavel consultarResponsavel = new ConsultarResponsavel();
            consultarResponsavel.MdiParent = this;
            panel4.Controls.Add(consultarResponsavel);
            consultarResponsavel.Show();
            tela = 11;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
