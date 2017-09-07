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
    public partial class DigiteSenha : Form
    {
        public DigiteSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha;
            senha = txbSenha.Text;

            if(senha == "1234")
            {
                var frmOperacoes = new Operacoes();

                frmOperacoes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("A senha númerica de 4 dígitos está incorreta", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
