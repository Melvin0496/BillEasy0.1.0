using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Ventas : ClaseMaestra
    {

        public int VentaId{ get; set; }
        public int ClienteId { get; set; }
        public string Fecha { get; set; }
        public float ITBIS { get; set; }
        public float Descuentos { get; set; }
        public string TipoVenta { get; set; }
        public string NFC { get; set; }
        public string TipoComprobanteFiscal { get; set; }
        public float Total { get; set; }

        public Ventas()
        {
            this.VentaId = 0;
            this.ClienteId = 0;
            this.Fecha = "";
            this.ITBIS = 0.0f;
            this.Descuentos = 0.0f;
            this.TipoVenta = "";
            this.NFC = "";
            this.TipoComprobanteFiscal = "";
            this.Total = 0.0f;
        }
        public Ventas(int ventaId,int clienteId,string fecha,float itbis,float descuentos,string tipoDeVenta,string nfc,string tipoComprobanteFiscal,float total)
        {
            this.VentaId = ventaId;
            this.ClienteId = clienteId;
            this.Fecha = fecha;
            this.ITBIS = itbis;
            this.Descuentos = descuentos;
            this.TipoVenta = tipoDeVenta;
            this.NFC = nfc;
            this.TipoComprobanteFiscal = tipoComprobanteFiscal;
            this.Total = total;
        }
        public override bool Buscar(int idBuscado)
        {
            throw new NotImplementedException();
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Insert into Ventas(ClienteId,Fecha,ITBIS,Descuentos,TipoVentas,NFC,TipoDeComprobanteFiscal,Total) values({0},'{1}',{2},{3},'{4}','{5}','{6}',{7})",this.ClienteId,this.Fecha,this.ITBIS,this.Descuentos,this.TipoVenta,this.NFC,this.TipoComprobanteFiscal,this.Total));
            return retorno;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            throw new NotImplementedException();
        }
    }
}
