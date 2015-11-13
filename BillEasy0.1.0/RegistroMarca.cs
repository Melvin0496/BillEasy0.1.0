using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using System.Text.RegularExpressions;
namespace BillEasy0._1._0
{
    public partial class RegistroMarca : Form
    {
        public RegistroMarca()
        {
            InitializeComponent();
        }

        private int Validar()
        {
            int retorno = 0;
            if(NombreTextBox.Text == "")
            {
                MessageBox.Show("Por favor complete los campos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            else
            {
                Regex espacio = new Regex(@"\s+");
                NombreTextBox.Text = espacio.Replace(NombreTextBox.Text, " ");
                retorno += 1;
            }
            
            return retorno;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            int id;
            int.TryParse(MarcaIdtextBox.Text, out id);
            marca.Buscar(id);
            NombreTextBox.Text = marca.Nombre;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            MarcaIdtextBox.Clear();
            NombreTextBox.Clear();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            if (MarcaIdtextBox.Text.Length > 0 && Validar() == 1)
            {
                int id ;
                int.TryParse(MarcaIdtextBox.Text, out id);
                marca.MarcaId = id;
                marca.Nombre = NombreTextBox.Text;
                if (marca.Editar())
                {
                    MessageBox.Show("Marca Editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            if (NombreTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MarcaIdtextBox.Text.Length == 0 && Validar() == 1)
            {
                marca.Nombre = NombreTextBox.Text;
                if (marca.Insertar())
                {
                    MessageBox.Show("Marca Guardada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar la marca ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            int id;
            if (MarcaIdtextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else 
            if (MarcaIdtextBox.Text.Length > 0)
            {
                int.TryParse(MarcaIdtextBox.Text, out id);
                marca.MarcaId = id;
                if(marca.Eliminar())
                {
                    MessageBox.Show("Marca Eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la marca","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void MarcaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
