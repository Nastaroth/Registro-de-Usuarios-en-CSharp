using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica_Telefonos
{
   public class ClientesCls
    {
       public string Identidad { get; set; }
       public string Nombre { get; set; }
       public string Direccion { get; set; }
       public string Telefono { get; set; }
       public string Email { get; set; }

       public ClientesCls() { }

       public ClientesCls(string pIdentidad, string pNombre, string pDireccion, string pTelefono, string pEmail) 
       
       {
           this.Identidad = pIdentidad;
           this.Nombre = pNombre;
           this.Direccion = pDireccion ;
           this.Telefono = pTelefono;
           this.Email = pEmail;
       }
    }
}
