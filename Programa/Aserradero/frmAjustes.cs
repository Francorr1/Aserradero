using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aserradero.Logica;
using Aserradero.Entidades;
using System.Reflection;

namespace Aserradero
{
    public partial class frmAjustes : Form
    {
        public clsLUsuario sesion;
        public clsLRegistro registro = new clsLRegistro();
        public Form formAnterior;
        public clsHerramientasInterfaz herramientasInterfaz = new clsHerramientasInterfaz();
        public bool diferenciador;

        clsERegistro busquedaRegistro = new clsERegistro();
        clsERegistro.clsERegistroSimple entidadRegistroSimple = new clsERegistro.clsERegistroSimple();
        clsEUsuario nuevoUsuario = new clsEUsuario();
        clsEUsuario comunicadorUsuario = new clsEUsuario();

        clsLUsuario logicaUsuario = new clsLUsuario();
        clsLTipoUsuario logicaTipoUsuario = new clsLTipoUsuario();

        clsEUsuario.clsEUsuarioSimple[] coleccionUsuariosSimples;
        clsEUsuario[] coleccionUsuarios;
                

        // Al crear un nuevo frmAjustes, se ejecuta esta función
        public frmAjustes(clsLUsuario ses, Form callerForm)
        {
            diferenciador = true;
            InitializeComponent();
            formAnterior = callerForm;
            sesion = ses;
            if (calRegistro.Visible) { calRegistro.Hide(); }
            if (!pnlUsuarios.Visible) { pnlUsuarios.Show(); }
            actualizarDGV();
            reiniciarPanelAgregar();
            reiniciarPanelEditar();
        }

        public void cargarDGV(object[] objetos)
        {
            dgvAjustes.AutoGenerateColumns = true;
            dgvAjustes.DataSource = objetos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarDGV();
        }


        #region Método actualizar DGV

        private void actualizarDGV()
        {
            if (lblTitulo.Text.Equals("Usuarios"))
            {
                clsEUsuario.clsEUsuarioSimple[] coleccionUsuariosSimples;
                clsEUsuario.clsEUsuarioSimple entidadRegistroSimple = new clsEUsuario.clsEUsuarioSimple();
                clsEUsuario[] coleccionUsuarios = sesion.listarUsuarios().ToArray();

                this.coleccionUsuarios = coleccionUsuarios;
                coleccionUsuariosSimples = entidadRegistroSimple.desarmarUsuario(coleccionUsuarios);

                this.coleccionUsuariosSimples = coleccionUsuariosSimples;
                cargarDGV(coleccionUsuariosSimples);

                reiniciarCboTipoAgregar();
            }

            if (lblTitulo.Text.Equals("Registro"))
            {
                clsERegistro.clsERegistroSimple[] coleccionRegistrosSimples;
                clsERegistro.clsERegistroSimple entidadRegistroSimple = new clsERegistro.clsERegistroSimple();
                clsERegistro[] coleccionRegistros = registro.listarRegistro().ToArray();

                coleccionRegistrosSimples = entidadRegistroSimple.desarmarRegistro(coleccionRegistros);

                cargarDGV(coleccionRegistrosSimples);

                cboUsuario.Items.Clear();
                cboUsuario.Text = "Usuarios";

                for (int cont = 0; cont < coleccionUsuariosSimples.Length; cont++)
                {
                    cboUsuario.Items.Insert(cont, coleccionUsuariosSimples[cont].nombre);
                }

            }

            if(lblTitulo.Text.Equals("Tipos de Usuario"))
            {
                clsETipoUsuario.clsETipoUsuarioSimple[] coleccionTiposUsuarioSimples;
                clsETipoUsuario.clsETipoUsuarioSimple entidadTipoUsuarioSimple = new clsETipoUsuario.clsETipoUsuarioSimple();
                clsETipoUsuario[] coleccionTiposUsuario = logicaTipoUsuario.listarTiposUsuario().ToArray();

                coleccionTiposUsuarioSimples = entidadTipoUsuarioSimple.desarmarTipoUsuario(coleccionTiposUsuario);

                cargarDGV(coleccionTiposUsuarioSimples);
            }
        }

        #endregion

        #region Barra Izquierda
        private void btnVolver_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Close();
            GC.Collect();
        }

