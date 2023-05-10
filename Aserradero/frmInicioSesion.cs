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
    public partial class frmInicioSesion : Form
    {
        // Instanciamos la sesión
        clsLUsuario sesion = new clsLUsuario();

        clsLRegistro registro = new clsLRegistro();

        // Instanciamos las herramientas de la interfaz
        clsHerramientasInterfaz herramientasInterfaz = new clsHerramientasInterfaz();

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string cedulaErronea = txtCedula.Text;
            int cedula = 0;
            int.TryParse(cedulaErronea, out cedula);

            clsEUsuario intentoInicio = sesion.iniciarSesion(new clsEUsuario().armarUsuario(cedula, "", txtClave.Text, 0, "", null));

            if (intentoInicio != null)
            {
                sesion.usuario = intentoInicio;

                clsERegistro entidadRegistro = new clsERegistro();
                entidadRegistro.descripcionRegistro = "Inició sesión";
                entidadRegistro.entidadUsuario = sesion.usuario;
                registro.altaRegistro(entidadRegistro);

                Form frmPrincipalForm = new frmPrincipal(sesion, this);
                frmPrincipalForm.Show();
                this.Hide();
            }
            else
            {
                lblErrorInicio.Text = "Usuario y/o contraseña incorrectos";
            }

            return;
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.cerrarVentanas(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.minimizarVentana(this);
        }
    }
}
