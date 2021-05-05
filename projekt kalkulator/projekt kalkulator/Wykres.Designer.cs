namespace projekt_kalkulator
{
    partial class Wykresforma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Powrot = new System.Windows.Forms.Button();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Rysuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // Powrot
            // 
            this.Powrot.Location = new System.Drawing.Point(12, 523);
            this.Powrot.Name = "Powrot";
            this.Powrot.Size = new System.Drawing.Size(75, 23);
            this.Powrot.TabIndex = 0;
            this.Powrot.Text = "Powrót";
            this.Powrot.UseVisualStyleBackColor = true;
            this.Powrot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wyjscie
            // 
            this.Wyjscie.Location = new System.Drawing.Point(12, 552);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(75, 23);
            this.Wyjscie.TabIndex = 1;
            this.Wyjscie.Text = "Wyjście";
            this.Wyjscie.UseVisualStyleBackColor = true;
            this.Wyjscie.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Wykres
            // 
            this.Wykres.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(559, 12);
            this.Wykres.Name = "Wykres";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Wykres.Series.Add(series1);
            this.Wykres.Size = new System.Drawing.Size(500, 563);
            this.Wykres.TabIndex = 2;
            this.Wykres.Text = "chart1";
            // 
            // Rysuj
            // 
            this.Rysuj.Location = new System.Drawing.Point(478, 495);
            this.Rysuj.Name = "Rysuj";
            this.Rysuj.Size = new System.Drawing.Size(75, 23);
            this.Rysuj.TabIndex = 3;
            this.Rysuj.Text = "Rysuj";
            this.Rysuj.UseVisualStyleBackColor = true;
            this.Rysuj.Click += new System.EventHandler(this.Rysuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stałe wzory";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Własne funkcje";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Dwa punkty";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Wykresforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rysuj);
            this.Controls.Add(this.Wykres);
            this.Controls.Add(this.Wyjscie);
            this.Controls.Add(this.Powrot);
            this.Name = "Wykresforma";
            this.Text = "Wykres";
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Powrot;
        private System.Windows.Forms.Button Wyjscie;
        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.Button Rysuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}