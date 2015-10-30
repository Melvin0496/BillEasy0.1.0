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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            FechamaskedTextBox.Text = String.Format("{0:dd/MM/yyyy}",DateTime.Now);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            UsuarioIdtextBox.Clear();
            NombretextBox.Clear();
            NombreUsuariotextBox.Clear();
            ContrasenatextBox.Clear();
            AreatextBox.Clear();
            
        }

        public void Datos()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Nombre = NombretextBox.Text;
            usuarios.NombreUsuario = NombreUsuariotextBox.Text;
            usuarios.Contrasena = ContrasenatextBox.Text;
            usuarios.Area = AreatextBox.Text;
            usuarios.Fecha = FechamaskedTextBox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            if (UsuarioIdtextBox.TextLength > 0)
            {
                usuarios.UsuarioId = int.Parse(UsuarioIdtextBox.Text);
                Datos();
                if (usuarios.Editar())
                {
                    MessageBox.Show("Usuario Editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al editar el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            if (NombretextBox.TextLength == 0 || NombreUsuariotextBox.TextLength == 0 || ContrasenatextBox.TextLength == 0 || AreatextBox.TextLength == 0)
            {
                MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                Datos();
                
                if (usuarios.Insertar())
                {
                    MessageBox.Show("Usuario Guardado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Nuevobutton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al editar el usuario","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (UsuarioIdtextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
               
                if (UsuarioIdtextBox.TextLength > 0)
                {
                    usuario.UsuarioId = int.Parse(UsuarioIdtextBox.Text);

                    if (usuario.Eliminar())
                    {
                        MessageBox.Show("Usuario Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Nuevobutton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();

            int.TryParse(UsuarioIdtextBox.Text,out id);
            usuario.UsuarioId = id;
            usuario.Buscar(id);

            NombretextBox.Text = usuario.Nombre;
            NombreUsuariotextBox.Text = usuario.NombreUsuario;
            ContrasenatextBox.Text = usuario.Contrasena;
            AreatextBox.Text = usuario.Area;
            FechamaskedTextBox.Text = usuario.Fecha;
        }

        private void UsuarioIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
