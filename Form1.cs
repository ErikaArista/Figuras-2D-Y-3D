using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        private List<Pelota> pelotas;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            pelotas = new List<Pelota>();
            timer = new Timer();
            timer.Interval = 50; // Intervalo en milisegundos
            timer.Tick += new EventHandler(MoverPelotas);

            // Agregar dos pelotas al inicio
            AgregarPelota(100, 100, 8, 4, Brushes.Blue);
            AgregarPelota(200, 200, -6, 5, Brushes.Red);
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            // Iniciar el temporizador para el movimiento
            timer.Start();
        }

        private void AgregarPelota(int x, int y, int velocidadX, int velocidadY, Brush color)
        {
            Pelota nuevaPelota = new Pelota(x, y, velocidadX, velocidadY, color);
            pelotas.Add(nuevaPelota);
        }

        private void MoverPelotas(object sender, EventArgs e)
        {
            // Mover cada pelota y manejar el rebote en los bordes
            foreach (Pelota pelota in pelotas)
            {
                pelota.Mover();
                pelota.RebotarEnBordes(ClientSize.Width, ClientSize.Height);
            }

            // Llamar al método para dibujar todas las pelotas
            DibujarPelotas();
        }

        private void DibujarPelotas()
        {
            // Crear un objeto Graphics para dibujar en el formulario
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(BackColor); // Limpiar el fondo

                // Dibujar cada pelota
                foreach (Pelota pelota in pelotas)
                {
                    g.FillEllipse(pelota.Color, pelota.X - pelota.Radio, pelota.Y - pelota.Radio, 2 * pelota.Radio, 2 * pelota.Radio);
                }
            }
        }

        // Clase que representa una pelota
        private class Pelota
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Radio { get; private set; }
            private int VelocidadX { get; set; }
            private int VelocidadY { get; set; }
            public Brush Color { get; private set; }

            public Pelota(int x, int y, int velocidadX, int velocidadY, Brush color)
            {
                X = x;
                Y = y;
                Radio = 20; // Tamaño de la pelota
                VelocidadX = velocidadX;
                VelocidadY = velocidadY;
                Color = color;
            }

            public void Mover()
            {
                // Actualizar las coordenadas para simular el movimiento
                X += VelocidadX;
                Y += VelocidadY;
            }

            public void RebotarEnBordes(int anchoFormulario, int altoFormulario)
            {
                // Verificar y ajustar el rebote en los bordes horizontales
                if (X - Radio < 0 || X + Radio > anchoFormulario)
                {
                    VelocidadX = -VelocidadX; // Invertir la dirección
                }

                // Verificar y ajustar el rebote en los bordes verticales
                if (Y - Radio < 0 || Y + Radio > altoFormulario)
                {
                    VelocidadY = -VelocidadY; // Invertir la dirección
                }
            }
        }

        private void buttonF3_Click(object sender, EventArgs e)
        {

        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            // Ocultar el Formulario1 (en lugar de cerrarlo)
            this.Hide();

            // Crear una instancia del segundo formulario
            Form2 segundoFormulario = new Form2();

            // Mostrar el segundo formulario
            segundoFormulario.Show();

            
        }
    }
}

