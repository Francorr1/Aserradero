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

namespace Aserradero
{
    public partial class frmAnterior : Form
    {
        // Instanciamos las herramientas de la interfaz
        clsHerramientasInterfaz herramientasInterfaz = new clsHerramientasInterfaz();

        // Instanciamos la sesión actual
        clsLUsuario sesion;

        public frmAnterior(clsLUsuario sec) // Pedimos una sesión al cargar el form
        {
            InitializeComponent();
            sesion = sec;
        }

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

        // TODO: Mover parcialmente el control de visibilidad a la capa lógica, algo como: herramientasInterfaz.ActualizarVistaPorUsuario(this, sesion);
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            tabABMLPrincipal.Hide(); // Por defecto, no se vé el tabcontrol del ABML Principal
            clsEUsuario usuario = sesion.usuario;
            //clsEntidadesUsuario.Usuario usuario = sesion.usuario;

            switch(usuario.entidadTipoUsuario.idTipo)
            {
                case 1:
                    tabABMLPrincipal.Show();
                    MostrarUsuarios();
                    lblNombre.Text = "Has iniciado sesión como usuario avanzado";
                    break;
                case 2:
                    lblNombre.Text = "Has iniciado sesión como usuario medio";
                    break;
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //lblResultadoRegistrarUsuario.Text = sesion.CrearUsuario(Convert.ToInt32(txtUsuarioCi.Text), txtUsuarioNombre.Text, txtUsuarioClave.Text, txtUsuarioTelefono.Text, txtUsuarioCorreo.Text, Convert.ToInt32(txtUsuarioNivel.Text));

            // TODO: Mejorar esto, no debería ser una comprobación de texto
            if (lblResultadoRegistrarUsuario.Text.StartsWith("Se ha"))
            {
                MostrarUsuarios();
            }
        }

        /// <summary>
        /// Actualiza el DataGridView de los usuarios
        /// </summary>
        private void MostrarUsuarios()
        {
            dgvListadoUsuarios.Rows.Clear();
            dgvListadoUsuarios.Columns.Clear();

            dgvListadoUsuarios.Columns.Add("CiUsuario", "Ci");
            dgvListadoUsuarios.Columns.Add("NombreUsuario", "Nombre");
            dgvListadoUsuarios.Columns.Add("TelefonoUsuario", "Teléfono");
            dgvListadoUsuarios.Columns.Add("CorreoUsuario", "Correo");
            dgvListadoUsuarios.Columns.Add("NivelUsuario", "Nivel");

            // TODO: Cambiar la función para utilizar objetos
            /*foreach(DataRow registro in usuarios.Rows)
            {
                dgvListadoUsuarios.Rows.Add(registro.Field<string>("CiUsuario"), registro.Field<string>("NombreUsuario"), registro.Field<string>("TelefonoUsuario"), registro.Field<string>("CorreoUsuario"), registro.Field<string>("IdTipo"));
            }*/
        }
    }
}
