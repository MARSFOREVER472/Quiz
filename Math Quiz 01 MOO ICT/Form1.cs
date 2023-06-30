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

        private void EventoCliquearBotonChequeo(object sender, EventArgs e)
        {
            // En instantes...
        }

        private void SetUpGame()
        {
            // En instantes...
        }
    }
}
