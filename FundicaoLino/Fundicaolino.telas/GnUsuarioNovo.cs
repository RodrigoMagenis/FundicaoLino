﻿using Fundicaolino.negocio;
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
            Int32 intConvertido;

            //resultado = int64.tryparse(txidentificador.text, out longconvertido);
            //if (resultado)
            //{
            //    usuario.id = longconvertido;
            //}
            //else
            //{
            //    usuario.id = -1;
            //}

            usuario.NmUsuario = TxNomeUsuario.Text;

            resultado = Int32.TryParse(TxMatricula.Text, out intConvertido);
            if (resultado)
            {
                usuario.Idmatricula = intConvertido;
            }
            else
            {
                usuario.Idmatricula = -1;
            }

            //resultado = Int64.TryParse(TxGrupodeAcesso.Text, out longConvertido);
           // if (resultado)
            {
            //    usuario.Idgrupo = longConvertido;
            }

            Validacao validacao;
            if (UsuarioSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarUsuario(usuario);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarUsuario(usuario);
            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Cliente salvo com sucesso");
            }

            this.Close();
        }
    }
}
