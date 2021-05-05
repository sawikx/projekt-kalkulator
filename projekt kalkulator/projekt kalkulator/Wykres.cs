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
    public partial class Wykresforma : Form
    {
        Thread th;
        public Wykresforma()
        {                        
            InitializeComponent();
            Wykres.Visible = false;
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openmenu(object obj)
        {
            Application.Run(new aplikacjimenu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(openmenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Rysuj_Click(object sender, EventArgs e)
        {
            Wykres.Visible = true;
            double maxx = 3 + 1, minx = 0 - 1;
            Wykres.Series.Clear();
            Wykres.Series.Add("X");
            Wykres.Series.Add("Y");
            Wykres.Series.Add("wykres");
            Wykres.Series.Add("wykrespomoc");
            Wykres.Series["wykrespomoc"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["wykrespomoc"].Points.AddXY(4, 4);
            Wykres.Series["wykrespomoc"].Points.AddXY(-1, -1);
            Wykres.Series["X"].BorderWidth = 2;
            Wykres.Series["Y"].BorderWidth = 2;
            Wykres.Series["wykres"].BorderWidth = 2;
            Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
            Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
            Wykres.Series["X"].Color = Color.Tomato;
            Wykres.Series["Y"].Color = Color.Maroon;
            Wykres.Series["wykres"].Color = Color.Lime;
            Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["wykres"].Points.AddXY(1, 1);
            Wykres.Series["wykres"].Points.AddXY(0, 0);
            Wykres.Series["wykres"].Points.AddXY(2, 2);
            Wykres.Series["wykres"].Points.AddXY(3, 3);            
            Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["X"].Points.AddXY(maxx, 0);
            Wykres.Series["X"].Points.AddXY(minx, 0);
            Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["Y"].Points.AddXY(0, maxx);
            Wykres.Series["Y"].Points.AddXY(0, minx);
        }
    }
}
