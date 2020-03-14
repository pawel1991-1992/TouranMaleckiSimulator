using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TouranMaleckiSimulator
{
    class Barriers
    {
        Image paly = Image.FromFile("paly.png");
        Image pizda = Image.FromFile("pizda.png");
        Image pizda1 = Image.FromFile("pizda1.png");
        Image nitro = Image.FromFile("nitro.png");
        Image ostrzezenie = Image.FromFile("ostrzezenie.png");
        Image krowa = Image.FromFile("krowa.png");
        Image krowa_prawa = Image.FromFile("krowa_prawa.png");
        public int which_direction = 0;
        public int[] pozycja_x = new int[4];
        public int[] pozycja_krowa_x = new int[4];
        public int pozycja_y = -90;
        public int licznik = 0;
        public int speed = 9;
        public string turbo = "powoli";
        public int poziom_turbo = 8;
        public int time_interval = 25;
        public int level = 1;
        public int seria = 0;

        public Barriers()
        {
            for (int i = 0; i < pozycja_krowa_x.Length; i++)
            {
                pozycja_krowa_x[i] = -100;
            }
        }
        public void print_paly(Graphics e)
        {
            if (poziom_turbo == 8)
            {
                licznik= licznik + (8 * time_interval);
            }
            if (poziom_turbo == 7)
            {
                licznik = licznik + (7 * time_interval);
            }
            if (poziom_turbo == 6)
            {
                licznik = licznik + (6 * time_interval);
            }
            if (poziom_turbo == 5)
            {
                licznik = licznik + (5 * time_interval);
            }
            if (poziom_turbo == 4)
            {
                licznik = licznik + (4 * time_interval);
            }
            if (seria == 0)
            {
                if (licznik == 124 * (8 * time_interval)) { pozycja_x[0] = 39; }
                if (licznik > 125 * (8 * time_interval) && licznik < 200 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 200 * (8 * time_interval);
                        pozycja_x[0] = 0;
                    }
                }

                if (licznik == 200 * (8 * time_interval)) { pozycja_x[3] = 252; }

                if (licznik > 200 * (8 * time_interval) && licznik < 300 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 300 * (8 * time_interval);
                        pozycja_x[3] = 0;
                    }
                }

                if (licznik == 300 * (8 * time_interval)) { pozycja_x[1] = 110; pozycja_x[2] = 181; }
                if (licznik > 300 * (8 * time_interval) && licznik < 400 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                    e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 400 * (8 * time_interval);
                        pozycja_x[1] = 0;
                        pozycja_x[2] = 0;
                    }

                }

                if (licznik == 400 * (8 * time_interval)) { pozycja_x[0] = 39; pozycja_x[2] = 181; }
                if (licznik > 400 * (8 * time_interval) && licznik < 500 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                    e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 500 * (8 * time_interval);
                        pozycja_x[0] = 0;
                        pozycja_x[2] = 0;
                    }

                }
                if (licznik == 500 * (8 * time_interval)) { pozycja_x[1] = 110; }
                if (licznik > 500 * (8 * time_interval) && licznik < 600 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 600 * (8 * time_interval);
                        pozycja_x[1] = 0;
                    }

                }
                if (licznik == 600 * (8 * time_interval)) { pozycja_x[3] = 252; pozycja_x[2] = 181; }
                if (licznik > 600 * (8 * time_interval) && licznik < 700 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                    e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 700 * (8 * time_interval);
                        pozycja_x[2] = 0;
                        pozycja_x[3] = 0;
                    }

                }
                if (licznik == 700 * (8 * time_interval)) { pozycja_x[0] = 39; pozycja_x[2] = 181; }
                if (licznik > 700 * (8 * time_interval) && licznik < 800 * (8 * time_interval))
                {
                    e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                    e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                    pozycja_y = pozycja_y + speed;
                    if (pozycja_y > 350)
                    {
                        pozycja_y = -90;
                        licznik = 900 * (8 * time_interval);
                        pozycja_x[0] = 0;
                        pozycja_x[2] = 0;
                    }

                }
                if (licznik > 900 * (8 * time_interval) && licznik < 1050 * (8 * time_interval))
                {
                    e.DrawImage(pizda, 190, 5, 150, 60);
                }
                if (licznik > 1050 * (8 * time_interval) && licznik < 1200 * (8 * time_interval))
                {
                    e.DrawImage(pizda1, 190, 65, 150, 47);
                }
                if (licznik > 1200 * (8 * time_interval) && licznik < 1350 * (8 * time_interval))
                {
                    level = 2;
                    e.DrawImage(nitro, 190, 112, 150, 54);
                }
                if (licznik > 1350 * (8 * time_interval))
                {
                    licznik = 0;
                    seria = 1;
                }
            }
            if (seria == 1)
            {
                seria = 2;
                pozycja_x[0] = 39;
                pozycja_x[3] = 252;
            }

            if (licznik > 125 * (8 * time_interval) && licznik < 175 * (8 * time_interval) && seria == 2)
            {
                 e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                 e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                 pozycja_y = pozycja_y + speed+6;
                 if (pozycja_y > 350)
                 {
                    pozycja_y = -90;
                    pozycja_x[0] = 0;
                    pozycja_x[3] = 0;
                    seria = 3;
                    licznik = 0;
                 }
            }
            if (seria == 3)
            {
                seria = 4;
                pozycja_x[1] = 110;
                pozycja_x[2] = 181;
                pozycja_x[3] = 252;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 4)
            {
                e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[1] = 0;
                    pozycja_x[2] = 0;
                    pozycja_x[3] = 0;
                    seria = 5;
                    licznik = 0;
                }
            }
            if (seria == 5)
            {
                seria = 6;
                pozycja_x[0] = 39;
                pozycja_x[1] = 110;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 6)
            {
                e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[0] = 0;
                    pozycja_x[1] = 0;
                    seria = 7;
                    licznik = 0;
                }
            }
            if (seria == 7)
            {
                seria = 8;
                pozycja_x[1] = 110;
                pozycja_x[2] = 181;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 8)
            {
                e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[1] = 0;
                    pozycja_x[2] = 0;
                    seria = 9;
                    licznik = 0;
                }
            }
            if (seria == 9)
            {
                seria = 10;
                pozycja_x[1] = 110;
                pozycja_x[3] = 252;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 10)
            {
                e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[1] = 0;
                    pozycja_x[3] = 0;
                    seria = 11;
                    licznik = 0;
                }
            }
            if (seria == 11)
            {
                seria = 12;
                pozycja_x[0] = 110;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 12)
            {
                e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[0] = 0;
                    seria = 13;
                    licznik = 0;
                }
            }
            if (seria == 13)
            {
                seria = 14;
                pozycja_x[2] = 181;
                pozycja_x[3] = 252;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 14)
            {
                e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[2] = 0;
                    pozycja_x[3] = 0;
                    seria = 15;
                    licznik = 0;
                }
            }
            if (seria == 15)
            {
                seria = 16;
                pozycja_x[1] = 110;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 16)
            {
                e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[1] = 0;
                    seria = 17;
                    licznik = 0;
                }
            }
            if (seria == 17)
            {
                seria = 18;
                pozycja_x[0] = 39;
                pozycja_x[3] = 252;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 18)
            {
                e.DrawImage(paly, pozycja_x[0], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[0] = 0;
                    pozycja_x[3] = 0;
                    seria = 19;
                    licznik = 0;
                }
            }
            if (seria == 19)
            {
                seria = 20;
                pozycja_x[1] = 39;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 20)
            {
                e.DrawImage(paly, pozycja_x[1], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -90;
                    pozycja_x[1] = 0;
                    seria = 21;
                    licznik = 0;
                }
            }
            if (seria == 21)
            {
                seria = 22;
                pozycja_x[2] = 181;
                pozycja_x[3] = 252;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 75 * (8 * time_interval) && seria == 22)
            {
                e.DrawImage(paly, pozycja_x[2], pozycja_y, 50, 90);
                e.DrawImage(paly, pozycja_x[3], pozycja_y, 50, 90);
                pozycja_y = pozycja_y + speed + 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -50;
                    pozycja_x[2] = 0;
                    pozycja_x[3] = 0;
                    seria = 23;
                    licznik = 0;
                }
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 125 * (8 * time_interval) && seria == 23)
            {
                e.DrawImage(ostrzezenie, 180,5, 166, 87);
            }
            if (licznik > 125 * (8 * time_interval) && seria == 23)
            {
                licznik = 0;
                seria = 25;
            }
            if (seria == 25)
            {
                pozycja_krowa_x[0] = 12;
                seria = 26;
            }
            if (licznik > 25 *(8 * time_interval) && licznik <125 * (8 * time_interval) && seria == 26)
            {
                e.DrawImage(krowa, pozycja_krowa_x[0], pozycja_y, 75, 50);
                pozycja_y = pozycja_y + speed;
                pozycja_krowa_x[0] = pozycja_krowa_x[0] + 2;
                if (pozycja_y > 350)
                {
                    pozycja_y = -50;
                    pozycja_krowa_x[0] = -100;
                    seria = 27;
                    licznik = 0;
                }
            }
            if (seria == 27)
            {
                pozycja_krowa_x[3] = 285;
                seria = 28;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 125 * (8 * time_interval) && seria == 28)
            {
                e.DrawImage(krowa_prawa, pozycja_krowa_x[3], pozycja_y, 75, 50);
                pozycja_y = pozycja_y + speed;
                pozycja_krowa_x[3] = pozycja_krowa_x[3] - 2;
                if (pozycja_y > 350)
                {
                    pozycja_y = -50;
                    pozycja_krowa_x[3] = -100;
                    seria = 29;
                    licznik = 0;
                }
            }
            if (seria == 29)
            {
                pozycja_krowa_x[1] = 110;
                seria = 30;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 125 * (8 * time_interval) && seria == 30)
            {
                e.DrawImage(krowa, pozycja_krowa_x[1], pozycja_y, 75, 50);
                pozycja_y = pozycja_y + speed;
                pozycja_krowa_x[1] = pozycja_krowa_x[1] + 2;
                if (pozycja_y > 350)
                {
                    pozycja_y = -50;
                    pozycja_krowa_x[1] = -100;
                    seria = 31;
                    licznik = 0;
                }
            }
            if (seria == 31)
            {
                pozycja_krowa_x[2] = 181;
                pozycja_krowa_x[3] = 252;
                seria = 32;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 125 * (8 * time_interval) && seria == 32)
            {
                e.DrawImage(krowa, pozycja_krowa_x[2], pozycja_y, 75, 50);
                e.DrawImage(krowa_prawa, pozycja_krowa_x[3], pozycja_y, 75, 50);
                pozycja_y = pozycja_y + speed;
                pozycja_krowa_x[2] = pozycja_krowa_x[2] + 2;
                pozycja_krowa_x[3] = pozycja_krowa_x[3] - 2;
                if (pozycja_y > 350)
                {
                    pozycja_y = -50;
                    pozycja_krowa_x[2] = -100;
                    pozycja_krowa_x[3] = -100;
                    seria = 33;
                    licznik = 0;
                }
            }
            if (seria == 33)
            {
                pozycja_krowa_x[3] = 252;
                seria = 34;
            }
            if (licznik > 25 * (8 * time_interval) && licznik < 125 * (8 * time_interval) && seria == 34)
            {
                e.DrawImage(krowa_prawa, pozycja_krowa_x[3], pozycja_y, 75, 50);
                pozycja_y = pozycja_y + speed;
                pozycja_krowa_x[3] = pozycja_krowa_x[3] - 6;
                if (pozycja_y > 350)
                {
                    pozycja_y = -50;
                    pozycja_krowa_x[3] = -100;
                    seria = 35;
                    licznik = 0;
                }
            }






        }

        public bool czy_wypadek(int twoja_pozycja_x, int twoja_pozycja_y)
        {
            if ((twoja_pozycja_x == pozycja_x[0] || twoja_pozycja_x == pozycja_x[1] || twoja_pozycja_x == pozycja_x[2] || twoja_pozycja_x == pozycja_x[3]) && twoja_pozycja_y < pozycja_y + 90)
            {
                return true;
            }
            if ((twoja_pozycja_x <= pozycja_krowa_x[0]+75 && twoja_pozycja_x+50 >= pozycja_krowa_x[0] ||
                twoja_pozycja_x <= pozycja_krowa_x[0]+75 && twoja_pozycja_x+50 >=pozycja_krowa_x[0] ||
                twoja_pozycja_x <= pozycja_krowa_x[0]+75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[0] ||
                twoja_pozycja_x >= pozycja_krowa_x[0] && twoja_pozycja_x <= pozycja_krowa_x[0]+75 ||
                twoja_pozycja_x <= pozycja_krowa_x[1] && twoja_pozycja_x + 50 >= pozycja_krowa_x[1] ||
                twoja_pozycja_x <= pozycja_krowa_x[1] + 75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[1] ||
                twoja_pozycja_x <= pozycja_krowa_x[1] + 75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[1] ||
                twoja_pozycja_x >= pozycja_krowa_x[1] && twoja_pozycja_x <= pozycja_krowa_x[1] + 75 ||
                twoja_pozycja_x <= pozycja_krowa_x[2] && twoja_pozycja_x + 50 >= pozycja_krowa_x[2] ||
                twoja_pozycja_x <= pozycja_krowa_x[2] + 75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[2] ||
                twoja_pozycja_x <= pozycja_krowa_x[2] + 75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[2] ||
                twoja_pozycja_x >= pozycja_krowa_x[2] && twoja_pozycja_x <= pozycja_krowa_x[2] + 75 ||
                twoja_pozycja_x <= pozycja_krowa_x[3] && twoja_pozycja_x + 50 >= pozycja_krowa_x[3] ||
                twoja_pozycja_x <= pozycja_krowa_x[3] + 75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[3] ||
                twoja_pozycja_x <= pozycja_krowa_x[3] + 75 && twoja_pozycja_x + 50 >= pozycja_krowa_x[3] ||
                twoja_pozycja_x + 50 >= pozycja_krowa_x[3] && twoja_pozycja_x <= pozycja_krowa_x[3] + 75
                ) && twoja_pozycja_y < pozycja_y + 50)
            {
                return true;
            }
            return false;
        }

    }
}
