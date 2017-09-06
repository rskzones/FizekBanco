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
    public partial class Movimentacao : Form
    {
        public Movimentacao()
        {
            InitializeComponent();
        }


        private void voltarParaOLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();

            frmLogin.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOKSenha_Click(object sender, EventArgs e)
        {
            string senhaNum = txbSenha.Text;

            if (senhaNum == "1234")
            {
                txbMovimentacao.Text = "Movimentação da Conta no ano de 2017" + "\r\n" + "Jan - Saldo: R$ 150,08 " + "\r\n"
                    + "Fev - Saldo: R$ 150,08 " + "\r\n" + "...";
            }
            else
            {
                MessageBox.Show("A senha númerica de 4 dígitos está incorreta", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var frmInicio = new Inicio();

            frmInicio.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
