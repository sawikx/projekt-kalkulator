namespace projekt_kalkulator
{
    partial class aplikacjimenu
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Geometriapl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.delta = new System.Windows.Forms.Button();
            this.wyjscie = new System.Windows.Forms.Button();
            this.Wykresguzik = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(307, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "menu";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(265, 93);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "kalkulator";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2.";
            // 
            // Geometriapl
            // 
            this.Geometriapl.Location = new System.Drawing.Point(265, 122);
            this.Geometriapl.Name = "Geometriapl";
            this.Geometriapl.Size = new System.Drawing.Size(75, 23);
            this.Geometriapl.TabIndex = 4;
            this.Geometriapl.Text = "Geometria płaska";
            this.Geometriapl.UseVisualStyleBackColor = true;
            this.Geometriapl.Click += new System.EventHandler(this.Geometriapl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3.";
            // 
            // delta
            // 
            this.delta.Location = new System.Drawing.Point(265, 151);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(75, 23);
            this.delta.TabIndex = 6;
            this.delta.Text = "Delta";
            this.delta.UseVisualStyleBackColor = true;
            this.delta.Click += new System.EventHandler(this.delta_Click);
            // 
            // wyjscie
            // 
            this.wyjscie.Location = new System.Drawing.Point(265, 415);
            this.wyjscie.Name = "wyjscie";
            this.wyjscie.Size = new System.Drawing.Size(75, 23);
            this.wyjscie.TabIndex = 7;
            this.wyjscie.Text = "Wyjście";
            this.wyjscie.UseVisualStyleBackColor = true;
            this.wyjscie.Click += new System.EventHandler(this.wyjscie_Click);
            // 
            // Wykresguzik
            // 
            this.Wykresguzik.Location = new System.Drawing.Point(265, 180);
            this.Wykresguzik.Name = "Wykresguzik";
            this.Wykresguzik.Size = new System.Drawing.Size(75, 23);
            this.Wykresguzik.TabIndex = 8;
            this.Wykresguzik.Text = "Wykres";
            this.Wykresguzik.UseVisualStyleBackColor = true;
            this.Wykresguzik.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "4.";
            // 
            // aplikacjimenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Wykresguzik);
            this.Controls.Add(this.wyjscie);
            this.Controls.Add(this.delta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Geometriapl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "aplikacjimenu";
            this.Text = "Kalkurator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Geometriapl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delta;
        private System.Windows.Forms.Button wyjscie;
        private System.Windows.Forms.Button Wykresguzik;
        private System.Windows.Forms.Label label5;
    }
}