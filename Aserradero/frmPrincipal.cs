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
    public partial class frmPrincipal : Form
    {
        public clsLUsuario sesion;
        public clsLEspecie logicaEspecie = new clsLEspecie();
        public clsLGrupoTroza logicaGrupoTroza = new clsLGrupoTroza();
        public clsLLote logicaLote = new clsLLote();
        public clsLRodal logicaRodal = new clsLRodal();
        public clsLProducto logicaProducto = new clsLProducto();
        public clsLPedido logicaPedido = new clsLPedido();
        public clsLRegistro logicaRegistro = new clsLRegistro();
        public clsLCliente logicaCliente = new clsLCliente();
        public Form formAnterior;
        public clsHerramientasInterfaz herramientasInterfaz = new clsHerramientasInterfaz();

        public clsERegistro entidadRegistro = new clsERegistro();
        public clsEProducto entidadProducto = new clsEProducto();
        public clsEPedido pedidoSeleccionado = new clsEPedido();
        public clsEGrupoTroza grupoTrozasSeleccionado = new clsEGrupoTroza();

        public clsECliente[] coleccionClientes;
        public clsEProducto[] coleccionProductos;
        public clsEEspecie[] coleccionEspecies;
        public clsERodal[] coleccionRodales;
        public clsEGrupoTroza[] coleccionGrupoTrozas;
        public clsEPedido[] coleccionPedidos;
        public clsELote[] coleccionLotes;
        public object[] coleccionEntidades;

        List<clsEProducto> listaProductos = new List<clsEProducto>();
        List<int> listaCantidades = new List<int>();

        public frmPrincipal(clsLUsuario s, Form callerForm)
        {
            formAnterior = callerForm;
            sesion = s;
            InitializeComponent();
            Inicial();
            pnlPrincipal.Show();
            pnlAgregarTrozas.Hide();
        }

        void Inicial()
        {
            lblCincuentas.Text = $"Bienvenido,\n{sesion.usuario.nombre}.";
            lblErrorSeleccionar.Hide();

            switch (sesion.usuario.entidadTipoUsuario.idTipo)
            {
                case 1:
                    break;

                case 2:
                    btnEliminar.Hide();
                    btnAgregar.Hide();
                    btnEditar.Hide();
                    interfazAdminCarpinteria();
                    break;

                case 3:
                    btnEliminar.Hide();
                    btnAgregar.Hide();
                    btnEditar.Hide();
                    interfazAdminForestal();
                    break;

                case 4:
                    btnEliminar.Hide();
                    btnAgregar.Hide();
                    btnEditar.Hide();
                    interfazEstandar();
                    break;

                default: lblCincuentas.Text = "Error desconocido."; break;
            }

            actualizarDgvPrincipal();

        }

        void interfazAdminCarpinteria()
        {
            btnAjustes.Hide();
        }

        void interfazAdminForestal()
        {
            btnAjustes.Hide();
        }

        void interfazEstandar()
        {
            btnAjustes.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarDgvPrincipal();
        }

        //Método que actuliza el data grid view principal con lo que le corresponda
        private void actualizarDgvPrincipal()
        {
            lblErrorSeleccionar.Hide(); //Se esconde la label de error al no seleccionar

            if (conseguirDatos() != null)
            {
                btnAgregarTroza.Hide();
                coleccionEntidades = conseguirDatos();
                dgvPrincipal.DataSource = coleccionEntidades;
            }
        }
        private void esconderObjetosModificar()
        {
            lblET1.Hide();
            lblET2.Hide();
            lblET3.Hide();
            lblET4.Hide();
            lblET5.Hide();
            lblET6.Hide();
            lblE1.Hide();
            lblE2.Hide();
            lblE3.Hide();
            lblE4.Hide();
            lblE5.Hide();
            lblE6.Hide();
            cboE1.Hide();
            cboE1.Items.Clear();
            cboE2.Hide();
            cboE3.Hide();
            cboE4.Hide();
            cboE5.Hide();
            cboE6.Hide();
            txtE1.Hide();
            txtE2.Hide();
            txtE3.Hide();
            txtE4.Hide();
            txtE5.Hide();
            txtE6.Hide();
            mtbE1.Hide();
            mtbE2.Hide();
            lblErrorEditar.Hide();
        }

        private void esconderObjetosAgregar()
        {
            lblAT1.Hide();
            lblAT2.Hide();
            lblAT3.Hide();
            lblAT4.Hide();
            lblAT5.Hide();
            lblAT6.Hide();
            lblA1.Hide();
            lblA2.Hide();
            lblA3.Hide();
            lblA4.Hide();
            lblA5.Hide();
            lblA6.Hide();
            cboA1.Hide();
            cboA1.Text = "";
            cboA2.Hide();
            cboA2.Text = "";
            cboA3.Hide();
            cboA3.Text = "";
            cboA4.Hide();
            cboA4.Text = "";
            cboA5.Hide();
            cboA5.Text = "";
            cboA6.Hide();
            cboA6.Text = "";
            txtA1.Hide();
            txtA1.Text = "";
            txtA2.Hide();
            txtA2.Text = "";
            txtA3.Hide();
            txtA3.Text = "";
            txtA4.Hide();
            txtA4.Text = "";
            txtA5.Hide();
            txtA5.Text = "";
            txtA6.Hide();
            txtA6.Text = "";
            mtbA1.Hide();
            mtbA1.Text = "";
            mtbA2.Hide();
            mtbA2.Text = "";
            lsbProductos.Items.Clear();
            lblErrorAgregar.Hide();
        }

        object[] conseguirDatos()
        {
            esconderObjetosAgregar();
            esconderObjetosModificar();
            btnAgregarTroza.Hide();
            btnEntregar.Hide();
            btnPedidoProducto.Hide();
            lsbProductos.Hide();
            pnlPedidosProductos.Hide();
            lblListaProductos.Hide();

            pnlAgregar.Hide();
            pnlEditar.Hide();

            btnAgregar.Hide();
            btnEliminar.Hide();
            btnEditar.Hide();

            //Definición de los objetos a utilizar

            #region Pedidos
            clsLPedido logicaPedido = new clsLPedido();
            clsEPedido.clsEPedidoSimple entidadPedidoSimple = new clsEPedido.clsEPedidoSimple();
            clsEPedido[] coleccionPedidos = logicaPedido.listarPedidos().ToArray();
            clsEPedido.clsEPedidoSimple[] coleccionPedidosSimples;
            this.coleccionPedidos = coleccionPedidos;
            #endregion
            #region Clientes
            clsLCliente logicaCliente = new clsLCliente();
            clsECliente.clsEClienteSimple entidadClienteSimple = new clsECliente.clsEClienteSimple();
            clsECliente[] coleccionClientes = logicaCliente.listarClientes().ToArray();
            clsECliente.clsEClienteSimple[] coleccionClientesSimples;
            this.coleccionClientes = coleccionClientes;
            #endregion
            #region Rodales
            clsLRodal logicaRodal = new clsLRodal();
            clsERodal.clsERodalSimple entidadRodalSimple = new clsERodal.clsERodalSimple();
            clsERodal[] coleccionRodales = logicaRodal.listarRodales().ToArray();
            clsERodal.clsERodalSimple[] coleccionRodalesSimples;
            this.coleccionRodales = coleccionRodales;
            #endregion
            #region Especies
            clsLEspecie logicaEspecie = new clsLEspecie();
            clsEEspecie.clsEEspecieSimple entidadEspecieSimple = new clsEEspecie.clsEEspecieSimple();
            clsEEspecie[] coleccionEspecies = logicaEspecie.listarEspecies().ToArray();
            clsEEspecie.clsEEspecieSimple[] coleccionEspeciesSimples;
            this.coleccionEspecies = coleccionEspecies;
            #endregion
            #region Trozas
            clsLGrupoTroza logicaGrupoTroza = new clsLGrupoTroza();
            clsEGrupoTroza.clsEGrupoTrozaSimple entidadGrupoTrozaSimple = new clsEGrupoTroza.clsEGrupoTrozaSimple();
            clsEGrupoTroza[] coleccionGruposTrozas = logicaGrupoTroza.listarGrupoTroza().ToArray();
            clsEGrupoTroza.clsEGrupoTrozaSimple[] coleccionGruposTrozasSimples;
            this.coleccionGrupoTrozas = coleccionGruposTrozas;
            #endregion
            #region Productos
            clsLProducto logicaProducto = new clsLProducto();
            clsEProducto.clsEProductoSimple entidadProductoSimple = new clsEProducto.clsEProductoSimple();
            clsEProducto[] coleccionProductos = logicaProducto.listarProductos().ToArray();
            clsEProducto.clsEProductoSimple[] coleccionProductosSimples;
            this.coleccionProductos = coleccionProductos;
            #endregion
            #region Lotes
            clsLLote logicaLote = new clsLLote();
            clsELote.clsELoteSimple entidadLoteSimple = new clsELote.clsELoteSimple();
            clsELote[] coleccionLotes = logicaLote.listarLotes().ToArray();
            clsELote.clsELoteSimple[] coleccionLotesSimples;
            this.coleccionLotes = coleccionLotes;
            #endregion

            btnEditar.Location = new Point(174, 453);

            switch (lblTitulo.Text) // TODO: Buscar una mejor comprobación
            {
                case "Pedidos":
                    
                    coleccionClientesSimples = entidadClienteSimple.desarmarCliente(coleccionClientes);

                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 3)
                    {
                        btnAgregar.Show();
                        //btnEditar.Show(); Es algo incierto si se modifican. De momento, no.
                        btnEliminar.Show();
                        btnEntregar.Show();
                    }

                    lblAT1.Text = "Fecha solicitud";
                    lblAT1.Show();
                    mtbA1.Show();
                    lblAT2.Text = "Fecha límite";
                    lblAT2.Show();
                    mtbA2.Show();
                    lblAT3.Text = "Cliente";
                    lblAT3.Show();

                    cboA3.Show();//Contiene los clientes
                    cboA3.Items.Clear();

                    for (int cont = 0; cont < coleccionClientesSimples.Length; cont++)
                    {
                        cboA3.Items.Insert(cont, coleccionClientesSimples[cont].nombre);
                    }


                    lblAT5.Text = "Producto";
                    lblAT5.Show();
                    btnPedidoProducto.Show();
                    lsbProductos.Show();
                    lblListaProductos.Show();

                    coleccionPedidosSimples = entidadPedidoSimple.desarmarPedido(coleccionPedidos);

                    return coleccionPedidosSimples;
                case "Rodales":

                    coleccionEspeciesSimples = entidadEspecieSimple.desarmarEspecie(coleccionEspecies);

                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 3)
                    {
                        btnAgregar.Show();
                        btnEditar.Show();
                        btnEliminar.Show();
                    }

                    lblAT1.Text = "Especie";
                    lblAT1.Show();

                    cboA1.Show(); //Contiene especies
                    cboA1.Items.Clear();

                    for (int cont = 0; cont < coleccionEspeciesSimples.Length; cont++)
                    {
                        cboA1.Items.Insert(cont, coleccionEspeciesSimples[cont].nombre);
                    }

                    lblAT2.Text = "Dimensiones en metros cuadrados";
                    lblAT2.Show();
                    txtA2.Show();

                    lblET1.Text = "Especie";
                    lblET1.Show();
                    lblE1.Text = "Nombre Especie";
                    lblE1.Show();
                    lblET2.Text = "Dimensiones en metros cuadrados";
                    lblET2.Show();
                    txtE2.Show();

                    coleccionRodalesSimples = entidadRodalSimple.desarmarRodal(coleccionRodales);

                    return coleccionRodalesSimples;
                case "Especies":

                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 3)
                    {
                        btnEditar.Show();
                        btnEditar.Location = new Point(93, 453);
                        btnAgregar.Show();
                    }

                    lblAT1.Text = "Nombre";
                    lblAT1.Show();
                    txtA1.Show();
                    lblAT2.Text = "Descripción de la especie";
                    lblAT2.Show();
                    txtA2.Show();

                    lblET1.Text = "Nombre";
                    lblET1.Show();
                    txtE1.Show();
                    lblET2.Text = "Descripción de la especie";
                    lblET2.Show();
                    txtE2.Show();

                    coleccionEspeciesSimples = entidadEspecieSimple.desarmarEspecie(coleccionEspecies);

                    return coleccionEspeciesSimples;
                case "Trozas":

                    coleccionEspeciesSimples = entidadEspecieSimple.desarmarEspecie(coleccionEspecies);

                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 3)
                    {
                        btnAgregar.Show();
                        btnEditar.Show();
                        btnEditar.Location = new Point(93, 453);
                        btnAgregarTroza.Show();
                    }

                    lblAT1.Text = "Diámetro";
                    lblAT1.Show();
                    txtA1.Show();
                    lblAT2.Text = "Cantidad";
                    lblAT2.Show();
                    txtA2.Show();
                    lblAT3.Text = "Especie";
                    lblAT3.Show();

                    cboA3.Show(); //Contiene especies
                    cboA3.Items.Clear();

                    for (int cont = 0; cont < coleccionEspeciesSimples.Length; cont++)
                    {
                        cboA3.Items.Insert(cont, coleccionEspeciesSimples[cont].nombre);
                    }

                    lblET1.Text = "Diámetro";
                    lblET1.Show();
                    txtE1.Show();
                    lblET2.Text = "Especie";
                    lblET2.Show();

                    cboE2.Show(); //Contiene especies
                    cboE2.Items.Clear();

                    for (int cont = 0; cont < coleccionEspeciesSimples.Length; cont++)
                    {
                        cboE2.Items.Insert(cont, coleccionEspeciesSimples[cont].nombre);
                    }

                    coleccionGruposTrozasSimples = entidadGrupoTrozaSimple.desarmarGrupoTroza(coleccionGruposTrozas);

                    return coleccionGruposTrozasSimples;
                case "Productos":

                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 2)
                    {
                        btnEditar.Show();
                        btnEditar.Location = new Point(93, 453);
                        btnAgregar.Show();
                    }

                    lblAT1.Text = "Nombre del producto";
                    lblAT1.Show();
                    txtA1.Show();
                    lblAT2.Text = "Descripción del producto";
                    lblAT2.Show();
                    txtA2.Show();

                    lblET1.Text = "Nombre del producto";
                    lblET1.Show();
                    txtE1.Show();
                    lblET2.Text = "Descripción del producto";
                    lblET2.Show();
                    txtE2.Show();

                    coleccionProductosSimples = entidadProductoSimple.desarmarProducto(coleccionProductos);

                    return coleccionProductosSimples;
                case "Lotes":

                    coleccionGruposTrozasSimples = entidadGrupoTrozaSimple.desarmarGrupoTroza(coleccionGruposTrozas);
                    coleccionProductosSimples = entidadProductoSimple.desarmarProducto(coleccionProductos);

                    btnEditar.Hide();
                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 2)
                    {
                        btnEliminar.Show();
                        btnAgregar.Show();
                    }

                    List<clsEProducto> productos = new clsLProducto().listarProductos();
                    List<clsEGrupoTroza> trozas = new clsLGrupoTroza().listarGrupoTroza();

                    lblAT1.Text = "Cantidad Producto";
                    lblAT1.Show();
                    txtA1.Show();
                    lblAT2.Text = "Cantidad Troza";
                    lblAT2.Show();
                    txtA2.Show();
                    lblAT3.Text = "Producto";
                    lblAT3.Show();

                    cboA3.Show(); //Contiene productos
                    cboA3.Items.Clear();

                    for(int cont = 0; cont < coleccionProductosSimples.Length; cont++)
                    {
                        cboA3.Items.Insert(cont, coleccionProductosSimples[cont].nombre);
                    }

                    lblAT4.Text = "Troza";
                    lblAT4.Show();

                    cboA4.Show(); //Contiene trozas
                    cboA4.Items.Clear();

                    for(int cont = 0; cont < coleccionGruposTrozasSimples.Length; cont++)
                    {
                        cboA4.Items.Insert(cont, $"{coleccionGruposTrozasSimples[cont].diametro}cm - {coleccionGruposTrozasSimples[cont].rodal}");
                    }

                    coleccionLotesSimples = entidadLoteSimple.desarmarLote(coleccionLotes);

                    return coleccionLotesSimples;
                case "Clientes":

                    if (sesion.usuario.entidadTipoUsuario.idTipo == 1 || sesion.usuario.entidadTipoUsuario.idTipo == 3)
                    {
                        btnAgregar.Show();
                        btnEditar.Show();
                        btnEditar.Location = new Point(93, 453);
                    }

                    lblAT1.Text = "Nombre";
                    lblAT1.Show();
                    txtA1.Show();
                    lblAT2.Text = "Ubicación";
                    lblAT2.Show();
                    txtA2.Show();

                    lblET1.Text = "Nombre";
                    lblET1.Show();
                    txtE1.Show();
                    lblET2.Text = "Ubicación";
                    lblET2.Show();
                    txtE2.Show();

                    coleccionClientesSimples = entidadClienteSimple.desarmarCliente(coleccionClientes);

                    return coleccionClientesSimples;
            }
            return null;
        }

        #region Barra Izquierda
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Pedidos";
            actualizarDgvPrincipal();
        }

        private void btnRodales_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Rodales";
            actualizarDgvPrincipal();
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Especies";
            actualizarDgvPrincipal();
        }

        private void btnTrozas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Trozas";
            actualizarDgvPrincipal();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Productos";
            actualizarDgvPrincipal();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Lotes";
            actualizarDgvPrincipal();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Clientes";
            actualizarDgvPrincipal();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Form frmAjustesForm = new frmAjustes(sesion, this);
            frmAjustesForm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.cerrarVentanas(this);
        }
        #endregion
        #region Barra Superior
        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            herramientasInterfaz.moverForms(e, this.Handle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.cerrarVentanas(this);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            herramientasInterfaz.minimizarVentana(this);
        }
        #endregion
        #region Barra inferior

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!pnlAgregar.Visible)
            {
                pnlPedidosProductos.Show();
                cboProductos.Text = "";
                nudProductoCantidad.Value = 0;
                lblErrorSeleccionar.Hide();
                pnlAgregarTrozas.Hide();
                pnlEditar.Hide();
                pnlAgregar.Show();
                pnlPedidosProductos.Hide();
            }
            else
            {
                lblErrorLimiteProductos.Hide();
                pnlAgregar.Hide();
                pnlPedidosProductos.Hide();
            }
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            switch (lblTitulo.Text)
            {
                case "Pedidos":

                    clsEPedido pedido = new clsEPedido();

                    if (cboA3.Text == "" || mtbA1.Text == "" || mtbA2.Text == "" || lsbProductos.Items.Count == 0)
                    {
                        lblErrorAgregar.Show();
                    }
                    else
                    {
                        lblErrorAgregar.Hide();
                        coleccionClientes = logicaCliente.listarClientes().ToArray();
                        pedido.entidadCliente = coleccionClientes[cboA3.SelectedIndex];

                        pedido.entidadUsuario = sesion.usuario;

                        pedido.fechaSolicitud = DateTime.Parse(mtbA1.Text).ToString("yyyy-MM-dd");
                        pedido.fechaLimite = DateTime.Parse(mtbA2.Text).ToString("yyyy-MM-dd");

                        pedido.coleccionProductos = listaProductos.ToArray();
                        pedido.cantidadSolicitada = listaCantidades.ToArray();

                        logicaPedido.altaPedido(pedido);
                        actualizarDgvPrincipal();
                        lsbProductos.Items.Clear();

                        listaProductos.Clear();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó pedido";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();

                    }

                    break;

                case "Rodales":
                    clsERodal rodal = new clsERodal();

                    if ((cboA1.Text == "") || (txtA1.Text == ""))
                    {
                        lblErrorAgregar.Show();
                    }

                    else
                    {
                        lblErrorAgregar.Hide();
                        coleccionEspecies = logicaEspecie.listarEspecies().ToArray();
                        rodal.entidadEspecie = coleccionEspecies[cboA1.SelectedIndex];

                        rodal.dimensiones = Convert.ToInt32(txtA2.Text);
                        rodal.entidadUsuario = sesion.usuario;

                        logicaRodal.altaRodal(rodal);
                        actualizarDgvPrincipal();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó rodal";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;

                case "Especies":
                    clsEEspecie especie = new clsEEspecie();

                    if ((txtA1.Text == "") || (txtA2.Text == ""))
                    {
                        lblErrorAgregar.Show();
                    }

                    else
                    {
                        lblErrorAgregar.Hide();
                        especie.nombre = txtA1.Text;
                        especie.descripcion = txtA2.Text;

                        logicaEspecie.altaEspecie(especie);
                        actualizarDgvPrincipal();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó especie";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;

                case "Trozas":
                    clsEGrupoTroza grupoTroza = new clsEGrupoTroza();

                    if ((txtA1.Text == "") || (txtA1.Text == "") || (cboA3.Text == ""))
                    {
                        lblErrorAgregar.Show();
                    }

                    else
                    {
                        lblErrorAgregar.Hide();
                        grupoTroza.diametro = Convert.ToInt32(txtA1.Text);
                        grupoTroza.cantidad = Convert.ToInt32(txtA2.Text);

                        coleccionEspecies = logicaEspecie.listarEspecies().ToArray();
                        grupoTroza.entidadRodal = logicaRodal.informeRodalPorEspecie(coleccionEspecies[cboA3.SelectedIndex]);

                        logicaGrupoTroza.altaGrupoTroza(grupoTroza);
                        actualizarDgvPrincipal();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó grupo de trozas";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;

                case "Productos":
                    clsEProducto producto = new clsEProducto();

                    if ((txtA1.Text == "") || (txtA1.Text == ""))
                    {
                        lblErrorAgregar.Show();
                    }

                    else
                    {
                        lblErrorAgregar.Hide();
                        producto.tipo = txtA1.Text;
                        producto.descripcion = txtA2.Text;
                        producto.entidadUsuario = sesion.usuario;

                        logicaProducto.altaProducto(producto);
                        actualizarDgvPrincipal();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó producto";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;

                case "Lotes":
                    clsELote lote = new clsELote();

                    if ((txtA1.Text == "") || (txtA1.Text == "") || (cboA3.Text == "") || (cboA4.Text == ""))
                    {
                        lblErrorAgregar.Show();
                    }

                    else
                    {
                        lblErrorAgregar.Hide();
                        lote.cantidadProducto = Convert.ToInt32(txtA1.Text);
                        lote.cantidadTroza = Convert.ToInt32(txtA2.Text);
                        lote.entidadUsuario = sesion.usuario;

                        coleccionProductos = logicaProducto.listarProductos().ToArray();
                        lote.entidadProducto = coleccionProductos[cboA3.SelectedIndex];

                        coleccionGrupoTrozas = logicaGrupoTroza.listarGrupoTroza().ToArray();
                        lote.entidadGrupoTroza = coleccionGrupoTrozas[cboA4.SelectedIndex];

                        logicaLote.altaLote(lote);
                        actualizarDgvPrincipal();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó Lote";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;

                case "Clientes":
                    clsECliente cliente = new clsECliente();

                    if ((txtA1.Text == "") || (txtA1.Text == ""))
                    {
                        lblErrorAgregar.Show();
                    }

                    else
                    {
                        lblErrorAgregar.Hide();
                        cliente.nombre = txtA1.Text;
                        cliente.ubicacion = txtA2.Text;

                        logicaCliente.altaCliente(cliente);
                        actualizarDgvPrincipal();

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Ingresó cliente";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;
            }
            if (lblErrorAgregar.Visible == false)
            {
                actualizarDgvPrincipal();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado().Length == 0)
            {
                lblErrorSeleccionar.Show();
            }
            else
            {
                pnlAgregar.Hide();
                pnlEditar.Hide();
                lblErrorSeleccionar.Hide();

                int[] indices;
                int contador = 0;

                switch (lblTitulo.Text)
                {
                    case "Pedidos":
                        indices = indiceSeleccionado();
                        clsEPedido[] pedidosEliminar = new clsEPedido[indices.Length];
                        contador = 0;

                        for (int cont = 0; cont < coleccionPedidos.Length; cont++)
                        {
                            if (indices.Contains(cont))
                            {
                                pedidosEliminar[contador] = coleccionPedidos[cont];
                                contador++;
                            }
                        }

                        for (int cont = 0; cont < pedidosEliminar.Length; cont++)
                        {
                            logicaPedido.bajaPedido(pedidosEliminar[cont]);

                            entidadRegistro.entidadUsuario = sesion.usuario;
                            entidadRegistro.descripcionRegistro = "Eliminó pedido";
                            logicaRegistro.altaRegistro(entidadRegistro);
                            entidadRegistro = new clsERegistro();
                        }

                        actualizarDgvPrincipal();
                        break;
                    case "Rodales":
                        indices = indiceSeleccionado();
                        clsERodal[] rodalesEliminar = new clsERodal[indices.Length];
                        contador = 0;

                        for (int cont = 0; cont < coleccionPedidos.Length; cont++)
                        {
                            if (indices.Contains(cont))
                            {
                                rodalesEliminar[contador] = coleccionRodales[cont];
                                contador++;
                            }
                        }

                        for (int cont = 0; cont < rodalesEliminar.Length; cont++)
                        {
                            logicaRodal.bajaRodal(rodalesEliminar[cont]);

                            entidadRegistro.entidadUsuario = sesion.usuario;
                            entidadRegistro.descripcionRegistro = "Eliminó rodal";
                            logicaRegistro.altaRegistro(entidadRegistro);
                            entidadRegistro = new clsERegistro();
                        }

                        actualizarDgvPrincipal();
                        break;
                    case "Lotes":
                        indices = indiceSeleccionado();
                        clsELote[] lotesEliminar = new clsELote[indices.Length];
                        contador = 0;

                        for (int cont = 0; cont < coleccionLotes.Length; cont++)
                        {
                            if (indices.Contains(cont))
                            {
                                lotesEliminar[contador] = coleccionLotes[cont];
                                contador++;
                            }
                        }

                        for (int cont = 0; cont < lotesEliminar.Length; cont++)
                        {
                            logicaLote.bajaLote(lotesEliminar[cont]);

                            entidadRegistro.entidadUsuario = sesion.usuario;
                            entidadRegistro.descripcionRegistro = "Eliminó lote";
                            logicaRegistro.altaRegistro(entidadRegistro);
                            entidadRegistro = new clsERegistro();
                        }

                        actualizarDgvPrincipal();
                        break;
                }
                actualizarDgvPrincipal();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (!pnlEditar.Visible)
            {
                pnlAgregarTrozas.Hide();
                pnlAgregar.Hide();
                pnlPedidosProductos.Hide();

                if(indiceSeleccionado().Length == 0)
                {
                    lblErrorSeleccionar.Show();
                }
                else { 
                    int[] indices = indiceSeleccionado();
                    int indiceEditar = indices[0];

                    pnlEditar.Show();
                    lblErrorSeleccionar.Hide();

                    switch (lblTitulo.Text)
                    {
                        case "Rodales":

                            coleccionRodales = logicaRodal.listarRodales().ToArray();

                            lblE1.Text = coleccionRodales[indiceEditar].entidadEspecie.nombre;
                            txtE2.Text = coleccionRodales[indiceEditar].dimensiones.ToString();
                            break;
                        case "Especies":

                            coleccionEspecies = logicaEspecie.listarEspecies().ToArray();

                            txtE1.Text = coleccionEspecies[indiceEditar].nombre;
                            txtE2.Text = coleccionEspecies[indiceEditar].descripcion;
                            break;
                        case "Trozas":

                            coleccionGrupoTrozas = logicaGrupoTroza.listarGrupoTroza().ToArray();

                            txtE1.Text = coleccionGrupoTrozas[indiceEditar].diametro.ToString();
                            cboE2.Text = coleccionGrupoTrozas[indiceEditar].entidadRodal.entidadEspecie.nombre;

                            break;
                        case "Productos":

                            coleccionProductos = logicaProducto.listarProductos().ToArray();

                            txtE1.Text = coleccionProductos[indiceEditar].tipo;
                            txtE2.Text = coleccionProductos[indiceEditar].descripcion;
                            break;
                        case "Clientes":

                            coleccionClientes = logicaCliente.listarClientes().ToArray();

                            txtE1.Text = coleccionClientes[indiceEditar].nombre;
                            txtE2.Text = coleccionClientes[indiceEditar].ubicacion;
                            break;
                    }
                }
            }
            else
            {
                pnlEditar.Hide();
            }
        }

        private void btnAceptarEditar_Click(object sender, EventArgs e)
        {
            int indiceEditar;
            int[] indices;

            lblErrorEditar.Hide();

            switch (lblTitulo.Text)
            {
                case "Rodales":

                    clsERodal entidadRodal = new clsERodal();

                    if (txtE2.Text == "")
                    {
                        lblErrorEditar.Show();
                    }

                    else
                    {
                        indices = indiceSeleccionado();
                        indiceEditar = indices[0];

                        entidadRodal.id = coleccionRodales[indiceEditar].id;
                        entidadRodal.dimensiones = Convert.ToInt32(txtE2.Text);
                        entidadRodal.entidadUsuario = sesion.usuario;

                        logicaRodal.modificarRodal(entidadRodal);

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Modificó rodal";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;

                case "Especies":

                    clsEEspecie entidadEspecie = new clsEEspecie();

                    if ((txtE1.Text == "") || (txtE2.Text == ""))
                    {
                        lblErrorEditar.Show();
                    }

                    else
                    {
                        indices = indiceSeleccionado();
                        indiceEditar = indices[0];

                        entidadEspecie.id = coleccionEspecies[indiceEditar].id;
                        entidadEspecie.nombre = txtE1.Text;
                        entidadEspecie.descripcion = txtE2.Text;

                        logicaEspecie.modificarEspecie(entidadEspecie);

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Modificó especie";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;
                case "Trozas":

                    clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();

                    if ((txtE1.Text == "") || (cboE2.Text == ""))
                    {
                        lblErrorEditar.Show();
                    }

                    else
                    {
                        indices = indiceSeleccionado();
                        indiceEditar = indices[0];

                        entidadGrupoTroza.id = coleccionGrupoTrozas[indiceEditar].id;
                        entidadGrupoTroza.diametro = Convert.ToInt32(txtE1.Text);

                        entidadEspecie = logicaEspecie.informeEspecie(cboE2.SelectedIndex + 1);
                        entidadGrupoTroza.entidadRodal = logicaRodal.informeRodalPorEspecie(entidadEspecie);

                        logicaGrupoTroza.modificarGrupoTroza(entidadGrupoTroza);

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Modificó grupo de trozas";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;
                case "Productos":

                    clsEProducto entidadProducto = new clsEProducto();

                    if ((txtE1.Text == "") || (txtE2.Text == ""))
                    {
                        lblErrorEditar.Show();
                    }

                    else
                    {
                        indices = indiceSeleccionado();
                        indiceEditar = indices[0];

                        entidadProducto.id = coleccionProductos[indiceEditar].id;
                        entidadProducto.tipo = txtE1.Text;
                        entidadProducto.descripcion = txtE2.Text;
                        entidadProducto.entidadUsuario = sesion.usuario;

                        logicaProducto.modificarProducto(entidadProducto);

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Modificó producto";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;
                case "Clientes":

                    clsECliente entidadCliente = new clsECliente();

                    if ((txtE1.Text == "") || (txtE2.Text == ""))
                    {
                        lblErrorEditar.Show();
                    }

                    else
                    {
                        indices = indiceSeleccionado();
                        indiceEditar = indices[0];

                        entidadCliente.id = coleccionClientes[indiceEditar].id;
                        entidadCliente.nombre = txtE1.Text;
                        entidadCliente.ubicacion = txtE2.Text;

                        logicaCliente.modificarCliente(entidadCliente);

                        entidadRegistro.entidadUsuario = sesion.usuario;
                        entidadRegistro.descripcionRegistro = "Modificó cliente";
                        logicaRegistro.altaRegistro(entidadRegistro);
                        entidadRegistro = new clsERegistro();
                    }

                    break;
            }
            if (lblErrorEditar.Visible == false)
            {
                actualizarDgvPrincipal();
            }
        }


        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (pnlEntregar.Visible)
            {
                pnlEntregar.Hide();
            }else
            {
                if (indiceSeleccionado().Length == 0)
                {
                    lblErrorSeleccionar.Show();
                }
                else
                { 
                    lblErrorSeleccionar.Hide();
                    coleccionPedidos = logicaPedido.listarPedidos().ToArray();
                    int[] indices = indiceSeleccionado();
                    pedidoSeleccionado = coleccionPedidos[indices[0]];
                    esconderEtiquetasProductos();

                    pnlEntregar.Show();
                    pnlEditar.Hide();
                    pnlAgregar.Hide();

                    lblEntregarCliente.Text = $"Cliente: {pedidoSeleccionado.entidadCliente.nombre}";

                    lblEntregarProducto1.Text = pedidoSeleccionado.coleccionProductos[0].tipo;
                    lblEntregadoSolicitado1.Text = $"{pedidoSeleccionado.cantidadEntregada[0].ToString()} Entregado, {pedidoSeleccionado.cantidadSolicitada[0].ToString()} Solicitado";
                    nudEntregar1.Maximum = pedidoSeleccionado.cantidadSolicitada[0] - pedidoSeleccionado.cantidadEntregada[0];

                    if (pedidoSeleccionado.coleccionProductos.Length > 1)
                    {
                        etiquetasProducto2(true);
                        lblEntregarProducto2.Text = pedidoSeleccionado.coleccionProductos[1].tipo;
                        lblEntregadoSolicitado2.Text = $"{pedidoSeleccionado.cantidadEntregada[1].ToString()} Entregado, {pedidoSeleccionado.cantidadSolicitada[1].ToString()} Solicitado";
                        nudEntregar2.Maximum = pedidoSeleccionado.cantidadSolicitada[1] - pedidoSeleccionado.cantidadEntregada[1];
                    }
                    if (pedidoSeleccionado.coleccionProductos.Length > 2)
                    {
                        etiquetasProducto3(true);
                        lblEntregarProducto3.Text = pedidoSeleccionado.coleccionProductos[2].tipo;
                        lblEntregadoSolicitado3.Text = $"{pedidoSeleccionado.cantidadEntregada[2].ToString()} Entregado, {pedidoSeleccionado.cantidadSolicitada[2].ToString()} Solicitado";
                        nudEntregar3.Maximum = pedidoSeleccionado.cantidadSolicitada[2] - pedidoSeleccionado.cantidadEntregada[2];
                    }
                    if (pedidoSeleccionado.coleccionProductos.Length > 3)
                    {
                        etiquetasProducto4(true);
                        lblEntregarProducto4.Text = pedidoSeleccionado.coleccionProductos[3].tipo;
                        lblEntregadoSolicitado4.Text = $"{pedidoSeleccionado.cantidadEntregada[3].ToString()} Entregado, {pedidoSeleccionado.cantidadSolicitada[3].ToString()} Solicitado";
                        nudEntregar4.Maximum = pedidoSeleccionado.cantidadSolicitada[3] - pedidoSeleccionado.cantidadEntregada[3];
                    }
                }
            }
        }

        private void btnAceptarEntregar_Click(object sender, EventArgs e)
        {
            pedidoSeleccionado.cantidadEntregada[0] = Convert.ToInt32(nudEntregar1.Value);

            if (pedidoSeleccionado.coleccionProductos.Length > 1)
            {
                pedidoSeleccionado.cantidadEntregada[1] = Convert.ToInt32(nudEntregar2.Value);
            }
            if (pedidoSeleccionado.coleccionProductos.Length > 2)
            {
                pedidoSeleccionado.cantidadEntregada[2] = Convert.ToInt32(nudEntregar3.Value);
            }
            if (pedidoSeleccionado.coleccionProductos.Length > 3)
            {
                pedidoSeleccionado.cantidadEntregada[3] = Convert.ToInt32(nudEntregar4.Value);
            }

            pnlEntregar.Hide();
            nudEntregar1.Value = 0;
            nudEntregar2.Value = 0;
            nudEntregar3.Value = 0;
            nudEntregar4.Value = 0;

            logicaPedido.entregarProductos(pedidoSeleccionado);
            actualizarDgvPrincipal();

            entidadRegistro.entidadUsuario = sesion.usuario;
            entidadRegistro.descripcionRegistro = "Entregó productos";
            logicaRegistro.altaRegistro(entidadRegistro);
        }

        private void btnAgregarTroza_Click(object sender, EventArgs e)
        {

            if (pnlAgregarTrozas.Visible)
            {
                pnlAgregarTrozas.Hide();
            }
            else
            {
                if (indiceSeleccionado().Length == 0)
                {
                    lblErrorSeleccionar.Show();
                }
                else
                {
                    lblErrorSeleccionar.Hide();
                    nudAgregarTroza.Value = 0;

                    int[] indices = indiceSeleccionado();
                    grupoTrozasSeleccionado = coleccionGrupoTrozas[indices[0]];

                    pnlEditar.Hide();
                    pnlAgregar.Hide();
                    pnlAgregarTrozas.Show();

                    lblEspecieDiametro.Text = $"Especie: {grupoTrozasSeleccionado.entidadRodal.entidadEspecie.nombre}\nDiámetro: {grupoTrozasSeleccionado.diametro}";
                }
            }
        }

        private void btnAceptarAgregarTroza_Click(object sender, EventArgs e)
        {
            grupoTrozasSeleccionado.cantidad = Convert.ToInt32(nudAgregarTroza.Value);

            logicaGrupoTroza.sumarTrozas(grupoTrozasSeleccionado);
            pnlAgregarTrozas.Hide();
            actualizarDgvPrincipal();

            entidadRegistro.entidadUsuario = sesion.usuario;
            entidadRegistro.descripcionRegistro = "Agregó trozas a un grupo";
            logicaRegistro.altaRegistro(entidadRegistro);
        }


        private void btnPedidoProducto_Click(object sender, EventArgs e)
        {
            if (!pnlPedidosProductos.Visible)
            {
                pnlPedidosProductos.Show();
                cboProductos.Text = "";
                nudProductoCantidad.Value = 0;

                cboProductos.Items.Clear(); //Se vacían los datos anteriormente almacenados en el comboBox
                coleccionProductos = logicaProducto.listarProductos().ToArray();
                for(int cont = 0; cont < coleccionProductos.Length; cont++)
                {
                    cboProductos.Items.Insert(cont, coleccionProductos[cont].tipo); //Se carga al comboBox productos con todos los nombres de los productos en el sistema
                }

            }
            else
            {
                pnlPedidosProductos.Hide();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            entidadProducto = coleccionProductos[cboProductos.SelectedIndex];
            int cantidad = Convert.ToInt32(nudProductoCantidad.Value);

            if (lsbProductos.Items.Count < 4)
            {
                listaCantidades.Add(cantidad);
                listaProductos.Add(entidadProducto);
                lsbProductos.Items.Add(entidadProducto.tipo);
            }
            else
            {
                lblErrorLimiteProductos.Show();
            }
            
        }

        #endregion

        #region Métodos extras
        private int[] indiceSeleccionado()
        {
            List<int> coleccionIndices = new List<int>();
            int[] coleccionIndicesInt;

            for(int i = 0; i < dgvPrincipal.RowCount; i++)
            {
                if ((bool)dgvPrincipal.Rows[i].Cells[0].Value == true)
                {
                    coleccionIndices.Add(i);
                }
            }
            coleccionIndicesInt = coleccionIndices.ToArray();

            return coleccionIndicesInt;
        }

        private void esconderEtiquetasProductos()
        {
            etiquetasProducto2(false);
            etiquetasProducto3(false);
            etiquetasProducto4(false);
        }
        private void etiquetasProducto2(bool mostrar)
        {
            if (mostrar)
            {
                lblEntregarProducto2.Show();
                lblEntregadoSolicitado2.Show();
                nudEntregar2.Show();
            }else
            {
                lblEntregarProducto2.Hide();
                lblEntregadoSolicitado2.Hide();
                nudEntregar2.Hide();
            }
        }
        private void etiquetasProducto3(bool mostrar)
        {
            if (mostrar)
            {
                lblEntregarProducto3.Show();
                lblEntregadoSolicitado3.Show();
                nudEntregar3.Show();
            }
            else
            {
                lblEntregarProducto3.Hide();
                lblEntregadoSolicitado3.Hide();
                nudEntregar3.Hide();
            }
        }
        private void etiquetasProducto4(bool mostrar)
        {
            if (mostrar)
            {
                lblEntregarProducto4.Show();
                lblEntregadoSolicitado4.Show();
                nudEntregar4.Show();
            }
            else
            {
                lblEntregarProducto4.Hide();
                lblEntregadoSolicitado4.Hide();
                nudEntregar4.Hide();
            }
        }
        #endregion
    }
}