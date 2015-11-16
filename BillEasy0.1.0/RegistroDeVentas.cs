using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace BillEasy0._1._0
{
    public partial class RegistroDeVentas : Form
    {
        public RegistroDeVentas()
        {
            InitializeComponent();
            FechamaskedTextBox.Text = string.Format("{0:dd/MM/yyyy}",DateTime.Now);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            VentaIdtextBox.Clear();
            DescuentostextBox.Clear();
            TipoVentatextBox.Clear();
            TipoNFCtextBox.Clear();
            NFCtextBox.Clear();
            ITBIStextBox.Clear();
            TotaltextBox.Clear();
        }
        public void LlenarDatos(Ventas ventas)
        {
            int id;
            int.TryParse(VentaIdtextBox.Text,out id);
            float descuentos;
            float.TryParse(DescuentostextBox.Text,out descuentos);

            ventas.Fecha = FechamaskedTextBox.Text;
            ventas.Descuentos = descuentos;
            ventas.TipoVenta = TipoVentatextBox.Text;
            ventas.TipoComprobanteFiscal = TipoNFCtextBox.Text;
            ventas.NFC = NFCtextBox.Text;
            ventas.ClienteId = (int)ClientecomboBox.SelectedValue;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            if(VentaIdtextBox.TextLength == 0)
            {
                LlenarDatos(ventas);
                if (ventas.Insertar())
                {
                    MessageBox.Show("Venta Registrada","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegistroDeVentas_Load(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            ClientecomboBox.DataSource = clientes.Listado(" * ","1=1","");
            ClientecomboBox.DisplayMember = "Nombres";
            ClientecomboBox.ValueMember = "ClienteId";
        }
    }
}
