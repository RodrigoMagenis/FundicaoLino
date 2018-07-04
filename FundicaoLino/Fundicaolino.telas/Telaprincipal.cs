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
                                MessageBox.Show("Usuário removido com sucesso");
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
                                MessageBox.Show("Usuário removido com sucesso");
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
                                MessageBox.Show("Processo removido com sucesso");
                                this.Close();
                            }
                                gridProcesso.CarregarProcessos();
                            }
                        }*/
                    break;
                case 7://tipo de produto
                    var gridTipodeProduto = (dgTipodeProdutoFundo)panel4.Controls[0];
                    if (gridTipodeProduto.VerificaSelecao())
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                        if (resultado == DialogResult.OK)
                        {
                            TipoProduto tipoProdutoSelecionado = (TipoProduto)gridTipodeProduto.GridTipoProduto.SelectedRows[0].DataBoundItem;
                            var validacao = Program.Gerenciador.RemoverTipodeProduto(tipoProdutoSelecionado);
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
                                MessageBox.Show("Tipo de produto removido com sucesso");
                            }
                            gridTipodeProduto.CarregarTiposProdutos();
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
                                MessageBox.Show("Material removido com sucesso");
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
                                MessageBox.Show("Usuário removido com sucesso");
                            }
                            gridProduto.CarregarProdutos();
                        }
                    }
                    break;
                default:

                    break;

            }
        }
        private GnNovaMateriaPrima gnNovaMateriaPrima;
        private void GenericoNovo_Click(object sender, EventArgs e)
        {
            switch (tela)
                {
                case 1:
                    //gridGrupo.Close();
                    GnGrupoNovo telaNovoGrupo = new GnGrupoNovo();
                    telaNovoGrupo.MdiParent = this;
                    panel4.Controls.Add(telaNovoGrupo);
                    telaNovoGrupo.FormClosing += atualizarGridGrupo;
                    telaNovoGrupo.Show();
                    this.DesabilitarBotoes();
                    break;
                case 2:
                    //gridUsuario.Close();
                    GnUsuarioNovo telaNovoUsuario = new GnUsuarioNovo();
                    telaNovoUsuario.MdiParent = this ;
                    panel4.Controls.Add(telaNovoUsuario);
                    telaNovoUsuario.FormClosing += atualizarGridUsuario;
                    telaNovoUsuario.Show();
                    this.DesabilitarBotoes();
                    break;
                case 5:
                    //gridProducao.Close();
                    GnCadProducao CadastraNovaProducao = new GnCadProducao();
                    CadastraNovaProducao.MdiParent = this;
                    panel4.Controls.Add(CadastraNovaProducao);
                    CadastraNovaProducao.FormClosing += atualizarGridProducao;
                    CadastraNovaProducao.Show();
                    this.DesabilitarBotoes();
                    break;
                case 6:
                    //gridProcesso.Close();
                    GnGerProcesso cadastraNovoProcesso = new GnGerProcesso();
                    cadastraNovoProcesso.MdiParent = this;
                    panel4.Controls.Add(cadastraNovoProcesso);
                    cadastraNovoProcesso.FormClosing += atualizarGridProcesso;
                    cadastraNovoProcesso.Show();
                    this.DesabilitarBotoes();
                    break;
                case 7:
                    //gridProduto.Close();
                    CadastraTipoProduto cadastraNovoTipoProduto = new CadastraTipoProduto();
                    cadastraNovoTipoProduto.MdiParent = this;
                    panel4.Controls.Add(cadastraNovoTipoProduto);
                    cadastraNovoTipoProduto.FormClosing += atualizarGridTipoProduto;
                    cadastraNovoTipoProduto.Show();
                    this.DesabilitarBotoes();
                    break;
                case 10:
                    gnNovaMateriaPrima = new GnNovaMateriaPrima();
                    gnNovaMateriaPrima.MdiParent = this;
                    panel4.Controls.Add(gnNovaMateriaPrima);
                    gnNovaMateriaPrima.FormClosing += atualizarGridMateriaPrima;
                    gnNovaMateriaPrima.Show();
                    this.DesabilitarBotoes();
                    break;
                case 11:
                    GnProdutoNovo gnProdutoNovo = new GnProdutoNovo();
                    gnProdutoNovo.MdiParent = this;
                    panel4.Controls.Add(gnProdutoNovo);
                    gnProdutoNovo.FormClosing += atualizarGridProduto;
                    gnProdutoNovo.Show();
                    this.DesabilitarBotoes();
                    break;
            }
        }

        private void atualizarGridProduto(object sender, FormClosingEventArgs e)
        {
            this.gridProduto.CarregarProdutos();
            this.HabilitaBotoes();
        }

        private void atualizarGridMateriaPrima(object sender, FormClosingEventArgs e)
        {
            this.gridMateriaPrima.CarregarMateriasPrimas();
            this.HabilitaBotoes();
        }

        private void atualizarGridTipoProduto(object sender, FormClosingEventArgs e)
        {
            this.gridTipoProduto.CarregarTiposProdutos();
            this.HabilitaBotoes();
        }

        private void atualizarGridProcesso(object sender, FormClosingEventArgs e)
        {
            // this.gridProcesso.CarregarProcessos();
            // #feature
            this.HabilitaBotoes();
        }

        private void atualizarGridProducao(object sender, FormClosingEventArgs e)
        {
            this.gridProducao.CarregarProducoes();
            this.HabilitaBotoes();
        }

        private void atualizarGridUsuario(object sender, FormClosingEventArgs e)
        {
            this.gridUsuario.CarregarUsuarios();
            this.HabilitaBotoes();
        }

        private void atualizarGridGrupo(object sender, FormClosingEventArgs e)
        {
            this.gridGrupo.CarregarGrupos();
            this.HabilitaBotoes();
        }

        private GridGrupo gridGrupo;
        private void Genericagerenciargrupo_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridGrupo = new GridGrupo();
            gridGrupo.MdiParent = this;
            panel4.Controls.Add(gridGrupo);
            gridGrupo.Show();
            tela = 1;
        }

        private GridUsuario gridUsuario;
        private void Genericagerenciarusuario_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridUsuario = new GridUsuario();
            gridUsuario.MdiParent = this;
            panel4.Controls.Add(gridUsuario);
            gridUsuario.Show();
            tela = 2;
        }

        private GraficoProdutosProduzidos ProducaoChart;
        private void GenericaControleProducao_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            ProducaoChart = new GraficoProdutosProduzidos();
            ProducaoChart.MdiParent = this;
            panel4.Controls.Add(ProducaoChart);
            ProducaoChart.Show();
            tela = 3;
        }
        private GridProducao gridProducao;
        private void btCadastraProducao_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridProducao = new GridProducao();
            gridProducao.MdiParent = this;
            panel4.Controls.Add(gridProducao);
            gridProducao.Show();
            tela = 5;
        }

        private GridProcesso gridProcesso;
        private void Genericacadastrarprocesso_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridProcesso = new GridProcesso();
            gridProcesso.MdiParent = this;
            panel4.Controls.Add(gridProcesso);
            gridProcesso.Show();
            tela = 6;
        }

        private dgTipodeProdutoFundo gridTipoProduto;
        private void Genericacadastrarproduto_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridTipoProduto = new dgTipodeProdutoFundo();
            gridTipoProduto.MdiParent = this;
            panel4.Controls.Add(gridTipoProduto);
            gridTipoProduto.Show();
            tela = 7;
        }

        private GridFiladeProducao gridFilaProducao;
        private void Genericaexibirfiladeproducao_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridFilaProducao = new GridFiladeProducao();
            gridFilaProducao.MdiParent = this;
            panel4.Controls.Add(gridFilaProducao);
            gridFilaProducao.Show();
            tela = 8;
        }

        private void Genericacontroleemtemporeal_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////FAZER///////////////////////////////////////////////////
            this.HabilitaBotoes();
            tela = 9;
        }

        GridMateriaPrima gridMateriaPrima;
        private void btCadastraMateriaPrima_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridMateriaPrima = new GridMateriaPrima();
            gridMateriaPrima.MdiParent = this;
            panel4.Controls.Add(gridMateriaPrima);
            gridMateriaPrima.Show();
            tela = 10;
        }

        GridProduto gridProduto;
        private void btGerenciarProdutos_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            gridProduto = new GridProduto();
            gridProduto.MdiParent = this;
            panel4.Controls.Add(gridProduto);
            gridProduto.Show();
            tela = 11;
        }

        ConsultaResponsavel consultaResponsavel;
        private void pesquisar_Click(object sender, EventArgs e)
        {
            this.HabilitaBotoes();
            consultaResponsavel = new ConsultaResponsavel();
            consultaResponsavel.MdiParent = this;
            panel4.Controls.Add(consultaResponsavel);
            consultaResponsavel.Show();
            tela = 12;
        }

        private void GenericaEditar_Click(object sender, EventArgs e)
        {
            switch (tela)
            {
                case 1:
                    this.DesabilitarBotoes();
                    break;
                case 2://Usuario
                    var gridUsuario = (GridUsuario)panel4.Controls[0];
                    if (gridUsuario.VerificaSelecao())
                    {
                        Usuario UsuarioSelecionado = (Usuario)gridUsuario.dgUsuario.SelectedRows[0].DataBoundItem;
                        AbreTelaInclusaoAlteracaoUsuario(UsuarioSelecionado);
                    }
                    this.DesabilitarBotoes();
                    break;
                case 3:
                    this.DesabilitarBotoes();
                    break;
                case 4:
                    this.DesabilitarBotoes();
                    break;
                case 5:
                    this.DesabilitarBotoes();
                    var producao = (GridProducao)panel4.Controls[0];
                    if (producao.VerificaSelecao())
                    {
                        Producao producaoSelecionada = (Producao)producao.dgProducao.SelectedRows[0].DataBoundItem;
                        AbreTelaInclusaoAlteracaoProducao(producaoSelecionada);
                    }
                    break;
                case 6://processo
                    this.DesabilitarBotoes();
                    break;
                case 7:
                    this.DesabilitarBotoes();
                    var tipoProduto = (dgTipodeProdutoFundo)panel4.Controls[0];
                    if (tipoProduto.VerificaSelecao())
                    {
                        TipoProduto TipoProdutoSelecionado = (TipoProduto)tipoProduto.GridTipoProduto.SelectedRows[0].DataBoundItem;
                        AbreTelaInclusaoAlteracaoTipoProduto(TipoProdutoSelecionado);
                    }
                    break;
                case 8:
                    this.DesabilitarBotoes();
                    break;
                case 9:
                    this.DesabilitarBotoes();
                    break;
                case 10:
                    this.DesabilitarBotoes();
                    var gridMateriaPrima = (GridMateriaPrima)panel4.Controls[0];
                    if (gridMateriaPrima.VerificaSelecao())
                    {
                        Material MateriaPrimaSelecionada = (Material)gridMateriaPrima.dgMateriaPrima.SelectedRows[0].DataBoundItem;
                        AbreTelaInclusaoAlteracaoMaterial(MateriaPrimaSelecionada);
                    }
                    break;
            }
        }
        
        private void AbreTelaInclusaoAlteracaoProducao(Producao producoes)
            {
                GnCadProducao tela = new GnCadProducao();
                tela.MdiParent = this;
                tela.ProducaoSelecionada = producoes;
                panel4.Controls.Add(tela);
                tela.FormClosed += Tela_FormClosedProducao;
                tela.Show();
            }

        private void AbreTelaInclusaoAlteracaoUsuario(Usuario usuarioSelecionado)
            {
                GnUsuarioNovo tela = new GnUsuarioNovo();
                tela.MdiParent = this;
                tela.UsuarioSelecionado = usuarioSelecionado;
                panel4.Controls.Add(tela);
                tela.FormClosed += Tela_FormClosedUsuario ;
                tela.Show();
            }
        private void AbreTelaInclusaoAlteracaoMaterial(Material materialSelecionado)
            {
                GnNovaMateriaPrima tela = new GnNovaMateriaPrima();
                tela.MdiParent = this;
                tela.MateriaPrimaSelecionado = materialSelecionado;
                panel4.Controls.Add(tela);
                tela.FormClosed += Tela_FormClosedMateriaPrima;
                tela.Show();
            }
        private void AbreTelaInclusaoAlteracaoTipoProduto(TipoProduto tipoProdutoSelecionado)
            {
                CadastraTipoProduto tela = new CadastraTipoProduto();
                tela.MdiParent = this;
                tela.TipoSelecionado = tipoProdutoSelecionado;
                panel4.Controls.Add(tela);
                tela.FormClosed += Tela_FormClosedTipoProduto;
                tela.Show();
            }
        
            private void Tela_FormClosedProducao(object sender, FormClosedEventArgs e)
        {
            //var gridProducao = (GridProducao)panel4.Controls[0];
            gridProducao.CarregarProducoes();
            this.HabilitaBotoes();
        }
        
        private void Tela_FormClosedTipoProduto(object sender, FormClosedEventArgs e)
        {
            //var gridTipoProduto = (dgTipodeProdutoFundo)panel4.Controls[0];
            gridTipoProduto.CarregarTiposProdutos();
            this.HabilitaBotoes();
        }

        private void Tela_FormClosedMateriaPrima(object sender, FormClosedEventArgs e)
        {
            
            //var gridMateriaPrima = (GridMateriaPrima)panel4.Controls[0];
            gridMateriaPrima.CarregarMateriasPrimas();
            this.HabilitaBotoes();
        }

        private void Tela_FormClosedUsuario(object sender, FormClosedEventArgs e)
        {
            //var gridUsuario = (GridUsuario)panel4.Controls[0];
            gridUsuario.CarregarUsuarios();
            this.HabilitaBotoes();
        }

        private void HabilitaBotoes()
        {
            this.GenericaExluir.Enabled = true;
            this.GenericoNovo.Enabled = true;
            this.GenericaEditar.Enabled = true;
        }
        private void DesabilitarBotoes()
        {
            this.GenericaExluir.Enabled = false;
            this.GenericoNovo.Enabled = false;
            this.GenericaEditar.Enabled = false;
        }
    }
}
