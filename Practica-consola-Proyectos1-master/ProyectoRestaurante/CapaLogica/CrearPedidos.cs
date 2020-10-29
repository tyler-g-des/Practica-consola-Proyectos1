using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class CrearPedidos
    {
        #region Pedidos
        Form simulado;
        Label lbTextoSeleccionPedidos = new Label();
        Label lbTextoEntrada = new Label();
        Label lbTextoPlatoFuerte = new Label();
        Label lbTextoPostre = new Label();
        Label lbTextoBebida = new Label();

        ComboBox cbMenuSeleccionEntrada = new ComboBox();
        ComboBox cbMenuSeleccionPlato = new ComboBox();
        ComboBox cbMenuPostre = new ComboBox();
        ComboBox cbMenuBebida = new ComboBox();

        Button btnGuardar = new Button();
        Pedidos pd = new Pedidos();
        Label mesa1Envio = new Label();
        #endregion

        public void crearPantalla(String mesa)
        {
            simulado = new Form();

            simulado.Visible = true;
            simulado.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            simulado.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            simulado.ClientSize = new System.Drawing.Size(818, 497);
            simulado.Text = "Form2";
            simulado.ResumeLayout(false);


            #region Tomar Perdido
            // ---------------------------- PANTALLLA Seleccion ----------------------------//
            // LABEL 
            lbTextoSeleccionPedidos.Text = "Seleccion Pedido";
            lbTextoSeleccionPedidos.Visible = true;
            lbTextoSeleccionPedidos.Size = new Size(280, 32);
            lbTextoSeleccionPedidos.Location = new Point(242, 42);
            lbTextoSeleccionPedidos.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            simulado.Controls.Add(lbTextoSeleccionPedidos);

            // LABEL Entrada
            lbTextoEntrada.Text = "Entrada";
            lbTextoEntrada.Visible = true;
            lbTextoEntrada.Size = new Size(122, 32);
            lbTextoEntrada.Location = new Point(24, 133);
            lbTextoEntrada.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            simulado.Controls.Add(lbTextoEntrada);

            lbTextoPlatoFuerte.Text = "Plato Fuerte";
            lbTextoPlatoFuerte.Visible = true;
            lbTextoPlatoFuerte.Size = new Size(182, 32);
            lbTextoPlatoFuerte.Location = new Point(190, 133);
            lbTextoPlatoFuerte.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            simulado.Controls.Add(lbTextoPlatoFuerte);

            lbTextoPostre.Text = "Postre";
            lbTextoPostre.Visible = true;
            lbTextoPostre.Size = new Size(103, 32);
            lbTextoPostre.Location = new Point(419, 133);
            lbTextoPostre.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            simulado.Controls.Add(lbTextoPostre);

            lbTextoBebida.Text = "Bebido";
            lbTextoBebida.Visible = true;
            lbTextoBebida.Size = new Size(111, 32);
            lbTextoBebida.Location = new Point(618, 133);
            lbTextoBebida.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            simulado.Controls.Add(lbTextoBebida);

            // --------------------------------------- COMBOX --------------------------//

            cbMenuSeleccionEntrada.Visible = true;
            cbMenuSeleccionEntrada.Size = new Size(138, 24);
            cbMenuSeleccionEntrada.Location = new Point(17, 187);
            cbMenuSeleccionEntrada.TabStop = false;

            simulado.Controls.Add(cbMenuSeleccionEntrada);

            cbMenuSeleccionPlato.Visible = true;
            cbMenuSeleccionPlato.Size = new Size(162, 24);
            cbMenuSeleccionPlato.Location = new Point(196, 187);
            cbMenuSeleccionPlato.TabStop = false;
            simulado.Controls.Add(cbMenuSeleccionPlato);

            cbMenuPostre.Visible = true;
            cbMenuPostre.Size = new Size(161, 24);
            cbMenuPostre.Location = new Point(408, 187);
            cbMenuPostre.TabStop = false;
            simulado.Controls.Add(cbMenuPostre);

            cbMenuBebida.Visible = true;
            cbMenuBebida.Size = new Size(161, 24);
            cbMenuBebida.Location = new Point(606, 187);
            cbMenuBebida.TabStop = false;
            simulado.Controls.Add(cbMenuBebida);


            Pedidos pedidos = new Pedidos();
            pedidos.opciones(cbMenuSeleccionEntrada, cbMenuSeleccionPlato, cbMenuPostre, cbMenuBebida);

            btnGuardar.Text = "Guardar";
            btnGuardar.Visible = true;
            btnGuardar.Size = new Size(216, 64);
            btnGuardar.Location = new Point(265, 314);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            btnGuardar.Click += new EventHandler(btnGuardarPedido);
            simulado.Controls.Add(btnGuardar);

            mesa1Envio.Text = mesa;
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            simulado.Controls.Add(mesa1Envio);
            #endregion

        }

        void btnGuardarPedido(object sender, EventArgs e)
        {

            String entrada = cbMenuSeleccionEntrada.SelectedItem.ToString();
            String platoFuerte = cbMenuSeleccionPlato.SelectedItem.ToString();
            String postre = cbMenuPostre.SelectedItem.ToString();
            String bebida = cbMenuBebida.SelectedItem.ToString();
            String mesa = mesa1Envio.Text;

            crudPedidos cp = new crudPedidos();

            cp.guardarPerdido(entrada, platoFuerte, postre, bebida,mesa);
            simulado.Close();

        }
    }
}
