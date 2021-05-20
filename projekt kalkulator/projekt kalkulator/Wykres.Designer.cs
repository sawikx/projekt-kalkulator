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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Powrot = new System.Windows.Forms.Button();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.stalewzory = new System.Windows.Forms.Button();
            this.wlasnef = new System.Windows.Forms.Button();
            this.dwapunkty = new System.Windows.Forms.Button();
            this.k2r1 = new System.Windows.Forms.Button();
            this.k2r2 = new System.Windows.Forms.Button();
            this.k2r3 = new System.Windows.Forms.Button();
            this.k2r4 = new System.Windows.Forms.Button();
            this.k2r5 = new System.Windows.Forms.Button();
            this.tekstnadbution = new System.Windows.Forms.Label();
            this.k3r1 = new System.Windows.Forms.Button();
            this.k3r2 = new System.Windows.Forms.Button();
            this.k3r3 = new System.Windows.Forms.Button();
            this.k3r4 = new System.Windows.Forms.Button();
            this.k3r5 = new System.Windows.Forms.Button();
            this.k3r6 = new System.Windows.Forms.Button();
            this.k3r7 = new System.Windows.Forms.Button();
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
            chartArea5.BackColor = System.Drawing.Color.Gray;
            chartArea5.BorderColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.White;
            this.Wykres.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Name = "Legend1";
            legend5.TitleBackColor = System.Drawing.Color.Transparent;
            this.Wykres.Legends.Add(legend5);
            this.Wykres.Location = new System.Drawing.Point(493, 12);
            this.Wykres.Name = "Wykres";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.Wykres.Series.Add(series5);
            this.Wykres.Size = new System.Drawing.Size(566, 563);
            this.Wykres.TabIndex = 2;
            this.Wykres.Text = "chart1";
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
            // stalewzory
            // 
            this.stalewzory.Location = new System.Drawing.Point(12, 28);
            this.stalewzory.Name = "stalewzory";
            this.stalewzory.Size = new System.Drawing.Size(91, 23);
            this.stalewzory.TabIndex = 5;
            this.stalewzory.Text = "Stałe wzory";
            this.stalewzory.UseVisualStyleBackColor = true;
            this.stalewzory.Click += new System.EventHandler(this.stalewzory_Click);
            // 
            // wlasnef
            // 
            this.wlasnef.Location = new System.Drawing.Point(12, 57);
            this.wlasnef.Name = "wlasnef";
            this.wlasnef.Size = new System.Drawing.Size(91, 23);
            this.wlasnef.TabIndex = 6;
            this.wlasnef.Text = "Własne funkcje";
            this.wlasnef.UseVisualStyleBackColor = true;
            // 
            // dwapunkty
            // 
            this.dwapunkty.Location = new System.Drawing.Point(12, 86);
            this.dwapunkty.Name = "dwapunkty";
            this.dwapunkty.Size = new System.Drawing.Size(91, 23);
            this.dwapunkty.TabIndex = 7;
            this.dwapunkty.Text = "Dwa punkty";
            this.dwapunkty.UseVisualStyleBackColor = true;
            // 
            // k2r1
            // 
            this.k2r1.Location = new System.Drawing.Point(126, 57);
            this.k2r1.Name = "k2r1";
            this.k2r1.Size = new System.Drawing.Size(102, 23);
            this.k2r1.TabIndex = 8;
            this.k2r1.Text = "Potęgowe";
            this.k2r1.UseVisualStyleBackColor = true;
            this.k2r1.Click += new System.EventHandler(this.k2r1_Click);
            // 
            // k2r2
            // 
            this.k2r2.Location = new System.Drawing.Point(126, 86);
            this.k2r2.Name = "k2r2";
            this.k2r2.Size = new System.Drawing.Size(102, 23);
            this.k2r2.TabIndex = 9;
            this.k2r2.Text = "Wykładnicze";
            this.k2r2.UseVisualStyleBackColor = true;
            this.k2r2.Click += new System.EventHandler(this.k2r2_Click);
            // 
            // k2r3
            // 
            this.k2r3.Location = new System.Drawing.Point(126, 115);
            this.k2r3.Name = "k2r3";
            this.k2r3.Size = new System.Drawing.Size(102, 23);
            this.k2r3.TabIndex = 10;
            this.k2r3.Text = "Logarytmiczne";
            this.k2r3.UseVisualStyleBackColor = true;
            this.k2r3.Click += new System.EventHandler(this.k2r3_Click);
            // 
            // k2r4
            // 
            this.k2r4.Location = new System.Drawing.Point(126, 145);
            this.k2r4.Name = "k2r4";
            this.k2r4.Size = new System.Drawing.Size(102, 23);
            this.k2r4.TabIndex = 11;
            this.k2r4.Text = "Trygonometryczne";
            this.k2r4.UseVisualStyleBackColor = true;
            this.k2r4.Click += new System.EventHandler(this.k2r4_Click);
            // 
            // k2r5
            // 
            this.k2r5.Location = new System.Drawing.Point(126, 175);
            this.k2r5.Name = "k2r5";
            this.k2r5.Size = new System.Drawing.Size(102, 23);
            this.k2r5.TabIndex = 12;
            this.k2r5.Text = "Cyklometryczne";
            this.k2r5.UseVisualStyleBackColor = true;
            this.k2r5.Click += new System.EventHandler(this.k2r5_Click);
            // 
            // tekstnadbution
            // 
            this.tekstnadbution.AutoSize = true;
            this.tekstnadbution.Location = new System.Drawing.Point(123, 28);
            this.tekstnadbution.Name = "tekstnadbution";
            this.tekstnadbution.Size = new System.Drawing.Size(45, 13);
            this.tekstnadbution.TabIndex = 16;
            this.tekstnadbution.Text = "Funkcje";
            // 
            // k3r1
            // 
            this.k3r1.Location = new System.Drawing.Point(250, 57);
            this.k3r1.Name = "k3r1";
            this.k3r1.Size = new System.Drawing.Size(75, 23);
            this.k3r1.TabIndex = 17;
            this.k3r1.Text = "button1";
            this.k3r1.UseVisualStyleBackColor = true;
            this.k3r1.Click += new System.EventHandler(this.k3r1_Click);
            // 
            // k3r2
            // 
            this.k3r2.Location = new System.Drawing.Point(250, 85);
            this.k3r2.Name = "k3r2";
            this.k3r2.Size = new System.Drawing.Size(75, 23);
            this.k3r2.TabIndex = 18;
            this.k3r2.Text = "button2";
            this.k3r2.UseVisualStyleBackColor = true;
            this.k3r2.Click += new System.EventHandler(this.k3r2_Click);
            // 
            // k3r3
            // 
            this.k3r3.Location = new System.Drawing.Point(250, 115);
            this.k3r3.Name = "k3r3";
            this.k3r3.Size = new System.Drawing.Size(75, 23);
            this.k3r3.TabIndex = 19;
            this.k3r3.Text = "button3";
            this.k3r3.UseVisualStyleBackColor = true;
            this.k3r3.Click += new System.EventHandler(this.k3r3_Click);
            // 
            // k3r4
            // 
            this.k3r4.Location = new System.Drawing.Point(250, 145);
            this.k3r4.Name = "k3r4";
            this.k3r4.Size = new System.Drawing.Size(75, 23);
            this.k3r4.TabIndex = 20;
            this.k3r4.Text = "button4";
            this.k3r4.UseVisualStyleBackColor = true;
            this.k3r4.Click += new System.EventHandler(this.k3r4_Click);
            // 
            // k3r5
            // 
            this.k3r5.Location = new System.Drawing.Point(250, 175);
            this.k3r5.Name = "k3r5";
            this.k3r5.Size = new System.Drawing.Size(75, 23);
            this.k3r5.TabIndex = 21;
            this.k3r5.Text = "button5";
            this.k3r5.UseVisualStyleBackColor = true;
            this.k3r5.Click += new System.EventHandler(this.k3r5_Click);
            // 
            // k3r6
            // 
            this.k3r6.Location = new System.Drawing.Point(250, 205);
            this.k3r6.Name = "k3r6";
            this.k3r6.Size = new System.Drawing.Size(75, 23);
            this.k3r6.TabIndex = 22;
            this.k3r6.Text = "button6";
            this.k3r6.UseVisualStyleBackColor = true;
            this.k3r6.Click += new System.EventHandler(this.k3r6_Click);
            // 
            // k3r7
            // 
            this.k3r7.Location = new System.Drawing.Point(250, 235);
            this.k3r7.Name = "k3r7";
            this.k3r7.Size = new System.Drawing.Size(75, 23);
            this.k3r7.TabIndex = 23;
            this.k3r7.Text = "button7";
            this.k3r7.UseVisualStyleBackColor = true;
            this.k3r7.Click += new System.EventHandler(this.k3r7_Click);
            // 
            // Wykresforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.k3r7);
            this.Controls.Add(this.k3r6);
            this.Controls.Add(this.k3r5);
            this.Controls.Add(this.k3r4);
            this.Controls.Add(this.k3r3);
            this.Controls.Add(this.k3r2);
            this.Controls.Add(this.k3r1);
            this.Controls.Add(this.tekstnadbution);
            this.Controls.Add(this.k2r5);
            this.Controls.Add(this.k2r4);
            this.Controls.Add(this.k2r3);
            this.Controls.Add(this.k2r2);
            this.Controls.Add(this.k2r1);
            this.Controls.Add(this.dwapunkty);
            this.Controls.Add(this.wlasnef);
            this.Controls.Add(this.stalewzory);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stalewzory;
        private System.Windows.Forms.Button wlasnef;
        private System.Windows.Forms.Button dwapunkty;
        private System.Windows.Forms.Button k2r1;
        private System.Windows.Forms.Button k2r2;
        private System.Windows.Forms.Button k2r3;
        private System.Windows.Forms.Button k2r4;
        private System.Windows.Forms.Button k2r5;
        private System.Windows.Forms.Label tekstnadbution;
        private System.Windows.Forms.Button k3r1;
        private System.Windows.Forms.Button k3r2;
        private System.Windows.Forms.Button k3r3;
        private System.Windows.Forms.Button k3r4;
        private System.Windows.Forms.Button k3r5;
        private System.Windows.Forms.Button k3r6;
        private System.Windows.Forms.Button k3r7;
    }
}