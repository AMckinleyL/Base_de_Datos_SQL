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
    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
        }

        private void frmconsulta_Load(object sender, EventArgs e)
        {
            //SE LLAMA AL METODO -Listar-
            Listar();
        }
        //METODO TIPO VOID PARA LLENAR EL DATAGRIDVIEW
        private void Listar()
        {
            try
            {
                //referencia a la clase datosSql
                DatosSQL ds = new DatosSQL();
                dgvconsultas.DataSource = ds.Listar();
                lblfilas.Text = "Total Empadronados: " + Convert.ToString(dgvconsultas.Rows.Count-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //METODO PARA BUSCAR REGISTROS

        private void buscar()
        {
            try
            {
                //referencia a la clase datosSql
                DatosSQL ds = new DatosSQL();
                dgvconsultas.DataSource = ds.Buscar(txtbuscar.Text);
                lblfilas.Text = "Total Empadronados: " + Convert.ToString(dgvconsultas.Rows.Count - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            //llamamos al metodo buscar
            this.buscar();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
