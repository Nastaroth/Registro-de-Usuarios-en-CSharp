using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Telefonos
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text==txtConfirmar.Text)
            {
                if (UsuariosCls.CrearCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con exito");

                    Application.Restart();
                }

                else
                
                {
                    MessageBox.Show("No se pudo crear la cuenta");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
