using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FizekBanco.View
{
    class Metodos
    {
        public void Voltar()
        {
            var frmInicio = new Inicio();

            frmInicio.Show();

        }
        public void LoginVoltar()
        {
            var frmLogin = new Login();

            frmLogin.Show();
        }

    }
}
