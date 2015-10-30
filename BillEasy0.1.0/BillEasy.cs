using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillEasy0._1._0
{
    public partial class BillEasy : Form
    {
        public BillEasy()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.MdiParent = this;
            registro.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuario consultaUsuario = new ConsultaUsuario();
            consultaUsuario.MdiParent = this;
            consultaUsuario.Show();
        }
    }
}
