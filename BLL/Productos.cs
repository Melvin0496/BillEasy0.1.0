using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Productos : ClaseMaestra
    {
        public int ProductoId { get; set; }
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public int MarcaId { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Costo { get; set; }
        public float ITBIS { get; set; }
       
        public Productos()
        {
            this.ProductoId = 0;
            this.ProveedorId = 0;
            this.Nombre = "";
            this.MarcaId = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Costo = 0;
            this.ITBIS = 0;
        }

        public Productos(int productoId, int proveedorId,string nombre, int marcaId, int cantidad, float precio, float costo, float iTBIS)
        {
            this.ProductoId = productoId;
            this.ProveedorId = proveedorId;
            this.Nombre = nombre;
            this.MarcaId = marcaId;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Costo = costo;
            this.ITBIS = iTBIS;
        }

        public override bool Buscar(int idBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            dt = conexion.ObtenerDatos(String.Format("",idBuscado));
            if (dt.Rows.Count > 0)
            {
                this.ProductoId = (int)dt.Rows[0]["ProductoId"];
                this.ProveedorId = (int)dt.Rows[0]["ProveedorId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.MarcaId = (int)dt.Rows[0]["MarcaId"];
                this.Cantidad = (int)dt.Rows[0]["Cantidad"];
                this.Precio = (float)dt.Rows[0]["Precio"];
                this.Costo = (float)dt.Rows[0]["Costo"];
                this.ITBIS = (float)dt.Rows[0]["ITBIS"];
            }
            return dt.Rows.Count > 0;
        }

        public override bool Editar()
        {
            bool retorno;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Update Productos set ProveedorId = {0}, Nombre = '{1}',MarcaId = {2}, Cantidad = {3},Precio = {4},Costo = {5}, ITBIS = {6} Where ProductoId = {7}",this.ProveedorId,this.Nombre,this.MarcaId,this.Cantidad,this.Precio,this.Costo,this.ITBIS,this.ProductoId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete Produyctos Where ProductoId = {0}",this.ProductoId));
            return retorno;
        }

        public override bool Insertar()
        {
            bool retorno;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Insert Into Productos(ProveedorId, Nombre,MarcaId,Cantidad,Precio,Costo,ITBIS) Values({0},'{1}',{2},{3},{4},{5},{6}) ", this.ProveedorId, this.Nombre, this.MarcaId, this.Cantidad, this.Precio, this.Costo, this.ITBIS, this.ProductoId));
            return retorno;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Orden by " + orden;
            return conexion.ObtenerDatos("Select "+ campos+ 
                " From Productos  where "+ condicion + "" +ordenFinal);
        }
    }
}
