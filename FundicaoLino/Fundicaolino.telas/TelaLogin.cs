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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        { 
            TelaPrincipal telaprincipal = new TelaPrincipal();
            if (TxLogin.Text == "admin" && TxSenha.Text == "admin")
            {
                telaprincipal.Show();
                this.Hide();
            }
            else
            {
                TxLogin.Text = "";
                TxSenha.Text = "";
                MessageBox.Show("Login Inválido");
            }  
        }

        private void EsqueciMinhaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com Administrador");
        }
    }
}
