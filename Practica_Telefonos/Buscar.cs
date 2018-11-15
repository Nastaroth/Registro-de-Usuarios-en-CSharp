//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Practica_Telefonos
//{
//    public partial class Buscar : Form
//    {
//        public Buscar()
//        {
//            InitializeComponent();
//        }

//        public ClientesCls ClienteSeleccionado { get; set; }

//        private void btnBuscar_Click(object sender, EventArgs e)
        
//        {
//            if (txtIdentidad.Text != "")
//            {
//                dataGridView1.DataSource = UsuariosCls.BuscarClientes(txtIdentidad.Text);
//            }

//            else
//            {
//                MessageBox.Show("Debe Colocar el documento de identificacion");
//            }
            

//        }

//        private void btnCancelar_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void Buscar_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnAceptar_Click(object sender, EventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count == 1)
//            {
//                Int64 id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
//                ClienteSeleccionado = UsuariosCls.ObtenerClientes(id);
//                this.Close();
//            }
//            else
//            {
//                MessageBox.Show("No ha seleccionado ningun cliente");
//            }
//        }
//    }
//}
