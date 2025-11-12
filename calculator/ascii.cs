using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class ASCII : Form
    {
        public ASCII()
        {
            InitializeComponent();
        }

        private void btnAsciiATexto_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada = txtEntrada.Text.Trim();
                string[] codigos = entrada.Split(' ');
                string texto = "";

                foreach (string codigo in codigos)
                {
                    // Convierte cada grupo de 7 bits a número y luego a carácter
                    int valor = Convert.ToInt32(codigo, 2);
                    texto += (char)valor;
                }

                txtResultado.Text = texto;
            }
            catch
            {
                MessageBox.Show("⚠️ Error: Asegúrate de ingresar códigos binarios de 7 bits separados por espacios.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTextoAAscii_Click(object sender, EventArgs e)
        {
            string texto = txtEntradaa.Text;
            StringBuilder asciiBinario = new StringBuilder();
            foreach (char c in texto)
            {
                // ASCII de 7 bits
                int ascii = (int)c;
                string binario7 = Convert.ToString(ascii, 2).PadLeft(7, '0');
                asciiBinario.Append(binario7 + " ");

                txtascii.Text = asciiBinario.ToString().Trim();
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtascii.Text = "";
            txtEntradaa.Text = "";
        }

        private void btnlimpiar1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtEntrada.Text = "";
        }

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }
    }
}
