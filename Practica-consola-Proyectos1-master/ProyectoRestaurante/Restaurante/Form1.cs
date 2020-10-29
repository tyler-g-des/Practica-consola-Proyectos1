using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Pantalla Inicial

        Label lbTextoMenuPrincipal = new Label();
        ComboBox cbMenuPrincipal = new ComboBox();
        Button btnComenzar = new Button();

        #endregion

        #region botones Segunda pantalla
        Button btnMesa1 = new Button();
        Button btnMesa2 = new Button();
        Button btnMesa3 = new Button();
        Button btnMesa4 = new Button();
        Button btnMesa5 = new Button();
        Button btnMesa6 = new Button();
        Button btnMesa7 = new Button();
        Button btnMesa8 = new Button();
        #endregion

        #region Pantalla SeleccionPersonas

        Label lbTextoSeleccionPersonas = new Label();
        ComboBox cbCantidadPersonas = new ComboBox();
        Button btnTomarOrdenes = new Button();

        #endregion

        #region Pedidos

        Label lbTextoSeleccionPedidos = new Label();
        Label lbTextoEntrada = new Label();
        Label lbTextoPlatoFuerte= new Label();
        Label lbTextoPostre = new Label();
        Label lbTextoBebida = new Label();

        ComboBox cbMenuSeleccionEntrada = new ComboBox();
        ComboBox cbMenuSeleccionPlato = new ComboBox();
        ComboBox cbMenuPostre = new ComboBox();
        ComboBox cbMenuBebida = new ComboBox();

        Button btnGuardar = new Button();
        Pedidos pd = new Pedidos();

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(818,497);
            #region Pantalla Inicial
            // ---------------------------- PANTALLLA PRINCIPAL ----------------------------//

            // LABEL PRINCIPAL
            lbTextoMenuPrincipal.Text = "Restaurante Seleccione la Cantidad de Mesas";
            lbTextoMenuPrincipal.Visible = true;
            lbTextoMenuPrincipal.Size = new Size(581,32);
            lbTextoMenuPrincipal.Location = new Point(101,33);
            lbTextoMenuPrincipal.Font= new Font("Microsoft Sans Serif",14, FontStyle.Bold);
            this.Controls.Add(lbTextoMenuPrincipal);

            //ComboBox ELECCION DE MESAS
            cbMenuPrincipal.Visible = true;
            cbMenuPrincipal.Size = new Size(265, 24);
            cbMenuPrincipal.Location = new Point(252, 138);
            cbMenuPrincipal.Items.Add(4);
            cbMenuPrincipal.Items.Add(5);
            cbMenuPrincipal.Items.Add(6);
            cbMenuPrincipal.Items.Add(7);
            cbMenuPrincipal.Items.Add(8);
            cbMenuPrincipal.TabStop = false;
            this.Controls.Add(cbMenuPrincipal);

            //BOTON COMENZAR
            btnComenzar.Text = "Comenzar";
            btnComenzar.Visible = true;
            btnComenzar.Size = new Size(219, 70);
            btnComenzar.Location = new Point(275,239);
            btnComenzar.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            btnComenzar.Click += new EventHandler(btnComenzarAccion);
            this.Controls.Add(btnComenzar);
            #endregion

            #region Segunda pantalla
            // ---------------------------- SEGUNDA PANTALLLA ----------------------------//
            Label lbTextoSegundoTexto = new Label();
            lbTextoSegundoTexto.Text = "Seleccione la mesa que desea atender";
            lbTextoSegundoTexto.Visible = true;
            lbTextoSegundoTexto.Size = new Size(562, 32);
            lbTextoSegundoTexto.Location = new Point(149, 32);
            lbTextoSegundoTexto.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm2.Controls.Add(lbTextoSegundoTexto);

            btnMesa1.Text = "Mesa 1";
            btnMesa1.Visible = false;
            btnMesa1.Size = new Size(118, 72);
            btnMesa1.Location = new Point(175, 86);
            btnMesa1.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa1.Click += new EventHandler(btnMesasAccion1);
            frm2.Controls.Add(btnMesa1);

            btnMesa2.Text = "Mesa 2";
            btnMesa2.Visible = false;
            btnMesa2.Size = new Size(118, 72);
            btnMesa2.Location = new Point(363, 86);
            btnMesa2.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa2.Click += new EventHandler(btnMesasAccion2);
            frm2.Controls.Add(btnMesa2);

            btnMesa3.Text = "Mesa 3";
            btnMesa3.Visible = false;
            btnMesa3.Size = new Size(118, 72);
            btnMesa3.Location = new Point(175, 199);
            btnMesa3.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa3.Click += new EventHandler(btnMesasAccion3);
            frm2.Controls.Add(btnMesa3);

            btnMesa4.Text = "Mesa 4";
            btnMesa4.Visible = false;
            btnMesa4.Size = new Size(118, 72);
            btnMesa4.Location = new Point(363,199);
            btnMesa4.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa4.Click += new EventHandler(btnMesasAccion4);
            frm2.Controls.Add(btnMesa4);

            btnMesa5.Text = "Mesa 5";
            btnMesa5.Visible = false;
            btnMesa5.Size = new Size(118, 72);
            btnMesa5.Location = new Point(175, 309);
            btnMesa5.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa5.Click += new EventHandler(btnMesasAccion5);
            frm2.Controls.Add(btnMesa5);

            btnMesa6.Text = "Mesa 6";
            btnMesa6.Visible = false;
            btnMesa6.Size = new Size(118, 72);
            btnMesa6.Location = new Point(363, 309);
            btnMesa6.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa6.Click += new EventHandler(btnMesasAccion6);
            frm2.Controls.Add(btnMesa6);

            btnMesa7.Text = "Mesa 7";
            btnMesa7.Visible = false;
            btnMesa7.Size = new Size(118, 72);
            btnMesa7.Location = new Point(563, 128);
            btnMesa7.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa7.Click += new EventHandler(btnMesasAccion7);
            frm2.Controls.Add(btnMesa7);


            btnMesa8.Text = "Mesa 8";
            btnMesa8.Visible = false;
            btnMesa8.Size = new Size(118, 72);
            btnMesa8.Location = new Point(563, 247);
            btnMesa8.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Bold);
            btnMesa8.Click += new EventHandler(btnMesasAccion8);
            frm2.Controls.Add(btnMesa8);
            #endregion

            #region Pantalla Selccion Personas
            // ---------------------------- PANTALLLA Seleccion ----------------------------//

            // LABEL PRINCIPAL
            lbTextoSeleccionPersonas.Text = "Restaurante Seleccione la Cantidad de Mesas";
            lbTextoSeleccionPersonas.Visible = true;
            lbTextoSeleccionPersonas.Size = new Size(581, 32);
            lbTextoSeleccionPersonas.Location = new Point(101, 33);
            lbTextoSeleccionPersonas.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(lbTextoSeleccionPersonas);

            //ComboBox ELECCION DE MESAS
            cbCantidadPersonas.Visible = true;
            cbCantidadPersonas.Size = new Size(265, 24);
            cbCantidadPersonas.Location = new Point(252, 138);
            cbCantidadPersonas.Items.Add(1);
            cbCantidadPersonas.Items.Add(2);
            cbCantidadPersonas.Items.Add(3);
            cbCantidadPersonas.Items.Add(4);
            cbCantidadPersonas.TabStop = false;
            frm3.Controls.Add(cbCantidadPersonas);

            //BOTON COMENZAR
            btnTomarOrdenes.Text = "Comenzar";
            btnTomarOrdenes.Visible = true;
            btnTomarOrdenes.Size = new Size(219, 70);
            btnTomarOrdenes.Location = new Point(275, 239);
            btnTomarOrdenes.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            btnTomarOrdenes.Click += new EventHandler(btnTomarPedido);
            frm3.Controls.Add(btnTomarOrdenes);
            #endregion

            #region Tomar Perdido
            // ---------------------------- PANTALLLA Seleccion ----------------------------//
            // LABEL 
            lbTextoSeleccionPedidos.Text = "Seleccion Pedido";
            lbTextoSeleccionPedidos.Visible = true;
            lbTextoSeleccionPedidos.Size = new Size(280, 32);
            lbTextoSeleccionPedidos.Location = new Point(242, 42);
            lbTextoSeleccionPedidos.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm4.Controls.Add(lbTextoSeleccionPedidos);

            // LABEL Entrada
            lbTextoEntrada.Text = "Entrada";
            lbTextoEntrada.Visible = true;
            lbTextoEntrada.Size = new Size(122, 32);
            lbTextoEntrada.Location = new Point(24, 133);
            lbTextoEntrada.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm4.Controls.Add(lbTextoEntrada);

            lbTextoPlatoFuerte.Text = "Plato Fuerte";
            lbTextoPlatoFuerte.Visible = true;
            lbTextoPlatoFuerte.Size = new Size(182, 32);
            lbTextoPlatoFuerte.Location = new Point(190, 133);
            lbTextoPlatoFuerte.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm4.Controls.Add(lbTextoPlatoFuerte);

            lbTextoPostre.Text = "Postre";
            lbTextoPostre.Visible = true;
            lbTextoPostre.Size = new Size(103, 32);
            lbTextoPostre.Location = new Point(419, 133);
            lbTextoPostre.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm4.Controls.Add(lbTextoPostre);

            lbTextoBebida.Text = "Bebido";
            lbTextoBebida.Visible = true;
            lbTextoBebida.Size = new Size(111, 32);
            lbTextoBebida.Location = new Point(618, 133);
            lbTextoBebida.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm4.Controls.Add(lbTextoBebida);

            // --------------------------------------- COMBOX --------------------------//

            cbMenuSeleccionEntrada.Visible = true;
            cbMenuSeleccionEntrada.Size = new Size(138, 24);
            cbMenuSeleccionEntrada.Location = new Point(17, 187);
            cbMenuSeleccionEntrada.TabStop = false;
            
            frm4.Controls.Add(cbMenuSeleccionEntrada);

            cbMenuSeleccionPlato.Visible = true;
            cbMenuSeleccionPlato.Size = new Size(162, 24);
            cbMenuSeleccionPlato.Location = new Point(196, 187);
            cbMenuSeleccionPlato.TabStop = false;
            frm4.Controls.Add(cbMenuSeleccionPlato);

            cbMenuPostre.Visible = true;
            cbMenuPostre.Size = new Size(161, 24);
            cbMenuPostre.Location = new Point(408, 187);
            cbMenuPostre.TabStop = false;
            frm4.Controls.Add(cbMenuPostre);

            cbMenuBebida.Visible = true;
            cbMenuBebida.Size = new Size(161, 24);
            cbMenuBebida.Location = new Point(606, 187);
            cbMenuBebida.TabStop = false;
            frm4.Controls.Add(cbMenuBebida);


            Pedidos pedidos = new Pedidos();
            pedidos.opciones(cbMenuSeleccionEntrada,cbMenuSeleccionPlato,cbMenuPostre,cbMenuBebida);

            btnGuardar.Text = "Guardar";
            btnGuardar.Visible = true;
            btnGuardar.Size = new Size(216, 64);
            btnGuardar.Location = new Point(265, 314);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            btnGuardar.Click += new EventHandler(btnGuardarPedido);
            frm4.Controls.Add(btnGuardar);


            #endregion
        }
    }
}
