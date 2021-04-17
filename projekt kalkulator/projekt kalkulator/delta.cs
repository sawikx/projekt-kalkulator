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
    public partial class delta : Form
    {
        public void niewidzi()
        {
            x1napis.Visible = false;
            x1początek.Visible = false;
            x1jeden.Visible = false;
            x1guraliczby.Visible = false;
            x1dulliczby.Visible = false;
            x1kreska.Visible = false;
            x1wynik.Visible = false;

            x2napis.Visible = false;
            x2poczatek.Visible = false;
            x2dwa.Visible = false;
            x2guraliczba.Visible = false;
            x2kreska.Visible = false;
            x2dulliczba.Visible = false;
            x2wynik.Visible = false;
        }
        Thread th;
        public delta()
        {
            InitializeComponent();
            erro1.Visible = false;
            
            deltawzur.Visible = false;
            deltanapis.Visible = false;
            deltawynik.Visible = false;
            bdelta2.Visible = false;
            wzor.Visible = false;
            Wyniknapisdelta.Visible = false;

            napisrwzorx.Visible = false;

            niewidzi();
        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void powrutt(object obj)
        {
            Application.Run(new aplikacjimenu());
        }
        private void powrut_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(powrutt);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void start1_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c=0, deltaliczba,x1,x2;
            erro1.Visible = false;
            try
            {
                a = double.Parse(danea.Text);
                b = double.Parse(daneb.Text);
                c = double.Parse(danec.Text);
                deltaliczba = b * b - (4 * a * c);
                deltawynik.Text = " " + deltaliczba;
                deltawzur.Visible = true;
                deltanapis.Visible = true;
                deltawynik.Visible = true;
                wzor.Visible = true;
                Wyniknapisdelta.Visible = true;
                bdelta2.Visible = true;
                if (deltaliczba >0)
                {
                    x1napis.Visible = true;
                    x1początek.Visible = true;
                    x1jeden.Visible = true;
                    x1guraliczby.Visible = true;
                    x1dulliczby.Visible = true;
                    x1kreska.Visible = true;
                    x1wynik.Visible = true;
                    x1guraliczby.Text = "−b−vΔ";
                    x1napis.Text = "x1";

                    x2napis.Visible = true;
                    x2poczatek.Visible = true;
                    x2dwa.Visible = true;
                    x2guraliczba.Visible = true;
                    x2kreska.Visible = true;
                    x2dulliczba.Visible = true;
                    x2wynik.Visible = true;

                    x1 = (-b - Math.Sqrt(deltaliczba)) / (2 * a);
                    x2 = (-b + Math.Sqrt(deltaliczba)) / (2 * a);

                    x1wynik.Text = "" + x1;
                    x2wynik.Text = "" + x2;

                }
                else if (deltaliczba == 0)
                {
                    niewidzi();
                    x1napis.Visible = true;
                    x1początek.Visible = true;
                    x1jeden.Visible = false;
                    x1guraliczby.Visible = true;
                    x1dulliczby.Visible = true;
                    x1kreska.Visible = true;
                    x1wynik.Visible = true;
                    x1guraliczby.Text = "−b";
                    x1napis.Text = "x";
                    x1 = -b / (2 * a);
                    x1wynik.Text = ""+x1;
                }
                else
                {
                    
                    x1napis.Visible = true;
                    x1napis.Text = "Delta ujemna -> Równanie kwadratowe nie ma rozwiązań ";
                }
            }
            catch (Exception)
            {
                erro1.Text = "Podaj liczby!";
                erro1.Visible = true;
                deltawynik.Visible = false;
                deltawzur.Visible = false;
                deltanapis.Visible = false;
                bdelta2.Visible = false;
                wzor.Visible = false;
                Wyniknapisdelta.Visible = false;
                niewidzi();
            }            
        }
    }
}
