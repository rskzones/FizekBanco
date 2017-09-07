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
    public partial class Operacoes : Form
    {
        public Operacoes()
        {
            InitializeComponent();
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

        private void btnSaque_Click(object sender, EventArgs e)
        {
            ContaGerenciar conta = new ContaGerenciar();

            string vlr, saldorestante;
            double valor;

            vlr = txbValor.Text;
            valor = Double.Parse(vlr);
            conta.saldo = conta.saldo - valor;

            saldorestante = conta.saldo.ToString);

            txbSaldo.Text = saldorestante;
        }

    }
}
