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
    public partial class SugestoesEReclamacoes : Form
    {
        public SugestoesEReclamacoes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var frmInicio = new Inicio();

            frmInicio.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = " ";
            txbEmail.Text = " ";
            txbMensagem.Text = " ";
        }

        private void voltarParaOLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();

            frmLogin.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();

            frmLogin.Show();
            this.Hide();
            MessageBox.Show("Obrigado por utilizar nossos serviços!", "Até Mais", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sobreOProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Rafael Ramos Lopes", "Sobre o Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
