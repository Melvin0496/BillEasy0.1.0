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
    public partial class RegistroCiudad : Form
    {
        public RegistroCiudad()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            int id;
            int.TryParse(CiudadIdtextBox.Text, out id);
            ciudad.Buscar(id);
            CiudadIdtextBox.Text = ciudad.CiudadId.ToString();
            NombretextBox.Text = ciudad.Nombre;
            CodigoPostalTextBox.Text = ciudad.CodigoPostal.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            CiudadIdtextBox.Clear();
            NombretextBox.Clear();
            CodigoPostalTextBox.Clear();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            if (CiudadIdtextBox.Text.Length > 0)
            {
               
                
                ciudad.CiudadId = int.Parse(CiudadIdtextBox.Text);
                ciudad.Nombre = NombretextBox.Text;
                ciudad.CodigoPostal = int.Parse(CodigoPostalTextBox.Text);
                if (ciudad.Editar())
                {
                    MessageBox.Show("Ciudad Editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            if (NombretextBox.TextLength == 0)
            {
                MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (CiudadIdtextBox.Text.Length == 0)
            {
                ciudad.Nombre = NombretextBox.Text;
                ciudad.CodigoPostal = int.Parse(CodigoPostalTextBox.Text);
                if (ciudad.Insertar())
                {
                    MessageBox.Show("Ciudad Guardada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar la ciudad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            int id;
            if (CiudadIdtextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (CiudadIdtextBox.Text.Length > 0)
            {
                int.TryParse(CiudadIdtextBox.Text, out id);
                ciudad.CiudadId = id;
                if (ciudad.Eliminar())
                {
                    MessageBox.Show("Ciudad Eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la ciudad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