        private void btnTiposUsuario_Click(object sender, EventArgs e)
        {
            pnlUsuarios.Hide();
            pnlVacioInferior.Show();
            lblTitulo.Text = "Tipos de Usuario";
            actualizarDGV();
            pnlAgregar.Hide();
            pnlEditar.Hide();
            calRegistro.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            pnlUsuarios.Hide();
            pnlVacioInferior.Hide();
            lblTitulo.Text = "Registro";
            actualizarDGV();
            pnlAgregar.Hide();
            pnlEditar.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pnlUsuarios.Show();
            pnlVacioInferior.Hide();
            lblTitulo.Text = "Usuarios";
            actualizarDGV();
            calRegistro.Hide();
        }
        #endregion

        #region Barra Superior
        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            herramientasInterfaz.moverForms(e, this.Handle);
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.cerrarVentanas(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.minimizarVentana(this);
        }

        #endregion

        #region Barra inferior

        //TODO: Búsqueda de registro, por fecha y por usuario

        private void btnFecha_Click(object sender, EventArgs e)
        {
            if (calRegistro.Visible)
            {
                calRegistro.Hide();
            }
            else
            {
                calRegistro.Show();
            }
        }

        private void calRegistro_DateSelected(object sender, DateRangeEventArgs e)
        {
            calRegistro.Hide();

            clsERegistro[] arrayRegistros;
            clsERegistro.clsERegistroSimple[] arrayRegistrosSimples;
            DateTime fechaSeleccionada = new DateTime();
            fechaSeleccionada = calRegistro.SelectionStart;
            string fechaConsulta = fechaSeleccionada.ToString("yyyy-MM-dd");

            List<clsERegistro> coleccionRegistros = registro.informeRegistroPorFecha(fechaConsulta);
            arrayRegistros = coleccionRegistros.ToArray();
            arrayRegistrosSimples = entidadRegistroSimple.desarmarRegistro(arrayRegistros);

            cargarDGV(arrayRegistrosSimples);

            return;
        }

        private void cboUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            clsERegistro[] coleccionRegistros = registro.informeRegistroPorUsuario(coleccionUsuarios[cboUsuario.SelectedIndex].ci).ToArray();
            
