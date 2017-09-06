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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txbLogin.Text;
            string senha = txbSenha.Text;

            if (usuario == "admin" && senha == "admin")
            {
                var frmInicio = new Inicio();
                frmInicio.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario ou Senha inválidos! Tente Novamente.", "Usuario ou Senha inválidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
