﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Practica_Telefonos
{
    class UsuariosCls
    {


        //Metodo para el boton de registrar para crear cuenta de usuario para el sistema

        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection Conex = BasedeDatos.Conexion();
 
            SqlCommand cmd = new SqlCommand(string.Format("insert into usuario (Nombre,Contraseña) values ('{0}', PwdEncrypt ('{1}') )" , pUsuario, pContraseña),Conex);

            resultado = cmd.ExecuteNonQuery();
            Conex.Close();

            return resultado;

        }



        //Metodo para hacer Login en el sistema

        public static int Login(string pUsuario, string pContraseña)

        {
            int resultado = -1;

            SqlConnection conexion = BasedeDatos.Conexion();

            SqlCommand cmd = new SqlCommand(string.Format("select * from usuario where nombre = '{0}' and PwdCompare('{1}',Contraseña)=1", pUsuario, pContraseña),conexion);

            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())

            {
                resultado = 50;
            }

            conexion.Close();
            return resultado;

        }



        //Metodo para el boton de registrar clientes en el sistema

        public static int RegistrarClientes(string pIdentidad, string pNombre, string pDireccion, string pTelefono,string pEmail)
        {
            int resultado = 0;
            SqlConnection Conex = BasedeDatos.Conexion();

            SqlCommand cmd = new SqlCommand(string.Format("insert into clientes (Doc_Identidad,Nombre,Direccion,Telefono,Email) values ('{0}', '{1}', '{2}', '{3}', '{4}' )", pIdentidad, pNombre, pDireccion, pTelefono, pEmail), Conex);

            resultado = cmd.ExecuteNonQuery();
            Conex.Close();

            return resultado;

        }





        //Metodo para modificar datos en el sistema


        public static int Modificar(ClientesCls pClientes)
        {
            int retorno = 0;

            using (SqlConnection conexion = BasedeDatos.Conexion())

            {
                SqlCommand cmd = new SqlCommand(string.Format("update clientes set   Nombre = '{1}',  Direccion = '{2}' , Telefono = '{3}', Email = '{4}' where Doc_Identidad= '{0}'",
                    pClientes.Identidad, pClientes.Nombre, pClientes.Direccion, pClientes.Telefono, pClientes.Email), conexion);
                
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
            }

            return retorno;

        }



        public static int eliminar(string pIdentidad)

        {
            int retorno = 0;

            using (SqlConnection conexion = BasedeDatos.Conexion())
            {
               SqlCommand cmd = new SqlCommand(string.Format("delete from clientes  where Doc_Identidad= '{0}'", pIdentidad), conexion);
               retorno = cmd.ExecuteNonQuery();
               conexion.Close();
            }

            return retorno;
        }

        
    }
}
