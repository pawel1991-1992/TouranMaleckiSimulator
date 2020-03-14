using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouranMaleckiSimulator
{
    public partial class Form1 : Form
    { 
        private bool czy_gra_aktywna;
        private Road droga;
        private Car auto;
        public Form1()
        {
            InitializeComponent();
            czy_gra_aktywna = false;
            timer1.Enabled = true;
            pauzaToolStripMenuItem.Enabled = false;
           // timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                pole_gry.CreateGraphics().Clear(Color.Black);
                droga.rysuj_droge(pole_gry.CreateGraphics(), new SolidBrush(Color.Red),pole_gry.Size.Width,pole_gry.Height);
                droga.ruch_drogi();
                auto.print_car(pole_gry.CreateGraphics());
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Aqua);
                pole_gry.CreateGraphics().DrawString("Naciśnij Start", f, b, 110, 165);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_gra_aktywna = true;
            droga = new Road();
            auto = new Car();
            pauzaToolStripMenuItem.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) auto.ruch = "prawo";
            if (e.KeyCode == Keys.Left) auto.ruch = "lewo";
        }
    }
}
