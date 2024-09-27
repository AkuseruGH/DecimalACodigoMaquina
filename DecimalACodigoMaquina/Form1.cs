using System;

namespace DecimalACodigoMaquina
{
    public partial class form1 : Form
    {
        //variables globales
        string entrada;
        float entradaToFloat;

        int entero;
        float fracc;

        int recorridos;

        int exponente = 0;
        int fillexp;

        int mantissa;
        int fillman;

        string binarioFraccionaria;
        string binarioEntero;
        string exponenteBinario;
        string binarioRealizado;

        string salida;


        public form1()
        {
            InitializeComponent();
            label1.Text = "linea 00000180  ";
            label2.Text = "Ingresa tu numero en decimal";

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (exponente != 0)
            {
                entrada = inputBox.Text;
                if (entrada.Contains('.'))
                {
                    //separar parte fraccionara y entera
                    entradaToFloat = float.Parse(entrada);
                    entero = (int)entradaToFloat;
                    fracc = entradaToFloat - entero;
                    fracc = Math.Abs(fracc);
                    entero = Math.Abs(entero);

                    //convertir ambas partes a binario
                    fraccionarioToBinario(fracc);
                    binarioEntero = Convert.ToString(entero, 2);
                    obtenerExponenteBinario();
                    representacion();
                    label1.Text = tolEndian(binhexa(binarioRealizado));
                }
                else
                {
                    label1.Text = "180 " + Convert.ToString(entero, 16).ToUpper();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un tipo de dato");
            }
        }

        private string fraccionarioToBinario(float fracc)
        {
            binarioFraccionaria = "";
            int limiteDecimales = 10;
            while (fracc > 0 && limiteDecimales > 0)
            {
                fracc *= 2;
                int bit = (int)fracc;
                binarioFraccionaria += bit;
                fracc -= bit;
                limiteDecimales--;
            }
            return binarioFraccionaria;
        }
        private string representacion()
        {
            string signo;
            if(entradaToFloat >= 0)
            {
                signo = "0";
            }
            else
            {
                signo = "1";
            }

            if(entero > 0)
            {
                binarioRealizado = signo + exponenteBinario + binarioEntero.Substring(1) + binarioFraccionaria;
                return binarioRealizado;
            }
            else
            {
                binarioRealizado = signo + exponenteBinario + binarioFraccionaria.Substring(recorridos);
                return binarioRealizado;
            }
        }

        private string obtenerExponenteBinario()
        {
            if (entero > 0)
            {
                recorridos = binarioEntero.Length - 1;
                exponenteBinario = Convert.ToString(exponente + recorridos, 2).PadLeft(fillexp, '0');
                return exponenteBinario;
            }
            else
            {
                recorridos = binarioFraccionaria.IndexOf('1') + 1;
                exponenteBinario = Convert.ToString(exponente - recorridos, 2).PadLeft(fillexp, '0');
                return exponenteBinario;
            }
        }
            private string binhexa(string binario)
        {
            // con 0 el binario
            binario = binario.PadRight(fillman, '0');
            string binarios = "";
            int index = 0;
            // Iterar a través de la cadena y agrupar en grupos de 4
            for (int i = 0; i < binario.Length; i++)
            {
                binarios += binario[i];
                // Añadir un espacio cada 4 caracteres, excepto al final
                if ((i + 1) % 4 == 0 && i != binario.Length - 1)
                {
                    binarios += " ";
                }
            }

            string[] hexas = binarios.Split(' ');
            foreach (string grupo in hexas)
            {
                // Convertir el grupo binario a decimal y luego a hexadecimal
                int decimalValue = Convert.ToInt32(grupo, 2);
                hexas[index] = decimalValue.ToString("X1"); // "X1" convierte a hex con al menos 1 dígito
                index++;
            }
            return string.Join("", hexas);
        }

        private void dwButton_Click(object sender, EventArgs e)
        {
            exponente = 15;
            fillexp = 5;
            fillman = 16;
        }

        private void ddButton_Click(object sender, EventArgs e)
        {
            exponente = 127;
            fillexp = 8;
            fillman = 32;
        }

        private void dqButton_Click(object sender, EventArgs e)
        {
            exponente = 1023;
            fillexp = 11;
            fillman = 64;
        }
        private string tolEndian(string hex)
        {
            // Separar el string en grupos de 2 caracteres
            string[] pares = new string[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                pares[i / 2] = hex.Substring(i, 2);
            }

            // Invertir los pares
            Array.Reverse(pares);

            // Unir los pares con espacios, y cada 4 pares agregar 2 espacios extra
            string resultado = "";
            for (int i = 0; i < pares.Length; i++)
            {
                resultado += pares[i];

                // Agregar un espacio simple después de cada par
                if (i < pares.Length - 1)
                {
                    resultado += " ";

                    // Agregar dos espacios después de cada 4 pares
                    if ((i + 1) % 4 == 0)
                    {
                        resultado += "  ";
                    }
                }
            }

            return resultado;
        }
    }
}