using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDeControl
{
    public partial class PersonalWF : MasterWF
    {
        public PersonalWF()
        {
            InitializeComponent();
        }

        private void PersonalWF_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void btnJugador_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonNuevoJugador();
            }
            catch (Exception ex)
            { }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonEditar();
            }
            catch (Exception ex)
            { }
        }
        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionesBotonEliminarJugadorMenu();
            }
            catch (Exception ex)
            { }
        }      
        #endregion
        #region Funciones
        public static int IdBoton;
        private void FuncionesBotonNuevoJugador()
        {
            IdBoton = 0;
            IdBoton = 1;
            ///// Visible False          
            lblDniOApellidoNombre.Visible = false;
            txtBuscarApellidoNombre.Visible = false;
            btnBuscar.Visible = false;
            lblTexto.Visible = false;
            ///// Visible True
            groupBox2.Visible = true;
            lblApellido.Visible = true;
            lblNombre.Visible = true;
            lblDni.Visible = true;
            lblSexo.Visible = true;
            lblSubse.Visible = true;
            lblSecretaria.Visible = true;
            lblDireccion.Visible = true;
            lblArea.Visible = true;
            lblPuesto.Visible = true;
            lblFechaNacimiento.Visible = true;
            lblLegajo.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            txtApellido.Visible = true;
            txtNombre.Visible = true;
            txtDni.Visible = true;
            cmbSexo.Visible = true;
            txtApodo.Visible = true;
            dtFechaNacimiento.Visible = true;
            cmbSecretaria.Visible = true;
            cmbSubse.Visible = true;
            cmbDireccion.Visible = true;
            txtArea.Visible = true;
            txtPuesto.Visible = true;
            ///// Otras
            txtApellido.Focus();
            groupBox2.Text = "Nueva Persona";
            txtBuscarApellidoNombre.Clear();
        }
        private void FuncionesBotonEditar()
        {
            txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorPesona.Autocomplete();
            txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            IdBoton = 0;
            IdBoton = 2;
            ///// Visible True
            groupBox2.Visible = true;
            lblDniOApellidoNombre.Visible = true;
            txtBuscarApellidoNombre.Visible = true;
            btnBuscar.Visible = true;
            ///// Visible False
            groupBox2.Visible = false;
            lblApellido.Visible = false;
            lblNombre.Visible = false;
            lblDni.Visible = false;
            lblSexo.Visible = false;
            lblSubse.Visible = false;
            lblSecretaria.Visible = false;
            lblDireccion.Visible = false;
            lblArea.Visible = false;
            lblPuesto.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblLegajo.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            txtDni.Visible = false;
            cmbSexo.Visible = false;
            txtApodo.Visible = false;
            dtFechaNacimiento.Visible = false;
            cmbSecretaria.Visible = false;
            cmbSubse.Visible = false;
            cmbDireccion.Visible = false;
            txtArea.Visible = false;
            txtPuesto.Visible = false;
            ///// Otras
            txtBuscarApellidoNombre.Clear();
            txtBuscarApellidoNombre.Focus();
            groupBox2.Text = "Editar Persona";
        }
        private void FuncionesBotonEliminarJugadorMenu()
        {
            txtBuscarApellidoNombre.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorPesona.Autocomplete();
            txtBuscarApellidoNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            IdBoton = 0;
            IdBoton = 3;
            ///// Visible True
            groupBox2.Visible = true;
            lblDniOApellidoNombre.Visible = true;
            txtBuscarApellidoNombre.Visible = true;
            btnBuscar.Visible = true;
            ///// Visible False
            groupBox2.Visible = false;
            lblApellido.Visible = false;
            lblNombre.Visible = false;
            lblDni.Visible = false;
            lblSexo.Visible = false;
            lblSubse.Visible = false;
            lblSecretaria.Visible = false;
            lblDireccion.Visible = false;
            lblArea.Visible = false;
            lblPuesto.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblLegajo.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            txtApellido.Visible = false;
            txtNombre.Visible = false;
            txtDni.Visible = false;
            cmbSexo.Visible = false;
            txtApodo.Visible = false;
            dtFechaNacimiento.Visible = false;
            cmbSecretaria.Visible = false;
            cmbSubse.Visible = false;
            cmbDireccion.Visible = false;
            txtArea.Visible = false;
            txtPuesto.Visible = false;
            ///// Otras
            txtBuscarApellidoNombre.Clear();
            txtBuscarApellidoNombre.Focus();
            groupBox2.Text = "Editar Persona";
        }
        #endregion
    }
}

