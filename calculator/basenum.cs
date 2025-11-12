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
    public partial class basenum : Form
    {
        public basenum()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string numeroIngresado = txtNumeroIngresado.Text.Trim();
            string baseInicial = cmbBaseInicial.SelectedItem.ToString();
            string baseFinal = cmbBaseFinal.SelectedItem.ToString();

            try
            {
                string resultado = "";

                // DECIMAL
                if (baseInicial == "Decimal" && baseFinal == "Binario")
                    resultado = DecimalABinario(int.Parse(numeroIngresado));

                else if (baseInicial == "Decimal" && baseFinal == "Hexadecimal")
                    resultado = DecimalAHexadecimal(int.Parse(numeroIngresado));

                else if (baseInicial == "Decimal" && baseFinal == "Octal")
                    resultado = DecimalAOctal(int.Parse(numeroIngresado));

                // BINARIO
                else if (baseInicial == "Binario" && baseFinal == "Decimal")
                    resultado = BinarioADecimal(numeroIngresado).ToString();

                else if (baseInicial == "Binario" && baseFinal == "Hexadecimal")
                    resultado = BinarioAHexadecimal(numeroIngresado);

                else if (baseInicial == "Binario" && baseFinal == "Octal")
                    resultado = BinarioAOctal(numeroIngresado);

                // HEXADECIMAL
                else if (baseInicial == "Hexadecimal" && baseFinal == "Decimal")
                    resultado = HexadecimalADecimal(numeroIngresado).ToString();

                else if (baseInicial == "Hexadecimal" && baseFinal == "Binario")
                    resultado = HexadecimalABinario(numeroIngresado);

                else if (baseInicial == "Hexadecimal" && baseFinal == "Octal")
                    resultado = HexadecimalAOctal(numeroIngresado);

                // OCTAL
                else if (baseInicial == "Octal" && baseFinal == "Decimal")
                    resultado = OctalADecimal(numeroIngresado).ToString();

                else if (baseInicial == "Octal" && baseFinal == "Binario")
                    resultado = OctalABinario(numeroIngresado);

                else if (baseInicial == "Octal" && baseFinal == "Hexadecimal")
                    resultado = OctalAHexadecimal(numeroIngresado);

                // MISMA BASE
                else if (baseInicial == baseFinal)
                    resultado = numeroIngresado;

                txtResultado.Text = resultado;
            }
            catch
            {
                MessageBox.Show("Verifica que el número sea válido para la base seleccionada.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string DecimalABinario(int numeroDecimal)
        {
            if (numeroDecimal == 0) return "0";

            string binario = "";
            int n = numeroDecimal;

            while (n > 0)
            {
                int resto = n % 2;
                binario = resto + binario;
                n /= 2;
            }

            return binario;
        }
        private int BinarioADecimal(string binario)
        {
            int decimalValue = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                int digito = binario[i] - '0';
                decimalValue = decimalValue * 2 + digito;
            }

            return decimalValue;
        }
        private string DecimalAHexadecimal(int numero)
        {
            if (numero == 0) return "0";

            string hex = "";
            int n = numero;

            while (n > 0)
            {
                int resto = n % 16;
                char digito = resto < 10 ? (char)('0' + resto) : (char)('A' + resto - 10);
                hex = digito + hex;
                n /= 16;
            }

            return hex;
        }
        private int HexadecimalADecimal(string hex)
        {
            hex = hex.ToUpper();
            int decimalValue = 0;

            foreach (char c in hex)
            {
                int digito = (c >= '0' && c <= '9') ? c - '0' : c - 'A' + 10;
                decimalValue = decimalValue * 16 + digito;
            }

            return decimalValue;
        }
        private string HexadecimalABinario(string hex)
        {
            hex = hex.ToUpper();
            string binario = "";

            foreach (char c in hex)
            {
                int valor = (c >= '0' && c <= '9') ? c - '0' : c - 'A' + 10;
                string bits = Convert.ToString(valor, 2).PadLeft(4, '0');
                binario += bits;
            }

            return binario;
        }
        private string BinarioAHexadecimal(string binario)
        {
            int resto = binario.Length % 4;
            if (resto != 0)
                binario = new string('0', 4 - resto) + binario;

            string hex = "";
            for (int i = 0; i < binario.Length; i += 4)
            {
                string grupo = binario.Substring(i, 4);
                int valor = Convert.ToInt32(grupo, 2);
                hex += (valor < 10) ? valor.ToString() : ((char)('A' + valor - 10)).ToString();
            }

            return hex;
        }
        private string DecimalAOctal(int numero)
        {
            return Convert.ToString(numero, 8);
        }

        private int OctalADecimal(string octal)
        {
            return Convert.ToInt32(octal, 8);
        }

        private string BinarioAOctal(string binario)
        {
            int decimalValue = Convert.ToInt32(binario, 2);
            return Convert.ToString(decimalValue, 8);
        }

        private string OctalABinario(string octal)
        {
            int decimalValue = Convert.ToInt32(octal, 8);
            return Convert.ToString(decimalValue, 2);
        }

        private string HexadecimalAOctal(string hex)
        {
            int decimalValue = Convert.ToInt32(hex, 16);
            return Convert.ToString(decimalValue, 8);
        }

        private string OctalAHexadecimal(string octal)
        {
            int decimalValue = Convert.ToInt32(octal, 8);
            return decimalValue.ToString("X");
        }

        private void btnlimpiar2_Click(object sender, EventArgs e)
        {
            txtNumeroIngresado.Clear();
            txtResultado.Clear();
            cmbBaseInicial.SelectedIndex = -1;
            cmbBaseFinal.SelectedIndex = -1;
            txtNumeroIngresado.Focus();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }
    }
}
