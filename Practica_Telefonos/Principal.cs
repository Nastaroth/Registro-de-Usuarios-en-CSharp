using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Practica_Telefonos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        //public ClientesCls ClienteSeleccionado { get; set; }

        //public ClientesCls ClienteActual { get; set; }

               
        
        
                private void btnCancelar_Click(object sender, EventArgs e)
                {
                    this.Close();
                }

            
        
                private void btnRegistrar_Click(object sender, EventArgs e)
                {
                    if (txtNombre.Text !="")
                    {
                        if (UsuariosCls.RegistrarClientes (txtIdentidad.Text, txtNombre.Text,txtDireccion.Text,txtTelefono.Text,txtEmail.Text) > 0)
                        {
                            MessageBox.Show("Cuenta Creada con exito");

                            limpiar();
                        }

                        else
                        {
                            MessageBox.Show("No se pudo crear la cuenta");
                        }

                    }
                }



                private void btnBuscar_Click(object sender, EventArgs e)
                {
                    //Buscar bsc = new Buscar();
                    //bsc.ShowDialog();

                    //if (bsc.ClienteSeleccionado != null)
                    //{
                    //    Int64 id = Convert.ToInt64(txtIdentidad);
                    //    ClienteSeleccionado = UsuariosCls.ObtenerClientes(id);

                    //    btnModificar.Enabled = true;
                    //    btnEliminar.Enabled = true;
                    //    btnRegistrar.Enabled = false;
                    //    ClienteActual = bsc.ClienteSeleccionado;
                    //    txtIdentidad.Text = bsc.ClienteSeleccionado.Identidad;
                    //    txtNombre.Text = bsc.ClienteSeleccionado.Nombre;
                    //    txtDireccion.Text = bsc.ClienteSeleccionado.Direccion;
                    //    txtTelefono.Text = bsc.ClienteSeleccionado.Telefono;
                    //    txtEmail.Text = bsc.ClienteSeleccionado.Email;

                    //}

                    SqlConnection Conex = BasedeDatos.Conexion();

                    string sqlcon = "select * from clientes where Doc_identidad='" + txtIdentidad.Text + "' ";
                   
                    SqlCommand cmd = new SqlCommand(sqlcon, Conex);
                    
                    

                    SqlDataReader leer = cmd.ExecuteReader();

                    if (leer.Read() == true)

                    {
                        txtNombre.Text = leer["Nombre"].ToString();
                        txtDireccion.Text = leer["Direccion"].ToString();
                        txtTelefono.Text = leer["Telefono"].ToString();
                        txtEmail.Text = leer["Email"].ToString();
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnRegistrar.Enabled = false;


                    }

                    else
                    {
                        txtNombre.Text = "";
                        txtDireccion.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";

                        MessageBox.Show("Debe introducir el documento de indentificacion");

                    }

                    Conex.Close();

                    

                }
                    
                    
                      

                        
                    



                private void btnModificar_Click(object sender, EventArgs e)
                {
                    ClientesCls pClientes = new ClientesCls();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnRegistrar.Enabled = true;
                
                    pClientes.Nombre = txtNombre.Text;
                    pClientes.Direccion = txtDireccion.Text;
                    pClientes.Telefono = txtTelefono.Text;
                    pClientes.Email = txtEmail.Text;
                    pClientes.Identidad = txtIdentidad.Text;

                    int resultado = UsuariosCls.Modificar(pClientes);

                            if (resultado > 0)

                            {
                                MessageBox.Show("Cliente Modificado con exito", "Cliente Modificado", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                limpiar();

                            }

                            else
                            {
                                MessageBox.Show("El cliente no pudo ser modificado con exito", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }

                private void btnEliminar_Click(object sender, EventArgs e)
                {
                    if (txtIdentidad.Text != "")
                    {
               

                            if (MessageBox.Show("Esta seguro que desea eliminar al cliente?", "Esta Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                btnEliminar.Enabled = false;
                                btnModificar.Enabled = false;
                                btnRegistrar.Enabled = true;

                                int resultado = UsuariosCls.eliminar(txtIdentidad.Text);


                                    if (resultado > 0)
                                    {
                                        MessageBox.Show("Cliente Eliminado con exito", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        limpiar();
                                        btnEliminar.Enabled = false;
                                        btnModificar.Enabled = false;
                                        btnRegistrar.Enabled = true;

                                    }

                                    else
                                    {
                                        MessageBox.Show("El cliente no pudo ser Eliminado", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    }
                      }

                                    else
                                    {
                                        MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
                                    }


                     }

                                    else
                                    {
                                        MessageBox.Show("Introduzca los datos a eliminar", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }


                }


              //Metodo para Limpiar los campos


                void limpiar()
                {
                    txtIdentidad.Clear();
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                }

        
                private void Principal_Load(object sender, EventArgs e)
                {

                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                 }

                private void Principal_FormClosing(object sender, FormClosingEventArgs e)
                {
                    Application.Exit();
                }

                private void BtnClientes_Click(object sender, EventArgs e)
                {
                    Informes inf = new Informes();
                    inf.ShowDialog();
                }

                private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
                {
                    ValidarCls.Solonumeros(e);
                }

                private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
                {
                    ValidarCls.Sololetras(e);
                }

                private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
                {
                    ValidarCls.Solonumeros(e);
                }



                public static bool Email_Valido(String email) // Método para validar el Email ingresado
                {
                        String validando;
                        validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                       
                    if (Regex.IsMatch(email, validando))
                        {
                            if (Regex.Replace(email, validando, String.Empty).Length == 0)
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;

                                }
                               
                                }
                                else
                                {
                               
                                    return false;
                                 }

                }

        
                private void txtEmail_Leave(object sender, EventArgs e)
                {
                    if (Email_Valido(txtEmail.Text) == false)// llamado del metodo Email_Valido
                    {

                        errorProvider1.SetError(txtEmail, "Ingrese un email correcto");
                        //MessageBox.Show("Error introduzca los valores correctos");
                        txtEmail.SelectAll();
                        txtEmail.Focus();
                        
                    }
                    else
                    {

                        errorProvider1.Clear();
                    }
                }

                private void txtEmail_TextChanged(object sender, EventArgs e)
                {

                }

            
                }
            }