            cargarDGV(entidadRegistroSimple.desarmarRegistro(coleccionRegistros));
        }

        // TODO: ABM de usuarios

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            reiniciarPanelAgregar();

            if (pnlEditar.Visible)
            {
                pnlEditar.Hide();
            }

            if (pnlAgregar.Visible)
            {
                pnlAgregar.Hide();
            }
            else
            {
                reiniciarCboTipoAgregar();
                pnlAgregar.Show();
            }

        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            lblErrorAgregar.Hide();

            if (txtCedulaAgregar.Text.Equals("") || txtClaveAgregar.Equals("") || txtCorreoAgregar.Equals("") || txtNombreAgregar.Equals("") || txtTelefonoAgregar.Equals("") || cboTipoAgregar.Text.Equals(""))
            {
                lblErrorAgregar.Text = "No pueden existir campos vacíos";
                lblErrorAgregar.Show();
            }
            else if (!confirmarCedula(txtCedulaAgregar.Text))
            {
                lblErrorAgregar.Text = "La cédula ingresada no es correcta";
                lblErrorAgregar.Show();
            }
            else if (!confirmarTipo(cboTipoAgregar.SelectedIndex + 1))
            {
                lblErrorAgregar.Text = "Debe seleccionar un tipo de usuario válido";
                lblErrorAgregar.Show();
            }
            else if (logicaUsuario.verificarUsuario(Convert.ToInt32(txtCedulaAgregar.Text)))
            {
                lblErrorAgregar.Text = "El usuario ya está ingresado al sistema";
                lblErrorAgregar.Show();
            }
            else
            {
                int cedula = Convert.ToInt32(txtCedulaAgregar.Text);
                string nombre = txtNombreAgregar.Text;
                string clave = txtClaveAgregar.Text;
                int telefono = Convert.ToInt32(txtTelefonoAgregar.Text);
                string correo = txtCorreoAgregar.Text;

                clsETipoUsuario entidadTipoUsuario = logicaTipoUsuario.informeTipoUsuarioParticular(Convert.ToInt32(cboTipoAgregar.SelectedIndex + 1));
                lblErrorAgregar.Hide();

                nuevoUsuario = comunicadorUsuario.armarUsuario(cedula, nombre, clave, telefono, correo, entidadTipoUsuario);
                logicaUsuario.altaUsuario(nuevoUsuario);
                pnlAgregar.Hide();
                actualizarDGV();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int cont = 0; cont < coleccionUsuariosSimples.Length; cont++)
            {
                if (coleccionUsuariosSimples[cont].seleccionado)
                {
                    logicaUsuario.bajaUsuario(Convert.ToInt32(coleccionUsuariosSimples[cont].documento));
                    actualizarDGV();
                }
            }

            return;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            reiniciarPanelEditar();

            if (pnlAgregar.Visible)
            {
                pnlAgregar.Hide();
            }

            if (pnlEditar.Visible)
            {
                pnlEditar.Hide();
            }
            else
            {
                pnlEditar.Show();

                if (confirmarSeleccion())
                {
                    lblDocumentoEditar.Text = usuarioSeleccionado().documento;
                    lblTipoEditar.Text = usuarioSeleccionado().tipo;
                    txtClaveEditar.Text = usuarioSeleccionado().clave;
                    txtTelefonoEditar.Text = usuarioSeleccionado().contacto;
                    txtCorreoEditar.Text = usuarioSeleccionado().correo;
                    txtNombreEditar.Text = usuarioSeleccionado().nombre;
                }else
                {
                    reiniciarPanelEditar();
                }
            }
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            lblErrorEditar.Hide();

            if (txtClaveEditar.Equals(null) || txtCorreoEditar.Equals(null) || txtNombreEditar.Equals(null) || txtTelefonoEditar.Equals(null))
            {
                lblErrorEditar.Show();
            }
            else
            {
                int documento = Convert.ToInt32(lblDocumentoEditar.Text);
                string nombre = txtNombreEditar.Text;
                string clave = txtClaveEditar.Text;
                int telefono = Convert.ToInt32(txtTelefonoEditar.Text);
                string correo = txtCorreoEditar.Text;
                lblErrorEditar.Hide();

                nuevoUsuario = comunicadorUsuario.armarUsuario(documento, nombre, clave, telefono, correo, null);
                logicaUsuario.modificarUsuario(nuevoUsuario);
                pnlEditar.Hide();
                actualizarDGV();
            }
        }

        #endregion

        #region Métodos extras

        private clsEUsuario.clsEUsuarioSimple usuarioSeleccionado()
        {
            for (int cont = 0; cont < coleccionUsuariosSimples.Length; cont++)
            {
                if (coleccionUsuariosSimples[cont].seleccionado)
                {
                    return coleccionUsuariosSimples[cont];
                }
            }

            return null;
        }

        private bool confirmarSeleccion()
        {
            bool haySeleccion = false;

            for (int cont = 0; cont < coleccionUsuariosSimples.Length; cont++)
            {
                if (coleccionUsuariosSimples[cont].seleccionado)
                {
                    haySeleccion = true;
                    break;
                }
            }

            return haySeleccion;
        }

        private bool confirmarCedula(string cedula)
        {
            if (cedula.Length != 8)
            {
                return false;
            }else
            {
                return true;
            }
        }

        private bool confirmarTipo(int tipo)
        {
            if (!tipo.Equals(1) && !tipo.Equals(2) && !tipo.Equals(3) && !tipo.Equals(4))
            {
                return false;
            }else {
                return true;
            }
        }

        private void reiniciarPanelAgregar()
        {

            lblErrorAgregar.Hide();
            txtCedulaAgregar.Text = "";
            txtClaveAgregar.Text = "";
            cboTipoAgregar.Text = "";
            txtCorreoAgregar.Text = "";
            txtNombreAgregar.Text = "";
            txtTelefonoAgregar.Text = "";
        }

        private void reiniciarPanelEditar()
        {
            lblErrorEditar.Hide();

            lblDocumentoEditar.Text = "[Cédula]";
            lblTipoEditar.Text = "[Tipo del usuario]";
            txtClaveEditar.Text = "";
            txtTelefonoEditar.Text = "";
            txtCorreoEditar.Text = "";
            txtNombreEditar.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.cerrarVentanas(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.minimizarVentana(this);
        }

        private void reiniciarCboTipoAgregar()
        {
            cboTipoAgregar.Items.Clear();

            cboTipoAgregar.Items.Insert(0, "Administrador Avanzado");
            cboTipoAgregar.Items.Insert(1, "Administrador Carpintería");
            cboTipoAgregar.Items.Insert(2, "Administrador Forestal");
            cboTipoAgregar.Items.Insert(3, "Usuario Estándar");
        }

        #endregion

        
    }
}
