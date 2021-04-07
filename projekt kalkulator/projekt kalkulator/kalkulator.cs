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

    public partial class kalkurator : Form
    {
        Thread th;
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
        public double ruwna(double a, double b, string c)
        {
            switch (c)
            {
                case "+":

                    return a + b;
                case "-":

                    return b - a;
                case "X":

                    return a * b;
                case ":":
                    return b / a;
                case "potęga":
                    return Math.Pow(a, b);
                case "pierwiastek":
                    return Math.Sqrt(a);
                case "ułamek":
                    return 1 / a;
                case "%":
                    return b * (a / 100);
                default:
                    return 0;
            }
        }
        public kalkurator()
        {
            InitializeComponent();
        }

        private void kalkurator_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "0";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "0";
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "1";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "2";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "3";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "4";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "5";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "6";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "7";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "8";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text == "" || wpis1.Text == "0")
            {
                wpis1.Text = "9";
            }
            else
            {
                string a = wpis1.Text;
                wpis1.Text = a + "9";
            }
        }

        private void cofnij_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text.Length > 0)
            {
                wpis1.Text = wpis1.Text.Remove(wpis1.Text.Length - 1);
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text == "")
                {
                    wpis2.Text = wpis1.Text;
                    wpis1.Text = "";

                }
                else
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    a += b;
                    wpis2.Text = a + "";
                    wpis1.Text = "";

                }
            }
            znak.Text = "+";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text == "")
                {
                    wpis2.Text = wpis1.Text;
                    wpis1.Text = "";

                }
                else
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    a = b - a;
                    wpis2.Text = a + "";
                    wpis1.Text = "";

                }
            }
            znak.Text = "-";
        }

        private void razy_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text == "")
                {
                    wpis2.Text = wpis1.Text;
                    wpis1.Text = "";

                }
                else
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    a = a * b;
                    wpis2.Text = a + "";
                    wpis1.Text = "";

                }
            }
            znak.Text = "X";
        }

        private void dziel_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text == "")
                {
                    wpis2.Text = wpis1.Text;
                    wpis1.Text = "";

                }
                else
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    if (a == 0)
                    {
                        komentarz.Text = "Nie dziel przez zero";
                        wpis2.Text = "";
                        wpis1.Text = "";
                    }
                    else if (b == 0)
                    {
                        wpis2.Text = "0";
                        wpis1.Text = "";
                    }
                    else
                    {
                        a = b / a;
                        wpis2.Text = a + "";
                        wpis1.Text = "";
                    }


                }
            }
            znak.Text = ":";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            wpis1.Text = "";
            wpis2.Text = "";
            znak.Text = "";
        }

        private void znakprzeciwny_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                double a = double.Parse(wpis1.Text);
                a = a * -1;
                wpis1.Text = a + "";
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            wpis1.Text = "";
        }

        private void równa_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text != "")
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    if (znak.Text == ":" && a == 0)
                    {
                        komentarz.Text = "Nie dziel przez zero";
                        wpis2.Text = "";
                        wpis1.Text = "";
                    }
                    else if (znak.Text == ":" && b == 0)
                    {
                        wpis2.Text = "0";
                        wpis1.Text = "";
                    }
                    else
                    {
                        a = ruwna(a, b, znak.Text);
                        wpis2.Text = a + "";
                        wpis1.Text = "";
                    }
                }
            }
        }

        private void potega_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text != "")
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    a = Math.Pow(a, b);
                    wpis2.Text = a + "";
                    wpis1.Text = "";
                }
                else
                {
                    wpis2.Text = wpis1.Text;
                    wpis1.Text = "";
                }

            }
            znak.Text = "potęga";
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                double a = double.Parse(wpis1.Text);
                a = Math.Sqrt(a);
                wpis2.Text = a + "";

            }
            znak.Text = "pierwiastek";
        }

        private void ulamek_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                double a = double.Parse(wpis1.Text);
                a = 1 / a;
                wpis2.Text = a + "";

            }
            znak.Text = "ułamek";
        }

        private void procent_Click(object sender, EventArgs e)
        {
            komentarz.Text = "";
            if (wpis1.Text != "")
            {
                if (wpis2.Text != "")
                {
                    double a = double.Parse(wpis1.Text), b = double.Parse(wpis2.Text);
                    a = b * (a / 100);
                    wpis2.Text = a + "";
                    wpis1.Text = "";
                }
                else
                {
                    wpis2.Text = wpis1.Text;
                    wpis1.Text = "";
                }
            }
            znak.Text = "%";
        }

        private void przecinek_Click(object sender, EventArgs e)
        {
            wpis1.Text = wpis1.Text + ",";
        }
    }
}
