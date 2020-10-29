
using CapaLogica;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurante
{
    partial class Form1
    {
        Form frm2 = new Form();
        Form frm3 = new Form();
        Form frm4 = new Form();
        Label mesa1Envio = new Label();
        public static int contador = 1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        void btnComenzarAccion(object sender, EventArgs e)
        {
            this.Visible = false;
            frm2.Visible = true;
            frm2.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm2.ClientSize = new System.Drawing.Size(818, 497);
            frm2.Text = "Form2";
            frm2.ResumeLayout(false);

            Button dd = new Button();
            Button[] botonesMesas = {dd,btnMesa1, btnMesa2, btnMesa3, btnMesa4,
                                     btnMesa5, btnMesa6, btnMesa7, btnMesa8};

            int cantidad = int.Parse(cbMenuPrincipal.SelectedItem.ToString());

            for (int i = 0; i <= cantidad; i++)
            {
                botonesMesas[i].Visible = true;
            }
        }

        void btnMesasAccion1(object sender, EventArgs e)
        {
            frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);

            btnMesa1.Enabled = false;
            mesa1Envio.Text = "MESA 1";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);
        }
        void btnMesasAccion2(object sender, EventArgs e)
        {
            frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);
            btnMesa2.Enabled = false;

            btnMesa2.Enabled = false;        
            mesa1Envio.Text = "MESA 2";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);

        }
        void btnMesasAccion3(object sender, EventArgs e)
        {
            frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);
            btnMesa3.Enabled = false;

            btnMesa3.Enabled = false;
            mesa1Envio.Text = "MESA 3";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);
        }
        void btnMesasAccion4(object sender, EventArgs e)
        {
            frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);
            btnMesa4.Enabled = false;

            btnMesa4.Enabled = false;
            mesa1Envio.Text = "MESA 4";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);
        }
        void btnMesasAccion5(object sender, EventArgs e)
        {
            frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);
            btnMesa5.Enabled = false;

            btnMesa5.Enabled = false;
            mesa1Envio.Text = "MESA 5";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);
        }
        void btnMesasAccion6(object sender, EventArgs e)
        {
            frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);
            btnMesa6.Enabled = false;

            btnMesa6.Enabled = false;
            mesa1Envio.Text = "MESA 6";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);
        }
        void btnMesasAccion7(object sender, EventArgs e)
        {
            try
            {
                frm2.Visible = false;
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);
                btnMesa7.Enabled = false;

                btnMesa7.Enabled = false;
                mesa1Envio.Text = "MESA 7";
                mesa1Envio.Location = new Point(723, 412);
                mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                frm3.Controls.Add(mesa1Envio);
            }
            catch
            {
                frm3 = new Form1();
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);
                btnMesa7.Enabled = false;

                btnMesa7.Enabled = false;
                mesa1Envio.Text = "MESA 7";
                mesa1Envio.Location = new Point(723, 412);
                mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                frm3.Controls.Add(mesa1Envio);
            }
        }
        void btnMesasAccion8(object sender, EventArgs e)
        {
            try
            {
             frm2.Visible = false;
            frm3.Visible = true;
            frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            frm3.ClientSize = new System.Drawing.Size(818, 497);
            frm3.Text = "Form2";
            frm3.ResumeLayout(false);
            btnMesa8.Enabled = false;

            btnMesa8.Enabled = false;
            mesa1Envio.Text = "MESA 8";
            mesa1Envio.Location = new Point(723, 412);
            mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            frm3.Controls.Add(mesa1Envio);

         
            }
            catch
            {
                frm3 = new Form();
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);
                btnMesa8.Enabled = false;

                btnMesa8.Enabled = false;
                mesa1Envio.Text = "MESA 8";
                mesa1Envio.Location = new Point(723, 412);
                mesa1Envio.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                frm3.Controls.Add(mesa1Envio);
            }
        }

        void btnCantidadDeOrdenes(object sender, EventArgs e)
        {
            try
            {
                frm2.Visible = false;
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);
            }
            catch 
            {
                frm3 = new Form();
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);

            }
        
        }

        void btnFormularioPedidos(object sender, EventArgs e)
        {
            try
            {
                frm2.Visible = false;
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);
            }
            catch
            {
                frm3 =  new Form(); 
                frm3.Visible = true;
                frm3.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm3.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm3.ClientSize = new System.Drawing.Size(818, 497);
                frm3.Text = "Form2";
                frm3.ResumeLayout(false);
            }
        }

        void btnTomarPedido(object sender, EventArgs e)
        {

            try
            {
                frm3.Visible = false;
                frm4.Visible = true;
                frm4.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm4.ClientSize = new System.Drawing.Size(818, 497);
                frm4.Text = "Form2";
                frm4.ResumeLayout(false);
            }
            catch 
            {
                frm4 = new Form();
                frm4.Visible = true;
                frm4.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                frm4.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                frm4.ClientSize = new System.Drawing.Size(818, 497);
                frm4.Text = "Form2";
                frm4.ResumeLayout(false);
            }
        }
        

        void btnGuardarPedido(object sender, EventArgs e)
        {
            int personas = int.Parse(cbCantidadPersonas.SelectedItem.ToString());

                String entrada = cbMenuSeleccionEntrada.SelectedItem.ToString();
                String platoFuerte = cbMenuSeleccionPlato.SelectedItem.ToString();
                String postre = cbMenuPostre.SelectedItem.ToString();
                String bebida = cbMenuBebida.SelectedItem.ToString();
                 String mesa = mesa1Envio.Text;

                crudPedidos cp = new crudPedidos();

                cp.guardarPerdido(entrada, platoFuerte, postre, bebida,mesa);
                frm4.Close();

            do
            {
                CrearPedidos cpedido = new CrearPedidos();
                cpedido.crearPantalla(mesa);
                contador++;

            } while (contador != personas);
            frm2.Show();
        }

    }
}

