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
        Thread th;
        public delta()
        {
            InitializeComponent();
            erro1.Visible = false;
            napisa.Visible = false;
            napisb.Visible = false;
            napisc.Visible = false;

            deltawzur.Visible = false;
            deltalicz.Visible = false;
            deltanapis.Visible = false;
            deltawynik.Visible = false;
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

        private void deltalicz_Click(object sender, EventArgs e)
        {
            deltawynik.Visible = true;
            int wynik = (4 * 4) - (4 * 2 * 2);
            deltawynik.Text = "" + wynik;
        }

        private void start1_Click(object sender, EventArgs e)
        {
            if (etap1.Text == "")
            {
                erro1.Text = "Podaj równanie zgodne ze wzorem np. 5x2+2x-2=0";
                erro1.Visible = true;
            }
            else 
            {
                string szukanya = "x2", szukanyb = "x", szukanyc,plus,minus;

                erro1.Visible = false;
                deltawzur.Visible = true;
                deltalicz.Visible = true;
                deltanapis.Visible = true;
            }
            
        }
    }
}
