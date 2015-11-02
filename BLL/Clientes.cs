﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Clientes : ClaseMaestra
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Cedula { get; set; }

        
        public Clientes()
        {
            this.ClienteId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.Telefono = "";
            this.Celular = "";
            this.Direccion = "";
            this.Email = "";
            this.Cedula = "";
        }

        public Clientes(int clienteId,string nombres,string apellido,string telefono, string celular, string direccion, string email, string cedula)
        {
            this.ClienteId = ClienteId;
            this.Nombres = nombres;
            this.Apellidos =  apellido;
            this.Telefono =  telefono;
            this.Celular = celular;
            this.Direccion = direccion;
            this.Email =  email;
            this.Cedula = cedula;
        }

        public override bool Insertar()
        {
            bool retorno;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Insert Into Clientes (Nombres,Apellidos,Telefono,Celular,Direccion,Email,Cedula) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",this.Nombres,this.Apellidos,this.Telefono,this.Celular,this.Direccion,this.Email,this.Cedula));
            return retorno;
        }

        public override bool Editar()
        {

            bool retorno;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Update Ciudades set Nombres = '{0}', Apellidos = '{1}',Telefono = '{2}',Celular = '{3}',Direccion = '{4}' ,Email = '{5}',Cedula = '{6}' where ClienteId = {7} ", this.Nombres, this.Apellidos, this.Telefono, this.Celular, this.Direccion, this.Email, this.Cedula,this.ClienteId));
            return retorno;
        }

        public override bool Eliminar()
        {

            bool retorno;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete  Ciudades Where CiudadId = {0})",this.ClienteId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("Select Nombres,Apellidos,Telefono,Celular,Direccion, Email,Ceudla From Where ClienteId = {0}",idBuscado));
            if(dt.Rows.Count > 0)
            {
                this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                this.Nombres = dt.Rows[0]["Nombres"].ToString();
                this.Nombres = dt.Rows[0]["Apellidos"].ToString();
                this.Nombres = dt.Rows[0]["Telefono"].ToString();
                this.Nombres = dt.Rows[0]["Celular"].ToString();
                this.Nombres = dt.Rows[0]["Email"].ToString();
                this.Nombres = dt.Rows[0]["Cedula"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Orden by  " + orden;
            return conexion.ObtenerDatos("Select " + campos +
               " From Clientes Where " + condicion + "" + ordenFinal);

        }
    }
}
