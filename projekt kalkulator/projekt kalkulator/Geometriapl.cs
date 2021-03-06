using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projekt_kalkulator
{
    public partial class Geometriapl : Form
    {
        Thread th;
        int jakafigura = 0;
        int longpi = 3;
        //3.14159265359
        double[] tabpi = new double[] {0,3,3.1,3.14, 3.141, 3.1415, 3.14159, 3.141592, 3.1415926, 3.14159265, 3.141592653, 3.1415926535, 3.14159265359 }  ; 
        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Powrot_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(menu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void menu(object obj)
        {
            Application.Run(new aplikacjimenu());
        }
        public void niewidoczne()
        {
            Pole.Visible = false;
            polepokaz.Visible = false;
            oa.Visible = false;
            oh.Visible = false;
            danea.Visible = false;
            daneh.Visible = false;
            obwod.Visible = false;
            obwodpokaz.Visible = false;
            ob.Visible = false;
            oc.Visible = false;
            daneb.Visible = false;
            danec.Visible = false;
            od.Visible = false;
            daned.Visible = false;
            wyniki.Visible = false;
            wynikobwod.Visible = false;
            wynikpole1.Visible = false;
            wynikpole2.Visible = false;
            wynikpole3.Visible = false;
            wzory.Visible = false;
            wzor1.Visible = false;
            wzor2.Visible = false;
            wzor3.Visible = false;
            wzoro.Visible = false;
            eror.Visible = false;
            daned1.Visible = false;
            od1.Visible = false;
            daned2.Visible = false;
            od2.Visible = false;
            or.Visible = false;
            opi.Visible = false;
            pilewo.Visible = false;
            piprawo.Visible = false;
            piwpis.Visible = false;

        }
        public Geometriapl()
        {
            InitializeComponent();
            niewidoczne();
        }

        private void trojkat_Click(object sender, EventArgs e)
        {
            niewidoczne();
            obraz.Image = Properties.Resources.trójkąt;

            Pole.Visible = true;
            oa.Visible = true;
            oh.Visible = true;
            danea.Visible = true;
            daneh.Visible = true;
            obwod.Visible = true;

            ob.Visible = true;
            oc.Visible = true;

            daneb.Visible = true;
            danec.Visible = true;
            jakafigura = 1;
            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"A+B+C";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"(1/2)*A*H";
            wzor1.Visible = true;
        }

        private void kwadrat_Click(object sender, EventArgs e)
        {
            niewidoczne();
            obraz.Image = Properties.Resources.kwadrat1;

            Pole.Visible = true;
            danea.Visible = true;
            oa.Visible = true;
            obwod.Visible = true;
            jakafigura = 2;
            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"4*A";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"A*A";
            wzor1.Visible = true;
        }

        private void Pole_Click(object sender, EventArgs e)
        {
            double a,b,d1,d2, h, wynik,wynik2;
            try { 
            switch (jakafigura)
            {
                case 1:
                        a = int.Parse(danea.Text);
                        h = int.Parse(daneh.Text);
                        wynik = a * h / 2;

                        if (a <= 0 || h <= 0)
                        {
                            eror.Visible = true;
                            wynikpole1.Visible = false;
                            eror.Text = "Podaj liczby dodatnie w A i H";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikpole1.Text = wynik + "";
                            wynikpole1.Visible = true;
                        }
                break;
                case 2:

                        a = int.Parse(danea.Text);
                        wynik = a * a;

                        if (a <= 0)
                        {
                            wynikpole1.Visible = false;
                            eror.Visible = true;
                            eror.Text = "Podaj dodatnią liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikpole1.Text = wynik + "";
                            wynikpole1.Visible = true;
                        }
                    break;
                case 3:
                        a = int.Parse(danea.Text);
                        h = int.Parse(daneh.Text);
                        wynik = a * h;

                        if (a <= 0 || h <= 0)
                        {
                            eror.Visible = true;
                            wynikpole1.Visible = false;
                            eror.Text = "Podaj dodatnie liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikpole1.Text = wynik + "";
                            wynikpole1.Visible = true;
                        }
                    break;
                case 4:
                        if (danea.Text == "" || daneh.Text == "")
                        {
                            d1 = int.Parse(daned1.Text);
                            d2 = int.Parse(daned2.Text);
                            wynik = d1 * d2 / 2;

                            if (d1 <= 0 || d2 <= 0)
                            {
                                eror.Visible = true;
                                wynikpole2.Visible = false;
                                eror.Text = "Podaj dodatnie liczby";
                            }
                            else
                            {
                                eror.Visible = false;
                                wynikpole2.Text = wynik + "";
                                wynikpole2.Visible = true;
                            }
                        }
                        else if (daned1.Text == "" || daned2.Text == "")
                        {
                            a = int.Parse(danea.Text);
                            h = int.Parse(daneh.Text);
                            wynik = a * h;

                            if (a <= 0 || h <= 0)
                            {
                                eror.Visible = true;
                                wynikpole1.Visible = false;
                                eror.Text = "Podaj dodatnie liczby";
                            }
                            else
                            {
                                eror.Visible = false;
                                wynikpole1.Text = wynik + "";
                                wynikpole1.Visible = true;
                            }
                        }
                        else
                        {
                            a = int.Parse(danea.Text);
                            h = int.Parse(daneh.Text);
                            d1 = int.Parse(daned1.Text);
                            d2 = int.Parse(daned2.Text);
                            wynik2 = d1 * d2 / 2;
                            wynik = a * h;

                            if (a <= 0 || h <= 0 || d1<=0 || d2<=0)
                            {
                                eror.Visible = true;
                                wynikpole1.Visible = false;
                                wynikpole2.Visible = false;
                                eror.Text = "Podaj dodatnie liczby";
                            }
                            else
                            {
                                eror.Visible = false;
                                wynikpole1.Text = wynik + "";
                                wynikpole1.Visible = true;
                                wynikpole2.Text = wynik2 + "";
                                wynikpole2.Visible = true;
                            }
                        }
                    break;
                case 5:
                        a = int.Parse(danea.Text);
                        b = int.Parse(daneb.Text);
                        h = int.Parse(daneh.Text);
                        wynik = (a+b) * h/2;

                        if (a <= 0 || h <= 0 ||b<=0)
                        {
                            eror.Visible = true;
                            wynikpole1.Visible = false;
                            eror.Text = "Podaj dodatnie liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikpole1.Text = wynik + "";
                            wynikpole1.Visible = true;
                        }
                break;
                case 6:
                        d1 = int.Parse(daned1.Text);
                        d2 = int.Parse(daned2.Text);
                        wynik = d1*d2/2;

                        if (d1 <= 0 || d2 <= 0)
                        {
                            eror.Visible = true;
                            wynikpole1.Visible = false;
                            eror.Text = "Podaj dodatnie liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikpole1.Text = wynik + "";
                            wynikpole1.Visible = true;
                        }
                break;
                case 7:
                    a = int.Parse(danea.Text);//R
                    if (longpi > 0)
                    {
                        wynik =  (a* a) * tabpi[longpi];
                        if (a <= 0)
                        {
                                eror.Visible = true;
                                wynikpole1.Visible = false;
                                eror.Text = "Podaj dodatnią liczbę w R";
                            }
                        else
                        {
                                eror.Visible = false;
                                wynikpole1.Text = wynik + "";
                                wynikpole1.Visible = true;
                            }
                    }
                    else
                    {
                        wynik = a * a;
                        if (a <= 0)
                        {
                                eror.Visible = true;
                                wynikpole1.Visible = false;
                                eror.Text = "Podaj dodatnią liczbę w R";
                            }
                        else
                        {
                                eror.Visible = false;
                                wynikpole1.Text = wynik + "Pi";
                                wynikpole1.Visible = true;
                            }

                    }
                 break;
                }
            }
            catch (Exception)
            {
                wynikpole1.Visible = false;
                eror.Visible = true;
                eror.Text = "Podaj liczby do pola";
            }
        }

        private void obwod_Click(object sender, EventArgs e)
        {
            double a, b, c, d, wynik = 0;
            try
            {
                switch (jakafigura)
                {
                    case 1:
                        a = int.Parse(danea.Text);
                        b = int.Parse(daneb.Text);
                        c = int.Parse(danec.Text);
                        wynik = a + b + c;

                        if (a <= 0 || b <= 0 || c <= 0)
                        {
                            eror.Visible = true;
                            wynikobwod.Visible = false;
                            eror.Text = "Podaj dodatnie liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikobwod.Text = wynik + "";
                            wynikobwod.Visible = true;
                        }
                        break;
                    case 2:
                    case 4:

                        a = int.Parse(danea.Text);
                        wynik = 4 * a;

                        if (a <= 0)
                        {
                            wynikobwod.Visible = false;
                            eror.Visible = true;
                            eror.Text = "Podaj dodatnią liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikobwod.Text = wynik + "";
                            wynikobwod.Visible = true;
                        }
                        break;
                    case 3:
                    case 6:
                        a = int.Parse(danea.Text);
                        b = int.Parse(daneb.Text);
                        wynik = (2 * a) + (2 * b);

                        if (a <= 0 || b <= 0)
                        {
                            wynikobwod.Visible = false;
                            eror.Visible = true;
                            eror.Text = "Podaj dodatnią liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikobwod.Text = wynik + "";
                            wynikobwod.Visible = true;
                        }
                        break;
                    case 5:
                        a = int.Parse(danea.Text);
                        b = int.Parse(daneb.Text);
                        c = int.Parse(danec.Text);
                        d = int.Parse(daned.Text);
                        wynik = a + b + c + d;

                        if (a <= 0 || b <= 0)
                        {
                            wynikobwod.Visible = false;
                            eror.Visible = true;
                            eror.Text = "Podaj dodatnią liczby";
                        }
                        else
                        {
                            eror.Visible = false;
                            wynikobwod.Text = wynik + "";
                            wynikobwod.Visible = true;
                        }
                        break;
                    case 7:
                        a = int.Parse(danea.Text);//R
                        if (longpi > 0)
                        {
                            wynik = 2 * a * tabpi[longpi];
                            if (a <= 0)
                            {
                                wynikobwod.Visible = false;
                                eror.Visible = true;
                                eror.Text = "Podaj dodatnią liczbe w R";
                            }
                            else
                            {
                                eror.Visible = false;
                                wynikobwod.Text = wynik + "";
                                wynikobwod.Visible = true;
                            }
                        }
                        else
                        {
                            wynik = 2 * a;
                            if (a <= 0)
                            {
                                wynikobwod.Visible = false;
                                eror.Visible = true;
                                eror.Text = "Podaj dodatnią liczbe w R";
                            }
                            else
                            {
                                eror.Visible = false;
                                wynikobwod.Text = wynik + "Pi";
                                wynikobwod.Visible = true;
                            }
                            
                        }
                        break;
                }
            }
            catch (Exception)
            {
                wynikobwod.Visible = false;
                eror.Visible = true;
                eror.Text = "Podaj liczby do obwodu";
            }
        }

        private void rownoleglobok_Click(object sender, EventArgs e)
        {
            niewidoczne();
            obraz.Image = Properties.Resources.rownoleglobok;

            Pole.Visible = true;
            danea.Visible = true;
            oa.Visible = true;
            daneh.Visible = true;
            oh.Visible = true;
            obwod.Visible = true;
            ob.Visible = true;
            daneb.Visible = true;
            jakafigura = 3;

            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"2*A + 2*B";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"A*H";
            wzor1.Visible = true;
        }

        private void Romb_Click(object sender, EventArgs e)
        {
            niewidoczne();
            obraz.Image = Properties.Resources.romb;

            Pole.Visible = true;
            danea.Visible = true;
            oa.Visible = true;
            daneh.Visible = true;
            oh.Visible = true;
            obwod.Visible = true;
            daned1.Visible = true;
            od1.Visible = true;
            daned2.Visible = true;
            od2.Visible = true;
            jakafigura = 4;

            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"4*A";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"A*H";
            wzor1.Visible = true;
            wzor2.Text = @"(d1*d2)/2";
            wzor2.Visible = true;
        }

        private void trapez_Click(object sender, EventArgs e)
        {

            niewidoczne();
            obraz.Image = Properties.Resources.trapez;

            Pole.Visible = true;
            danea.Visible = true;
            oa.Visible = true;
            daneh.Visible = true;
            oh.Visible = true;
            obwod.Visible = true;
            daneb.Visible = true;
            danec.Visible = true;
            daned.Visible = true;
            ob.Visible = true;
            oc.Visible = true;
            od.Visible = true;
            jakafigura = 5;

            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"A+B+C+D";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"1/2*(A+B)*H";
            wzor1.Visible = true;
        }

        private void deltoid_Click(object sender, EventArgs e)
        {
            niewidoczne();
            obraz.Image = Properties.Resources.deltoid;

            Pole.Visible = true;
            danea.Visible = true;
            oa.Visible = true;
            daned1.Visible = true;
            od1.Visible = true;
            daned2.Visible = true;
            od2.Visible = true;
            obwod.Visible = true;
            ob.Visible = true;
            daneb.Visible = true;
            jakafigura = 6;

            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"2*A + 2*B";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"(1/2)*d1*d2";
            wzor1.Visible = true;
        }

        private void kolo_Click(object sender, EventArgs e)
        {
            niewidoczne();
            obraz.Image = Properties.Resources.koło;

            Pole.Visible = true;
            pilewo.Visible = true;
            piprawo.Visible = true;
            piwpis.Visible = true;
            piwpis.Text = "3.14";
            or.Visible = true;
            danea.Visible = true;
            opi.Visible = true;
            obwod.Visible = true;
            jakafigura = 7;

            polepokaz.Visible = true;
            obwodpokaz.Visible = true;
            wzoro.Text = @"Pi*R*2";
            wzoro.Visible = true;
            wyniki.Visible = true;
            wzory.Visible = true;
            wzor1.Text = @"Pi*(r*r)";
            wzor1.Visible = true;
        }

        private void piprawo_Click(object sender, EventArgs e)
        {

            if (tabpi.Length - 1 == longpi)
            {
                piwpis.Text = "" + tabpi[longpi];
            }
            else
            {
                longpi += 1;
                piwpis.Text = "" + tabpi[longpi];
            }
        }

        private void pilewo_Click(object sender, EventArgs e)
        {
            if (0 == longpi - 1)
            {
                piwpis.Text = "pi";
                longpi -= 1;
            }
            else
            {
                longpi -= 1;
                piwpis.Text = "" + tabpi[longpi];
            }

        }

    }
}
