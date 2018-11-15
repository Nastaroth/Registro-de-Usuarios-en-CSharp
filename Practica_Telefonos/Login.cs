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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrarse reg = new Registrarse();

            reg.ShowDialog ();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (UsuariosCls.Login(txtNombre.Text,txtContraseña.Text) >0)
                
                {
                    this.Hide();
                    Principal f= new Principal();
                     f.ShowDialog();
                }

                else
                
                {
                    MessageBox.Show("Error en los datos");
                }
            }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                
                {
                    if (UsuariosCls.Login(txtNombre.Text, txtContraseña.Text) > 0)
                    {
                        this.Hide();
                        Principal f = new Principal();
                        f.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Error en los datos");
                        limpiar();
                    }
                }
        }

                void limpiar()
                {
                    txtNombre.Clear();
                    txtContraseña.Clear();
                }

                private void Login_Load(object sender, EventArgs e)
                {

                }

                private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

                private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("Por favor comuniquese con el administrador del sistema a traves del 0000000");

                }

                private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    Registrarse reg2 = new Registrarse();

                    reg2.ShowDialog();
                }

                private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    txtNombre.Text = "";
                    txtContraseña.Text = "";
                   
                }

              

        }
    }

