using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TouranMaleckiSimulator
{
    class Road
    {
        public Road()
        {
            for (int i = 0; i < pasy_ruchu.Length; i++)
            {
                pasy_ruchu[i] = i * odstep - 18;
            }
        }
        private int odstep = 18;
        private int[] pasy_ruchu = new int[25];
        private int i;
        public void rysuj_droge(Graphics g, Brush b, int Width, int Height )
        {
            g.FillRectangle(b, 20, 0, 10, Height);
            g.FillRectangle(b, Width - 30, 0, 10, Height);
            //Console.WriteLine("Wartość szzerokości panela to: " + Height);
            //Console.WriteLine("Wartość wysokości panela to: " + Width);
            for ( i = 0; i < pasy_ruchu.Length; i++)
            {
                g.FillRectangle(b, 97, pasy_ruchu[i], 5, 14);
                g.FillRectangle(b, 168, pasy_ruchu[i], 5, 14);
                g.FillRectangle(b, 239, pasy_ruchu[i], 5, 14);
            }

        }
        public void ruch_drogi()
        {
            for (i = 0; i < pasy_ruchu.Length; i++)
            {
                pasy_ruchu[i] = pasy_ruchu[i]+6;
                if (pasy_ruchu[0] == 0)
                {
                    for (int k = 0; k < pasy_ruchu.Length; k++)
                    {
                        pasy_ruchu[k] = k * odstep - 18;
                    }
                }
            }
        }
    }
}
