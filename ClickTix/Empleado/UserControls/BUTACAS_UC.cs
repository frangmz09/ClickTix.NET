using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix.Empleado.UserControls
{
    public partial class BUTACAS_UC : UserControl
    {
        public BUTACAS_UC()
        {
            InitializeComponent();
        }

        private void BUTACAS_UC_Load(object sender, EventArgs e)
        {
            int numFilas = 5; // Número de filas de butacas
            int numColumnas = 6; // Número de columnas de butacas

            for (int fila = 0; fila < numFilas; fila++)
            {
                for (int columna = 0; columna < numColumnas; columna++)
                {
                    Button butaca = new Button();
                    butaca.Width = 50; 
                    butaca.Height = 50; 
                    butaca.Text = $"Fila {fila + 1}, Asiento {columna + 1}";
                    butaca.Name = $"btnButaca_{fila}_{columna}";
                    butaca.BackColor = Color.Green; // Color para las butacas disponibles
                    butaca.Margin = new Padding(5); // Espaciado entre botones

                    butaca.Click += Butaca_Click;

                    // Agrega el botón al FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(butaca);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Butaca_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Realiza acciones comunes para todas las butacas aquí
            // Por ejemplo, puedes cambiar el color de fondo del botón o realizar otras operaciones.

            // Ejemplo: Cambiar el color de fondo del botón al hacer clic
            if (clickedButton.BackColor == Color.Green)
            {
                clickedButton.BackColor = Color.Red; // Cambiar el color a rojo si la butaca está disponible
            }
            else
            {
                clickedButton.BackColor = Color.Green; // Cambiar el color a verde si la butaca está ocupada
            }
        }
    }
}
