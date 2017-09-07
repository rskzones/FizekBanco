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
    public partial class InfoConta : Form
    {
        public InfoConta()
        {
            InitializeComponent();
        }

        private void btnOKSenha_Click(object sender, EventArgs e)
        {
            string senhaNum = txbSenha.Text;

            if (senhaNum == "1234")
            {
                txbInfoConta.Text = "Usuário: Admin " + "\r\n" + "Saldo Disponível: R$ 150,08" + "\r\n" + "Número do Cartão: 0000 0000 0000 0000";
            }
            else
            {
                MessageBox.Show("A senha númerica de 4 dígitos está incorreta", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void voltarParaOLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();

            frmLogin.Show();
            this.Hide();
            MessageBox.Show("Obrigado por utilizar nossos serviços!", "Até Mais", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();

            metodos.Voltar();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreOProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Rafael Ramos Lopes", "Sobre o Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
