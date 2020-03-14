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
        private System.Media.SoundPlayer player1 = new System.Media.SoundPlayer("killing_my_love.wav");
        private System.Media.SoundPlayer player2 = new System.Media.SoundPlayer("bad_luck.wav");
        private Road droga;
        private Car auto;
        private Barriers przeszkody;
        private Image boom = Image.FromFile("boom.png");
        private int ticker=0;
        public Form1()
        {
            InitializeComponent();
            czy_gra_aktywna = false;
            timer1.Enabled = true;
            pauzaToolStripMenuItem.Enabled = false;
            timer1.Interval = 40;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                pole_gry.CreateGraphics().Clear(Color.Black);
                droga.rysuj_droge(pole_gry.CreateGraphics(), new SolidBrush(Color.Red),pole_gry.Size.Width,pole_gry.Height);
                droga.ruch_drogi();
                auto.print_car(pole_gry.CreateGraphics());
                przeszkody.print_paly(pole_gry.CreateGraphics());
                if (przeszkody.czy_wypadek(auto.pozycje[auto.pozycja],250)==true)
                {
                    czy_gra_aktywna = false;
                    pole_gry.CreateGraphics().DrawImage(boom, auto.pozycje[auto.pozycja]-20, 220, 90, 50);
                    player1.Stop();
                    player2.Play();

                }
                if (przeszkody.level > 1)
                {
                    if (przeszkody.turbo == "dzida" && przeszkody.poziom_turbo == 8)
                    {
                        ticker = ticker + 200;
                        if (ticker == 5000)
                        {
                            przeszkody.poziom_turbo = 7;
                            Console.WriteLine("Dupa cycki jaja");
                            timer1.Interval = 35;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "dzida" && przeszkody.poziom_turbo == 7)
                    {
                        ticker = ticker + 175;
                        if (ticker == 4900)
                        {
                            przeszkody.poziom_turbo = 6;
                            Console.WriteLine("Dupa cycki jaja");
                            timer1.Interval = 30;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "dzida" && przeszkody.poziom_turbo == 6)
                    {
                        ticker = ticker + 150;
                        if (ticker == 4950)
                        {
                            przeszkody.poziom_turbo = 5;
                            Console.WriteLine("Dupa cycki jaja");
                            timer1.Interval = 25;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "dzida" && przeszkody.poziom_turbo == 5)
                    {
                        ticker = ticker + 125;
                        if (ticker == 5000)
                        {
                            przeszkody.poziom_turbo = 4;
                            Console.WriteLine("Dupa cycki jaja");
                            timer1.Interval = 20;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "powoli" && przeszkody.poziom_turbo == 4)
                    {
                        ticker = ticker + 100;
                        if (ticker == 5000)
                        {
                            przeszkody.poziom_turbo = 5;
                            Console.WriteLine("Zwalniamy kuźwa");
                            timer1.Interval = 25;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "powoli" && przeszkody.poziom_turbo == 5)
                    {
                        ticker = ticker + 125;
                        if (ticker == 5000)
                        {
                            przeszkody.poziom_turbo = 6;
                            Console.WriteLine("Zwalniamy kuźwa");
                            timer1.Interval = 30;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "powoli" && przeszkody.poziom_turbo == 6)
                    {
                        ticker = ticker + 150;
                        if (ticker == 4950)
                        {
                            przeszkody.poziom_turbo = 7;
                            Console.WriteLine("Zwalniamy kuźwa");
                            timer1.Interval = 35;
                            ticker = 0;
                        }
                    }
                    if (przeszkody.turbo == "powoli" && przeszkody.poziom_turbo == 7)
                    {
                        ticker = ticker + 175;
                        if (ticker == 4900)
                        {
                            przeszkody.poziom_turbo = 8;
                            Console.WriteLine("Zwalniamy kuźwa");
                            timer1.Interval = 40;
                            ticker = 0;
                        }
                    }
                }
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
            przeszkody = new Barriers();
            pauzaToolStripMenuItem.Enabled = true;
            timer1.Interval = 40;
            player1.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) auto.ruch = "prawo";
            if (e.KeyCode == Keys.Left) auto.ruch = "lewo";
            if (e.KeyCode == Keys.Space) przeszkody.turbo = "dzida";
        }

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                czy_gra_aktywna = false;
                pauzaToolStripMenuItem.Text = "Wznów";
                pole_gry.CreateGraphics().Clear(Color.Black);
                player1.Stop();
            }
            else
            {
                pauzaToolStripMenuItem.Text = "Pauza";
                player1.Play();
                czy_gra_aktywna = true;
                droga = new Road();
                auto = new Car();
                przeszkody = new Barriers();
                pauzaToolStripMenuItem.Enabled = true;
                player1.Play();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_gra_aktywna = true;
            droga = new Road();
            auto = new Car();
            przeszkody = new Barriers();
            pauzaToolStripMenuItem.Enabled = true;
            player1.Play();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) przeszkody.turbo = "powoli";
        }
    }
}
