using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FizekBanco.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            var frmMovimentacao = new Movimentacao();
            
            frmMovimentacao.Show();
            this.Hide();
            
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            var frmOperacoes = new Operacoes();

            frmOperacoes.Show();
            this.Hide();

        }

        private void btnInfoConta_Click(object sender, EventArgs e)
        {
            var frmInfoConta = new InfoConta();

            frmInfoConta.Show();
            this.Hide();

        }

        private void btnSugestões_Click(object sender, EventArgs e)
        {
            var frmSugestoesReclamacoes = new SugestoesEReclamacoes();

            frmSugestoesReclamacoes.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();

            metodos.LoginVoltar();
            this.Hide();
            MessageBox.Show("Obrigado por utilizar nossos serviços!", "Até Mais", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void voltarParaOLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();

            metodos.LoginVoltar();
            this.Hide();
            MessageBox.Show("Obrigado por utilizar nossos serviços!", "Até Mais", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreOProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
