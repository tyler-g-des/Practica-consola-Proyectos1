using System;
using System.Windows.Forms;

namespace ahorcadoPractica
{
    partial class Form1
    {
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

        private int buenas = 0;			
        private string antes; 
        private string PabElegida;
        private bool Jugar = false;  
        private int malas = -1; 
        private int num_text = 0; 
        private int tamanio;  
        private int cant = 0; 
        private int tema_elegido; 

        private string[] animales ={
            "gato",
            "perro",
            "burro",
            "elefante",
            "gaviota",
            "delfin",
            "vibora",
            "foca",
            "ballena",
            "gusano",
        };

        private string[] frutas ={
            "manzana",
            "apio",
            "mango",
            "zanahoria",
            "platano",
            "calabaza",
            "fresa",
            "frambuesa",
            "papaya",
            "aguacate",
        };

		private string[] marcas =
		{
		   "audi",
		   "lexux",
		   "porshe",
		   "bmw",
		   "mazda",
		   "buick",
		   "toyota",
		   "kia",
		   "honda",
		};

		private string[] fotos =
		{
			"imagen1.PNG",
			"imagen2.PNG",
			"imagen3.PNG",
			"imagen4.PNG",
			"imagen5.PNG",
		};

		public void Iniciar_juego()
		{
			groupBox1.Visible = false;
			PabElegida = temaElegido(tema_elegido);
			tamanio = PabElegida.Length;
			Crear_texto();
			Count_Letras(PabElegida);
			cant++;
			label1.Text = "Tiene " + PabElegida.Length.ToString() + " letras";
			Jugar = true;
			maskedTextBox1.Focus();
		}

		public void Buscar_palabra(int cantcad)
		{
			Random a = new Random();
			num_text = a.Next(0, cantcad);
			
		}

		public string temaElegido(int Var)
		{
			string Tema_Ele = "";
			switch (Var)
			{
				case 2:
					Buscar_palabra(frutas.Length);
					Tema_Ele = frutas[num_text];
					break;
				case 3:
					Buscar_palabra(marcas.Length);
					Tema_Ele = marcas[num_text];
					break;
				case 1:
					Buscar_palabra(animales.Length);
					Tema_Ele = animales[num_text];
					break;
			}
			return Tema_Ele;
		}

		public void Count_Letras(string cadelegida)
		{
			cant++;
			string precount = cadelegida;
			string precount2 = "", precount3 = "";
			for (int x = 0; x < precount.Length; x++)
			{
				precount2 = precount.Substring(0, 1);
				if (precount2 != precount.Substring(x, 1))
				{
					precount3 += precount.Substring(x, 1);
				}
			}
			if (precount3.Length != 1)
				Count_Letras(precount3);
		}
		public void Crear_texto()
		{
			
			string mas = "";
			for (int i = 1; i <= tamanio; i++)
			{
				mas += "-a";
				antes += "- ";
			}
			this.maskedTextBox1.Mask = mas;
		}
	
		void MaskedTextBox1KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (Jugar == true)
			{
				
				texto_ver(e);
			}
			this.maskedTextBox1.Text = antes;
			if (buenas == cant && malas < 8)
			{
				MessageBox.Show("FELICIDADES");
				reiniciarJuego();
			}
		}

		public void texto_ver(System.Windows.Forms.KeyPressEventArgs e)
		{
			
			bool esta = false;
			string mas2 = "";
			for (int x = 0; x < PabElegida.Length; x++)
			{
				if (PabElegida.Substring(x, 1) == e.KeyChar.ToString().ToLower())
				{
					mas2 += ("-" + e.KeyChar.ToString());
					esta = true;
				}
				else
				{
					mas2 += "- ";
				}
			}
		
			string mientras = ""; bool gt = true;

			for (int y = 0; y < antes.Length; y = y + 2)
			{
				if (antes.Substring(y, 2) == "- " && mas2.Substring(y, 2) != "- ")
				{
					mientras += mas2.Substring(y, 2);
					if (gt == true) buenas++;
					gt = false;
				}
				else
				{
					mientras += antes.Substring(y, 2);
				}
			}
			this.maskedTextBox1.Text = mientras;
			antes = mientras;
			if (esta == false)
			{
				malas++; 
				listBox1.Items.Add(e.KeyChar.ToString());
			}
			if (malas > -1)

				pictureBox1.ImageLocation = "imagenes/" + fotos[malas];
			if (malas == 4)
			{
				MessageBox.Show("HAS PERDIDO");
				reiniciarJuego();
			}
			esta = false;
		}

		void MaskedTextBox1KeyUp(object sender, KeyEventArgs e)
		{
			this.maskedTextBox1.Text = antes;
			if (buenas == cant && malas < 8)
			{
				MessageBox.Show("FELICIDADES");
				reiniciarJuego();
			}
		}

		void Button1Click(object sender, EventArgs e)
		{
			
			if (radioButton1.Checked == true)
			{
				tema_elegido = 1;
				Iniciar_juego();
			}
			else if (radioButton2.Checked == true)
			{
				tema_elegido = 2;
				Iniciar_juego();
			}
			else if (radioButton3.Checked == true)
			{
				tema_elegido = 3;
				Iniciar_juego();
			}
			else
				MessageBox.Show("elige una opcion", "el ahorcado");
		}
		public void reiniciarJuego()
		{
			groupBox1.Visible = true;
			listBox1.Items.Clear(); 
			maskedTextBox1.Clear(); 
			pictureBox1.ImageLocation = "images/vacio.PNG";//muestra una imagen vacia
			malas = -1;
			antes = "";
			PabElegida = "";	
		}

	}
}

