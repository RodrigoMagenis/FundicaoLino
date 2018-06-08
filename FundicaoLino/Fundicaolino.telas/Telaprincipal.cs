using Fundicaolino.negocio;
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

        //Definição das tela globais
         GridGrupo gridGrupo = new GridGrupo();/*Tela = 1*/
         GridUsuario gridUsuario = new GridUsuario();/*Tela = 2*/
         //                                            /*Tela = 3*/
           //                                          /*Tela = 4*/
        GridProducao gridProducao = new GridProducao(); /*Tela = 5*/
        GridProcesso gridProcesso = new GridProcesso();/*Tela = 6*/
        GridProduto gridProduto = new GridProduto();/*Tela = 7*/
        GridFiladeProducao gridFilaProducao = new GridFiladeProducao();  /*Tela = 8*/

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

        }

        private void GenericoNovo_Click(object sender, EventArgs e)
        {
            switch (tela)
                {
                case 1:
                    

                    break;
                case 2:
                    gridUsuario.Close();
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
                    gridProducao.Close();
                    GnCadProducao CadastraNovaProducao = new GnCadProducao();
                    CadastraNovaProducao.MdiParent = this;
                    panel4.Controls.Add(CadastraNovaProducao);
                    CadastraNovaProducao.Show();
                    break;
                case 6:
                    gridProcesso.Close();
                    GnGerProcesso cadastraNovoProcesso = new GnGerProcesso();
                    cadastraNovoProcesso.MdiParent = this;
                    panel4.Controls.Add(cadastraNovoProcesso);
                    cadastraNovoProcesso.Show();
                    break;
                case 7:
                    gridProduto.Close();
                    CadastraTipoProduto cadastraNovoProduto = new CadastraTipoProduto();
                    cadastraNovoProduto.MdiParent = this;
                    panel4.Controls.Add(cadastraNovoProduto);
                    cadastraNovoProduto.Show();


                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }

        

        private void Genericagerenciargrupo_Click(object sender, EventArgs e)
        {
            gridGrupo.MdiParent = this;
            panel4.Controls.Add(gridGrupo);
            gridGrupo.Show();
            tela = 1;
        }

        private void Genericagerenciarusuario_Click(object sender, EventArgs e)
        {
            gridUsuario.MdiParent = this;
            panel4.Controls.Add(gridUsuario);
            gridUsuario.Show();
            tela = 2;
        }

        private void GenericaControleProducao_Click(object sender, EventArgs e)
        {
           
            tela = 3;
        }

        private void GenericaControleQualidade_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////FAZER///////////////////////////////////////////////////
            tela = 4;
        }
        private void btCadastraProducao_Click(object sender, EventArgs e)
        {
            gridProducao.MdiParent = this;
            panel4.Controls.Add(gridProducao);
            gridProducao.Show();
            tela = 5;
        }
        private void Genericacadastrarprocesso_Click(object sender, EventArgs e)
        {
            gridProcesso.MdiParent = this;
            panel4.Controls.Add(gridProcesso);
            gridProcesso.Show();
            tela = 6;
        }

        private void Genericacadastrarproduto_Click(object sender, EventArgs e)
        {
            gridProduto.MdiParent = this;
            panel4.Controls.Add(gridProduto);
            gridProduto.Show();
            tela = 7;
        }

        private void Genericaexibirfiladeproducao_Click(object sender, EventArgs e)
        {
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

      
    }
}
