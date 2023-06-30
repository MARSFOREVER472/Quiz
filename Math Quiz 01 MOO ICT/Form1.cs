using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz_01_MOO_ICT
{
    public partial class Form1 : Form
    {
        // Importaremos las variables al Método privado SetUp.

        Random rnd = new Random(); // Aleatorio.
        string[] Maths = { "Adición, Sustracción, Multiplicación" }; // Se enlista las operaciones realizadas por categorías.
        int total; // Puntuación total.
        int score; // Puntuación.

        public Form1()
        {
            InitializeComponent(); // Llamado del método inicial.
            SetUpGame(); // Llamado del método anterior.
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // En instantes...
        }

        // Método generado por la interfaz para revisar la respuesta ingresada.
        private void ChequearRespuesta(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]")) // Sólo debe ingresar números desde teclado (0, 1, 2, 3, 4, 5, 6, 7, 8, 9).
            {
                MessageBox.Show("Debe ingresar solamente los números");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1); // Desaparece el texto ingresado incorrectamente.
            }
        }

        // Al clickear el botón de chequear respuesta, se muestran las acciones mediante un método para posteriores revisiones de ejecución.
        private void EventoCliquearBotonChequeo(object sender, EventArgs e)
        {
            SetUpGame(); // Llamado del método anterior.
        }

        // Método para arreglar la interfaz del juego.
        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20); // Le pasamos valores aleatorios del 10 al 20 en el valor 1.
            int numB = rnd.Next(0, 9); // Le pasamos valores aleatorios del 0 al 9 en el valor 2.

            txtAnswer.Text = null; // La respuesta debe ser nula, es decir, debe estar asociado al valor ingresado correctamente entre estos dos valores.

            // Lo vamos a categorizar por 3 operaciones fundamentales (Excepto la división).

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Adición": // Suma.

                    total = numA + numB; // Ej: 14 + 2 = 16
                    lblSymbol.Text = "+"; // Símbolo para sumar 2 valores.
                    lblSymbol.ForeColor = Color.Red;  // Rojo para la suma.

                    break;

                 case "Sustracción": // Resta.

                    total = numA - numB; // Ej: 14 - 2 = 12
                    lblSymbol.Text = "-"; // Símbolo para restar 2 valores.
                    lblSymbol.ForeColor = Color.Blue; // Azul para la resta.

                    break;

                 case "Multiplicación": // Multiplicación.

                    total = numA * numB; // Ej: 8 * 2 = 16
                    lblSymbol.Text = "x"; // Símbolo para multiplicar 2 valores.
                    lblSymbol.ForeColor = Color.Yellow; // Amarillo para la multiplicación.

                    break;
            }

            // Para los 2 valores:

            lblNumA.Text = numA.ToString(); // Valor 1.
            lblNumB.Text = numB.ToString(); // Valor 2.

        }
    }
}
