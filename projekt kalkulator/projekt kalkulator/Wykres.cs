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
        double pi = 3.14159265359;
        public Wykresforma()
        {                        
            InitializeComponent();
            ukryj();
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
        private void ukryj()
        {
            Wykres.Visible = false;
            tekstnadbution.Visible = false;
            k2r1.Visible = false;
            k2r2.Visible = false;
            k2r3.Visible = false;
            k2r4.Visible = false;
            k2r5.Visible = false;
            k3r1.Visible = false;
            k3r2.Visible = false;
            k3r3.Visible = false;
            k3r4.Visible = false;
            k3r5.Visible = false;
            k3r6.Visible = false;
            k3r7.Visible = false;            
        }
        private void ukryjk3()
        {
            Wykres.Visible = false;
            k3r1.Visible = false;
            k3r2.Visible = false;
            k3r3.Visible = false;
            k3r4.Visible = false;
            k3r5.Visible = false;
            k3r6.Visible = false;
            k3r7.Visible = false;
        }               

        private void stalewzory_Click(object sender, EventArgs e)
        {
            ukryj();
            tekstnadbution.Visible = true;
            k2r1.Visible = true;
            k2r2.Visible = true;
            k2r3.Visible = true;
            k2r4.Visible = true;
            k2r5.Visible = true;
        }

        private void k2r1_Click(object sender, EventArgs e)
        {
            ukryjk3();
            k3r1.Text = "x^2";
            k3r1.Visible = true;
            k3r2.Text = "x^3";
            k3r2.Visible = true;
            k3r3.Text = "1/x";
            k3r3.Visible = true;
            k3r4.Text = "1/(x^2)";
            k3r4.Visible = true;
            k3r5.Text = "√x";
            k3r5.Visible = true;
            k3r6.Text = "3^√x";
            k3r6.Visible = true;
            k3r7.Text = "3^√x^2";
            k3r7.Visible = true;
        }

        private void k2r2_Click(object sender, EventArgs e)
        {
            ukryjk3();
            k3r1.Text = "a>1 a^x";
            k3r1.Visible = true;
            k3r2.Text = "0<a<1 a^x";
            k3r2.Visible = true;
        }

        private void k2r3_Click(object sender, EventArgs e)
        {
            ukryjk3();
            k3r1.Text = "a>1 loga x";
            k3r1.Visible = true;
            k3r2.Text = "0<a<1 loga x";
            k3r2.Visible = true;
        }

        private void k2r4_Click(object sender, EventArgs e)
        {
            ukryjk3();
            k3r1.Text = "sin x";
            k3r1.Visible = true;
            k3r2.Text = "cos x";
            k3r2.Visible = true;
            k3r3.Text = "tg x";
            k3r3.Visible = true;
            k3r4.Text = "ctg x";
            k3r4.Visible = true;
        }

        private void k2r5_Click(object sender, EventArgs e)
        {
            ukryjk3();
            k3r1.Text = "arc sin x";
            k3r1.Visible = true;
            k3r2.Text = "arc cos x";
            k3r2.Visible = true;
            k3r3.Text = "arc tg x";
            k3r3.Visible = true;
            k3r4.Text = "arc ctg x";
            k3r4.Visible = true;
        }

        private void k3r1_Click(object sender, EventArgs e)
        {
            switch (k3r1.Text)
            {
                case "x^2":
                    Wykres.Visible = true;                    
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");                    
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (int i=-10;i<=10; i++)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i,i*i);
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-11, 0);
                    Wykres.Series["X"].Points.AddXY(11, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10);
                    Wykres.Series["Y"].Points.AddXY(0, 10*10);
                    break;
                case "a>1 a^x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (int i = -10; i <= 10; i++)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i,Math.Pow(1.3,i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-10, 0);
                    Wykres.Series["X"].Points.AddXY(11, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10);
                    Wykres.Series["Y"].Points.AddXY(0, Math.Pow(1.3, 10));
                    break;
                case "a>1 loga x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (int i = 1; i <= 10; i++)
                    {
                        if (i == 1) {
                            for (double j = 0.1; j <= 1; j+=0.1)
                            {
                                Wykres.Series["wykres"].Points.AddXY(j, Math.Round(Math.Log(j, 2),2));
                            } 
                        }
                            Wykres.Series["wykres"].Points.AddXY(i, Math.Round(Math.Log(i, 2),2));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-1, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, Math.Round(Math.Log(0.1, 2),2));
                    Wykres.Series["Y"].Points.AddXY(0, 4);
                    break;
                case "sin x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -4; i <= 4; i+=0.1)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i,Math.Sin(i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-4, 0);
                    Wykres.Series["X"].Points.AddXY(4, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -2);
                    Wykres.Series["Y"].Points.AddXY(0, 2);
                    break;
                case "arc sin x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -1; i <= 1; i+=0.01)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i,Math.Round(Math.Asin(i),2));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-1, 0);
                    Wykres.Series["X"].Points.AddXY(1, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -3.14/2);
                    Wykres.Series["Y"].Points.AddXY(0, Math.Round(Math.Asin(1), 2));
                    break;
            }
        }

        private void k3r2_Click(object sender, EventArgs e)
        {
            switch (k3r2.Text)
            {
                case "x^3":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (int i = -10; i <= 10; i++)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, i * i*i);
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-11, 0);
                    Wykres.Series["X"].Points.AddXY(11, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10*10*10);
                    Wykres.Series["Y"].Points.AddXY(0, 10 * 10*10);
                    break;
                case "0<a<1 a^x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -10; i <= 10; i++)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Pow(0.8, i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-10, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -2);
                    Wykres.Series["Y"].Points.AddXY(0, Math.Pow(0.8, -10));
                    break;
                case "0<a<1 loga x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (int i = 1; i <= 10; i++)
                    {
                        if (i == 1)
                        {
                            for (double j = 0.1; j < 1; j += 0.01)
                            {
                                Wykres.Series["wykres"].Points.AddXY(j, Math.Round(Math.Log(j, 0.8), 2));
                            }
                        }
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Round(Math.Log(i, 0.8), 2));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-1, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, Math.Round(Math.Log(10, 0.8), 2));
                    Wykres.Series["Y"].Points.AddXY(0, Math.Round(Math.Log(0.1, 0.8), 2));
                    break;
                case "cos x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -4; i <= 4; i += 0.1)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Cos(i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-4, 0);
                    Wykres.Series["X"].Points.AddXY(4, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -2);
                    Wykres.Series["Y"].Points.AddXY(0, 2);
                    break;
                case "arc cos x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -1; i <= 1; i += 0.01)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Acos(i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-1, 0);
                    Wykres.Series["X"].Points.AddXY(1, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, 0);
                    Wykres.Series["Y"].Points.AddXY(0, 3.14 );
                    break;
            }
        }

        private void k3r3_Click(object sender, EventArgs e)
        {
            switch (k3r3.Text)
            {
                case "1/x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("x<0");
                    Wykres.Series.Add("x>0");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["x<0"].BorderWidth = 2;
                    Wykres.Series["x>0"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["x<0"].Color = Color.Lime;
                    Wykres.Series["x<0"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["x>0"].Color = Color.Lime;
                    Wykres.Series["x>0"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -10; i <-0.1; i+=0.1)
                    {
                        Wykres.Series["x<0"].Points.AddXY(i, 1/i);
                    }
                    for (double i = 0.1; i <=10; i+=0.1)
                    {
                        Wykres.Series["x>0"].Points.AddXY(i, 1 / i);
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-10, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10);
                    Wykres.Series["Y"].Points.AddXY(0, 10 );
                    break;                                
                case "tg x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -pi/2+0.1; i <= pi / 2 - 0.1; i += 0.01)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Tan(i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-pi/2, 0);
                    Wykres.Series["X"].Points.AddXY(pi/2, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10);
                    Wykres.Series["Y"].Points.AddXY(0, Math.Tan(pi/2-0.1));
                    break;
                case "arc tg x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -10; i <= 10; i += 0.1)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Atan(i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-10, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -3.14 / 2);
                    Wykres.Series["Y"].Points.AddXY(0, 3.14/2);
                    break;
            }
        }

        private void k3r4_Click(object sender, EventArgs e)
        {
            switch (k3r4.Text)
            {
                case "1/(x^2)":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series.Add("x>0");
                    Wykres.Series["x>0"].IsVisibleInLegend = false;
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.Series["x>0"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["x>0"].Color = Color.Lime;
                    Wykres.Series["x>0"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -10; i < -0.1; i += 0.1)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, 1 / (i*i));
                    }
                    for (double i = 0.1; i <= 10; i += 0.1)
                    {
                        Wykres.Series["x>0"].Points.AddXY(i, 1 / (i*i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-10, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10);
                    Wykres.Series["Y"].Points.AddXY(0, 1/(0.1*0.1));
                    break;
                case "ctg x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -pi / 2 + 0.1; i <= pi / 2 - 0.1; i += 0.01)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Tan(-i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-pi / 2, 0);
                    Wykres.Series["X"].Points.AddXY(pi / 2, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -10);
                    Wykres.Series["Y"].Points.AddXY(0, Math.Tan(pi / 2 - 0.1));
                    break;
                case "arc ctg x":
                    Wykres.Visible = true;
                    Wykres.Series.Clear();
                    Wykres.Series.Add("X");
                    Wykres.Series.Add("Y");
                    Wykres.Series.Add("wykres");
                    Wykres.Series["X"].BorderWidth = 2;
                    Wykres.Series["Y"].BorderWidth = 2;
                    Wykres.Series["wykres"].BorderWidth = 2;
                    Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
                    Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
                    Wykres.Series["X"].Color = Color.Tomato;
                    Wykres.Series["Y"].Color = Color.Maroon;
                    Wykres.Series["wykres"].Color = Color.Lime;
                    Wykres.Series["wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    for (double i = -10; i <= 10; i += 0.1)
                    {
                        Wykres.Series["wykres"].Points.AddXY(i, Math.Atan(-i));
                    }
                    Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["X"].Points.AddXY(-10, 0);
                    Wykres.Series["X"].Points.AddXY(10, 0);
                    Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                    Wykres.Series["Y"].Points.AddXY(0, -3.14 / 2);
                    Wykres.Series["Y"].Points.AddXY(0, 3.14 / 2);
                    break;
            }
        }

        private void k3r5_Click(object sender, EventArgs e)
        {
            Wykres.Visible = true;
            Wykres.Series.Clear();
            Wykres.Series.Add("X");
            Wykres.Series.Add("Y");
            Wykres.Series.Add("Wykres");
            Wykres.Series["X"].BorderWidth = 2;
            Wykres.Series["Y"].BorderWidth = 2;
            Wykres.Series["Wykres"].BorderWidth = 2;
            Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
            Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
            Wykres.Series["X"].Color = Color.Tomato;
            Wykres.Series["Y"].Color = Color.Maroon;
            Wykres.Series["Wykres"].Color = Color.Lime;
            Wykres.Series["Wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            for (double i = 0; i <= 10; i += 0.1)
            {
                Wykres.Series["Wykres"].Points.AddXY(i,Math.Sqrt(i));
            }
            Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["X"].Points.AddXY(-10, 0);
            Wykres.Series["X"].Points.AddXY(10, 0);
            Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["Y"].Points.AddXY(0, -1);
            Wykres.Series["Y"].Points.AddXY(0, 10);
        }

        private void k3r6_Click(object sender, EventArgs e)
        {
            Wykres.Visible = true;
            Wykres.Series.Clear();
            Wykres.Series.Add("X");
            Wykres.Series.Add("Y");
            Wykres.Series.Add("Wykres");
            Wykres.Series["X"].BorderWidth = 2;
            Wykres.Series["Y"].BorderWidth = 2;
            Wykres.Series["Wykres"].BorderWidth = 2;
            Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
            Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
            Wykres.Series["X"].Color = Color.Tomato;
            Wykres.Series["Y"].Color = Color.Maroon;
            Wykres.Series["Wykres"].Color = Color.Lime;
            Wykres.Series["Wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            for (double i = -10; i <0; i += 0.1)
            {
                Wykres.Series["Wykres"].Points.AddXY(i, -1 * Math.Pow(-i, 1 / 3.0));
            }
            for (double i = 0; i <= 10; i += 0.1)
            {
                Wykres.Series["Wykres"].Points.AddXY(i,Math.Pow(i,1/3.0));
            }
            Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["X"].Points.AddXY(-10, 0);
            Wykres.Series["X"].Points.AddXY(10, 0);
            Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["Y"].Points.AddXY(0, -10);
            Wykres.Series["Y"].Points.AddXY(0, 10);
        }

        private void k3r7_Click(object sender, EventArgs e)
        {
            Wykres.Visible = true;
            Wykres.Series.Clear();
            Wykres.Series.Add("X");
            Wykres.Series.Add("Y");
            Wykres.Series.Add("Wykres");
            Wykres.Series["X"].BorderWidth = 2;
            Wykres.Series["Y"].BorderWidth = 2;
            Wykres.Series["Wykres"].BorderWidth = 2;
            Wykres.ChartAreas[0].AxisX.IsMarginVisible = false;
            Wykres.ChartAreas[0].AxisY.IsMarginVisible = false;
            Wykres.Series["X"].Color = Color.Tomato;
            Wykres.Series["Y"].Color = Color.Maroon;
            Wykres.Series["Wykres"].Color = Color.Lime;
            Wykres.Series["Wykres"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            for (double i = -10; i <= 10; i += 0.1)
            {
                Wykres.Series["Wykres"].Points.AddXY(i,Math.Pow(i*i, 1 / 3.0));
            }
            Wykres.Series["X"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["X"].Points.AddXY(-10, 0);
            Wykres.Series["X"].Points.AddXY(10, 0);
            Wykres.Series["Y"].ChartType = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
            Wykres.Series["Y"].Points.AddXY(0, -1);
            Wykres.Series["Y"].Points.AddXY(0, 10);
        
        }
    
    }
}
