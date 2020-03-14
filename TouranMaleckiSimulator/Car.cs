using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace TouranMaleckiSimulator
{
    class Car
    {
        public Image newImage = Image.FromFile("Car.png");
        public string ruch;
        public int pozycja;
        public int[] pozycje = new int[4];
        public Car()
        {
            for (int i = 0; i < pozycje.Length; i++)
            {
                pozycje[i] = 39 + (i * 71);
                pozycja = 1;
            }
            ruch = "default";
        }

        public void print_car(Graphics e)
        {
            if (ruch == "prawo")
            {
                pozycja++;
                ruch = "default";
                if (pozycja == 4)
                {
                    pozycja = 3;
                }

            }
            if (ruch == "lewo")
            {
                pozycja--;
                ruch = "default";
                if (pozycja == -1)
                {
                    pozycja = 0;
                }
            }
            e.DrawImage(newImage,pozycje[pozycja],250,50,90);
        }

    }
}
