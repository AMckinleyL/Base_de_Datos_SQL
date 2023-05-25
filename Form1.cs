using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios
{
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            Form formulario = new frmusuario();
            formulario.ShowDialog();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            Form formulario = new frmconsulta();
            formulario.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frminicio_Load(object sender, EventArgs e)
        {

        }
    }
}
