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
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }
        //METODO PARA LLENADO DE LAS CASILLAS
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if(txtnombres.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(txtnombres, "Ingrese Nombre");
                    return;
                }
                if (txtapellidos.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(txtapellidos, "Ingrese Apellidos");
                    return;
                }
                if (txtcui.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(txtcui, "Ingrese CUI");
                    return;
                }               
                if (dtfecha.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(dtfecha, "Ingrese Fecha de Nacimiento");
                    return;
                }
                if (txtpais.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(txtpais, "Ingrese Pais");
                    return;
                }
                if (txtdepa.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(txtdepa, "Ingrese Departamento");
                    return;
                }
                if (txtmuni.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos del registro");
                    error.SetError(txtmuni, "Ingrese Municipio");
                    return;
                }
                //SE GENERA UNA INSTANCIA PARA LA CLASE -user-
                user obj = new user();
                obj.perNombres = txtnombres.Text;
                obj.perApellidos = txtapellidos.Text;
                obj.perCUI = txtcui.Text;
                obj.perFecha = dtfecha.Value;  
                obj.perPais = txtpais.Text;
                obj.perDepartamento = txtdepa.Text;
                obj.perMunicipio = txtmuni.Text;
                obj.perGenero = cmbgenero.Text;

                //SE GENERA UNA INSTANCIA PARA MI CLASE -DatosSQL- (CONFIRMACION DE DATOS AGREGADOS)
                DatosSQL ds = new DatosSQL();
                respuesta = ds.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    this.MensajeOk("Se inserto de forma correcta el registro");
                    this.Limpiar();
                    
                }
                else
                {
                    this.MensajeError(respuesta);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            {

            }
        }

        //METODO PARA LIMPIAR LOS CAMPOS

        private void Limpiar()
        {
            txtnombres.Clear();
            txtapellidos.Clear();
            txtcui.Clear();
            //dtfecha.Clear();
            txtdepa.Clear();
            txtmuni.Clear();
            txtpais.Clear();
            //cmbgenero.Clear();
            txtnombres.Focus();
            error.Clear(); //se limpiar los mensajes del error provider

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        //METODOS PARA CONTROL DE MENSAJES de errores
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Control de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Control de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
