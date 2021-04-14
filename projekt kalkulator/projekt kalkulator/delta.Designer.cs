namespace projekt_kalkulator
{
    partial class delta
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
            this.powrut = new System.Windows.Forms.Button();
            this.wyjscie = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            this.wzurprzyklad = new System.Windows.Forms.Label();
            this.dwa = new System.Windows.Forms.Label();
            this.etap1 = new System.Windows.Forms.TextBox();
            this.erro1 = new System.Windows.Forms.Label();
            this.napisa = new System.Windows.Forms.Label();
            this.napisb = new System.Windows.Forms.Label();
            this.napisc = new System.Windows.Forms.Label();
            this.deltanapis = new System.Windows.Forms.Label();
            this.deltawzur = new System.Windows.Forms.Label();
            this.deltawynik = new System.Windows.Forms.Label();
            this.deltalicz = new System.Windows.Forms.Button();
            this.start1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powrut
            // 
            this.powrut.Location = new System.Drawing.Point(12, 386);
            this.powrut.Name = "powrut";
            this.powrut.Size = new System.Drawing.Size(75, 23);
            this.powrut.TabIndex = 0;
            this.powrut.Text = "Powrót";
            this.powrut.UseVisualStyleBackColor = true;
            this.powrut.Click += new System.EventHandler(this.powrut_Click);
            // 
            // wyjscie
            // 
            this.wyjscie.Location = new System.Drawing.Point(12, 415);
            this.wyjscie.Name = "wyjscie";
            this.wyjscie.Size = new System.Drawing.Size(75, 23);
            this.wyjscie.TabIndex = 1;
            this.wyjscie.Text = "Wyjście";
            this.wyjscie.UseVisualStyleBackColor = true;
            this.wyjscie.Click += new System.EventHandler(this.wyjscie_Click);
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.Location = new System.Drawing.Point(252, 9);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(277, 18);
            this.tytul.TabIndex = 2;
            this.tytul.Text = "Równania kwadratowe w postaci ogólnej";
            // 
            // wzurprzyklad
            // 
            this.wzurprzyklad.AutoSize = true;
            this.wzurprzyklad.BackColor = System.Drawing.Color.Transparent;
            this.wzurprzyklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wzurprzyklad.Location = new System.Drawing.Point(312, 41);
            this.wzurprzyklad.Name = "wzurprzyklad";
            this.wzurprzyklad.Size = new System.Drawing.Size(79, 17);
            this.wzurprzyklad.TabIndex = 3;
            this.wzurprzyklad.Text = "ax +bx+c=0";
            // 
            // dwa
            // 
            this.dwa.AutoSize = true;
            this.dwa.BackColor = System.Drawing.Color.Transparent;
            this.dwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dwa.ForeColor = System.Drawing.Color.Black;
            this.dwa.Location = new System.Drawing.Point(325, 35);
            this.dwa.Name = "dwa";
            this.dwa.Size = new System.Drawing.Size(13, 13);
            this.dwa.TabIndex = 3;
            this.dwa.Text = "2";
            // 
            // etap1
            // 
            this.etap1.Location = new System.Drawing.Point(280, 75);
            this.etap1.Name = "etap1";
            this.etap1.Size = new System.Drawing.Size(159, 20);
            this.etap1.TabIndex = 4;
            // 
            // erro1
            // 
            this.erro1.AutoSize = true;
            this.erro1.Location = new System.Drawing.Point(639, 75);
            this.erro1.Name = "erro1";
            this.erro1.Size = new System.Drawing.Size(25, 13);
            this.erro1.TabIndex = 5;
            this.erro1.Text = "erro";
            // 
            // napisa
            // 
            this.napisa.AutoSize = true;
            this.napisa.Location = new System.Drawing.Point(252, 114);
            this.napisa.Name = "napisa";
            this.napisa.Size = new System.Drawing.Size(42, 13);
            this.napisa.TabIndex = 6;
            this.napisa.Text = "a = ax2";
            // 
            // napisb
            // 
            this.napisb.AutoSize = true;
            this.napisb.Location = new System.Drawing.Point(325, 114);
            this.napisb.Name = "napisb";
            this.napisb.Size = new System.Drawing.Size(36, 13);
            this.napisb.TabIndex = 7;
            this.napisb.Text = "b = bx";
            // 
            // napisc
            // 
            this.napisc.AutoSize = true;
            this.napisc.Location = new System.Drawing.Point(403, 114);
            this.napisc.Name = "napisc";
            this.napisc.Size = new System.Drawing.Size(31, 13);
            this.napisc.TabIndex = 8;
            this.napisc.Text = "c = c";
            // 
            // deltanapis
            // 
            this.deltanapis.AutoSize = true;
            this.deltanapis.Location = new System.Drawing.Point(325, 144);
            this.deltanapis.Name = "deltanapis";
            this.deltanapis.Size = new System.Drawing.Size(32, 13);
            this.deltanapis.TabIndex = 9;
            this.deltanapis.Text = "Delta";
            // 
            // deltawzur
            // 
            this.deltawzur.AutoSize = true;
            this.deltawzur.Location = new System.Drawing.Point(226, 166);
            this.deltawzur.Name = "deltawzur";
            this.deltawzur.Size = new System.Drawing.Size(56, 13);
            this.deltawzur.TabIndex = 10;
            this.deltawzur.Text = "Δ=b2−4ac";
            // 
            // deltawynik
            // 
            this.deltawynik.AutoSize = true;
            this.deltawynik.Location = new System.Drawing.Point(404, 166);
            this.deltawynik.Name = "deltawynik";
            this.deltawynik.Size = new System.Drawing.Size(35, 13);
            this.deltawynik.TabIndex = 11;
            this.deltawynik.Text = "label1";
            // 
            // deltalicz
            // 
            this.deltalicz.Location = new System.Drawing.Point(303, 161);
            this.deltalicz.Name = "deltalicz";
            this.deltalicz.Size = new System.Drawing.Size(75, 23);
            this.deltalicz.TabIndex = 12;
            this.deltalicz.Text = "Licz";
            this.deltalicz.UseVisualStyleBackColor = true;
            this.deltalicz.Click += new System.EventHandler(this.deltalicz_Click);
            // 
            // start1
            // 
            this.start1.Location = new System.Drawing.Point(454, 75);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(75, 23);
            this.start1.TabIndex = 13;
            this.start1.Text = "Rozpocznij";
            this.start1.UseVisualStyleBackColor = true;
            this.start1.Click += new System.EventHandler(this.start1_Click);
            // 
            // delta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.deltalicz);
            this.Controls.Add(this.deltawynik);
            this.Controls.Add(this.deltawzur);
            this.Controls.Add(this.deltanapis);
            this.Controls.Add(this.napisc);
            this.Controls.Add(this.napisb);
            this.Controls.Add(this.napisa);
            this.Controls.Add(this.erro1);
            this.Controls.Add(this.etap1);
            this.Controls.Add(this.dwa);
            this.Controls.Add(this.wzurprzyklad);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.wyjscie);
            this.Controls.Add(this.powrut);
            this.Name = "delta";
            this.Text = "delta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrut;
        private System.Windows.Forms.Button wyjscie;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label wzurprzyklad;
        private System.Windows.Forms.Label dwa;
        private System.Windows.Forms.TextBox etap1;
        private System.Windows.Forms.Label erro1;
        private System.Windows.Forms.Label napisa;
        private System.Windows.Forms.Label napisb;
        private System.Windows.Forms.Label napisc;
        private System.Windows.Forms.Label deltanapis;
        private System.Windows.Forms.Label deltawzur;
        private System.Windows.Forms.Label deltawynik;
        private System.Windows.Forms.Button deltalicz;
        private System.Windows.Forms.Button start1;
    }
}